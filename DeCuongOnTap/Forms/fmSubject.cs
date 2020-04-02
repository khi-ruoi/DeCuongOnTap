using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using DeCuongOnTap.DataContext;
using DevExpress.XtraBars.Ribbon;
using DeCuongOnTap.Classes;

namespace DeCuongOnTap.Forms
{
    public partial class fmSubject : RibbonForm
    {
        AutoGenData auto = new AutoGenData();
        clGenOrder Gen = new clGenOrder();
        int ID = 0;

        Subject modelSubject = new Subject();


        void BindingSubjectDGRView()
        {
            using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
            {
                //int idC = db.Subjects.Where(x => x.CLBFullName == cbxClubStu.Text).Select(x => x.Id_CLB).FirstOrDefault();
                var S = (from s in db.Subjects

                         select new
                         {
                             s.Id,
                             s.Status,
                             s.SubjectName
                         }
                         ).ToList();
                gridSubject.DataSource = S;
            }
        }
        void GetInfoFromGridview()
        {
            var gv = gridViewSubject;
            int index = gv.FocusedRowHandle;

            if (index > -1)
            {
                btnDel.Enabled = true;
                btnAdd.Text = "Update";
                btnDel.Enabled = true;

                ID = Convert.ToInt32(auto.GenData(gv, "Id"));
                modelSubject.Id = ID;

                using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
                {
                    var S = (from s in db.Subjects

                             where s.Id == ID
                             select new
                             {
                                 s.Id,
                                 s.Status,
                                 s.SubjectName
                             }).FirstOrDefault();

                    txtSubjectName.Text = S.SubjectName;

                    bool ck = Convert.ToBoolean(S.Status);
                    chkStatus.Checked = ck;

                }

            }

        }
        void AddInfo()
        {
            string SubjectName = txtSubjectName.Text.Trim();

            bool bl = chkStatus.Checked;

            modelSubject.Id = ID;

            if (SubjectName == "")
            {
                MessageBox.Show("Tên môn học không được để trống.\n\nNhập tên môn học hợp lệ trước khi tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            modelSubject.SubjectName = SubjectName;
            modelSubject.Status = bl;

            using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
            {
                // Nếu chưa có thì thêm mới
                if (ID == 0)
                {
                    db.Subjects.Add(modelSubject);
                    db.SaveChanges();
                    MessageBox.Show("Thêm mới Môn học thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Ngược lại sửa Record hiện tại
                else
                {
                    modelSubject.Authorities = null;
                    db.Entry(modelSubject).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Cập nhật Môn học thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ClearInfo();
                BindingSubjectDGRView();
            }
        }
        void ClearInfo()
        {
            txtSubjectName.Text = "";
            ID = 0;
            btnAdd.Text = "Create";
            btnDel.Enabled = false;
        }
        void DelInfo()
        {
            if (ID > 0)
            {
                if (MessageBox.Show("Có chắc chắn muốn xóa Môn học này không", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
                    {
                        // Xóa VS khỏi CLB
                        var entry = db.Entry(modelSubject);
                        if (entry.State == EntityState.Detached)
                            db.Subjects.Attach(modelSubject);
                        db.Subjects.Remove(modelSubject);
                        db.SaveChanges();

                        MessageBox.Show("Xóa Môn học thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ClearInfo();
                    BindingSubjectDGRView();
                }

            }
        }


        public fmSubject()
        {
            InitializeComponent();
            Gen.GenOrder(gridViewSubject);
        }

        private void fmManageSubject_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void fmManageSubject_Load(object sender, EventArgs e)
        {
            BindingSubjectDGRView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddInfo();
            }
            catch
            {
                MessageBox.Show("Tên môn học bị trùng!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void dtnClear_Click(object sender, EventArgs e)
        {
            ClearInfo();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DelInfo();
        }

        private void gridViewSubject_Click(object sender, EventArgs e)
        {
            GetInfoFromGridview();
        }
    }
}
