using DevExpress.XtraBars.Ribbon;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DeCuongOnTap.Forms;
using DeCuongOnTap.DataContext;
using DeCuongOnTap.Classes;

namespace DeCuongOnTap
{
    public partial class Login : RibbonForm
    {
        AutoGenData auto = new AutoGenData();

        string pw;

        void LogAdmin()
        {
            try
            {
                using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
                {
                    var A = (from a in db.Administrators
                             where a.UserName == txtUserName.Text && a.Password == pw
                             select new { a.Id }).FirstOrDefault();
                    if (A != null)
                    {
                        fmMain f = new fmMain(A.Id);
                        Hide();
                        f.ShowDialog();
                        Show();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không hợp lệ!\n\nKiểm tra lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        void LogTeacher()
        {
            try
            {
                using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
                {
                    var A = (from a in db.Teachers
                             where a.UserName == txtUserName.Text && a.Password == pw
                             select new { a.Id, a.Status }).FirstOrDefault();
                    if (A != null)
                    {
                        fmMain f = new fmMain((bool)A.Status,A.Id);
                        Hide();
                        f.ShowDialog();
                        Show();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không hợp lệ!\n\nKiểm tra lại hoặc liên hệ Quản trị viên để được tạo tài khoản.\n\nMật khẩu có phân biệt HOA - thường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                pw = auto.EnCode(txtPassword.Text);
                if (tgType.IsOn)
                {
                    LogAdmin();
                }
                else
                {
                    LogTeacher();
                }
            }
        }

    }
}
