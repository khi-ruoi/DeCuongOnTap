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
using System.Data.Entity;
using DeCuongOnTap.Classes;

namespace DeCuongOnTap.Forms
{
    public partial class fmRegister : RibbonForm
    {
        // Khai báo biến
        int ID;
        string UserName, PassWord, FullName, DOB;
        bool Status;

        clKeyEvent Key = new clKeyEvent();
        AutoGenData auto = new AutoGenData();
        // Lấy thông tin Giáo viên
        void GetTeacherInfo()
        {
            using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
            {
                var T = (from t in db.Teachers
                         where t.Id == ID
                         select new
                         {
                             t.UserName,
                             t.Password,
                             t.FullName,
                             t.DOB,
                             t.Status
                         }).FirstOrDefault();
                txtUserName.Text = UserName = T.UserName;
                PassWord = T.Password;
                txtFullName.Text = FullName = T.FullName;
                dtDOB.Text = DOB = T.DOB;
                Status = (bool)T.Status;
            }
        }
        // Cập nhật thông tin Giáo viên
        void UpdateTeacher()
        {
            if (txtPassword.Text != PassWord || txtRePassword.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu xác nhận không chính xác hoặc Mật khẩu mới không hợp lệ.\n\nMật khẩu là chuổi ký tự gồm 'a-z' 'A-Z' '0-9'", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Teacher model = new Teacher();
            model.Id = ID;
            model.Password = txtRePassword.Text.Trim();
            model.UserName = UserName;
            model.FullName = auto.ChuanHoa(txtFullName.Text.Trim());
            model.DOB = dtDOB.Text;
            model.Status = Status;

            model.Authorities = null;

            DeCuongOnTapEntities db = new DeCuongOnTapEntities();
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();

            GetTeacherInfo();

            MessageBox.Show("Cập nhật thông tin thành công!\n\nNếu gặp vấn đề về Mật khẩu hay quyền quản lý đề cương hãy liên hệ với Quản trị viên!\n\n* Lưu ý: Thông tin đăng ký là riêng tư, không được chia sẽ dưới mọi hình thức nhằm tránh khỏi dữ liệu gặp rủi ro.", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public fmRegister()
        {
            InitializeComponent();
        }
        // Khởi tạo Form
        public fmRegister(int id)
        {
            InitializeComponent();
            ID = id;
            GetTeacherInfo();
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key.AllowKey(e);
        }

        // Nút thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Nút Cập nhật
        private void btnReg_Click(object sender, EventArgs e)
        {
            UpdateTeacher();
        }
        // Đóng Form
        private void fmRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
