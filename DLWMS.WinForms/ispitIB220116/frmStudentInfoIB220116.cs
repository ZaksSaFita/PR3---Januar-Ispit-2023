using DLWMS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.ispitIB220116
{
    public partial class frmStudentInfoIB220116 : Form
    {
        private Student _sendStudent;

        public frmStudentInfoIB220116(Student sendStudent)
        {
            InitializeComponent();
            this._sendStudent = sendStudent;
            this.Text = $"{_sendStudent.BrojIndeksa}";
        }

        private void frmStudentInfoIB220116_Load(object sender, EventArgs e)
        {
            pbSlikaStudenta.Image = Helpers.ImageHelper.FromByteToImage( _sendStudent.Slika);
            lblStudent.Text = _sendStudent.StudentName;
            lblProsjek.Text= $"Prosjek: {_sendStudent.Prosjek.ToString()}";
        }
    }
}
