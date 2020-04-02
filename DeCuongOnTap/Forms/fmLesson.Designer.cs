namespace DeCuongOnTap.Forms
{
    partial class fmLesson
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblTeacherName = new DevExpress.XtraEditors.LabelControl();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cbxSem = new System.Windows.Forms.ComboBox();
            this.cbxGra = new System.Windows.Forms.ComboBox();
            this.cbxSub = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gridQuestion = new DevExpress.XtraGrid.GridControl();
            this.gridViewQuestion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Level = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Question = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AnsA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AnsB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AnsC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AnsD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Answer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Update = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Purple;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(1000, 61);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Purple;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(301, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(399, 42);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "NỘI DUNG ĐỀ CƯƠNG";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblTeacherName.Appearance.Options.UseFont = true;
            this.lblTeacherName.Appearance.Options.UseTextOptions = true;
            this.lblTeacherName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTeacherName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTeacherName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTeacherName.Location = new System.Drawing.Point(2, 2);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(989, 33);
            this.lblTeacherName.TabIndex = 3;
            this.lblTeacherName.Text = "<Giáo viên>";
            // 
            // cbxType
            // 
            this.cbxType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Trắc nghiệm",
            "Tự luận"});
            this.cbxType.Location = new System.Drawing.Point(372, 76);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(115, 27);
            this.cbxType.TabIndex = 3;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(270, 79);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(96, 19);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Loại câu hỏi: ";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.cbxSem);
            this.panelControl2.Controls.Add(this.cbxGra);
            this.panelControl2.Controls.Add(this.cbxSub);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.btnAdd);
            this.panelControl2.Controls.Add(this.cbxType);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.lblTeacherName);
            this.panelControl2.Location = new System.Drawing.Point(5, 64);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(993, 116);
            this.panelControl2.TabIndex = 5;
            // 
            // cbxSem
            // 
            this.cbxSem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSem.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbxSem.FormattingEnabled = true;
            this.cbxSem.Items.AddRange(new object[] {
            "Trắc nghiệm",
            "Tự luận"});
            this.cbxSem.Location = new System.Drawing.Point(121, 43);
            this.cbxSem.Name = "cbxSem";
            this.cbxSem.Size = new System.Drawing.Size(115, 27);
            this.cbxSem.TabIndex = 0;
            this.cbxSem.SelectedIndexChanged += new System.EventHandler(this.cbxSem_SelectedIndexChanged);
            // 
            // cbxGra
            // 
            this.cbxGra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxGra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGra.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbxGra.FormattingEnabled = true;
            this.cbxGra.Location = new System.Drawing.Point(121, 76);
            this.cbxGra.Name = "cbxGra";
            this.cbxGra.Size = new System.Drawing.Size(115, 27);
            this.cbxGra.TabIndex = 1;
            this.cbxGra.SelectedIndexChanged += new System.EventHandler(this.cbxGra_SelectedIndexChanged);
            // 
            // cbxSub
            // 
            this.cbxSub.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSub.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbxSub.FormattingEnabled = true;
            this.cbxSub.Location = new System.Drawing.Point(372, 43);
            this.cbxSub.Name = "cbxSub";
            this.cbxSub.Size = new System.Drawing.Size(115, 27);
            this.cbxSub.TabIndex = 2;
            this.cbxSub.SelectedIndexChanged += new System.EventHandler(this.cbxSub_SelectedIndexChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(251, 46);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(115, 19);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "Chọn môn học: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(721, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(267, 60);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm câu hỏi";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(5, 79);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(110, 19);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Chọn khối lớp: ";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(16, 46);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(99, 19);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Chọn học kỳ: ";
            // 
            // gridQuestion
            // 
            this.gridQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridQuestion.Location = new System.Drawing.Point(2, 186);
            this.gridQuestion.MainView = this.gridViewQuestion;
            this.gridQuestion.MenuManager = this.ribbonControl1;
            this.gridQuestion.Name = "gridQuestion";
            this.gridQuestion.Size = new System.Drawing.Size(996, 597);
            this.gridQuestion.TabIndex = 0;
            this.gridQuestion.TabStop = false;
            this.gridQuestion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewQuestion});
            // 
            // gridViewQuestion
            // 
            this.gridViewQuestion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.Level,
            this.STT,
            this.Question,
            this.AnsA,
            this.AnsB,
            this.AnsC,
            this.AnsD,
            this.Answer,
            this.Update});
            this.gridViewQuestion.GridControl = this.gridQuestion;
            this.gridViewQuestion.Name = "gridViewQuestion";
            this.gridViewQuestion.RowHeight = 1;
            this.gridViewQuestion.DoubleClick += new System.EventHandler(this.gridViewQuestion_DoubleClick);
            // 
            // colID
            // 
            this.colID.FieldName = "Id";
            this.colID.MaxWidth = 40;
            this.colID.MinWidth = 40;
            this.colID.Name = "colID";
            this.colID.Width = 40;
            // 
            // Level
            // 
            this.Level.AppearanceCell.Options.UseTextOptions = true;
            this.Level.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Level.AppearanceHeader.Options.UseTextOptions = true;
            this.Level.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Level.Caption = "Mức độ";
            this.Level.FieldName = "Level";
            this.Level.MaxWidth = 60;
            this.Level.MinWidth = 60;
            this.Level.Name = "Level";
            this.Level.OptionsColumn.AllowEdit = false;
            this.Level.Visible = true;
            this.Level.VisibleIndex = 0;
            this.Level.Width = 60;
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.Options.UseTextOptions = true;
            this.STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.MaxWidth = 30;
            this.STT.MinWidth = 30;
            this.STT.Name = "STT";
            this.STT.OptionsColumn.AllowEdit = false;
            this.STT.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.STT.Visible = true;
            this.STT.VisibleIndex = 1;
            this.STT.Width = 30;
            // 
            // Question
            // 
            this.Question.AppearanceCell.Options.UseTextOptions = true;
            this.Question.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Question.AppearanceHeader.Options.UseTextOptions = true;
            this.Question.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Question.Caption = "Câu hỏi";
            this.Question.FieldName = "Question";
            this.Question.MinWidth = 200;
            this.Question.Name = "Question";
            this.Question.OptionsColumn.AllowEdit = false;
            this.Question.Visible = true;
            this.Question.VisibleIndex = 2;
            this.Question.Width = 200;
            // 
            // AnsA
            // 
            this.AnsA.AppearanceHeader.Options.UseTextOptions = true;
            this.AnsA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AnsA.Caption = "Đáp án A";
            this.AnsA.FieldName = "AnswerA";
            this.AnsA.Name = "AnsA";
            this.AnsA.OptionsColumn.AllowEdit = false;
            this.AnsA.Visible = true;
            this.AnsA.VisibleIndex = 3;
            this.AnsA.Width = 96;
            // 
            // AnsB
            // 
            this.AnsB.AppearanceHeader.Options.UseTextOptions = true;
            this.AnsB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AnsB.Caption = "Đáp án B";
            this.AnsB.FieldName = "AnswerB";
            this.AnsB.Name = "AnsB";
            this.AnsB.OptionsColumn.AllowEdit = false;
            this.AnsB.Visible = true;
            this.AnsB.VisibleIndex = 4;
            this.AnsB.Width = 96;
            // 
            // AnsC
            // 
            this.AnsC.AppearanceHeader.Options.UseTextOptions = true;
            this.AnsC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AnsC.Caption = "Đáp án C";
            this.AnsC.FieldName = "AnswerC";
            this.AnsC.Name = "AnsC";
            this.AnsC.OptionsColumn.AllowEdit = false;
            this.AnsC.Visible = true;
            this.AnsC.VisibleIndex = 5;
            this.AnsC.Width = 96;
            // 
            // AnsD
            // 
            this.AnsD.AppearanceHeader.Options.UseTextOptions = true;
            this.AnsD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AnsD.Caption = "Đáp án D";
            this.AnsD.FieldName = "AnswerD";
            this.AnsD.Name = "AnsD";
            this.AnsD.OptionsColumn.AllowEdit = false;
            this.AnsD.Visible = true;
            this.AnsD.VisibleIndex = 6;
            this.AnsD.Width = 96;
            // 
            // Answer
            // 
            this.Answer.AppearanceHeader.Options.UseTextOptions = true;
            this.Answer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Answer.Caption = "Cấu trả lới";
            this.Answer.FieldName = "Answer";
            this.Answer.Name = "Answer";
            this.Answer.OptionsColumn.AllowEdit = false;
            this.Answer.Visible = true;
            this.Answer.VisibleIndex = 7;
            this.Answer.Width = 177;
            // 
            // Update
            // 
            this.Update.AppearanceCell.Options.UseTextOptions = true;
            this.Update.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Update.AppearanceHeader.Options.UseTextOptions = true;
            this.Update.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Update.Caption = "Thời gian tạo";
            this.Update.FieldName = "UpdateTime";
            this.Update.MaxWidth = 120;
            this.Update.MinWidth = 120;
            this.Update.Name = "Update";
            this.Update.OptionsColumn.AllowEdit = false;
            this.Update.Visible = true;
            this.Update.VisibleIndex = 8;
            this.Update.Width = 120;
            // 
            // fmLesson
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 783);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gridQuestion);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmLesson";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản lý đề cương";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblTeacherName;
        private System.Windows.Forms.ComboBox cbxType;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl gridQuestion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewQuestion;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ComboBox cbxSem;
        private System.Windows.Forms.ComboBox cbxGra;
        private System.Windows.Forms.ComboBox cbxSub;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn Level;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn Question;
        private DevExpress.XtraGrid.Columns.GridColumn AnsA;
        private DevExpress.XtraGrid.Columns.GridColumn AnsB;
        private DevExpress.XtraGrid.Columns.GridColumn AnsC;
        private DevExpress.XtraGrid.Columns.GridColumn AnsD;
        private DevExpress.XtraGrid.Columns.GridColumn Answer;
        private DevExpress.XtraGrid.Columns.GridColumn Update;
    }
}