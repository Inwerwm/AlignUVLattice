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

        public CtrlForm(IPERunArgs input)
        {
            InitializeComponent();
            args = input;
            pmx = args.Host.Connector.Pmx.GetCurrentState();
            origin = null;
            topSide = null;
            leftSide = null;
            targetVertices = null;
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
                MessageBox.Show("上辺と左辺が共有している起点以外の頂点が存在します"+Environment.NewLine+"上辺と左辺の両方に属す頂点は起点のみです");
                return;
            }
            //対象頂点群の起点・上辺・左辺に含まれる頂点を除去
            targetVertices.Remove(origin);
            targetVertices.RemoveAll(v => topSide.Contains(v));
            targetVertices.RemoveAll(v => leftSide.Contains(v));

            //格子を形成可能な頂点数かを確認
            if (targetVertices.Count != (topSide.Count - 1) * (leftSide.Count - 1))
            {
                MessageBox.Show("対象頂点の数が上辺・左辺の頂点数と合いません");
                return;
            }


        }

        private void buttonAlign_Click(object sender, EventArgs e)
        {

        }
    }
}