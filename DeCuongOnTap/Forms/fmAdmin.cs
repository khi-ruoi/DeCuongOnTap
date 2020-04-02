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
using DeCuongOnTap.Classes;

namespace DeCuongOnTap.Forms
{
    public partial class fmAdmin : RibbonForm
    {
        AutoGenData auto = new AutoGenData();
        DeCuongOnTapEntities dbb = new DeCuongOnTapEntities();
        public fmAdmin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Administrator modelAdmin = new Administrator();
            string pw = auto.EnCode(txtOldPass.Text.Trim());
            using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
            {
                var Acc = (from a in db.Administrators
                           where (a.UserName == txtUserName.Text.Trim() && a.Password == pw)
                           select new
                           {
                               a.Id,
                               a.UserName,
                               a.Password
                           }).FirstOrDefault();
                if (Acc == null)
                {
                    MessageBox.Show("Thông tin Admin không chính xác!\n\nHãy chắc chắn bạn là Admin khi thực hiện truy cập nội dung này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (txtNewPass.Text.Trim() == "")
                    {
                        modelAdmin.Password = txtOldPass.Text.Trim();
                    }
                    else if (txtReNewPass.Text.Trim() == txtNewPass.Text.Trim())
                    {
                        modelAdmin.Password = auto.EnCode(txtNewPass.Text.Trim());
                    }
                    else
                    {
                        MessageBox.Show("Nhập lại Mật khẩu mới không khớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (txtNewUserName.Text.Trim() != "")
                    {
                        modelAdmin.UserName = txtNewUserName.Text.Trim();
                    }
                    else
                    {
                        modelAdmin.UserName = txtUserName.Text.Trim();
                    }
                    modelAdmin.Id = Acc.Id;
                    
                    db.Entry(modelAdmin).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Cập nhật thành công", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
        }
    }
}
