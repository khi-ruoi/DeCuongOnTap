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
    public partial class fmSemester : RibbonForm
    {
        AutoGenData auto = new AutoGenData();
        clGenOrder Gen = new clGenOrder();
        int ID = 0;

        Semester modelSem = new Semester();


        void BindingSemesterDGRView()
        {
            using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
            {
                //int idC = db.Subjects.Where(x => x.CLBFullName == cbxClubStu.Text).Select(x => x.Id_CLB).FirstOrDefault();
                var S = (from s in db.Semesters

                         select new
                         {
                             s.Id,
                             s.Status,
                             s.SemName
                         }
                         ).ToList();
                gridSem.DataSource = S;
            }
        }
        void GetInfoFromGridview()
        {
            var gv = gridViewSem;
            int index = gv.FocusedRowHandle;

            if (index > -1)
            {
                btnDel.Enabled = true;
                btnAdd.Text = "Update";
                btnDel.Enabled = true;

                ID = Convert.ToInt32(auto.GenData(gv, "Id"));
                modelSem.Id = ID;

                using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
                {
                    var S = (from s in db.Semesters

                             where s.Id == ID
                             select new
                             {
                                 s.Id,
                                 s.Status,
                                 s.SemName
                             }).FirstOrDefault();

                    txtSemName.Text = S.SemName;

                    bool ck = Convert.ToBoolean(S.Status);
                    chkStatus.Checked = ck;

                }

            }

        }
        void AddInfo()
        {
            string SubjectName = txtSemName.Text.Trim();

            bool bl = chkStatus.Checked;

            modelSem.Id = ID;

            if (SubjectName == "")
            {
                MessageBox.Show("Tên Học kỳ không được để trống.\n\nNhập tên Học kỳ hợp lệ trước khi tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            modelSem.SemName = SubjectName;
            modelSem.Status = bl;

            using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
            {
                // Nếu chưa có thì thêm mới
                if (ID == 0)
                {
                    db.Semesters.Add(modelSem);
                    db.SaveChanges();
                    MessageBox.Show("Thêm mới Học kỳ thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Ngược lại sửa Record hiện tại
                else
                {
                    modelSem.Authorities = null;
                    db.Entry(modelSem).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Cập nhật Học kỳ thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ClearInfo();
                BindingSemesterDGRView();
            }
        }
        void ClearInfo()
        {
            txtSemName.Text = "";
            ID = 0;
            btnAdd.Text = "Create";
            btnDel.Enabled = false;
        }
        void DelInfo()
        {
            if (ID > 0)
            {
                if (MessageBox.Show("Có chắc chắn muốn xóa Học kỳ này không", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
                    {
                        // Xóa VS khỏi CLB
                        var entry = db.Entry(modelSem);
                        if (entry.State == EntityState.Detached)
                            db.Semesters.Attach(modelSem);
                        db.Semesters.Remove(modelSem);
                        db.SaveChanges();

                        MessageBox.Show("Xóa Học kỳ thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ClearInfo();
                    BindingSemesterDGRView();
                }

            }
        }

        public fmSemester()
        {
            InitializeComponent();
            Gen.GenOrder(gridViewSem);
        }

        private void fmSemester_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void fmSemester_Load(object sender, EventArgs e)
        {
            BindingSemesterDGRView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddInfo();
            }
            catch
            {
                MessageBox.Show("Tên học kỳ bị trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        private void gridViewSem_Click(object sender, EventArgs e)
        {
            GetInfoFromGridview();
        }
    }
}
