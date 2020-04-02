using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeCuongOnTap.Classes
{
    public class ckSubjectAuth
    {
        public void GenSubject(FlowLayoutPanel pn ,string SubjectName, int id)
        {
            CheckEdit ckSubject = new CheckEdit();
            ckSubject.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            ckSubject.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            ckSubject.Properties.Caption = SubjectName;
            ckSubject.Properties.Appearance.Options.UseFont = true;
            ckSubject.Properties.Appearance.Options.UseForeColor = true;
            ckSubject.Size = new System.Drawing.Size(217, 23);
            ckSubject.TabIndex = 0;
            ckSubject.Properties.Tag = id;

            pn.Controls.Add(ckSubject);
        }
    }
}
