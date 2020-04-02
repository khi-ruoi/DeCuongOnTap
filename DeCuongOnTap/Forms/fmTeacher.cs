using DevExpress.XtraBars.Ribbon;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DeCuongOnTap.DataContext;
using System.Data.Entity;
using DeCuongOnTap.Classes;

namespace DeCuongOnTap.Forms
{
    public partial class fmTeacher : RibbonForm
    {
        AutoGenData auto = new AutoGenData();
        clGenOrder Gen = new clGenOrder();
        clKeyEvent Key = new clKeyEvent();
        Teacher modelTeacher = new Teacher();

        clKeyEvent AllowKey = new clKeyEvent();

        int ID_Teacher = 0;


        void AddInfo()
        {
            string FullName = auto.ChuanHoa(txtFullName.Text.Trim());
            string UserName = txtUserName.Text.Trim();
            string Password = txtPassword.Text.Trim();
            string DOB = dtDOB.Text;

            bool bl = chkStatus.Checked;

            modelTeacher.Id = ID_Teacher;

            if (FullName == "" || UserName == "" || Password == "")
            {
                MessageBox.Show("Thông tin còn thiếu.\n\nNhập đủ thông tin trước khi tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            modelTeacher.DOB = DOB;
            modelTeacher.FullName = FullName;
            modelTeacher.UserName = UserName;
            modelTeacher.Password = auto.EnCode(Password);
            modelTeacher.Status = bl;

            using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
            {
                // Nếu chưa có thì thêm mới
                if (ID_Teacher == 0)
                {
                    db.Teachers.Add(modelTeacher);
                    db.SaveChanges();
                    MessageBox.Show("Thêm mới Giáo viên thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Ngược lại sửa Record hiện tại
                else
                {
                    modelTeacher.Authorities = null;
                    db.Entry(modelTeacher).State = EntityState.Modified;
                db.SaveChanges();
                    MessageBox.Show("Cập nhật thông tin Giáo viên thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ClearInfo();
                BindingTeacherDGRView();
            }
        }
        void ClearInfo()
        {
            txtFullName.Text = txtPassword.Text = txtUserName.Text = "";
            ID_Teacher = 0;
            btnAdd.Text = "Create";
            btnDel.Enabled = false;
        }
        void DelInfo()
        {
            if (ID_Teacher >0)
            {
                if (MessageBox.Show("Có chắc chắn muốn xóa thông tin của Giáo viên này không", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
                    {
                        // Xóa VS khỏi CLB
                        var entry = db.Entry(modelTeacher);
                        if (entry.State == EntityState.Detached)
                            db.Teachers.Attach(modelTeacher);
                        db.Teachers.Remove(modelTeacher);
                        db.SaveChanges();

                        MessageBox.Show("Xóa Giáo viên thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ClearInfo();
                    BindingTeacherDGRView();
                }

            }
        }

        void BindingTeacherDGRView()
        {
            using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
            {
                //int idC = db.Teachers.Where(x => x.CLBFullName == cbxClubStu.Text).Select(x => x.Id_CLB).FirstOrDefault();
                var T = (from t in db.Teachers

                         select new
                         {
                             t.Id,
                             t.UserName,
                             t.Password,
                             t.FullName,
                             t.DOB,
                             t.Status
                         }
                         ).ToList();
                gridTeacher.DataSource = T;
            }
        }
        void GetInfoFromGridview()
        {
            var gv = gridViewTeacher;
            int index = gv.FocusedRowHandle;

            if (index > -1)
            {
                btnDel.Enabled = true;
                btnAdd.Text = "Update";
                btnDel.Enabled = true;

                ID_Teacher = Convert.ToInt32(auto.GenData(gv,"Id"));
                modelTeacher.Id = ID_Teacher;

                using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
                {
                    var T = (from t in db.Teachers

                             where t.Id == ID_Teacher
                             select new
                             {
                                 t.Id,
                                 t.DOB,
                                 t.FullName,
                                 t.Password,
                                 t.Status,
                                 t.UserName
                             }).FirstOrDefault();

                    txtUserName.Text = T.UserName;
                    txtPassword.Text = auto.Decode(T.Password);
                    txtFullName.Text = T.FullName;

                    bool ck = Convert.ToBoolean(T.Status);
                    chkStatus.Checked = ck;

                    dtDOB.Text = T.DOB;
                }

            }

        }

        public fmTeacher()
        {
            InitializeComponent();
            Gen.GenOrder(gridViewTeacher);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fmManageTeacher_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void fmManageTeacher_Load(object sender, EventArgs e)
        {
            BindingTeacherDGRView();
        }

        private void gridViewTeacher_Click(object sender, EventArgs e)
        {
            GetInfoFromGridview();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddInfo();
            }
            catch 
            {
                MessageBox.Show("Tên tài khoản bị trùng!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInfo();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DelInfo();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowKey.AllowKey(e);
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Key.AllowKey(e);
        }
    }
}
