namespace AlignUVLattice
{
    partial class CtrlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOrigin = new System.Windows.Forms.Button();
            this.buttonTopSide = new System.Windows.Forms.Button();
            this.buttonLeftSide = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxOrigin = new System.Windows.Forms.TextBox();
            this.textBoxTopSide = new System.Windows.Forms.TextBox();
            this.textBoxLeftSide = new System.Windows.Forms.TextBox();
            this.labelConstraint = new System.Windows.Forms.Label();
            this.buttonTarget = new System.Windows.Forms.Button();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonMakeLattice = new System.Windows.Forms.Button();
            this.textBoxMakeLattice = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonCC = new System.Windows.Forms.RadioButton();
            this.radioButtonTL = new System.Windows.Forms.RadioButton();
            this.radioButtonTC = new System.Windows.Forms.RadioButton();
            this.radioButtonTR = new System.Windows.Forms.RadioButton();
            this.radioButtonCR = new System.Windows.Forms.RadioButton();
            this.radioButtonBR = new System.Windows.Forms.RadioButton();
            this.radioButtonBC = new System.Windows.Forms.RadioButton();
            this.radioButtonCL = new System.Windows.Forms.RadioButton();
            this.radioButtonBL = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonVIsometry = new System.Windows.Forms.RadioButton();
            this.radioButtonVRatio = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonHRatio = new System.Windows.Forms.RadioButton();
            this.radioButtonHIsometry = new System.Windows.Forms.RadioButton();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelalign = new System.Windows.Forms.Label();
            this.buttonAlign = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOrigin
            // 
            this.buttonOrigin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOrigin.Location = new System.Drawing.Point(6, 7);
            this.buttonOrigin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOrigin.Name = "buttonOrigin";
            this.buttonOrigin.Size = new System.Drawing.Size(97, 28);
            this.buttonOrigin.TabIndex = 0;
            this.buttonOrigin.Text = "起点を取得";
            this.buttonOrigin.UseVisualStyleBackColor = true;
            // 
            // buttonTopSide
            // 
            this.buttonTopSide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTopSide.Location = new System.Drawing.Point(113, 7);
            this.buttonTopSide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTopSide.Name = "buttonTopSide";
            this.buttonTopSide.Size = new System.Drawing.Size(310, 28);
            this.buttonTopSide.TabIndex = 0;
            this.buttonTopSide.Text = "上辺を取得";
            this.buttonTopSide.UseVisualStyleBackColor = true;
            // 
            // buttonLeftSide
            // 
            this.buttonLeftSide.Location = new System.Drawing.Point(6, 47);
            this.buttonLeftSide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLeftSide.Name = "buttonLeftSide";
            this.buttonLeftSide.Size = new System.Drawing.Size(97, 107);
            this.buttonLeftSide.TabIndex = 0;
            this.buttonLeftSide.Text = "左辺を取得";
            this.buttonLeftSide.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.buttonOrigin, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonTopSide, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonLeftSide, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonTarget, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 112);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 161);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxOrigin, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxTopSide, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxTarget, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxLeftSide, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(477, 112);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(433, 161);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // textBoxOrigin
            // 
            this.textBoxOrigin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxOrigin.Location = new System.Drawing.Point(5, 5);
            this.textBoxOrigin.Multiline = true;
            this.textBoxOrigin.Name = "textBoxOrigin";
            this.textBoxOrigin.ReadOnly = true;
            this.textBoxOrigin.Size = new System.Drawing.Size(100, 32);
            this.textBoxOrigin.TabIndex = 1;
            this.textBoxOrigin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTopSide
            // 
            this.textBoxTopSide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTopSide.Location = new System.Drawing.Point(113, 5);
            this.textBoxTopSide.Multiline = true;
            this.textBoxTopSide.Name = "textBoxTopSide";
            this.textBoxTopSide.ReadOnly = true;
            this.textBoxTopSide.Size = new System.Drawing.Size(315, 32);
            this.textBoxTopSide.TabIndex = 1;
            this.textBoxTopSide.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLeftSide
            // 
            this.textBoxLeftSide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLeftSide.Location = new System.Drawing.Point(5, 45);
            this.textBoxLeftSide.Multiline = true;
            this.textBoxLeftSide.Name = "textBoxLeftSide";
            this.textBoxLeftSide.ReadOnly = true;
            this.textBoxLeftSide.Size = new System.Drawing.Size(100, 111);
            this.textBoxLeftSide.TabIndex = 1;
            this.textBoxLeftSide.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelConstraint
            // 
            this.labelConstraint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelConstraint.Location = new System.Drawing.Point(477, 9);
            this.labelConstraint.Name = "labelConstraint";
            this.labelConstraint.Size = new System.Drawing.Size(433, 82);
            this.labelConstraint.TabIndex = 1;
            this.labelConstraint.Text = "前提\r\n・上辺と下辺の点数が同じである\r\n・左辺と右辺の点数が同じである\r\n・起点から辺を確定するとき前方に1次近接点が2つ以上存在しない　";
            // 
            // buttonTarget
            // 
            this.buttonTarget.Location = new System.Drawing.Point(113, 47);
            this.buttonTarget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTarget.Name = "buttonTarget";
            this.buttonTarget.Size = new System.Drawing.Size(310, 107);
            this.buttonTarget.TabIndex = 0;
            this.buttonTarget.Text = "整列対象を取得";
            this.buttonTarget.UseVisualStyleBackColor = true;
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTarget.Location = new System.Drawing.Point(113, 45);
            this.textBoxTarget.Multiline = true;
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.ReadOnly = true;
            this.textBoxTarget.Size = new System.Drawing.Size(315, 111);
            this.textBoxTarget.TabIndex = 1;
            this.textBoxTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDescription.Location = new System.Drawing.Point(16, 9);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(433, 82);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "1. UV格子生成の起点となる頂点を選択する\r\n2. UV格子の上辺・左辺となる頂点群を選択する\r\n3. UV格子を当てはめる頂点群を選択する\r\n頂点が複数回選択" +
    "された場合、数字が小さい手順の選択が優先される\r\n";
            // 
            // buttonMakeLattice
            // 
            this.buttonMakeLattice.Location = new System.Drawing.Point(20, 292);
            this.buttonMakeLattice.Name = "buttonMakeLattice";
            this.buttonMakeLattice.Size = new System.Drawing.Size(429, 27);
            this.buttonMakeLattice.TabIndex = 3;
            this.buttonMakeLattice.Text = "格子を生成";
            this.buttonMakeLattice.UseVisualStyleBackColor = true;
            // 
            // textBoxMakeLattice
            // 
            this.textBoxMakeLattice.Location = new System.Drawing.Point(477, 292);
            this.textBoxMakeLattice.Name = "textBoxMakeLattice";
            this.textBoxMakeLattice.ReadOnly = true;
            this.textBoxMakeLattice.Size = new System.Drawing.Size(433, 27);
            this.textBoxMakeLattice.TabIndex = 1;
            this.textBoxMakeLattice.Text = "格子未生成";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.Controls.Add(this.radioButtonCC, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.radioButtonTL, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.radioButtonTC, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.radioButtonTR, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.radioButtonCR, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.radioButtonBR, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.radioButtonBC, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.radioButtonCL, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.radioButtonBL, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(480, 392);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(379, 128);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // radioButtonCC
            // 
            this.radioButtonCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonCC.AutoSize = true;
            this.radioButtonCC.Checked = true;
            this.radioButtonCC.Location = new System.Drawing.Point(160, 51);
            this.radioButtonCC.Name = "radioButtonCC";
            this.radioButtonCC.Size = new System.Drawing.Size(57, 24);
            this.radioButtonCC.TabIndex = 0;
            this.radioButtonCC.TabStop = true;
            this.radioButtonCC.Text = "中央";
            this.radioButtonCC.UseVisualStyleBackColor = true;
            // 
            // radioButtonTL
            // 
            this.radioButtonTL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonTL.AutoSize = true;
            this.radioButtonTL.Location = new System.Drawing.Point(34, 9);
            this.radioButtonTL.Name = "radioButtonTL";
            this.radioButtonTL.Size = new System.Drawing.Size(57, 24);
            this.radioButtonTL.TabIndex = 0;
            this.radioButtonTL.Text = "左上";
            this.radioButtonTL.UseVisualStyleBackColor = true;
            // 
            // radioButtonTC
            // 
            this.radioButtonTC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonTC.AutoSize = true;
            this.radioButtonTC.Location = new System.Drawing.Point(160, 9);
            this.radioButtonTC.Name = "radioButtonTC";
            this.radioButtonTC.Size = new System.Drawing.Size(57, 24);
            this.radioButtonTC.TabIndex = 0;
            this.radioButtonTC.Text = "中上";
            this.radioButtonTC.UseVisualStyleBackColor = true;
            // 
            // radioButtonTR
            // 
            this.radioButtonTR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonTR.AutoSize = true;
            this.radioButtonTR.Location = new System.Drawing.Point(287, 9);
            this.radioButtonTR.Name = "radioButtonTR";
            this.radioButtonTR.Size = new System.Drawing.Size(57, 24);
            this.radioButtonTR.TabIndex = 0;
            this.radioButtonTR.Text = "右上";
            this.radioButtonTR.UseVisualStyleBackColor = true;
            // 
            // radioButtonCR
            // 
            this.radioButtonCR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonCR.AutoSize = true;
            this.radioButtonCR.Location = new System.Drawing.Point(287, 51);
            this.radioButtonCR.Name = "radioButtonCR";
            this.radioButtonCR.Size = new System.Drawing.Size(57, 24);
            this.radioButtonCR.TabIndex = 0;
            this.radioButtonCR.Text = "右中";
            this.radioButtonCR.UseVisualStyleBackColor = true;
            // 
            // radioButtonBR
            // 
            this.radioButtonBR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonBR.AutoSize = true;
            this.radioButtonBR.Location = new System.Drawing.Point(287, 93);
            this.radioButtonBR.Name = "radioButtonBR";
            this.radioButtonBR.Size = new System.Drawing.Size(57, 24);
            this.radioButtonBR.TabIndex = 0;
            this.radioButtonBR.Text = "右下";
            this.radioButtonBR.UseVisualStyleBackColor = true;
            // 
            // radioButtonBC
            // 
            this.radioButtonBC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonBC.AutoSize = true;
            this.radioButtonBC.Location = new System.Drawing.Point(160, 93);
            this.radioButtonBC.Name = "radioButtonBC";
            this.radioButtonBC.Size = new System.Drawing.Size(57, 24);
            this.radioButtonBC.TabIndex = 0;
            this.radioButtonBC.Text = "中下";
            this.radioButtonBC.UseVisualStyleBackColor = true;
            // 
            // radioButtonCL
            // 
            this.radioButtonCL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonCL.AutoSize = true;
            this.radioButtonCL.Location = new System.Drawing.Point(34, 51);
            this.radioButtonCL.Name = "radioButtonCL";
            this.radioButtonCL.Size = new System.Drawing.Size(57, 24);
            this.radioButtonCL.TabIndex = 0;
            this.radioButtonCL.Text = "左中";
            this.radioButtonCL.UseVisualStyleBackColor = true;
            // 
            // radioButtonBL
            // 
            this.radioButtonBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonBL.AutoSize = true;
            this.radioButtonBL.Location = new System.Drawing.Point(34, 93);
            this.radioButtonBL.Name = "radioButtonBL";
            this.radioButtonBL.Size = new System.Drawing.Size(57, 24);
            this.radioButtonBL.TabIndex = 0;
            this.radioButtonBL.Text = "左下";
            this.radioButtonBL.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonVRatio);
            this.panel1.Controls.Add(this.radioButtonVIsometry);
            this.panel1.Location = new System.Drawing.Point(122, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 33);
            this.panel1.TabIndex = 5;
            // 
            // radioButtonVIsometry
            // 
            this.radioButtonVIsometry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonVIsometry.AutoSize = true;
            this.radioButtonVIsometry.Location = new System.Drawing.Point(3, 4);
            this.radioButtonVIsometry.Name = "radioButtonVIsometry";
            this.radioButtonVIsometry.Size = new System.Drawing.Size(57, 24);
            this.radioButtonVIsometry.TabIndex = 0;
            this.radioButtonVIsometry.TabStop = true;
            this.radioButtonVIsometry.Text = "等長";
            this.radioButtonVIsometry.UseVisualStyleBackColor = true;
            // 
            // radioButtonVRatio
            // 
            this.radioButtonVRatio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonVRatio.AutoSize = true;
            this.radioButtonVRatio.Location = new System.Drawing.Point(104, 4);
            this.radioButtonVRatio.Name = "radioButtonVRatio";
            this.radioButtonVRatio.Size = new System.Drawing.Size(57, 24);
            this.radioButtonVRatio.TabIndex = 0;
            this.radioButtonVRatio.TabStop = true;
            this.radioButtonVRatio.Text = "比率";
            this.radioButtonVRatio.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonHRatio);
            this.panel2.Controls.Add(this.radioButtonHIsometry);
            this.panel2.Location = new System.Drawing.Point(24, 405);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(92, 81);
            this.panel2.TabIndex = 5;
            // 
            // radioButtonHRatio
            // 
            this.radioButtonHRatio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButtonHRatio.AutoSize = true;
            this.radioButtonHRatio.Location = new System.Drawing.Point(22, 54);
            this.radioButtonHRatio.Name = "radioButtonHRatio";
            this.radioButtonHRatio.Size = new System.Drawing.Size(57, 24);
            this.radioButtonHRatio.TabIndex = 0;
            this.radioButtonHRatio.TabStop = true;
            this.radioButtonHRatio.Text = "比率";
            this.radioButtonHRatio.UseVisualStyleBackColor = true;
            // 
            // radioButtonHIsometry
            // 
            this.radioButtonHIsometry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonHIsometry.AutoSize = true;
            this.radioButtonHIsometry.Location = new System.Drawing.Point(22, 3);
            this.radioButtonHIsometry.Name = "radioButtonHIsometry";
            this.radioButtonHIsometry.Size = new System.Drawing.Size(57, 24);
            this.radioButtonHIsometry.TabIndex = 0;
            this.radioButtonHIsometry.TabStop = true;
            this.radioButtonHIsometry.Text = "等長";
            this.radioButtonHIsometry.UseVisualStyleBackColor = true;
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(122, 406);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(229, 80);
            this.labelLength.TabIndex = 6;
            this.labelLength.Text = "各々の行または列の長さを\r\n揃えるか比率を保持するかを選択する\r\n・横並びのものは各行\r\n・縦並びのものは各列";
            // 
            // labelalign
            // 
            this.labelalign.AutoSize = true;
            this.labelalign.Location = new System.Drawing.Point(473, 366);
            this.labelalign.Name = "labelalign";
            this.labelalign.Size = new System.Drawing.Size(298, 20);
            this.labelalign.TabIndex = 7;
            this.labelalign.Text = "比率保持をした場合の整列基準位置を選択する";
            // 
            // buttonAlign
            // 
            this.buttonAlign.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAlign.Location = new System.Drawing.Point(20, 567);
            this.buttonAlign.Name = "buttonAlign";
            this.buttonAlign.Size = new System.Drawing.Size(890, 89);
            this.buttonAlign.TabIndex = 3;
            this.buttonAlign.Text = "整列を実行";
            this.buttonAlign.UseVisualStyleBackColor = true;
            // 
            // CtrlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 673);
            this.Controls.Add(this.labelalign);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.buttonAlign);
            this.Controls.Add(this.buttonMakeLattice);
            this.Controls.Add(this.textBoxMakeLattice);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelConstraint);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CtrlForm";
            this.Text = "UV格子の整列";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CtrlForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOrigin;
        private System.Windows.Forms.Button buttonTopSide;
        private System.Windows.Forms.Button buttonLeftSide;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonTarget;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxOrigin;
        private System.Windows.Forms.TextBox textBoxTopSide;
        private System.Windows.Forms.TextBox textBoxLeftSide;
        private System.Windows.Forms.TextBox textBoxTarget;
        private System.Windows.Forms.Label labelConstraint;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonMakeLattice;
        private System.Windows.Forms.TextBox textBoxMakeLattice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton radioButtonCC;
        private System.Windows.Forms.RadioButton radioButtonTL;
        private System.Windows.Forms.RadioButton radioButtonTC;
        private System.Windows.Forms.RadioButton radioButtonTR;
        private System.Windows.Forms.RadioButton radioButtonCR;
        private System.Windows.Forms.RadioButton radioButtonBR;
        private System.Windows.Forms.RadioButton radioButtonBC;
        private System.Windows.Forms.RadioButton radioButtonCL;
        private System.Windows.Forms.RadioButton radioButtonBL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonVRatio;
        private System.Windows.Forms.RadioButton radioButtonVIsometry;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonHRatio;
        private System.Windows.Forms.RadioButton radioButtonHIsometry;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelalign;
        private System.Windows.Forms.Button buttonAlign;
    }
}