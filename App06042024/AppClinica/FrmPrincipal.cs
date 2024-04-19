﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppClinica.Reportes;
using CapaPresentacion;

namespace AppClinica
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        CapaPresentacion.FrmModuloPaciente frmModuloPacientes = new CapaPresentacion.FrmModuloPaciente();
        private void registroDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            frmModuloPacientes.MdiParent = this;
            frmModuloPacientes.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongTimeString();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongDateString();
            toolStripProgressBar1.Increment(10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        FrmModuloEspecialista frmModuloEspecialista = new FrmModuloEspecialista();
        private void registroDeEspecialistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModuloEspecialista.MdiParent = this;
            frmModuloEspecialista.Show();
        }

        FrmModuloHHCC frmModuloHHCC = new FrmModuloHHCC();
        private void registroDeHHCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModuloHHCC.MdiParent = this;
            frmModuloHHCC.Show();
        }

        FrmModuloActoMedico frmModuloActoMedico = new FrmModuloActoMedico();    
        private void registroDeAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModuloActoMedico.MdiParent = this;
            frmModuloActoMedico.Show();
        }

        FrmReportesPacienteDiagnostico frmReportesPacienteDiagnostico = new FrmReportesPacienteDiagnostico();
        private void gestorDeReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportesPacienteDiagnostico.MdiParent = this;
            frmReportesPacienteDiagnostico.Show();
        }
    }
}
