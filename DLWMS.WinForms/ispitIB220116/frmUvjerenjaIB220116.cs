using DLWMS.Data;
using DLWMS.Data.ispitIB220116;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Izvjestaji;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.ispitIB220116
{
    public partial class frmUvjerenjaBrojIndeksa : Form
    {
        private Student _sendStudent;
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiUvjerenjaIB220116> _studentUvjerenje;

        public frmUvjerenjaBrojIndeksa(Student sendStudent)
        {
            InitializeComponent();
            this._sendStudent = sendStudent;
            dgvUvjerenje.AutoGenerateColumns = false;
        }

        private void frmUvjerenjaBrojIndeksa_Load(object sender, EventArgs e)
        {
            UcitajUvjerenje();
        }

        private void UcitajUvjerenje()
        {
            _studentUvjerenje = db.StudentiUvjerenjaIB220116.Include(x=>x.Student)
                .Where(x => x.Student == _sendStudent)
                .ToList();

            if (_studentUvjerenje != null)
            {
                dgvUvjerenje.DataSource = null;
                dgvUvjerenje.DataSource = _studentUvjerenje;
                btnDodaj.Enabled = true;
            }
            if (_studentUvjerenje.Count == 0)
                btnDodaj.Enabled = false;
            else
                btnDodaj.Enabled = true;              
            this.Text = $"Broj uvjerenja -> {_studentUvjerenje.Count}";
        }

        private void btnZahtjev_Click(object sender, EventArgs e)
        {
            frmNovoUvjerenjeIB220116 noviZahtjev = new frmNovoUvjerenjeIB220116(_sendStudent);
            if (noviZahtjev.ShowDialog() == DialogResult.OK)
            {
                UcitajUvjerenje();
            }
           
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {
                if (cmbVrsta.SelectedIndex == 0)
                    MessageBox.Show("Unesite Vrstu uvjerenja !","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                else
                {
                    var _vrsta = cmbVrsta.SelectedItem==null ? "" : cmbVrsta.SelectedItem.ToString();                                  
                    var _svrha = txtSvrha.Text;
                    var _broj = int.Parse(txtBroj.Text);
                    Thread t1 = new Thread(() => Generisi(_vrsta, _svrha, _broj));
                    t1.Start();
                }
            }
        }

        private void Generisi(string _vrsta, string _svrha, int _broj)
        {
            for (int i = 0; i < _broj; i++)
            {
                var noviZahtjev = new StudentiUvjerenjaIB220116
                {
                    StudentId = _sendStudent.Id,
                    Datum = DateTime.Now,
                    Vrsta = _vrsta,
                    Svrha = _svrha,
                    Uplatnica = _studentUvjerenje[0].Uplatnica,
                    Printano = false,
                };
                Thread.Sleep(300);
                var poruak = $"{DateTime.Now.ToString("HH:mm:ss")} -> {_vrsta} ({_sendStudent.BrojIndeksa}) - {_sendStudent} u svrhu {_svrha}" + Environment.NewLine;
                Action printTo = () => txtInfo.AppendText(poruak);
                txtInfo.Invoke(printTo);
                db.StudentiUvjerenjaIB220116.Add(noviZahtjev);
                db.SaveChanges();
            }

            Action refresh = () =>
            {
                UcitajUvjerenje();
                
                if (MessageBox.Show($"Uspjesno dodano: {_broj} -> {_vrsta}." +Environment.NewLine + " Da li zelite reset polja?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    cmbVrsta.SelectedIndex = 0;
                    txtSvrha.Text = "";
                    txtBroj.Text = "";
                    txtInfo.Text = "";
                }
            };
            BeginInvoke(refresh);
        }

        private bool Validacija()
        {
            return Helpers.Validator.ValidirajKontrolu(cmbVrsta, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
             Helpers.Validator.ValidirajKontrolu(txtSvrha, errorProvider1, Kljucevi.ObaveznaVrijednost) &&
             Helpers.Validator.ValidirajKontrolu(txtBroj, errorProvider1, Kljucevi.ObaveznaVrijednost);
        }

        private void dgvUvjerenje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var izabranoUvjerenje = _studentUvjerenje[e.RowIndex];
                if (e.ColumnIndex==5)
                {
                    if (MessageBox.Show("Da li ste sigurni?","Pitanje",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                     db.StudentiUvjerenjaIB220116.Remove(izabranoUvjerenje); 
                     db.SaveChanges();
                     UcitajUvjerenje();                        
                    }
                }
                if (e.ColumnIndex==6)
                {
                    frmIzvjestaji frmIzvjestaji = new frmIzvjestaji(izabranoUvjerenje);
                    if (frmIzvjestaji.ShowDialog()==DialogResult.OK)
                    {
                        izabranoUvjerenje.Printano = true;
                        db.SaveChanges();
                        UcitajUvjerenje();
                    }
                }
            }
        }
    }
}
