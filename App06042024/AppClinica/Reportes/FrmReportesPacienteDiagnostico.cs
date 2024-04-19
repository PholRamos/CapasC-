using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppClinica.Reportes
{
    public partial class FrmReportesPacienteDiagnostico : Form
    {
        public FrmReportesPacienteDiagnostico()
        {
            InitializeComponent();
        }

        private void FrmReportesPacienteDiagnostico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_ClinicaDataSetReportes.usp_ReportePacienteDiagnostico' Puede moverla o quitarla según sea necesario.
            this.usp_ReportePacienteDiagnosticoTableAdapter.Fill(this.dB_ClinicaDataSetReportes.usp_ReportePacienteDiagnostico);            
            this.rptVwPacienteDiagnostico.RefreshReport();
        }
    }
}
