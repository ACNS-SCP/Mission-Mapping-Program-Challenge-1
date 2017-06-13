namespace MappingStageOne
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnCreate = new System.Windows.Forms.Button();
            this.chkPoints = new System.Windows.Forms.CheckBox();
            this.chkLines = new System.Windows.Forms.CheckBox();
            this.chkCircles = new System.Windows.Forms.CheckBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpStart = new System.Windows.Forms.GroupBox();
            this.lblLong = new System.Windows.Forms.Label();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.lblLat = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.grpSpecialLines = new System.Windows.Forms.GroupBox();
            this.lblMidPoints = new System.Windows.Forms.Label();
            this.lblEndPoint = new System.Windows.Forms.Label();
            this.lblEndLong = new System.Windows.Forms.Label();
            this.txtEndLong = new System.Windows.Forms.TextBox();
            this.lblEndLat = new System.Windows.Forms.Label();
            this.txtEndLat = new System.Windows.Forms.TextBox();
            this.btnRemoveMidpoint = new System.Windows.Forms.Button();
            this.btnAddMidpoint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMidPoints = new System.Windows.Forms.ListBox();
            this.txtMidLong = new System.Windows.Forms.TextBox();
            this.txtMidLat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSpecialCircles = new System.Windows.Forms.GroupBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lsvPoints = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPoints = new System.Windows.Forms.Label();
            this.btnDeletePoint = new System.Windows.Forms.Button();
            this.btnDeleteCircle = new System.Windows.Forms.Button();
            this.lblCircles = new System.Windows.Forms.Label();
            this.lsvCircles = new System.Windows.Forms.ListView();
            this.colCircleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCircleLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCircleRadius = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvLines = new System.Windows.Forms.ListView();
            this.colLineName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLineBegin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLineMid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLineEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteLine = new System.Windows.Forms.Button();
            this.lblLines = new System.Windows.Forms.Label();
            this.openXmlFile = new System.Windows.Forms.OpenFileDialog();
            this.saveXmlFile = new System.Windows.Forms.SaveFileDialog();
            this.btnLoadXml = new System.Windows.Forms.Button();
            this.btnSaveXml = new System.Windows.Forms.Button();
            this.grpStart.SuspendLayout();
            this.grpSpecialLines.SuspendLayout();
            this.grpSpecialCircles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Location = new System.Drawing.Point(12, 41);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(78, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // chkPoints
            // 
            this.chkPoints.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPoints.Location = new System.Drawing.Point(12, 12);
            this.chkPoints.Name = "chkPoints";
            this.chkPoints.Size = new System.Drawing.Size(50, 23);
            this.chkPoints.TabIndex = 2;
            this.chkPoints.Tag = "point";
            this.chkPoints.Text = "Point";
            this.chkPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPoints.UseVisualStyleBackColor = true;
            this.chkPoints.Click += new System.EventHandler(this.changeDrawingMode);
            // 
            // chkLines
            // 
            this.chkLines.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkLines.Location = new System.Drawing.Point(68, 12);
            this.chkLines.Name = "chkLines";
            this.chkLines.Size = new System.Drawing.Size(50, 23);
            this.chkLines.TabIndex = 3;
            this.chkLines.Tag = "line";
            this.chkLines.Text = "Line";
            this.chkLines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkLines.UseVisualStyleBackColor = true;
            this.chkLines.Click += new System.EventHandler(this.changeDrawingMode);
            // 
            // chkCircles
            // 
            this.chkCircles.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCircles.Location = new System.Drawing.Point(124, 12);
            this.chkCircles.Name = "chkCircles";
            this.chkCircles.Size = new System.Drawing.Size(50, 23);
            this.chkCircles.TabIndex = 4;
            this.chkCircles.Tag = "circle";
            this.chkCircles.Text = "Circle";
            this.chkCircles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCircles.UseVisualStyleBackColor = true;
            this.chkCircles.Click += new System.EventHandler(this.changeDrawingMode);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Enabled = false;
            this.lblName.Location = new System.Drawing.Point(18, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(62, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(94, 20);
            this.txtName.TabIndex = 8;
            // 
            // grpStart
            // 
            this.grpStart.Controls.Add(this.lblLong);
            this.grpStart.Controls.Add(this.txtLong);
            this.grpStart.Controls.Add(this.lblLat);
            this.grpStart.Controls.Add(this.txtLat);
            this.grpStart.Enabled = false;
            this.grpStart.Location = new System.Drawing.Point(12, 96);
            this.grpStart.Name = "grpStart";
            this.grpStart.Size = new System.Drawing.Size(162, 77);
            this.grpStart.TabIndex = 9;
            this.grpStart.TabStop = false;
            this.grpStart.Text = "Location";
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Location = new System.Drawing.Point(6, 48);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(34, 13);
            this.lblLong.TabIndex = 12;
            this.lblLong.Text = "Long:";
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(50, 45);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(94, 20);
            this.txtLong.TabIndex = 13;
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Location = new System.Drawing.Point(6, 22);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(25, 13);
            this.lblLat.TabIndex = 10;
            this.lblLat.Text = "Lat:";
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(50, 19);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(94, 20);
            this.txtLat.TabIndex = 11;
            // 
            // grpSpecialLines
            // 
            this.grpSpecialLines.Controls.Add(this.lblMidPoints);
            this.grpSpecialLines.Controls.Add(this.lblEndPoint);
            this.grpSpecialLines.Controls.Add(this.lblEndLong);
            this.grpSpecialLines.Controls.Add(this.txtEndLong);
            this.grpSpecialLines.Controls.Add(this.lblEndLat);
            this.grpSpecialLines.Controls.Add(this.txtEndLat);
            this.grpSpecialLines.Controls.Add(this.btnRemoveMidpoint);
            this.grpSpecialLines.Controls.Add(this.btnAddMidpoint);
            this.grpSpecialLines.Controls.Add(this.label1);
            this.grpSpecialLines.Controls.Add(this.lstMidPoints);
            this.grpSpecialLines.Controls.Add(this.txtMidLong);
            this.grpSpecialLines.Controls.Add(this.txtMidLat);
            this.grpSpecialLines.Controls.Add(this.label2);
            this.grpSpecialLines.Location = new System.Drawing.Point(12, 179);
            this.grpSpecialLines.Name = "grpSpecialLines";
            this.grpSpecialLines.Size = new System.Drawing.Size(162, 271);
            this.grpSpecialLines.TabIndex = 10;
            this.grpSpecialLines.TabStop = false;
            this.grpSpecialLines.Text = "Special";
            this.grpSpecialLines.Visible = false;
            // 
            // lblMidPoints
            // 
            this.lblMidPoints.AutoSize = true;
            this.lblMidPoints.Location = new System.Drawing.Point(6, 81);
            this.lblMidPoints.Name = "lblMidPoints";
            this.lblMidPoints.Size = new System.Drawing.Size(56, 13);
            this.lblMidPoints.TabIndex = 24;
            this.lblMidPoints.Text = "Mid Points";
            // 
            // lblEndPoint
            // 
            this.lblEndPoint.AutoSize = true;
            this.lblEndPoint.Location = new System.Drawing.Point(6, 198);
            this.lblEndPoint.Name = "lblEndPoint";
            this.lblEndPoint.Size = new System.Drawing.Size(53, 13);
            this.lblEndPoint.TabIndex = 23;
            this.lblEndPoint.Text = "End Point";
            // 
            // lblEndLong
            // 
            this.lblEndLong.AutoSize = true;
            this.lblEndLong.Location = new System.Drawing.Point(6, 243);
            this.lblEndLong.Name = "lblEndLong";
            this.lblEndLong.Size = new System.Drawing.Size(34, 13);
            this.lblEndLong.TabIndex = 21;
            this.lblEndLong.Text = "Long:";
            // 
            // txtEndLong
            // 
            this.txtEndLong.Location = new System.Drawing.Point(47, 240);
            this.txtEndLong.Name = "txtEndLong";
            this.txtEndLong.Size = new System.Drawing.Size(97, 20);
            this.txtEndLong.TabIndex = 22;
            // 
            // lblEndLat
            // 
            this.lblEndLat.AutoSize = true;
            this.lblEndLat.Location = new System.Drawing.Point(6, 217);
            this.lblEndLat.Name = "lblEndLat";
            this.lblEndLat.Size = new System.Drawing.Size(25, 13);
            this.lblEndLat.TabIndex = 19;
            this.lblEndLat.Text = "Lat:";
            // 
            // txtEndLat
            // 
            this.txtEndLat.Location = new System.Drawing.Point(47, 214);
            this.txtEndLat.Name = "txtEndLat";
            this.txtEndLat.Size = new System.Drawing.Size(97, 20);
            this.txtEndLat.TabIndex = 20;
            // 
            // btnRemoveMidpoint
            // 
            this.btnRemoveMidpoint.Location = new System.Drawing.Point(92, 71);
            this.btnRemoveMidpoint.Name = "btnRemoveMidpoint";
            this.btnRemoveMidpoint.Size = new System.Drawing.Size(23, 23);
            this.btnRemoveMidpoint.TabIndex = 18;
            this.btnRemoveMidpoint.Text = "-";
            this.btnRemoveMidpoint.UseVisualStyleBackColor = true;
            this.btnRemoveMidpoint.Click += new System.EventHandler(this.btnRemoveMidpoint_Click);
            // 
            // btnAddMidpoint
            // 
            this.btnAddMidpoint.Location = new System.Drawing.Point(121, 71);
            this.btnAddMidpoint.Name = "btnAddMidpoint";
            this.btnAddMidpoint.Size = new System.Drawing.Size(23, 23);
            this.btnAddMidpoint.TabIndex = 12;
            this.btnAddMidpoint.Text = "+";
            this.btnAddMidpoint.UseVisualStyleBackColor = true;
            this.btnAddMidpoint.Click += new System.EventHandler(this.btnAddMidpoint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Long:";
            // 
            // lstMidPoints
            // 
            this.lstMidPoints.FormattingEnabled = true;
            this.lstMidPoints.Location = new System.Drawing.Point(6, 100);
            this.lstMidPoints.Name = "lstMidPoints";
            this.lstMidPoints.Size = new System.Drawing.Size(138, 95);
            this.lstMidPoints.TabIndex = 0;
            // 
            // txtMidLong
            // 
            this.txtMidLong.Location = new System.Drawing.Point(50, 45);
            this.txtMidLong.Name = "txtMidLong";
            this.txtMidLong.Size = new System.Drawing.Size(94, 20);
            this.txtMidLong.TabIndex = 17;
            // 
            // txtMidLat
            // 
            this.txtMidLat.Location = new System.Drawing.Point(50, 19);
            this.txtMidLat.Name = "txtMidLat";
            this.txtMidLat.Size = new System.Drawing.Size(94, 20);
            this.txtMidLat.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lat:";
            // 
            // grpSpecialCircles
            // 
            this.grpSpecialCircles.Controls.Add(this.lblRadius);
            this.grpSpecialCircles.Controls.Add(this.txtRadius);
            this.grpSpecialCircles.Location = new System.Drawing.Point(12, 179);
            this.grpSpecialCircles.Name = "grpSpecialCircles";
            this.grpSpecialCircles.Size = new System.Drawing.Size(162, 53);
            this.grpSpecialCircles.TabIndex = 11;
            this.grpSpecialCircles.TabStop = false;
            this.grpSpecialCircles.Text = "Special";
            this.grpSpecialCircles.Visible = false;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(6, 22);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(43, 13);
            this.lblRadius.TabIndex = 14;
            this.lblRadius.Text = "Radius:";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(50, 19);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(94, 20);
            this.txtRadius.TabIndex = 15;
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // lsvPoints
            // 
            this.lsvPoints.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colLocation});
            this.lsvPoints.FullRowSelect = true;
            this.lsvPoints.HideSelection = false;
            this.lsvPoints.Location = new System.Drawing.Point(180, 41);
            this.lsvPoints.MultiSelect = false;
            this.lsvPoints.Name = "lsvPoints";
            this.lsvPoints.Size = new System.Drawing.Size(247, 132);
            this.lsvPoints.TabIndex = 12;
            this.lsvPoints.UseCompatibleStateImageBehavior = false;
            this.lsvPoints.View = System.Windows.Forms.View.Details;
            this.lsvPoints.SelectedIndexChanged += new System.EventHandler(this.lsvPoints_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 105;
            // 
            // colLocation
            // 
            this.colLocation.Text = "Location";
            this.colLocation.Width = 138;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(177, 17);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(39, 13);
            this.lblPoints.TabIndex = 13;
            this.lblPoints.Text = "Points:";
            // 
            // btnDeletePoint
            // 
            this.btnDeletePoint.Enabled = false;
            this.btnDeletePoint.Location = new System.Drawing.Point(349, 12);
            this.btnDeletePoint.Name = "btnDeletePoint";
            this.btnDeletePoint.Size = new System.Drawing.Size(78, 23);
            this.btnDeletePoint.TabIndex = 14;
            this.btnDeletePoint.Text = "Delete";
            this.btnDeletePoint.UseVisualStyleBackColor = true;
            this.btnDeletePoint.Click += new System.EventHandler(this.btnDeletePoint_Click);
            // 
            // btnDeleteCircle
            // 
            this.btnDeleteCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCircle.Enabled = false;
            this.btnDeleteCircle.Location = new System.Drawing.Point(605, 12);
            this.btnDeleteCircle.Name = "btnDeleteCircle";
            this.btnDeleteCircle.Size = new System.Drawing.Size(78, 23);
            this.btnDeleteCircle.TabIndex = 17;
            this.btnDeleteCircle.Text = "Delete";
            this.btnDeleteCircle.UseVisualStyleBackColor = true;
            this.btnDeleteCircle.Click += new System.EventHandler(this.btnDeleteCircle_Click);
            // 
            // lblCircles
            // 
            this.lblCircles.AutoSize = true;
            this.lblCircles.Location = new System.Drawing.Point(433, 17);
            this.lblCircles.Name = "lblCircles";
            this.lblCircles.Size = new System.Drawing.Size(41, 13);
            this.lblCircles.TabIndex = 16;
            this.lblCircles.Text = "Circles:";
            // 
            // lsvCircles
            // 
            this.lsvCircles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvCircles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCircleName,
            this.colCircleLocation,
            this.colCircleRadius});
            this.lsvCircles.FullRowSelect = true;
            this.lsvCircles.HideSelection = false;
            this.lsvCircles.Location = new System.Drawing.Point(436, 41);
            this.lsvCircles.MultiSelect = false;
            this.lsvCircles.Name = "lsvCircles";
            this.lsvCircles.Size = new System.Drawing.Size(247, 132);
            this.lsvCircles.TabIndex = 15;
            this.lsvCircles.UseCompatibleStateImageBehavior = false;
            this.lsvCircles.View = System.Windows.Forms.View.Details;
            this.lsvCircles.SelectedIndexChanged += new System.EventHandler(this.lsvCircles_SelectedIndexChanged);
            // 
            // colCircleName
            // 
            this.colCircleName.Text = "Name";
            this.colCircleName.Width = 72;
            // 
            // colCircleLocation
            // 
            this.colCircleLocation.Text = "Location";
            this.colCircleLocation.Width = 124;
            // 
            // colCircleRadius
            // 
            this.colCircleRadius.Text = "Radius";
            this.colCircleRadius.Width = 47;
            // 
            // lsvLines
            // 
            this.lsvLines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLineName,
            this.colLineBegin,
            this.colLineMid,
            this.colLineEnd});
            this.lsvLines.FullRowSelect = true;
            this.lsvLines.HideSelection = false;
            this.lsvLines.Location = new System.Drawing.Point(180, 208);
            this.lsvLines.MultiSelect = false;
            this.lsvLines.Name = "lsvLines";
            this.lsvLines.Size = new System.Drawing.Size(503, 132);
            this.lsvLines.TabIndex = 18;
            this.lsvLines.UseCompatibleStateImageBehavior = false;
            this.lsvLines.View = System.Windows.Forms.View.Details;
            this.lsvLines.SelectedIndexChanged += new System.EventHandler(this.lsvLines_SelectedIndexChanged);
            // 
            // colLineName
            // 
            this.colLineName.Text = "Name";
            this.colLineName.Width = 78;
            // 
            // colLineBegin
            // 
            this.colLineBegin.Text = "Begin";
            this.colLineBegin.Width = 78;
            // 
            // colLineMid
            // 
            this.colLineMid.Text = "Mid-points";
            this.colLineMid.Width = 265;
            // 
            // colLineEnd
            // 
            this.colLineEnd.Text = "End";
            this.colLineEnd.Width = 78;
            // 
            // btnDeleteLine
            // 
            this.btnDeleteLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteLine.Enabled = false;
            this.btnDeleteLine.Location = new System.Drawing.Point(605, 179);
            this.btnDeleteLine.Name = "btnDeleteLine";
            this.btnDeleteLine.Size = new System.Drawing.Size(78, 23);
            this.btnDeleteLine.TabIndex = 20;
            this.btnDeleteLine.Text = "Delete";
            this.btnDeleteLine.UseVisualStyleBackColor = true;
            this.btnDeleteLine.Click += new System.EventHandler(this.btnDeleteLines_Click);
            // 
            // lblLines
            // 
            this.lblLines.AutoSize = true;
            this.lblLines.Location = new System.Drawing.Point(177, 184);
            this.lblLines.Name = "lblLines";
            this.lblLines.Size = new System.Drawing.Size(35, 13);
            this.lblLines.TabIndex = 19;
            this.lblLines.Text = "Lines:";
            // 
            // openXmlFile
            // 
            this.openXmlFile.DefaultExt = "xml";
            this.openXmlFile.Filter = "Xml Files|*.xml";
            // 
            // saveXmlFile
            // 
            this.saveXmlFile.DefaultExt = "xml";
            this.saveXmlFile.Filter = "Xml Files|*.xml";
            // 
            // btnLoadXml
            // 
            this.btnLoadXml.Location = new System.Drawing.Point(608, 427);
            this.btnLoadXml.Name = "btnLoadXml";
            this.btnLoadXml.Size = new System.Drawing.Size(75, 23);
            this.btnLoadXml.TabIndex = 21;
            this.btnLoadXml.Text = "Load";
            this.btnLoadXml.UseVisualStyleBackColor = true;
            this.btnLoadXml.Click += new System.EventHandler(this.btnLoadXml_Click);
            // 
            // btnSaveXml
            // 
            this.btnSaveXml.Location = new System.Drawing.Point(527, 427);
            this.btnSaveXml.Name = "btnSaveXml";
            this.btnSaveXml.Size = new System.Drawing.Size(75, 23);
            this.btnSaveXml.TabIndex = 22;
            this.btnSaveXml.Text = "Save";
            this.btnSaveXml.UseVisualStyleBackColor = true;
            this.btnSaveXml.Click += new System.EventHandler(this.btnSaveXml_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 462);
            this.Controls.Add(this.btnSaveXml);
            this.Controls.Add(this.btnLoadXml);
            this.Controls.Add(this.btnDeleteLine);
            this.Controls.Add(this.lblLines);
            this.Controls.Add(this.lsvLines);
            this.Controls.Add(this.btnDeleteCircle);
            this.Controls.Add(this.lblCircles);
            this.Controls.Add(this.lsvCircles);
            this.Controls.Add(this.btnDeletePoint);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lsvPoints);
            this.Controls.Add(this.grpSpecialCircles);
            this.Controls.Add(this.grpSpecialLines);
            this.Controls.Add(this.grpStart);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.chkCircles);
            this.Controls.Add(this.chkLines);
            this.Controls.Add(this.chkPoints);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpStart.ResumeLayout(false);
            this.grpStart.PerformLayout();
            this.grpSpecialLines.ResumeLayout(false);
            this.grpSpecialLines.PerformLayout();
            this.grpSpecialCircles.ResumeLayout(false);
            this.grpSpecialCircles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.CheckBox chkPoints;
        private System.Windows.Forms.CheckBox chkLines;
        private System.Windows.Forms.CheckBox chkCircles;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpStart;
        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.GroupBox grpSpecialLines;
        private System.Windows.Forms.GroupBox grpSpecialCircles;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button btnRemoveMidpoint;
        private System.Windows.Forms.Button btnAddMidpoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstMidPoints;
        private System.Windows.Forms.TextBox txtMidLong;
        private System.Windows.Forms.TextBox txtMidLat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEndPoint;
        private System.Windows.Forms.Label lblEndLong;
        private System.Windows.Forms.TextBox txtEndLong;
        private System.Windows.Forms.Label lblEndLat;
        private System.Windows.Forms.TextBox txtEndLat;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.ListView lsvPoints;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colLocation;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Button btnDeletePoint;
        private System.Windows.Forms.Button btnDeleteCircle;
        private System.Windows.Forms.Label lblCircles;
        private System.Windows.Forms.ListView lsvCircles;
        private System.Windows.Forms.ColumnHeader colCircleName;
        private System.Windows.Forms.ColumnHeader colCircleLocation;
        private System.Windows.Forms.ColumnHeader colCircleRadius;
        private System.Windows.Forms.Label lblMidPoints;
        private System.Windows.Forms.Button btnDeleteLine;
        private System.Windows.Forms.Label lblLines;
        private System.Windows.Forms.ListView lsvLines;
        private System.Windows.Forms.ColumnHeader colLineName;
        private System.Windows.Forms.ColumnHeader colLineBegin;
        private System.Windows.Forms.ColumnHeader colLineMid;
        private System.Windows.Forms.ColumnHeader colLineEnd;
        private System.Windows.Forms.Button btnSaveXml;
        private System.Windows.Forms.Button btnLoadXml;
        private System.Windows.Forms.OpenFileDialog openXmlFile;
        private System.Windows.Forms.SaveFileDialog saveXmlFile;
    }
}
