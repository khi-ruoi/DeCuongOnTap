namespace DeCuongOnTap.Forms
{
    partial class fmSemester
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
            this.chkStatus = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.dtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtSemName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridSem = new DevExpress.XtraGrid.GridControl();
            this.gridViewSem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSemName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSem)).BeginInit();
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
            // chkStatus
            // 
            this.chkStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkStatus.Location = new System.Drawing.Point(629, 61);
            this.chkStatus.MenuManager = this.ribbonControl1;
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStatus.Properties.Appearance.Options.UseFont = true;
            this.chkStatus.Properties.Caption = "Kích hoạt";
            this.chkStatus.Size = new System.Drawing.Size(149, 23);
            this.chkStatus.TabIndex = 18;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(521, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 19);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Trạng thái";
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDel.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnDel.Appearance.Options.UseFont = true;
            this.btnDel.Appearance.Options.UseForeColor = true;
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(580, 304);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(142, 32);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "Xóa";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dtnClear
            // 
            this.dtnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtnClear.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.dtnClear.Appearance.Options.UseFont = true;
            this.dtnClear.Appearance.Options.UseForeColor = true;
            this.dtnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dtnClear.Location = new System.Drawing.Point(580, 219);
            this.dtnClear.Name = "dtnClear";
            this.dtnClear.Size = new System.Drawing.Size(142, 32);
            this.dtnClear.TabIndex = 15;
            this.dtnClear.Text = "Làm trống";
            this.dtnClear.Click += new System.EventHandler(this.dtnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.Location = new System.Drawing.Point(580, 134);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 32);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSemName
            // 
            this.txtSemName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSemName.Location = new System.Drawing.Point(330, 60);
            this.txtSemName.MenuManager = this.ribbonControl1;
            this.txtSemName.Name = "txtSemName";
            this.txtSemName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemName.Properties.Appearance.Options.UseFont = true;
            this.txtSemName.Size = new System.Drawing.Size(149, 26);
            this.txtSemName.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(222, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 19);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Tên Học kỳ";
            // 
            // gridSem
            // 
            this.gridSem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gridSem.Location = new System.Drawing.Point(222, 98);
            this.gridSem.MainView = this.gridViewSem;
            this.gridSem.MenuManager = this.ribbonControl1;
            this.gridSem.Name = "gridSem";
            this.gridSem.Size = new System.Drawing.Size(318, 440);
            this.gridSem.TabIndex = 11;
            this.gridSem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSem});
            // 
            // gridViewSem
            // 
            this.gridViewSem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.Id,
            this.SemName,
            this.Status});
            this.gridViewSem.GridControl = this.gridSem;
            this.gridViewSem.Name = "gridViewSem";
            this.gridViewSem.Click += new System.EventHandler(this.gridViewSem_Click);
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
            this.STT.VisibleIndex = 0;
            this.STT.Width = 30;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.OptionsColumn.AllowEdit = false;
            // 
            // SemName
            // 
            this.SemName.AppearanceHeader.Options.UseTextOptions = true;
            this.SemName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SemName.Caption = "Tên học kỳ";
            this.SemName.FieldName = "SemName";
            this.SemName.MaxWidth = 200;
            this.SemName.MinWidth = 200;
            this.SemName.Name = "SemName";
            this.SemName.OptionsColumn.AllowEdit = false;
            this.SemName.Visible = true;
            this.SemName.VisibleIndex = 1;
            this.SemName.Width = 200;
            // 
            // Status
            // 
            this.Status.AppearanceCell.Options.UseTextOptions = true;
            this.Status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Status.AppearanceHeader.Options.UseTextOptions = true;
            this.Status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Status.Caption = "Status";
            this.Status.FieldName = "Status";
            this.Status.Name = "Status";
            this.Status.OptionsColumn.AllowEdit = false;
            this.Status.Visible = true;
            this.Status.VisibleIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(337, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "QUẢN LÝ HỌC KỲ";
            // 
            // fmSemester
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.dtnClear;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.dtnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSemName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridSem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmSemester";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản lý học kỳ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmSemester_FormClosed);
            this.Load += new System.EventHandler(this.fmSemester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSemName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraEditors.CheckEdit chkStatus;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton dtnClear;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtSemName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridSem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSem;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn SemName;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private System.Windows.Forms.Label label1;
    }
}