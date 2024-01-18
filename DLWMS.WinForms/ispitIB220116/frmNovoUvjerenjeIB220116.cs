using DLWMS.Data;
using DLWMS.Data.ispitIB220116;
using DLWMS.WinForms.Helpers;
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
    public partial class frmNovoUvjerenjeIB220116 : Form
    {
        private Student sendStudent;
        DLWMSDbContext db = new DLWMSDbContext();

        public frmNovoUvjerenjeIB220116(Student sendStudent)
        {
            InitializeComponent();
            this.sendStudent = sendStudent;

        }

        private void frmNovoUvjerenjeIB220116_Load(object sender, EventArgs e)
        {
            this.Text = "Novi zahtjev za izdavanje uvjerenja";
        }


        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {
                if (cmbVrsta.SelectedIndex == 0)
                    MessageBox.Show("Unesite Vrstu uvjerenja !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    var noviZahtjev = new StudentiUvjerenjaIB220116
                    {
                        StudentId = sendStudent.Id,
                        Printano = false,
                        Datum = DateTime.Now,
                        Svrha = txtSvrha.Text,
                        Vrsta=cmbVrsta.SelectedItem.ToString(),
                        Uplatnica= Helpers.ImageHelper.FromImageToByte( pbSlika.Image)
                    };
                    db.StudentiUvjerenjaIB220116.Add(noviZahtjev);
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Uspjesno dodano novo uvjerenje");
                    
                }
            }
        }

        private bool Validacija()
        {
            return Helpers.Validator.ValidirajKontrolu(cmbVrsta, err,Kljucevi.ObaveznaVrijednost) &&
                     Helpers. Validator.ValidirajKontrolu(txtSvrha,err, Kljucevi.ObaveznaVrijednost) &&
                     Helpers.Validator.ValidirajKontrolu( pbSlika, err, Kljucevi.ObaveznaVrijednost);
        }
    }
}
