using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaLogica;

namespace CapaPresentacion
{
    public partial class FrmModuloHHCC : Form
    {
        public FrmModuloHHCC()
        {
            InitializeComponent();
        }

        private void CargarDatosHHCC()
        {
            try
            {
                DataTable dtHHCC = NHhCc.ListarHHCC();
                if (dtHHCC != null && dtHHCC.Rows.Count > 0)
                {
                    this.dgvHHCC.DataSource = dtHHCC;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos de HHCC.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos de HHCC: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarDatosHHCC()
        {
            this.dgvHHCC.DataSource =
              NHhCc.ListarHHCCDNI(this.txtPacienteCodigo.Text);
        }

        private void FrmModuloHHCC_Load(object sender, EventArgs e)
        {
            CargarDatosHHCC();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuscarDatosHHCC();
        }

        private bool ValidarHHCC(string pacienteCodigo) // Agregamos nuevos parámetros para la validación
        {
            bool valido = true;

            if (string.IsNullOrEmpty(pacienteCodigo))
            {
                MessageBox.Show("El campo Codigo de Paciente es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }

            // Validar la fecha (opcional)
            // if (fecha <= DateTime.MinValue) { ... }

            // Validar el diagnóstico (opcional)
            // if (string.IsNullOrEmpty(diagnostico)) { ... }

            return valido;
        }

        private void InsertaHHCC()
        {
            try
            {
                string pacienteCodigo = txtPacienteCodigo.Text.Trim();                

                // Validación de datos
                if (!ValidarHHCC(pacienteCodigo)) // Agregamos nuevos parámetros para la validación
                {
                    return;
                }

                NHhCc.Insertar(pacienteCodigo); // Se llama a la función específica para HHCC
                MessageBox.Show("HHCC insertada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar HHCC: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertaHHCC();
            CargarDatosHHCC();
        }

        private void ModificaHHCC()
        {
            try
            {
                // Implementar la lógica para obtener los datos de la HHCC a modificar (código, fecha, diagnóstico)
                string pacienteCodigo = txtPacienteCodigo.Text; // Obtener el código del paciente                
                int hhCc = int.Parse(txtHHCCCodigo.Text); // Obtener el diagnóstico

                // Validación de datos
                if (!ValidarHHCC(pacienteCodigo)) // Se usa la misma función de validación
                {
                    return;
                }

                NHhCc.Actualizar(hhCc, pacienteCodigo); // Se llama a la función para actualizar la HHCC
                MessageBox.Show("HHCC modificada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar HHCC: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ModificaHHCC();
            CargarDatosHHCC();
        }
    }
}
