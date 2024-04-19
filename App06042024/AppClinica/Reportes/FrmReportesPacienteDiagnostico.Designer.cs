namespace AppClinica.Reportes
{
    partial class FrmReportesPacienteDiagnostico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.uspReportePacienteDiagnosticoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_ClinicaDataSetReportes = new AppClinica.DB_ClinicaDataSetReportes();
            this.rptVwPacienteDiagnostico = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usp_ReportePacienteDiagnosticoTableAdapter = new AppClinica.DB_ClinicaDataSetReportesTableAdapters.usp_ReportePacienteDiagnosticoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uspReportePacienteDiagnosticoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ClinicaDataSetReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // uspReportePacienteDiagnosticoBindingSource
            // 
            this.uspReportePacienteDiagnosticoBindingSource.DataMember = "usp_ReportePacienteDiagnostico";
            this.uspReportePacienteDiagnosticoBindingSource.DataSource = this.dB_ClinicaDataSetReportes;
            // 
            // dB_ClinicaDataSetReportes
            // 
            this.dB_ClinicaDataSetReportes.DataSetName = "DB_ClinicaDataSetReportes";
            this.dB_ClinicaDataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptVwPacienteDiagnostico
            // 
            this.rptVwPacienteDiagnostico.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportePacienteDiagnostico";
            reportDataSource1.Value = this.uspReportePacienteDiagnosticoBindingSource;
            this.rptVwPacienteDiagnostico.LocalReport.DataSources.Add(reportDataSource1);
            this.rptVwPacienteDiagnostico.LocalReport.ReportEmbeddedResource = "AppClinica.Reportes.ReportPacientesDiagnostico.rdlc";
            this.rptVwPacienteDiagnostico.Location = new System.Drawing.Point(0, 0);
            this.rptVwPacienteDiagnostico.Name = "rptVwPacienteDiagnostico";
            this.rptVwPacienteDiagnostico.ServerReport.BearerToken = null;
            this.rptVwPacienteDiagnostico.Size = new System.Drawing.Size(1190, 517);
            this.rptVwPacienteDiagnostico.TabIndex = 0;
            // 
            // usp_ReportePacienteDiagnosticoTableAdapter
            // 
            this.usp_ReportePacienteDiagnosticoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportesPacienteDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 517);
            this.ControlBox = false;
            this.Controls.Add(this.rptVwPacienteDiagnostico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmReportesPacienteDiagnostico";
            this.Text = "Reportes Paciente Diagnostico";
            this.Load += new System.EventHandler(this.FrmReportesPacienteDiagnostico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspReportePacienteDiagnosticoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_ClinicaDataSetReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptVwPacienteDiagnostico;
        private DB_ClinicaDataSetReportes dB_ClinicaDataSetReportes;
        private System.Windows.Forms.BindingSource uspReportePacienteDiagnosticoBindingSource;
        private DB_ClinicaDataSetReportesTableAdapters.usp_ReportePacienteDiagnosticoTableAdapter usp_ReportePacienteDiagnosticoTableAdapter;
    }
}