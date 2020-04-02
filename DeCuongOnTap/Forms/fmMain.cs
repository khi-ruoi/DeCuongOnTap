using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeCuongOnTap.DataContext;

namespace DeCuongOnTap.Forms
{
    public partial class fmMain : RibbonForm
    {
        #region Form Initial
        fmAdmin fmAd;
        fmRegister fmReg;
        fmTeacher fmTeacher;
        fmAuthority fmAuth;
        fmLesson fmLesson;
        fmSubject fmSubject;
        fmSemester fmSem;
        fmGrade fmGrade;

        DeCuongOnTapEntities db = new DeCuongOnTapEntities();
        #endregion

        #region Variaty Init
        int ID;
        string AccName;
        string AccStatus;
        #endregion

        void fNull(RibbonForm f)
        {
            if (f != null)
                f.Close();
            f = null;
        }

        void FClosed()
        {
            fNull(fmAuth);
            fNull(fmAd);
            fNull(fmReg);
            fNull(fmTeacher);
            fNull(fmLesson);
            fNull(fmSubject);
            fNull(fmSem);
            fNull(fmGrade);

        }
        public fmMain()
        {
            InitializeComponent();
        }
        public fmMain(int id)
        {
            InitializeComponent();
            ribTeacher.Visible = false;
            ID = id;
            AccName = "Quản trị viên";
        }

        //Truy cập trình quản lý
        public fmMain(bool Status, int id)
        {
            InitializeComponent();
            ribAdmin.Visible = false;
            ribbonPageGroupLesson.Visible = Status;
            ID = id;
            if (Status) AccStatus = "Hoạt động";
            else AccStatus = "Bị khóa";
            AccName = $"Giáo viên:  {db.Teachers.Where(x => x.Id == id).Select(x => x.FullName).FirstOrDefault()}  < {AccStatus} > ";
        }

        // Đổi thông tin Admin
        private void barBtnChangeInfor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FClosed();
            fmAd = new fmAdmin();
            fmAd.MdiParent = this;
            fmAd.Show();
        }
        // Đổi thông tin Teacher
        private void barBtnEditInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FClosed();
            fmReg = new fmRegister(ID);
            fmReg.MdiParent = this;
            fmReg.Show();
        }
        // Exit button
        private void barBtnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FClosed();
            Close();
        }
        // Quản lý giáo viên
        private void barBtnManageTeacher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FClosed();
            fmTeacher = new fmTeacher();
            fmTeacher.MdiParent = this;
            fmTeacher.Show();
        }
        //Quản lý Phân quyền
        private void barBtnManageAuth_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FClosed();
            FClosed();
            fmAuth = new fmAuthority();
            fmAuth.MdiParent = this;
            fmAuth.Show();
        }
        //Quản lý chương trình học
        private void barBtnLesson_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FClosed();
            fmLesson = new fmLesson(ID);
            fmLesson.MdiParent = this;
            fmLesson.Show();
        }
        // Form start
        private void fmManager_Load(object sender, EventArgs e)
        {

        }
        // Quản lí môn học
        private void barBtnSubject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FClosed();
            fmSubject = new fmSubject();
            fmSubject.MdiParent = this;
            fmSubject.Show();
        }
        // Quản lí học kỳ
        private void barBtnSem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FClosed();
            fmSem = new fmSemester();
            fmSem.MdiParent = this;
            fmSem.Show();
        }
        // Quản lí khối
        private void barBtnGrade_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FClosed();
            fmGrade = new fmGrade();
            fmGrade.MdiParent = this;
            fmGrade.Show();
        }
        // Đóng Form quản lí
        private void fmManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            FClosed();
        }
        // Thời gian
        private void timer_Tick(object sender, EventArgs e)
        {
            string n(string s)
            {
                string v;
                if (Convert.ToInt32(s) < 10)
                {
                    v = $"0{s}";
                }
                else
                    v = s;
                return v;
            }
            var cl = DateTime.Now;
            string h = cl.Hour.ToString(); h = n(h);
            string m = cl.Minute.ToString(); m = n(m);
            string ss = cl.Second.ToString(); ss = n(ss);
            string W = cl.DayOfWeek.ToString();
            string d = cl.Day.ToString(); d = n(d);
            string M = cl.Month.ToString(); M = n(M);
            string y = cl.Year.ToString();
            lblTime.Text = $"{AccName}  ||  {h} : {m} : {ss} - {W}, {d}/{M}/{y}";
        }

        private void barBtnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
    }
}
