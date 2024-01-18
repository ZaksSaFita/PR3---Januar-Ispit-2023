using DLWMS.Data;
using DLWMS.Data.ispitIB220116;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private StudentiUvjerenjaIB220116 izabranoUvjerenje;

        public frmIzvjestaji(StudentiUvjerenjaIB220116 izabranoUvjerenje)
        {
            InitializeComponent();
            this.izabranoUvjerenje = izabranoUvjerenje;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var parametri = new ReportParameterCollection();
            parametri.Add(new ReportParameter("Student", izabranoUvjerenje.Student.ToString()));
            parametri.Add(new ReportParameter("Indeks", izabranoUvjerenje.Student.BrojIndeksa.ToString()));
            parametri.Add(new ReportParameter("Vrsta", izabranoUvjerenje.Vrsta.ToString()));
            parametri.Add(new ReportParameter("Svrha", izabranoUvjerenje.Svrha.ToString()));

            reportViewer1.LocalReport.SetParameters(parametri);

            reportViewer1.RefreshReport();
        }

        private void reportViewer1_PrintingBegin(object sender, ReportPrintEventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Activate();
        }
    }


}
