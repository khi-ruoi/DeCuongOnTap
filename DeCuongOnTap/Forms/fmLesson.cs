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
using DeCuongOnTap.UCtrl;
using System.Data.Entity;
using DeCuongOnTap.Classes;

namespace DeCuongOnTap.Forms
{
    public partial class fmLesson : RibbonForm
    {
        DeCuongOnTapEntities db = new DeCuongOnTapEntities();
        AutoGenData auto = new AutoGenData();

        clGenOrder Gen = new clGenOrder();

        int IDSem;
        int IDGrade;
        int IDTeacher;
        int IDSubject;
        int IDAuth;
        int IDQuest;
        int QType;

        void InitForm()
        {
            using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
            {
                var T = (from t in db.Teachers
                         where t.Id == IDTeacher
                         select new
                         {
                             t.FullName
                         }).FirstOrDefault();
                lblTeacherName.Text = $"Giáo viên: {T.FullName}";

                var Sem = (from s in db.Authorities
                           where s.Status == true && s.IdTeacher == IDTeacher
                           select new { s.Semester.SemName }).Distinct().ToList();

                cbxSem.DataSource = Sem;
                cbxSem.DisplayMember = "SemName";
                //cbxSem.ValueMember = "Id";

            }
            try
            {
                cbxSem.SelectedIndex = -1;
                cbxSem.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }

        }
        void ShowGrid()
        {
            if (cbxType.SelectedIndex == 0)
            {
                LoadMultiQuestion();
                QType = 0;
            }
            else
            {
                LoadEssayQuestion();
                QType = 1;
            }
        }
        void LoadMultiQuestion()
        {
            using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
            {
                var Q = (from q in db.MultiChoices
                         where q.IdAuth == IDAuth
                         orderby q.Level
                         select new
                         {
                             q.Id,
                             q.IdAuth,
                             q.Level,
                             q.Question,
                             q.AnswerA,
                             q.AnswerB,
                             q.AnswerC,
                             q.AnswerD,
                             q.Answer,
                             q.UpdateTime,
                             q.Status
                         }).ToList();

                gridQuestion.DataSource = Q;
            }
            AnsA.Visible = AnsB.Visible = AnsC.Visible = AnsD.Visible = true;
            AnsA.VisibleIndex = 3;
            AnsB.VisibleIndex = 4;
            AnsC.VisibleIndex = 5;
            AnsD.VisibleIndex = 6;
            Answer.VisibleIndex = 7;
            Update.VisibleIndex = 8;
        }
        void LoadEssayQuestion()
        {
            using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
            {
                var Q = (from q in db.EssayTests
                         where q.IdAuth == IDAuth
                         orderby q.Level
                         select new
                         {
                             q.Id,
                             q.IdAuth,
                             q.Level,
                             q.Question,
                             q.Answer,
                             q.UpdateTime,
                             q.Status
                         }).ToList();

                gridQuestion.DataSource = Q;
            }
            AnsA.Visible = AnsB.Visible = AnsC.Visible = AnsD.Visible = false;

        }
        public fmLesson()
        {
            InitializeComponent();
        }
        public fmLesson(int IdTeacher)
        {
            InitializeComponent();
            IDTeacher = IdTeacher;
            InitForm();
            Gen.GenOrder(gridViewQuestion);
        }
        // Chọn học kỳ
        private void cbxSem_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
            {
                IDSem = db.Semesters.Where(x => x.SemName == cbxSem.Text).Select(x => x.Id).FirstOrDefault();
                var A = (from a in db.Authorities
                         where a.IdSem == IDSem && a.IdTeacher == IDTeacher && a.Status == true
                         select new
                         {
                             a.Grade.Id,
                             a.Grade.GradeName
                         }
                    ).ToList();
                A = A.Distinct().ToList();
                cbxGra.DataSource = A;
                cbxGra.DisplayMember = "GradeName";
                //cbxGra.ValueMember = "id";
            }
            try
            {
                cbxGra.SelectedIndex = -1;
                cbxGra.SelectedIndex = 0;

            }
            catch (Exception)
            {}
            //cbxSub.DataSource = null;

        }
        // Chọn khối lớp
        private void cbxGra_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
                {
                    IDGrade = db.Grades.Where(x => x.GradeName == cbxGra.Text).Select(x => x.Id).FirstOrDefault();
                    var A = (from a in db.Authorities
                             where a.IdSem == IDSem && a.IdTeacher == IDTeacher && a.IdGrade == IDGrade && a.Status == true
                             select new
                             {
                                 a.Subject.Id,
                                 a.Subject.SubjectName
                             }
                        ).ToList();
                    A = A.Distinct().ToList();
                    cbxSub.DataSource = A;
                    cbxSub.DisplayMember = "SubjectName";
                    //cbxSub.ValueMember = "id";
                }
                cbxSub.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
            }
        }
        // Chọn môn học
        private void cbxSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
                {
                    IDSubject = db.Subjects.Where(x => x.SubjectName == cbxSub.Text).Select(x => x.Id).FirstOrDefault();
                    var A = (from a in db.Authorities
                             where a.IdGrade == IDGrade && a.IdSem == IDSem && a.IdSubject == IDSubject && a.IdTeacher == IDTeacher && a.Status == true
                             select a.Id
                           ).FirstOrDefault();
                    IDAuth = A;
                }
                btnAdd.Enabled = true;
                cbxType.SelectedIndex = -1;
                cbxType.SelectedIndex = 0;

            }
            catch (Exception)
            { }

        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            ManageQuestion UC = new ManageQuestion(IDAuth);
            UC.ShowDialog();
            ShowGrid();
        }

        private void gridViewQuestion_DoubleClick(object sender, EventArgs e)
        {
            var gv = gridViewQuestion;
            int index = gv.FocusedRowHandle;
            if (index > -1)
            {
                IDQuest = Convert.ToInt32(auto.GenData(gv, "Id"));
                ManageQuestion UC = new ManageQuestion(IDAuth, QType, IDQuest);
                UC.ShowDialog();

                ShowGrid();
            }
        }
    }
}
