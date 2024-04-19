using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppClinica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        FrmModuloPacientes frmModuloPacientes = new FrmModuloPacientes();
        private void registroDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            frmModuloPacientes.MdiParent = this;
            frmModuloPacientes.Show();
        }

        

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text=DateTime.Now.ToLongTimeString();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongDateString();
            toolStripProgressBar1.Increment(5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
