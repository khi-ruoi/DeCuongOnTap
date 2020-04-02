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
    public partial class fmGrade : RibbonForm
    {
        clGenOrder Gen = new clGenOrder();
        AutoGenData auto = new AutoGenData();
        int ID = 0;

        Grade model = new Grade();


        void BindingGradeDGRView()
        {
            using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
            {
                var S = (from s in db.Grades

                         select new
                         {
                             s.Id,
                             s.Status,
                             s.GradeName
                         }
                         ).ToList();
                gridGrade.DataSource = S;
            }
        }
        void GetInfoFromGridview()
        {
            var gv = gridViewGrade;
            int index = gv.FocusedRowHandle;

            if (index > -1)
            {
                btnDel.Enabled = true;
                btnAdd.Text = "Update";
                btnDel.Enabled = true;

                ID = Convert.ToInt32(auto.GenData(gv,"Id"));
                model.Id = ID;

                using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
                {
                    var S = (from s in db.Grades

                             where s.Id == ID
                             select new
                             {
                                 s.Id,
                                 s.Status,
                                 s.GradeName
                             }).FirstOrDefault();

                    txtGradeName.Text = S.GradeName;

                    bool ck = Convert.ToBoolean(S.Status);
                    chkStatus.Checked = ck;
                }
            }
        }

        void AddInfo()
        {
            string GradeName = txtGradeName.Text.Trim();

            bool bl = chkStatus.Checked;

            model.Id = ID;

            if (GradeName == "")
            {
                MessageBox.Show("Tên Khối lớp không được để trống.\n\nNhập tên Khối lớp hợp lệ trước khi tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            model.GradeName = GradeName;
            model.Status = bl;

            using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
            {
                // Nếu chưa có thì thêm mới
                if (ID == 0)
                {
                    db.Grades.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Thêm mới Khối lớp thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Ngược lại sửa Record hiện tại
                else
                {
                    model.Authorities = null;
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                    MessageBox.Show("Cập nhật Khối lớp thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ClearInfo();
                BindingGradeDGRView();
            }
        }
        void ClearInfo()
        {
            txtGradeName.Text = "";
            ID = 0;
            btnAdd.Text = "Create";
            btnDel.Enabled = false;

        }
        void DelInfo()
        {
            if (ID > 0)
            {
                if (MessageBox.Show("Có chắc chắn muốn xóa Khối lớp này không", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (DeCuongOnTapEntities db = new DeCuongOnTapEntities())
                    {
                        // Xóa VS khỏi CLB
                        var entry = db.Entry(model);
                        if (entry.State == EntityState.Detached)
                            db.Grades.Attach(model);
                        db.Grades.Remove(model);
                        db.SaveChanges();

                        MessageBox.Show("Xóa Khối lớp thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ClearInfo();
                    BindingGradeDGRView();
                }

            }
        }
        public fmGrade()
        {
            InitializeComponent();
            Gen.GenOrder(gridViewGrade);
        }

        private void fmGrade_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void fmGrade_Load(object sender, EventArgs e)
        {
            BindingGradeDGRView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

            AddInfo();
            }
            catch
            {
                MessageBox.Show("Tên khối bị trùng! Kiểm tra lại.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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

        private void gridViewGrade_Click(object sender, EventArgs e)
        {
            GetInfoFromGridview();
        }
    }
}
