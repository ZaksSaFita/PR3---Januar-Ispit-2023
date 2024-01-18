using DLWMS.Data;
using DLWMS.Data.ispitIB220116;
using DLWMS.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;
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

    public partial class frmPretragaIB220116 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> _student;
        public frmPretragaIB220116()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
            this.Text = "Pretraga studenata";
        }

        private void frmPretragaIB220116_Load(object sender, EventArgs e)
        {
            UcitajSpol();
            UcitajSve();
        }

        private void UcitajSve()
        {
            if (cmbSpol.SelectedIndex == 0)           
                _student = db.Studenti.Include(x => x.Spol)
                    .Where(x => x.DatumRodjenja >= dtpDatumOD.Value && x.DatumRodjenja <= dtpDatumDO.Value)
                    .ToList();         
            else
                _student = db.Studenti.Include(x => x.Spol)
                   .Where(x => x.Spol == cmbSpol.SelectedItem && x.DatumRodjenja >= dtpDatumOD.Value && x.DatumRodjenja <= dtpDatumDO.Value)
                   .ToList();

            if (_student != null)
            {
                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = _student;
            }
            if (_student.Count < 1)
                MessageBox.Show($"U bazi podataka ne postoji evidencija o studentima < {cmbSpol.SelectedItem} > spola rođenih u periodu od {dtpDatumOD.Value.ToString("dd.MM.yyyy")} - {dtpDatumDO.Value.ToString("dd.MM.yyyy")} godine");
        }

        private void UcitajSpol()
        {
            var spolovi = db.Spolovi.ToList();
            spolovi.Insert(0, new Spol { Id = 4, Naziv = "Svi" });
            cmbSpol.DataSource = spolovi;
            cmbSpol.SelectedIndex = 0;
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajSve();
        }

        private void dtpDatumOD_ValueChanged(object sender, EventArgs e)
        {
            UcitajSve();
        }

        private void dtpDatumDO_ValueChanged(object sender, EventArgs e)
        {
            UcitajSve();
        }

        private void dgvPretraga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var sendStudent = _student[e.RowIndex];
                if (e.ColumnIndex!=5)
                {
                    frmStudentInfoIB220116 frmStudentInfo = new frmStudentInfoIB220116(sendStudent);
                    frmStudentInfo.ShowDialog();
                }
                else if (e.ColumnIndex==5)
                {
                    frmUvjerenjaBrojIndeksa frmUvjerenje = new frmUvjerenjaBrojIndeksa(sendStudent);
                    frmUvjerenje.ShowDialog(); 
                }
            }
        }
    }
}

