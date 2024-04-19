using System;
using System.Data;
using System.Windows.Forms;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class FrmHHCC : Form
    {
        public FrmHHCC()
        {
            InitializeComponent();
        }

        private void FrmHHCC_Load(object sender, EventArgs e)
        {
            CargarDatosHhcc();
        }

        private void BuscarDatosHhcc()
        {
            this.dgvHHCC.DataSource = NHhCc.ListarCCHHDni(this.txtDni.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuscarDatosHhcc();
        }

        private bool ValidarHhcc(int HHCCCodigo, DateTime HHCCFecha, string PacienteCodigo)
        {
            bool valido = true;

            if (HHCCCodigo <= 0)
            {
                MessageBox.Show("El campo Número de HHCC debe ser un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }

            if (HHCCFecha == DateTime.MinValue)
            {
                MessageBox.Show("El campo Fecha de HHCC es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }

            if (string.IsNullOrEmpty(PacienteCodigo))
            {
                MessageBox.Show("El campo Código de paciente es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }

            return valido;
        }

        private void InsertaHhcc()
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                DateTime fecha = Convert.ToDateTime(txtFecha.Text);
                string pacienteCodigo = txtDni.Text;

                if (ValidarHhcc(codigo, fecha, pacienteCodigo))
                {
                    NHhCc.Insertar(codigo, fecha, pacienteCodigo);
                    MessageBox.Show("HHCC insertado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar HHCC: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificaHhcc()
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                DateTime fecha = Convert.ToDateTime(txtFecha.Text);
                string pacienteCodigo = txtDni.Text;

                if (ValidarHhcc(codigo, fecha, pacienteCodigo))
                {
                    NHhCc.Actualizar(codigo, fecha, pacienteCodigo);
                    MessageBox.Show("HHCC modificado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar HHCC: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosHhcc()
        {
            try
            {
                DataTable dtHHCC = NHhCc.ListarHHCC();
                if (dtHHCC != null && dtHHCC.Rows.Count > 0)
                {
                    dgvHHCC.DataSource = dtHHCC;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos de HHCC.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de HHCC: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertaHhcc();
            CargarDatosHhcc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificaHhcc();
            CargarDatosHhcc();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
