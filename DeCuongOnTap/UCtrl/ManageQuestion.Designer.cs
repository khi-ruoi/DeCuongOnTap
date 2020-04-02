namespace DeCuongOnTap.UCtrl
{
    partial class ManageQuestion
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
            this.pnEssay = new System.Windows.Forms.Panel();
            this.txtAnswer = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.radD = new System.Windows.Forms.RadioButton();
            this.radB = new System.Windows.Forms.RadioButton();
            this.radC = new System.Windows.Forms.RadioButton();
            this.pnMulti = new System.Windows.Forms.Panel();
            this.radA = new System.Windows.Forms.RadioButton();
            this.txtAnsA = new DevExpress.XtraEditors.MemoEdit();
            this.txtAnsB = new DevExpress.XtraEditors.MemoEdit();
            this.txtAnsC = new DevExpress.XtraEditors.MemoEdit();
            this.txtAnsD = new DevExpress.XtraEditors.MemoEdit();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuestion = new DevExpress.XtraEditors.MemoEdit();
            this.lblInfo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbxLevel = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQLevel = new DevExpress.XtraEditors.LabelControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.pnEssay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnswer.Properties)).BeginInit();
            this.pnMulti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnsA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnsB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnsC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnsD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestion.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnEssay
            // 
            this.pnEssay.Controls.Add(this.txtAnswer);
            this.pnEssay.Controls.Add(this.labelControl8);
            this.pnEssay.Location = new System.Drawing.Point(29, 271);
            this.pnEssay.Name = "pnEssay";
            this.pnEssay.Size = new System.Drawing.Size(848, 245);
            this.pnEssay.TabIndex = 63;
            this.pnEssay.Visible = false;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(77, 1);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAnswer.Properties.Appearance.Options.UseFont = true;
            this.txtAnswer.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAnswer.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtAnswer.Size = new System.Drawing.Size(771, 241);
            this.txtAnswer.TabIndex = 0;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(7, 113);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(46, 19);
            this.labelControl8.TabIndex = 47;
            this.labelControl8.Text = "Trả lời";
            // 
            // radD
            // 
            this.radD.AutoSize = true;
            this.radD.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radD.Location = new System.Drawing.Point(604, 144);
            this.radD.Name = "radD";
            this.radD.Size = new System.Drawing.Size(115, 27);
            this.radD.TabIndex = 7;
            this.radD.TabStop = true;
            this.radD.Text = "Đáp án D";
            this.radD.UseVisualStyleBackColor = true;
            // 
            // radB
            // 
            this.radB.AutoSize = true;
            this.radB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radB.Location = new System.Drawing.Point(604, 33);
            this.radB.Name = "radB";
            this.radB.Size = new System.Drawing.Size(114, 27);
            this.radB.TabIndex = 5;
            this.radB.TabStop = true;
            this.radB.Text = "Đáp án B";
            this.radB.UseVisualStyleBackColor = true;
            // 
            // radC
            // 
            this.radC.AutoSize = true;
            this.radC.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radC.Location = new System.Drawing.Point(142, 144);
            this.radC.Name = "radC";
            this.radC.Size = new System.Drawing.Size(114, 27);
            this.radC.TabIndex = 6;
            this.radC.TabStop = true;
            this.radC.Text = "Đáp án C";
            this.radC.UseVisualStyleBackColor = true;
            // 
            // pnMulti
            // 
            this.pnMulti.Controls.Add(this.radD);
            this.pnMulti.Controls.Add(this.radB);
            this.pnMulti.Controls.Add(this.radC);
            this.pnMulti.Controls.Add(this.radA);
            this.pnMulti.Controls.Add(this.txtAnsA);
            this.pnMulti.Controls.Add(this.txtAnsB);
            this.pnMulti.Controls.Add(this.txtAnsC);
            this.pnMulti.Controls.Add(this.txtAnsD);
            this.pnMulti.Location = new System.Drawing.Point(29, 246);
            this.pnMulti.Name = "pnMulti";
            this.pnMulti.Size = new System.Drawing.Size(887, 293);
            this.pnMulti.TabIndex = 62;
            this.pnMulti.Visible = false;
            // 
            // radA
            // 
            this.radA.AutoSize = true;
            this.radA.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radA.Location = new System.Drawing.Point(142, 33);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(114, 27);
            this.radA.TabIndex = 4;
            this.radA.TabStop = true;
            this.radA.Text = "Đáp án A";
            this.radA.UseVisualStyleBackColor = true;
            // 
            // txtAnsA
            // 
            this.txtAnsA.Location = new System.Drawing.Point(38, 66);
            this.txtAnsA.Name = "txtAnsA";
            this.txtAnsA.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAnsA.Properties.Appearance.Options.UseFont = true;
            this.txtAnsA.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAnsA.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtAnsA.Size = new System.Drawing.Size(353, 72);
            this.txtAnsA.TabIndex = 0;
            // 
            // txtAnsB
            // 
            this.txtAnsB.Location = new System.Drawing.Point(495, 66);
            this.txtAnsB.Name = "txtAnsB";
            this.txtAnsB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAnsB.Properties.Appearance.Options.UseFont = true;
            this.txtAnsB.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAnsB.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtAnsB.Size = new System.Drawing.Size(353, 72);
            this.txtAnsB.TabIndex = 1;
            // 
            // txtAnsC
            // 
            this.txtAnsC.Location = new System.Drawing.Point(38, 177);
            this.txtAnsC.Name = "txtAnsC";
            this.txtAnsC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAnsC.Properties.Appearance.Options.UseFont = true;
            this.txtAnsC.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAnsC.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtAnsC.Size = new System.Drawing.Size(353, 72);
            this.txtAnsC.TabIndex = 2;
            // 
            // txtAnsD
            // 
            this.txtAnsD.Location = new System.Drawing.Point(495, 177);
            this.txtAnsD.Name = "txtAnsD";
            this.txtAnsD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAnsD.Properties.Appearance.Options.UseFont = true;
            this.txtAnsD.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAnsD.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtAnsD.Size = new System.Drawing.Size(353, 72);
            this.txtAnsD.TabIndex = 3;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btnDel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnDel.Appearance.Options.UseFont = true;
            this.btnDel.Appearance.Options.UseForeColor = true;
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(791, 38);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(120, 40);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Xóa";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(34, 146);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 19);
            this.labelControl1.TabIndex = 58;
            this.labelControl1.Text = "Câu hỏi";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(106, 144);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtQuestion.Properties.Appearance.Options.UseFont = true;
            this.txtQuestion.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuestion.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtQuestion.Size = new System.Drawing.Size(771, 21);
            this.txtQuestion.TabIndex = 2;
            this.txtQuestion.TextChanged += new System.EventHandler(this.txtQuestion_TextChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Appearance.Options.UseFont = true;
            this.lblInfo.Appearance.Options.UseTextOptions = true;
            this.lblInfo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblInfo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(925, 32);
            this.lblInfo.TabIndex = 54;
            this.lblInfo.Text = "<Học kỳ>";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(18, 52);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(96, 19);
            this.labelControl5.TabIndex = 52;
            this.labelControl5.Text = "Loại câu hỏi: ";
            // 
            // cbxLevel
            // 
            this.cbxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLevel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbxLevel.FormattingEnabled = true;
            this.cbxLevel.Items.AddRange(new object[] {
            "Mức 1",
            "Mức 2",
            "Mức 3"});
            this.cbxLevel.Location = new System.Drawing.Point(364, 49);
            this.cbxLevel.Name = "cbxLevel";
            this.cbxLevel.Size = new System.Drawing.Size(115, 27);
            this.cbxLevel.TabIndex = 1;
            this.cbxLevel.SelectedIndexChanged += new System.EventHandler(this.cbxLevel_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(267, 52);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(91, 19);
            this.labelControl4.TabIndex = 50;
            this.labelControl4.Text = "Mức câu hỏi:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(641, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Lưu";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Trắc nghiệm",
            "Tự luận"});
            this.cbxType.Location = new System.Drawing.Point(120, 49);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(115, 27);
            this.cbxType.TabIndex = 0;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblQLevel);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.cbxType);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.cbxLevel);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Location = new System.Drawing.Point(4, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 93);
            this.panel1.TabIndex = 64;
            // 
            // lblQLevel
            // 
            this.lblQLevel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblQLevel.Appearance.Options.UseFont = true;
            this.lblQLevel.Location = new System.Drawing.Point(527, 52);
            this.lblQLevel.Name = "lblQLevel";
            this.lblQLevel.Size = new System.Drawing.Size(60, 19);
            this.lblQLevel.TabIndex = 62;
            this.lblQLevel.Text = "<Level>";
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
            this.ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(929, 61);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // ManageQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(929, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnEssay);
            this.Controls.Add(this.pnMulti);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageQuestion";
            this.Ribbon = this.ribbonControl1;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CẬP NHẬT  CÂU HỎI";
            this.pnEssay.ResumeLayout(false);
            this.pnEssay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnswer.Properties)).EndInit();
            this.pnMulti.ResumeLayout(false);
            this.pnMulti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnsA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnsB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnsC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnsD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestion.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnEssay;
        private DevExpress.XtraEditors.MemoEdit txtAnswer;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.RadioButton radD;
        private System.Windows.Forms.RadioButton radB;
        private System.Windows.Forms.RadioButton radC;
        private System.Windows.Forms.Panel pnMulti;
        private System.Windows.Forms.RadioButton radA;
        private DevExpress.XtraEditors.MemoEdit txtAnsA;
        private DevExpress.XtraEditors.MemoEdit txtAnsB;
        private DevExpress.XtraEditors.MemoEdit txtAnsC;
        private DevExpress.XtraEditors.MemoEdit txtAnsD;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtQuestion;
        private DevExpress.XtraEditors.LabelControl lblInfo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cbxLevel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblQLevel;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    }
}