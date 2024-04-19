using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmModuloActoMedico : Form
    {
        public FrmModuloActoMedico()
        {
            InitializeComponent();
        }

        NAuxiliar auxiliares = new NAuxiliar();

        private void CargarCbxEspecialista()
        {
            cbxEspecialista.DataSource = auxiliares.CargaComboEspecialista();
            cbxEspecialista.DisplayMember = "EspecialistaNombre";
            cbxEspecialista.ValueMember = "EspecialistaCMP";
        }
        private void FrmModuloActoMedico_Load(object sender, EventArgs e)
        {
            CargarCbxEspecialista();
        }

        private void BuscarDatosHHCC()
        {
            //this.txtPacienteDNI.Text = NPaciente.BuscaHHCCDni(this.txtHHCCCodigo.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
