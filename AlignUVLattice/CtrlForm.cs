using PEPlugin;
using PEPlugin.Pmx;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AlignUVLattice
{
    public partial class CtrlForm : Form
    {
        IPERunArgs args;
        IPXPmx pmx;

        IPXVertex origin;
        List<IPXVertex> topSide;
        List<IPXVertex> leftSide;
        List<IPXVertex> targetVertices;

        IPXVertex[,] UVLattice;
        int[,] UVLatticeID;

        bool existLattice;

        public CtrlForm(IPERunArgs input)
        {
            InitializeComponent();
            args = input;
            pmx = args.Host.Connector.Pmx.GetCurrentState();
            origin = null;
            topSide = null;
            leftSide = null;
            targetVertices = null;

            existLattice = false;
        }

        private void CtrlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Visible = false;
            }
        }

        private void buttonOrigin_Click(object sender, EventArgs e)
        {
            SetLatticeExistance(false);
            var selectedVerticesID = args.Host.Connector.View.PmxView.GetSelectedVertexIndices();
            if (selectedVerticesID.Length == 1)
            {
                origin = pmx.Vertex[selectedVerticesID[0]];
                textBoxOrigin.Text = "起点選択済み";
            }
            else
                MessageBox.Show("起点は1点のみ選択してください");
        }

        private bool isOverlapTopLeft()
        {
            //どちらか一方でもnullなら重複していることはありえない
            if (topSide == null || leftSide == null)
                return false;

            //上辺と左辺の頂点群の積集合の大きさが重複点の数である。
            return topSide.Intersect(leftSide).Count() != 0;
        }

        private void buttonTopSide_Click(object sender, EventArgs e)
        {
            SetLatticeExistance(true);
            topSide = args.Host.Connector.View.PmxView.GetSelectedVertexIndices().Select(i => pmx.Vertex[i]).ToList();
            if (origin != null)
                topSide.Remove(origin);
            if (isOverlapTopLeft())
            {
                topSide = null;
                MessageBox.Show("起点ではない左辺に含まれている点が選択されています" + Environment.NewLine + "上辺と左辺の両方に属す頂点は起点のみです");
                return;
            }
            textBoxTopSide.Text = topSide.Count.ToString();
        }

        private void buttonLeftSide_Click(object sender, EventArgs e)
        {
            SetLatticeExistance(true);
            leftSide = args.Host.Connector.View.PmxView.GetSelectedVertexIndices().Select(i => pmx.Vertex[i]).ToList();
            if (origin != null)
                leftSide.Remove(origin);
            if (isOverlapTopLeft())
            {
                leftSide = null;
                MessageBox.Show("起点ではない上辺に含まれている点が選択されています" + Environment.NewLine + "上辺と左辺の両方に属す頂点は起点のみです");
                return;
            }
            textBoxLeftSide.Text = leftSide.Count.ToString();
        }

        private void buttonTarget_Click(object sender, EventArgs e)
        {
            SetLatticeExistance(true);
            targetVertices = args.Host.Connector.View.PmxView.GetSelectedVertexIndices().Select(i => pmx.Vertex[i]).ToList();

            textBoxTarget.Text = targetVertices.Count.ToString();
        }

        private void buttonMakeLattice_Click(object sender, EventArgs e)
        {
            //起点・上辺・左辺・対象の頂点が選択済みかを確認
            if (origin == null || topSide == null || leftSide == null || targetVertices == null)
            {
                MessageBox.Show("すべての必要な頂点を選択してください");
                return;
            }

            //辺の頂点から起点を除去
            topSide.Remove(origin);
            leftSide.Remove(origin);
            //上辺と左辺に共有頂点が存在しないか確認
            if (isOverlapTopLeft())
            {
                MessageBox.Show("上辺と左辺が共有している起点以外の頂点が存在します" + Environment.NewLine + "上辺と左辺の両方に属す頂点は起点のみです");
                return;
            }
            //対象頂点群の起点・上辺・左辺に含まれる頂点を除去
            targetVertices.Remove(origin);
            targetVertices.RemoveAll(v => topSide.Contains(v));
            targetVertices.RemoveAll(v => leftSide.Contains(v));

            //格子を形成可能な頂点数かを確認
            if (targetVertices.Count != (topSide.Count - 1) * (leftSide.Count - 1))
            {
                MessageBox.Show("対象頂点の数が上辺・左辺の頂点数から計算される数と合いません");
                return;
            }

            //UV格子の作成
            UVLattice = new IPXVertex[leftSide.Count, topSide.Count];
            UVLattice[0, 0] = origin;

            //UV格子における1次隣接点リスト
            List<IPXVertex>[,] latticeNeighbor = new List<IPXVertex>[leftSide.Count, topSide.Count];

            //起点の1次隣接点
            latticeNeighbor[0, 0] = GetNeighbor(UVLattice[0, 0]);

            //上辺の確定
            for (int i = 0; i < topSide.Count - 1; i++)
            {
                var dupSet = latticeNeighbor[0, i].Intersect(topSide).ToList();
                switch (dupSet.Count)
                {
                    case 0:
                        MessageBox.Show("上辺の選択頂点が不正です" + Environment.NewLine + "面が途切れています");
                        return;
                    case 1:
                        UVLattice[0, i + 1] = dupSet[0];
                        break;
                    default:
                        MessageBox.Show("上辺の選択頂点が不正です" + Environment.NewLine + "分岐しています");
                        return;
                }
            }

            //左辺の確定
            for (int i = 0; i < leftSide.Count - 1; i++)
            {
                var dupSet = latticeNeighbor[i, 0].Intersect(leftSide).ToList();
                switch (dupSet.Count)
                {
                    case 0:
                        MessageBox.Show("左辺の選択頂点が不正です" + Environment.NewLine + "面が途切れています");
                        return;
                    case 1:
                        UVLattice[i + 1, 0] = dupSet[0];
                        break;
                    default:
                        MessageBox.Show("左辺の選択頂点が不正です" + Environment.NewLine + "分岐しています");
                        return;
                }
            }

            //格子作成ループ
            try
            {
                (int x, int y) forcus = (1, 1);
                while (forcus.x <= leftSide.Count && forcus.y <= topSide.Count)
                {
                    var candidate = latticeNeighbor[forcus.x - 1, forcus.y];
                    //格子内に確定済みの頂点を候補から除去
                    candidate.RemoveAll(v => UVLattice.Cast<IPXVertex>().Contains(v));
                    if (candidate.Count < 1)
                        throw new Exception("格子に割り当てられる頂点が見つかりませんでした");
                    UVLattice[forcus.x, forcus.y] = GetNearestUVPoint(UVLattice[forcus.x, forcus.y - 1], candidate);

                    if (forcus.x == leftSide.Count)
                    {
                        forcus.x = 1;
                        forcus.y++;
                    }
                    else
                    {
                        forcus.x++;
                    }
                }

                for (int i = 0; i < leftSide.Count; i++)
                {
                    for (int j = 0; j < topSide.Count; j++)
                    {
                        UVLatticeID[i, j] = pmx.Vertex.IndexOf(UVLattice[i, j]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            SetLatticeExistance(true);
        }

        private void buttonAlign_Click(object sender, EventArgs e)
        {
            //起点のUV座標を基準とする
            //各点間の距離割合は3次元座標から計算する

            //対象の行を選ぶ
            //Posから分布比率を求める
            //UV座標における辺の総距離を求める
            //0列目の点を基準に横方向に総距離の長さの線分を比率に沿って分割する
            //0行目であった場合、等長ならこの総距離の長さを全ての行の長さにする、比率なら基準にして他の行では長さの比率で距離を決める
            float basisSideLength = 0;
            var HLength = new float[leftSide.Count];
            var VLength = new float[topSide.Count];

            for (int i = 0; i < leftSide.Count; i++)
            {
                float UVsideLength = 0;
                float XYZsideLength = 0;
                for (int j = 1; j < topSide.Count; j++)
                {
                    //UV座標における辺の総距離を求める
                    UVsideLength += (UVLattice[i, j - 1].UV - UVLattice[i, j].UV).Length();
                    //位置座標における辺の総距離を求める
                    XYZsideLength += (UVLattice[i, j - 1].Position - UVLattice[i, j].Position).Length();
                }

                if (i == 0)
                {
                    //0行目のUV辺総距離を基準長として保存
                    basisSideLength = UVsideLength;
                }

                for (int j = 1; j < topSide.Count; j++)
                {
                    //0列目の点を基準に横方向に総距離の長さの線分を比率に沿って分割する
                    var ratio = (UVLattice[i, j - 1].Position - UVLattice[i, j].Position).Length() / XYZsideLength;
                    UVLattice[i, j].UV.V = UVLattice[i, 0].UV.V;
                    UVLattice[i, j].UV.U = UVLattice[i, j - 1].UV.U + (checkBoxHIsolength.Checked ? basisSideLength : UVsideLength) * ratio;
                }

                HLength[i] = UVsideLength;
            }

            //列についても同様にする
            for (int i = 0; i < topSide.Count; i++)
            {
                float UVsideLength = 0;
                float XYZsideLength = 0;
                for (int j = 1; j < leftSide.Count; j++)
                {
                    //UV座標における辺の総距離を求める
                    UVsideLength += (UVLattice[j - 1, i].UV - UVLattice[j, i].UV).Length();
                    //位置座標における辺の総距離を求める
                    XYZsideLength += (UVLattice[j - 1, i].Position - UVLattice[j, i].Position).Length();
                }

                if (i == 0)
                {
                    //0列目のUV辺総距離を基準長として保存
                    basisSideLength = UVsideLength;
                }

                for (int j = 1; j < leftSide.Count; j++)
                {
                    //0行目の点を基準に横方向に総距離の長さの線分を比率に沿って分割する
                    var ratio = (UVLattice[j - 1, i].Position - UVLattice[j, i].Position).Length() / XYZsideLength;
                    UVLattice[j, i].UV.V = UVLattice[0, i].UV.V;
                    UVLattice[j, i].UV.U = UVLattice[j - 1, i].UV.U + (checkBoxVIsolength.Checked ? basisSideLength : UVsideLength) * ratio;
                }
                VLength[i] = UVsideLength;
            }

            //整列処理

            //ラジオボタンの結果を方向に分解
            byte alH = 0;//0:左 1:中 2:右
            if (radioButtonBL.Checked || radioButtonCL.Checked || radioButtonTL.Checked)
                alH = 0;
            else if (radioButtonBC.Checked || radioButtonCC.Checked || radioButtonTC.Checked)
                alH = 1;
            else if (radioButtonBR.Checked || radioButtonCR.Checked || radioButtonTR.Checked)
                alH = 2;

            byte alV = 0;//0:上 1:中 2:下
            if (radioButtonTL.Checked || radioButtonTC.Checked || radioButtonTR.Checked)
                alV = 0;
            else if (radioButtonCL.Checked || radioButtonCC.Checked || radioButtonCR.Checked)
                alV = 1;
            else if (radioButtonBL.Checked || radioButtonBC.Checked || radioButtonBR.Checked)
                alV = 2;

            //整列
            if (!checkBoxHIsolength.Checked)
            {
                float maxLength = HLength.Max();
                switch (alH)
                {
                    case 1:
                        for (int i = 0; i < leftSide.Count; i++)
                        {
                            var trans = (maxLength - HLength[i]) / 2;
                            for (int j = 0; j < topSide.Count; j++)
                            {
                                UVLattice[i, j].UV += new PEPlugin.SDX.V2(trans, 0);
                            }
                        }
                        break;
                    case 2:
                        for (int i = 0; i < leftSide.Count; i++)
                        {
                            var trans = maxLength - HLength[i];
                            for (int j = 0; j < topSide.Count; j++)
                            {
                                UVLattice[i, j].UV += new PEPlugin.SDX.V2(trans, 0);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

            if (!checkBoxVIsolength.Checked)
            {
                float maxLength = VLength.Max();
                switch (alV)
                {
                    case 1:
                        for (int i = 0; i < topSide.Count; i++)
                        {
                            var trans = (maxLength - VLength[i]) / 2;
                            for (int j = 0; j < leftSide.Count; j++)
                            {
                                UVLattice[j, i].UV += new PEPlugin.SDX.V2(0, trans);
                            }
                        }
                        break;
                    case 2:
                        for (int i = 0; i < topSide.Count; i++)
                        {
                            var trans = maxLength - VLength[i];
                            for (int j = 0; j < leftSide.Count; j++)
                            {
                                UVLattice[j, i].UV += new PEPlugin.SDX.V2(0, trans);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

            for (int i = 0; i < leftSide.Count; i++)
            {
                for (int j = 0; j < topSide.Count; j++)
                {
                    pmx.Vertex[UVLatticeID[i, j]] = UVLattice[i, j];
                }
            }
            Methods.Update(args.Host.Connector, pmx, PmxUpdateObject.Vertex);
        }


        private void SetLatticeExistance(bool value)
        {
            existLattice = value;
            textBoxMakeLattice.Text = value ? "格子生成済み" : "格子未生成";
        }

        /// <summary>
        /// 頂点の1次隣接点を取得
        /// </summary>
        /// <param name="v">クエリ頂点</param>
        /// <returns></returns>
        private List<IPXVertex> GetNeighbor(IPXVertex v)
        {
            var n = new List<IPXVertex>();

            var faces = GetIncludedFacesOf(v);
            foreach (var f in faces)
            {
                if (f.Vertex1 == v)
                {
                    n.Add(f.Vertex2);
                    n.Add(f.Vertex3);
                }
                else
                {
                    n.Add(f.Vertex1);
                    if (f.Vertex2 == v)
                        n.Add(f.Vertex3);
                    else
                        n.Add(f.Vertex2);
                }
            }
            return n;
        }

        private List<IPXFace> GetIncludedFacesOf(IPXVertex v)
        {
            List<IPXFace> faces = new List<IPXFace>();
            for (int i = 0; i < pmx.Material.Count; i++)
            {
                faces.AddRange(pmx.Material[i].Faces.Where(f => f.Vertex1 == v || f.Vertex2 == v || f.Vertex3 == v).ToList());
            }
            return faces;
        }

        private IPXVertex GetNearestUVPoint(IPXVertex query, List<IPXVertex> source)
        {
            var minDist = (source[0].UV - query.UV).LengthSq();
            int nearestID = 0;
            for (int i = 1; i < source.Count; i++)
            {
                var dist = (source[i].UV - query.UV).LengthSq();
                if (minDist > dist)
                {
                    minDist = dist;
                    nearestID = i;
                }
            }
            return source[nearestID];
        }
    }
}