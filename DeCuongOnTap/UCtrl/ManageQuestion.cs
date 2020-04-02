using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DeCuongOnTap.DataContext;
using DevExpress.XtraBars.Ribbon;

namespace DeCuongOnTap.UCtrl
{
    public partial class ManageQuestion : RibbonForm
    {
        #region Khai báo biến
        int IDAuth, IDQuest;
        int QType;
        string QLevel;

        DeCuongOnTapEntities db = new DeCuongOnTapEntities();
        MultiChoice modelMulti = new MultiChoice();
        EssayTest modelEssay = new EssayTest();

        #endregion

        public ManageQuestion()
        {
            InitializeComponent();

        }
        public ManageQuestion(int IdAuth)
        {
            InitializeComponent();
            btnDel.Enabled = false;
            btnAdd.Enabled = false;
            btnAdd.Text = "Thêm";
            IDAuth = IdAuth;
            GetInfo();
            cbxType.SelectedIndex = 0;
        }

        public ManageQuestion(int IdAuth, int QuestionType, int IdQuestion)
        {
            InitializeComponent();
            btnDel.Enabled = true;
            btnAdd.Enabled = true;
            btnAdd.Text = "Sửa";
            IDAuth = IdAuth;
            IDQuest = IdQuestion;
            QType = QuestionType;

            GetInfo();
        }

        #region Method
        void GetInfo()
        {
            lblQLevel.Text = "";
            using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
            {
                var A = (from a in db.Authorities
                         where a.Id == IDAuth
                         select new { a.Semester.SemName, a.Grade.GradeName, a.Teacher.FullName, a.Subject.SubjectName }).FirstOrDefault();
                lblInfo.Text = $"Đề cương [{A.SemName}]   thuộc [{A.GradeName}]    môn [{A.SubjectName}]    của Giáo viên: [{A.FullName}]";

                if (IDQuest > 0)
                {
                    if (QType == 0)
                    {
                        var Q = (from q in db.MultiChoices
                                 where q.IdAuth == IDAuth && q.Id == IDQuest
                                 select q).FirstOrDefault();
                        txtQuestion.Text = Q.Question;
                        txtAnsA.Text = Q.AnswerA;
                        txtAnsB.Text = Q.AnswerB;
                        txtAnsC.Text = Q.AnswerC;
                        txtAnsD.Text = Q.AnswerD;

                        txtAnswer.Text = Q.Answer;
                        switch (Q.Answer)
                        {
                            case "A": radA.Checked = true; break;
                            case "B": radB.Checked = true; break;
                            case "C": radC.Checked = true; break;
                            case "D": radD.Checked = true; break;
                            default: break;
                        }

                        cbxType.SelectedIndex = 0;

                        lblInfo.Text += $"   <{Q.Level}>";
                    }
                    else
                    {

                        var Q = (from q in db.EssayTests
                                 where q.IdAuth == IDAuth && q.Id == IDQuest
                                 select q).FirstOrDefault();
                        txtQuestion.Text = Q.Question;

                        txtAnswer.Text = Q.Answer;

                        lblInfo.Text += $"   <{Q.Level}>";

                        cbxType.SelectedIndex = 1;
                    }

                    lblQLevel.Text = QLevel;
                    cbxType.Enabled = false;
                    btnDel.Enabled = true;
                    btnAdd.Text = "Sửa";
                }
            }
        }
        void ShowQuestForm()
        {
            if (QType == 0)
            {
                pnMulti.Visible = true;
                pnEssay.Visible = false;
            }
            else
            {
                pnMulti.Visible = false;
                pnEssay.Visible = true;
            }
        }
        void SaveMulti()
        {

            modelMulti.IdAuth = IDAuth;
            modelMulti.Level = cbxLevel.Text;
            modelMulti.Question = txtQuestion.Text;
            modelMulti.AnswerA = txtAnsA.Text;
            modelMulti.AnswerB = txtAnsB.Text;
            modelMulti.AnswerC = txtAnsC.Text;
            modelMulti.AnswerD = txtAnsD.Text;

            if (radA.Checked) modelMulti.Answer = "A";
            if (radB.Checked) modelMulti.Answer = "B";
            if (radC.Checked) modelMulti.Answer = "C";
            if (radD.Checked) modelMulti.Answer = "D";

            modelMulti.Status = true;
            modelMulti.UpdateTime = DateTime.Now.ToString();
            using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
            {
                if (IDQuest == 0)
                {

                    db.MultiChoices.Add(modelMulti);
                }
                else
                {
                    modelMulti.Id = IDQuest;
                    db.Entry(modelMulti).State = EntityState.Modified;
                }
                db.SaveChanges();
            }

            IDQuest = modelMulti.Id;
            GetInfo();
        }
        void SaveEssay()
        {

            modelEssay.IdAuth = IDAuth;
            modelEssay.Level = cbxLevel.Text;
            modelEssay.Question = txtQuestion.Text;
            modelEssay.Answer = txtAnswer.Text;
            modelEssay.Status = true;
            modelEssay.UpdateTime = DateTime.Now.ToString();
            using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
            {
                if (IDQuest == 0)
                {

                    db.EssayTests.Add(modelEssay);
                }
                else
                {
                    modelEssay.Id = IDQuest;
                    db.Entry(modelEssay).State = EntityState.Modified;
                }
                db.SaveChanges();
            }

            IDQuest = modelEssay.Id;
            GetInfo();
        }
        void DelQuestion()
        {
            if (MessageBox.Show("Có chắc chắn muốn xóa Câu hỏi này không", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (QType == 0)
                {
                    modelMulti.Id = IDQuest;
                    using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
                    {
                        // Xóa VS khỏi CLB
                        var entry = db.Entry(modelMulti);
                        if (entry.State == EntityState.Detached)
                            db.MultiChoices.Attach(modelMulti);
                        db.MultiChoices.Remove(modelMulti);
                        db.SaveChanges();

                    }
                }
                else
                {
                    modelEssay.Id = IDQuest;
                    using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
                    {
                        // Xóa VS khỏi CLB
                        var entry = db.Entry(modelEssay);
                        if (entry.State == EntityState.Detached)
                            db.EssayTests.Attach(modelEssay);
                        db.EssayTests.Remove(modelEssay);
                        db.SaveChanges();

                    }
                }
                Close();
            }
        }

        #endregion

        #region Events
        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxLevel.SelectedIndex = 0;
            QType = cbxType.SelectedIndex;
            ShowQuestForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cbxLevel.Text) ;
            if (QType == 0)
            {
                SaveMulti();
            }
            else
            {
                SaveEssay();
            }
            MessageBox.Show("Cập nhật đề cương thành công!", "Thông báo");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DelQuestion();
        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(txtQuestion.Text, txtQuestion.Font);
            //txtQuestion.Width = size.Width;
            if (size.Height>=10 && size.Height <= 100)
                txtQuestion.Height = size.Height + 10;
        }

        private void cbxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        #endregion
    }
}
