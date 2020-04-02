using DevExpress.XtraBars.Ribbon;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DeCuongOnTap.DataContext;
using DevExpress.XtraEditors;
using DeCuongOnTap.Classes;
using System.Data.Entity;
using System.Drawing;

namespace DeCuongOnTap.Forms
{
    public partial class fmAuthority : RibbonForm
    {
        clGenOrder Gen = new clGenOrder();
        AutoGenData auto = new AutoGenData();
        // Khai báo model
        Authority Auth = new Authority();
        Teacher modelTeacher = new Teacher();
        Semester modelSem = new Semester();
        Grade modelGrade = new Grade();

        // Khai báo biến
        int IDSem = 0;
        int IDGra = 0;
        int IDTeacher = 0;
        int IDSubject = 0;

        DeCuongOnTapEntities db;

        void FLoad()
        {
            using (db = new DeCuongOnTapEntities())
            {
                // Lấy danh sách Học kỳ
                var Sem = (from s in db.Semesters
                           where s.Status == true
                           select new
                           {
                               s.Id,
                               s.SemName,
                               s.Status
                           }).ToList();

                cbxSem.DataSource = Sem;
                cbxSem.DisplayMember = "SemName";

                // Lấy danh sách Khối
                var Gra = (from g in db.Grades
                           where g.Status == true
                           select new
                           {
                               g.Id,
                               g.GradeName,
                               g.Status
                           }).ToList();

                cbxGrade.DataSource = Gra;
                cbxGrade.DisplayMember = "GradeName";

                // Lấy danh sách Giáo viên

                var T = (from t in db.Teachers
                         select new
                         {
                             t.Id,
                             t.FullName,
                             t.DOB,
                             t.Status,
                             t.UserName
                         }).ToList();
                gridTeacher.DataSource = T;
            }
        }
        // Liệt kê tên các môn học
        void ListSubject()
        {
            using (db = new DeCuongOnTapEntities())
            {
                var S = (from s in db.Subjects
                         where s.Status == true
                         select new
                         {
                             s.Id,
                             s.Status,
                             s.SubjectName
                         }
                       ).ToList();
                foreach (var i in S)
                {
                    ckSubjectAuth ck = new ckSubjectAuth();

                    ck.GenSubject(fpnAuth, i.SubjectName, i.Id);
                }
            }
        }
        // Lấy quyền quản lý đề cương của Giáo viên
        void GetInfoFromGridview()
        {
            lblSem.Text = cbxSem.Text;
            lblGra.Text = cbxGrade.Text;

            var gv = gridViewTeacher;
            int index = gv.FocusedRowHandle;

            if (index > -1)
            {
                IDTeacher = Convert.ToInt32(auto.GenData(gv,"Id"));
                string TName = auto.GenData(gv, "FullName");
                bool b = Convert.ToBoolean(auto.GenData(gv,"Status"));

                lblTea.Text = TName;
                if (b)
                {
                    lblAuth.Text = "Tài khoản đang hoạt động";
                    lblAuth.ForeColor = Color.Blue;
                }
                else
                {
                    lblAuth.Text = "Tài khoản đang khóa";
                    lblAuth.ForeColor = Color.Red;
                }
                using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
                {
                    var S = (from s in db.Semesters where s.SemName == cbxSem.Text select new { s.Id }).FirstOrDefault();
                    IDSem = S.Id;
                    var G = (from g in db.Grades where g.GradeName == cbxGrade.Text select new { g.Id }).FirstOrDefault();
                    IDGra = G.Id;

                    foreach (CheckEdit c in fpnAuth.Controls)
                    {

                        var I = (from i in db.Subjects where i.SubjectName == c.Text select new { i.Id }).FirstOrDefault();
                        int IDSubject = I.Id;
                        var A = (from a in db.Authorities where a.IdGrade == IDGra && a.IdSem == IDSem && a.IdTeacher == IDTeacher && a.IdSubject == IDSubject select new { a.Id, a.Status }).FirstOrDefault();
                        if (A == null || A.Status == false)
                        {
                            c.Checked = false;
                        }
                        else c.Checked = true;

                    }

                    if (!b)
                    {
                        btnUpdate.Enabled = false;
                    }
                    else
                    {
                        btnUpdate.Enabled = true;
                    }

                }
            }

        }
        // Cập nhật quyền cho Giáo viên
        void UpdateAuth()
        {
            foreach (CheckEdit c in fpnAuth.Controls)
            {
                //Lấy ID của Subject
                using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
                {
                    var S = (from s in db.Subjects
                             where s.SubjectName == c.Text
                             select new
                             {
                                 s.Id
                             }).FirstOrDefault();
                    IDSubject = S.Id;
                }
                // Kiểm tra sự tồn tại của Quyền
                int ID = 0;
                using (var db = new DeCuongOnTapEntities())
                {
                    var A = (from a in db.Authorities
                             where a.IdGrade == IDGra && a.IdSem == IDSem && a.IdSubject == IDSubject && a.IdTeacher == IDTeacher
                             select new
                             {
                                 a.Id
                             }
                            ).FirstOrDefault();
                    if (A == null) ID = 0;
                    else ID = A.Id;
                }
                bool bl = c.Checked;

                Authority model = new Authority();

                model.IdGrade = IDGra;
                model.IdSem = IDSem;
                model.IdTeacher = IDTeacher;
                model.IdSubject = IDSubject;
                model.Status = bl;
                // Cập nhật quyền
                using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
                {
                    // Nếu chưa có thì thêm mới
                    if (ID == 0)
                    {
                        db.Authorities.Add(model);
                    }
                    // Ngược lại sửa Record hiện tại
                    else
                    {
                        model.Id = ID;
                        //model.Semester = null;
                        //model.Grade = null;
                        //model.Teacher = null;
                        //model.Subject = null;

                        //model.MultiChoices = null;
                        //model.EssayTests = null;

                        db.Entry(model).State = EntityState.Modified;
                    }
                    db.SaveChanges();
                }
            }

            MessageBox.Show("Đã tạo quyền cho giáo viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Refresh các Control
        void RefreshAuth()
        {
            foreach (CheckEdit c in fpnAuth.Controls)
            {
                c.Checked = false;
            }
            btnUpdate.Enabled = false;
            lblSem.Text = cbxSem.Text;
            lblGra.Text = cbxGrade.Text;
            lblTea.Text = "";
            lblAuth.Text = "";
        }
        public fmAuthority()
        {
            InitializeComponent();
            Gen.GenOrder(gridViewTeacher);
        }

        private void fmManageAuth_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fmManageAuth_Load(object sender, EventArgs e)
        {
            FLoad();
            ListSubject();
            RefreshAuth();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAuth();
        }

        private void cbxSem_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            GetInfoFromGridview();
        }

        private void cbxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetInfoFromGridview();
        }

        private void gridViewTeacher_DoubleClick(object sender, EventArgs e)
        {

            GetInfoFromGridview();
        }

        private void gridViewTeacher_Click(object sender, EventArgs e)
        {
            GetInfoFromGridview();
        }
    }
}

