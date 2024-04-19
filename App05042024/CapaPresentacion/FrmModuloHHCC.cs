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

        /// <summary>
        /// Modulo para cargar los datos de la historia clinica 
        /// </summary>
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

        /// <summary>
        /// Modulo para cargar datos de la historia clinica utilizando el dni del paciente
        /// </summary>
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

        /// <summary>
        /// Modulo que permite validar los datos de las historias clinicas
        /// </summary>
        /// <param name="pacienteCodigo"></param>
        /// <returns></returns>
        private bool ValidarHHCC(string pacienteCodigo) // Agregamos nuevos parámetros para la validación
        {
            bool valido = true;

            if (string.IsNullOrEmpty(pacienteCodigo))
            {
                MessageBox.Show("El campo Codigo de Paciente es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }
            return valido;
        }

        /// <summary>
        /// Modulo para agregar historias clinicas
        /// </summary>
        private void InsertaHHCC()
        {
            try
            {
                string pacienteCodigo = txtPacienteCodigo.Text.Trim();                
                
                if (!ValidarHHCC(pacienteCodigo)) 
                {
                    return;
                }

                NHhCc.Insertar(pacienteCodigo); 
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

        /// <summary>
        /// Metodo para modificar la informacion de la historia clinica
        /// </summary>
        private void ModificaHHCC()
        {
            try
            {                
                string pacienteCodigo = txtPacienteCodigo.Text; // Obtener el código del paciente                
                int hhCc = int.Parse(txtHHCCCodigo.Text); // Obtener el diagnóstico

             
                if (!ValidarHHCC(pacienteCodigo)) // Se usa la misma función de validación
                {
                    return;
                }

                NHhCc.Actualizar(hhCc, pacienteCodigo);
                MessageBox.Show("HHCC modificada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar HHCC: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void button2_Click_1(object sender, EventArgs e)
        {
            ModificaHHCC();
            CargarDatosHHCC();
        }

        private void dgvHHCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHHCCCodigo.Text = dgvHHCC.CurrentRow.Cells[0].Value.ToString();
            txtPacienteCodigo.Text = dgvHHCC.CurrentRow.Cells[2].Value.ToString();
            txtFechaActual.Text= dgvHHCC.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
