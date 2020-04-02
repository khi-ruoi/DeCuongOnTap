namespace DeCuongOnTap.Forms
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.barBtnManageTeacher = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnManageAuth = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnChangeInfor = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEditInfo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnLesson = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnExport = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSubject = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSem = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGrade = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnExit = new DevExpress.XtraBars.BarButtonItem();
            this.ribAdmin = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupStalf = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupProgram = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribTeacher = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupLesson = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupChoose = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barBtnManageProrgam = new DevExpress.XtraBars.BarButtonItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AllowMdiChildButtons = false;
            this.ribbonControl1.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbonControl1.AutoHideEmptyItems = true;
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Purple;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barBtnManageTeacher,
            this.barBtnManageAuth,
            this.barBtnChangeInfor,
            this.barBtnEditInfo,
            this.barBtnLesson,
            this.barBtnExport,
            this.barBtnLogout,
            this.barBtnSubject,
            this.barBtnSem,
            this.barBtnGrade,
            this.barBtnExit});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribAdmin,
            this.ribTeacher});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(998, 157);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbonControl1;
            // 
            // barBtnManageTeacher
            // 
            this.barBtnManageTeacher.Caption = "Giáo viên";
            this.barBtnManageTeacher.Id = 1;
            this.barBtnManageTeacher.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnManageTeacher.ImageOptions.Image")));
            this.barBtnManageTeacher.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnManageTeacher.ImageOptions.LargeImage")));
            this.barBtnManageTeacher.LargeWidth = 100;
            this.barBtnManageTeacher.Name = "barBtnManageTeacher";
            this.barBtnManageTeacher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnManageTeacher_ItemClick);
            // 
            // barBtnManageAuth
            // 
            this.barBtnManageAuth.Caption = "Phân quyền";
            this.barBtnManageAuth.Id = 2;
            this.barBtnManageAuth.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnManageAuth.ImageOptions.Image")));
            this.barBtnManageAuth.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnManageAuth.ImageOptions.LargeImage")));
            this.barBtnManageAuth.LargeWidth = 100;
            this.barBtnManageAuth.Name = "barBtnManageAuth";
            this.barBtnManageAuth.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnManageAuth_ItemClick);
            // 
            // barBtnChangeInfor
            // 
            this.barBtnChangeInfor.Caption = "Admin";
            this.barBtnChangeInfor.Id = 6;
            this.barBtnChangeInfor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnChangeInfor.ImageOptions.Image")));
            this.barBtnChangeInfor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnChangeInfor.ImageOptions.LargeImage")));
            this.barBtnChangeInfor.LargeWidth = 100;
            this.barBtnChangeInfor.Name = "barBtnChangeInfor";
            this.barBtnChangeInfor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnChangeInfor_ItemClick);
            // 
            // barBtnEditInfo
            // 
            this.barBtnEditInfo.Caption = "Thông tin cá nhân";
            this.barBtnEditInfo.Id = 8;
            this.barBtnEditInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnEditInfo.ImageOptions.Image")));
            this.barBtnEditInfo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnEditInfo.ImageOptions.LargeImage")));
            this.barBtnEditInfo.LargeWidth = 100;
            this.barBtnEditInfo.Name = "barBtnEditInfo";
            this.barBtnEditInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEditInfo_ItemClick);
            // 
            // barBtnLesson
            // 
            this.barBtnLesson.Caption = "Quản lý đề cương";
            this.barBtnLesson.Id = 9;
            this.barBtnLesson.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnLesson.ImageOptions.Image")));
            this.barBtnLesson.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnLesson.ImageOptions.LargeImage")));
            this.barBtnLesson.LargeWidth = 100;
            this.barBtnLesson.Name = "barBtnLesson";
            this.barBtnLesson.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLesson_ItemClick);
            // 
            // barBtnExport
            // 
            this.barBtnExport.Caption = "Xuất đề cương";
            this.barBtnExport.Id = 10;
            this.barBtnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnExport.ImageOptions.Image")));
            this.barBtnExport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnExport.ImageOptions.LargeImage")));
            this.barBtnExport.LargeWidth = 100;
            this.barBtnExport.Name = "barBtnExport";
            // 
            // barBtnLogout
            // 
            this.barBtnLogout.Caption = "Đăng xuất";
            this.barBtnLogout.Id = 12;
            this.barBtnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnLogout.ImageOptions.Image")));
            this.barBtnLogout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnLogout.ImageOptions.LargeImage")));
            this.barBtnLogout.LargeWidth = 100;
            this.barBtnLogout.Name = "barBtnLogout";
            this.barBtnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLogout_ItemClick);
            // 
            // barBtnSubject
            // 
            this.barBtnSubject.Caption = "Môn học";
            this.barBtnSubject.Id = 13;
            this.barBtnSubject.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSubject.ImageOptions.Image")));
            this.barBtnSubject.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSubject.ImageOptions.LargeImage")));
            this.barBtnSubject.LargeWidth = 100;
            this.barBtnSubject.Name = "barBtnSubject";
            this.barBtnSubject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSubject_ItemClick);
            // 
            // barBtnSem
            // 
            this.barBtnSem.Caption = "Học kỳ";
            this.barBtnSem.Id = 14;
            this.barBtnSem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSem.ImageOptions.Image")));
            this.barBtnSem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSem.ImageOptions.LargeImage")));
            this.barBtnSem.LargeWidth = 100;
            this.barBtnSem.Name = "barBtnSem";
            this.barBtnSem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSem_ItemClick);
            // 
            // barBtnGrade
            // 
            this.barBtnGrade.Caption = "Khối lớp";
            this.barBtnGrade.Id = 15;
            this.barBtnGrade.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnGrade.ImageOptions.Image")));
            this.barBtnGrade.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnGrade.ImageOptions.LargeImage")));
            this.barBtnGrade.LargeWidth = 100;
            this.barBtnGrade.Name = "barBtnGrade";
            this.barBtnGrade.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGrade_ItemClick);
            // 
            // barBtnExit
            // 
            this.barBtnExit.Caption = "Thoát";
            this.barBtnExit.Id = 4;
            this.barBtnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnExit.ImageOptions.SvgImage")));
            this.barBtnExit.LargeWidth = 100;
            this.barBtnExit.Name = "barBtnExit";
            this.barBtnExit.SmallWithTextWidth = 100;
            this.barBtnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnExit_ItemClick);
            // 
            // ribAdmin
            // 
            this.ribAdmin.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupStalf,
            this.ribbonPageGroupProgram});
            this.ribAdmin.Name = "ribAdmin";
            this.ribAdmin.Text = "Quản trị viên";
            // 
            // ribbonPageGroupStalf
            // 
            this.ribbonPageGroupStalf.ItemLinks.Add(this.barBtnChangeInfor);
            this.ribbonPageGroupStalf.ItemLinks.Add(this.barBtnManageTeacher);
            this.ribbonPageGroupStalf.ItemLinks.Add(this.barBtnManageAuth);
            this.ribbonPageGroupStalf.Name = "ribbonPageGroupStalf";
            this.ribbonPageGroupStalf.ShowCaptionButton = false;
            this.ribbonPageGroupStalf.Text = "Nhân sự";
            // 
            // ribbonPageGroupProgram
            // 
            this.ribbonPageGroupProgram.ItemLinks.Add(this.barBtnSem);
            this.ribbonPageGroupProgram.ItemLinks.Add(this.barBtnGrade);
            this.ribbonPageGroupProgram.ItemLinks.Add(this.barBtnSubject);
            this.ribbonPageGroupProgram.Name = "ribbonPageGroupProgram";
            this.ribbonPageGroupProgram.ShowCaptionButton = false;
            this.ribbonPageGroupProgram.Text = "Chương trình học";
            // 
            // ribTeacher
            // 
            this.ribTeacher.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupLesson,
            this.ribbonPageGroupChoose});
            this.ribTeacher.Name = "ribTeacher";
            this.ribTeacher.Text = "Giáo viên";
            // 
            // ribbonPageGroupLesson
            // 
            this.ribbonPageGroupLesson.ItemLinks.Add(this.barBtnLesson);
            this.ribbonPageGroupLesson.ItemLinks.Add(this.barBtnExport);
            this.ribbonPageGroupLesson.Name = "ribbonPageGroupLesson";
            this.ribbonPageGroupLesson.ShowCaptionButton = false;
            this.ribbonPageGroupLesson.Text = "Đề cương";
            // 
            // ribbonPageGroupChoose
            // 
            this.ribbonPageGroupChoose.ItemLinks.Add(this.barBtnEditInfo);
            this.ribbonPageGroupChoose.ItemLinks.Add(this.barBtnLogout);
            this.ribbonPageGroupChoose.ItemLinks.Add(this.barBtnExit);
            this.ribbonPageGroupChoose.Name = "ribbonPageGroupChoose";
            this.ribbonPageGroupChoose.ShowCaptionButton = false;
            this.ribbonPageGroupChoose.Text = "Chức năng";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // barBtnManageProrgam
            // 
            this.barBtnManageProrgam.Caption = "Chương trình học";
            this.barBtnManageProrgam.Id = 4;
            this.barBtnManageProrgam.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnManageProrgam.ImageOptions.Image")));
            this.barBtnManageProrgam.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnManageProrgam.ImageOptions.LargeImage")));
            this.barBtnManageProrgam.LargeWidth = 100;
            this.barBtnManageProrgam.Name = "barBtnManageProrgam";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTime
            // 
            this.lblTime.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTime.Appearance.Options.UseBackColor = true;
            this.lblTime.Appearance.Options.UseFont = true;
            this.lblTime.Appearance.Options.UseForeColor = true;
            this.lblTime.Appearance.Options.UseTextOptions = true;
            this.lblTime.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTime.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTime.Location = new System.Drawing.Point(0, 157);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(998, 25);
            this.lblTime.TabIndex = 19;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(998, 699);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "fmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đề Cương Ôn Tập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmManager_FormClosed);
            this.Load += new System.EventHandler(this.fmManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribAdmin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupStalf;
        private DevExpress.XtraBars.BarButtonItem barBtnManageTeacher;
        private DevExpress.XtraBars.BarButtonItem barBtnManageAuth;
        private DevExpress.XtraBars.BarButtonItem barBtnChangeInfor;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupProgram;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribTeacher;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupChoose;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarButtonItem barBtnEditInfo;
        private DevExpress.XtraBars.BarButtonItem barBtnLesson;
        private DevExpress.XtraBars.BarButtonItem barBtnExport;
        private DevExpress.XtraBars.BarButtonItem barBtnLogout;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupLesson;
        private DevExpress.XtraBars.BarButtonItem barBtnSubject;
        private DevExpress.XtraBars.BarButtonItem barBtnSem;
        private DevExpress.XtraBars.BarButtonItem barBtnGrade;
        private DevExpress.XtraBars.BarButtonItem barBtnManageProrgam;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraEditors.LabelControl lblTime;
        private DevExpress.XtraBars.BarButtonItem barBtnExit;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
    }
}