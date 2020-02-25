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
            this.tableLayoutPanelButton = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTarget = new System.Windows.Forms.Button();
            this.tableLayoutPanelNum = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxOrigin = new System.Windows.Forms.TextBox();
            this.textBoxTopSide = new System.Windows.Forms.TextBox();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.textBoxLeftSide = new System.Windows.Forms.TextBox();
            this.labelConstraint = new System.Windows.Forms.Label();
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
            this.buttonAlign = new System.Windows.Forms.Button();
            this.checkBoxHIsolength = new System.Windows.Forms.CheckBox();
            this.checkBoxVIsolength = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanelSettings = new System.Windows.Forms.TableLayoutPanel();
            this.labelalign = new System.Windows.Forms.Label();
            this.tableLayoutPanelSetDesc = new System.Windows.Forms.TableLayoutPanel();
            this.labelHIsolength = new System.Windows.Forms.Label();
            this.labelVIsolength = new System.Windows.Forms.Label();
            this.labelSettings = new System.Windows.Forms.Label();
            this.labelSetDesc = new System.Windows.Forms.Label();
            this.tableLayoutPanelButton.SuspendLayout();
            this.tableLayoutPanelNum.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanelSettings.SuspendLayout();
            this.tableLayoutPanelSetDesc.SuspendLayout();
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
            this.buttonOrigin.Click += new System.EventHandler(this.buttonOrigin_Click);
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
            this.buttonTopSide.Click += new System.EventHandler(this.buttonTopSide_Click);
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
            this.buttonLeftSide.Click += new System.EventHandler(this.buttonLeftSide_Click);
            // 
            // tableLayoutPanelButton
            // 
            this.tableLayoutPanelButton.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanelButton.ColumnCount = 2;
            this.tableLayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelButton.Controls.Add(this.buttonOrigin, 0, 0);
            this.tableLayoutPanelButton.Controls.Add(this.buttonTopSide, 1, 0);
            this.tableLayoutPanelButton.Controls.Add(this.buttonLeftSide, 0, 1);
            this.tableLayoutPanelButton.Controls.Add(this.buttonTarget, 1, 1);
            this.tableLayoutPanelButton.Location = new System.Drawing.Point(20, 112);
            this.tableLayoutPanelButton.Name = "tableLayoutPanelButton";
            this.tableLayoutPanelButton.RowCount = 2;
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelButton.Size = new System.Drawing.Size(429, 161);
            this.tableLayoutPanelButton.TabIndex = 1;
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
            this.buttonTarget.Click += new System.EventHandler(this.buttonTarget_Click);
            // 
            // tableLayoutPanelNum
            // 
            this.tableLayoutPanelNum.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanelNum.ColumnCount = 2;
            this.tableLayoutPanelNum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNum.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelNum.Controls.Add(this.textBoxOrigin, 0, 0);
            this.tableLayoutPanelNum.Controls.Add(this.textBoxTopSide, 1, 0);
            this.tableLayoutPanelNum.Controls.Add(this.textBoxTarget, 1, 1);
            this.tableLayoutPanelNum.Controls.Add(this.textBoxLeftSide, 0, 1);
            this.tableLayoutPanelNum.Location = new System.Drawing.Point(477, 112);
            this.tableLayoutPanelNum.Name = "tableLayoutPanelNum";
            this.tableLayoutPanelNum.RowCount = 2;
            this.tableLayoutPanelNum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNum.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelNum.Size = new System.Drawing.Size(433, 161);
            this.tableLayoutPanelNum.TabIndex = 1;
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
            this.labelConstraint.Text = "前提\r\n・上辺と下辺の点数が同じである\r\n・左辺と右辺の点数が同じである\r\n・起点から辺を確定するとき前方に1次隣接点が2つ以上存在しない　";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDescription.Location = new System.Drawing.Point(16, 9);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(433, 82);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "1. UV格子生成の起点となる格子左上頂点を選択する\r\n2. UV格子の上辺・左辺となる頂点群を選択する\r\n3. UV格子を当てはめる頂点群を選択する\r\n頂点が複" +
    "数回選択された場合、数字が小さい手順の選択が優先される\r\n";
            // 
            // buttonMakeLattice
            // 
            this.buttonMakeLattice.Location = new System.Drawing.Point(20, 292);
            this.buttonMakeLattice.Name = "buttonMakeLattice";
            this.buttonMakeLattice.Size = new System.Drawing.Size(429, 27);
            this.buttonMakeLattice.TabIndex = 3;
            this.buttonMakeLattice.Text = "格子を生成";
            this.buttonMakeLattice.UseVisualStyleBackColor = true;
            this.buttonMakeLattice.Click += new System.EventHandler(this.buttonMakeLattice_Click);
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
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(112, 45);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(312, 111);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // radioButtonCC
            // 
            this.radioButtonCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonCC.AutoSize = true;
            this.radioButtonCC.Checked = true;
            this.radioButtonCC.Location = new System.Drawing.Point(127, 42);
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
            this.radioButtonTL.Location = new System.Drawing.Point(23, 6);
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
            this.radioButtonTC.Location = new System.Drawing.Point(127, 6);
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
            this.radioButtonTR.Location = new System.Drawing.Point(231, 6);
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
            this.radioButtonCR.Location = new System.Drawing.Point(231, 42);
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
            this.radioButtonBR.Location = new System.Drawing.Point(231, 79);
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
            this.radioButtonBC.Location = new System.Drawing.Point(127, 79);
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
            this.radioButtonCL.Location = new System.Drawing.Point(23, 42);
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
            this.radioButtonBL.Location = new System.Drawing.Point(23, 79);
            this.radioButtonBL.Name = "radioButtonBL";
            this.radioButtonBL.Size = new System.Drawing.Size(57, 24);
            this.radioButtonBL.TabIndex = 0;
            this.radioButtonBL.Text = "左下";
            this.radioButtonBL.UseVisualStyleBackColor = true;
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
            this.buttonAlign.Click += new System.EventHandler(this.buttonAlign_Click);
            // 
            // checkBoxHIsolength
            // 
            this.checkBoxHIsolength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxHIsolength.AutoSize = true;
            this.checkBoxHIsolength.Location = new System.Drawing.Point(203, 9);
            this.checkBoxHIsolength.Name = "checkBoxHIsolength";
            this.checkBoxHIsolength.Size = new System.Drawing.Size(129, 24);
            this.checkBoxHIsolength.TabIndex = 8;
            this.checkBoxHIsolength.Text = "横の長さを揃える";
            this.checkBoxHIsolength.UseVisualStyleBackColor = true;
            // 
            // checkBoxVIsolength
            // 
            this.checkBoxVIsolength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxVIsolength.AutoSize = true;
            this.checkBoxVIsolength.Location = new System.Drawing.Point(21, 68);
            this.checkBoxVIsolength.Name = "checkBoxVIsolength";
            this.checkBoxVIsolength.Size = new System.Drawing.Size(66, 64);
            this.checkBoxVIsolength.TabIndex = 8;
            this.checkBoxVIsolength.Text = "縦の\r\n長さを\r\n揃える";
            this.checkBoxVIsolength.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxVIsolength.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelSettings
            // 
            this.tableLayoutPanelSettings.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanelSettings.ColumnCount = 2;
            this.tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelSettings.Controls.Add(this.checkBoxHIsolength, 1, 0);
            this.tableLayoutPanelSettings.Controls.Add(this.checkBoxVIsolength, 0, 1);
            this.tableLayoutPanelSettings.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanelSettings.Controls.Add(this.labelSettings, 0, 0);
            this.tableLayoutPanelSettings.Location = new System.Drawing.Point(20, 366);
            this.tableLayoutPanelSettings.Name = "tableLayoutPanelSettings";
            this.tableLayoutPanelSettings.RowCount = 2;
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelSettings.Size = new System.Drawing.Size(429, 161);
            this.tableLayoutPanelSettings.TabIndex = 1;
            // 
            // labelalign
            // 
            this.labelalign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelalign.AutoSize = true;
            this.labelalign.Location = new System.Drawing.Point(221, 90);
            this.labelalign.Name = "labelalign";
            this.labelalign.Size = new System.Drawing.Size(99, 20);
            this.labelalign.TabIndex = 7;
            this.labelalign.Text = "整列基準位置";
            // 
            // tableLayoutPanelSetDesc
            // 
            this.tableLayoutPanelSetDesc.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanelSetDesc.ColumnCount = 2;
            this.tableLayoutPanelSetDesc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSetDesc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelSetDesc.Controls.Add(this.labelalign, 1, 1);
            this.tableLayoutPanelSetDesc.Controls.Add(this.labelHIsolength, 1, 0);
            this.tableLayoutPanelSetDesc.Controls.Add(this.labelVIsolength, 0, 1);
            this.tableLayoutPanelSetDesc.Controls.Add(this.labelSetDesc, 0, 0);
            this.tableLayoutPanelSetDesc.Location = new System.Drawing.Point(477, 366);
            this.tableLayoutPanelSetDesc.Name = "tableLayoutPanelSetDesc";
            this.tableLayoutPanelSetDesc.RowCount = 2;
            this.tableLayoutPanelSetDesc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSetDesc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelSetDesc.Size = new System.Drawing.Size(433, 161);
            this.tableLayoutPanelSetDesc.TabIndex = 1;
            // 
            // labelHIsolength
            // 
            this.labelHIsolength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHIsolength.AutoSize = true;
            this.labelHIsolength.Location = new System.Drawing.Point(150, 11);
            this.labelHIsolength.Name = "labelHIsolength";
            this.labelHIsolength.Size = new System.Drawing.Size(241, 20);
            this.labelHIsolength.TabIndex = 7;
            this.labelHIsolength.Text = "上辺の長さに全ての横の長さを合わせる";
            // 
            // labelVIsolength
            // 
            this.labelVIsolength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVIsolength.AutoSize = true;
            this.labelVIsolength.Location = new System.Drawing.Point(5, 70);
            this.labelVIsolength.Name = "labelVIsolength";
            this.labelVIsolength.Size = new System.Drawing.Size(99, 60);
            this.labelVIsolength.TabIndex = 7;
            this.labelVIsolength.Text = "左辺の長さに全ての縦の長さを合わせる";
            // 
            // labelSettings
            // 
            this.labelSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSettings.AutoSize = true;
            this.labelSettings.Location = new System.Drawing.Point(20, 11);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(69, 20);
            this.labelSettings.TabIndex = 9;
            this.labelSettings.Text = "整列設定";
            // 
            // labelSetDesc
            // 
            this.labelSetDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSetDesc.AutoSize = true;
            this.labelSetDesc.Location = new System.Drawing.Point(20, 11);
            this.labelSetDesc.Name = "labelSetDesc";
            this.labelSetDesc.Size = new System.Drawing.Size(69, 20);
            this.labelSetDesc.TabIndex = 9;
            this.labelSetDesc.Text = "設定概要";
            // 
            // CtrlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 673);
            this.Controls.Add(this.buttonAlign);
            this.Controls.Add(this.buttonMakeLattice);
            this.Controls.Add(this.textBoxMakeLattice);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.tableLayoutPanelNum);
            this.Controls.Add(this.tableLayoutPanelSetDesc);
            this.Controls.Add(this.tableLayoutPanelSettings);
            this.Controls.Add(this.tableLayoutPanelButton);
            this.Controls.Add(this.labelConstraint);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CtrlForm";
            this.Text = "UV格子の整列";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CtrlForm_FormClosing);
            this.tableLayoutPanelButton.ResumeLayout(false);
            this.tableLayoutPanelNum.ResumeLayout(false);
            this.tableLayoutPanelNum.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanelSettings.ResumeLayout(false);
            this.tableLayoutPanelSettings.PerformLayout();
            this.tableLayoutPanelSetDesc.ResumeLayout(false);
            this.tableLayoutPanelSetDesc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOrigin;
        private System.Windows.Forms.Button buttonTopSide;
        private System.Windows.Forms.Button buttonLeftSide;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButton;
        private System.Windows.Forms.Button buttonTarget;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNum;
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
        private System.Windows.Forms.Button buttonAlign;
        private System.Windows.Forms.CheckBox checkBoxHIsolength;
        private System.Windows.Forms.CheckBox checkBoxVIsolength;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSettings;
        private System.Windows.Forms.Label labelalign;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSetDesc;
        private System.Windows.Forms.Label labelHIsolength;
        private System.Windows.Forms.Label labelVIsolength;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Label labelSetDesc;
    }
}