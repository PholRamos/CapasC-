using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaLogica;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class FrmModuloEspecialista : Form
    {
        public FrmModuloEspecialista()
        {
            InitializeComponent();
        }
        
        NAuxiliar especialidad = new NAuxiliar();

        private void CargarCbxEspecialidad()
        {
            cbxEspecialidad.DataSource = especialidad.CargaComboEspecialidad();
            cbxEspecialidad.DisplayMember = "EspecialidadDescripcion";
            cbxEspecialidad.ValueMember = "EspecialidadCodigo";
        }

        private void FrmModuloEspecialista_Load(object sender, EventArgs e)
        {
            CargarDatosEspecialista();
            CargarCbxEspecialidad();
        }

        

        /// <summary>
        /// Modulo para buscar datos del especialista
        /// </summary>
        private void BuscarDatosEspecialista()
        {
            this.dgvEspecialista.DataSource =
                NEspecialista.ListarEspecialistaCMP(int.Parse(this.txtCMPEspecialista.Text));
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            BuscarDatosEspecialista();
        }

        /// <summary>
        /// Modulo para guardar la informacion del especialista
        /// </summary>
        private void InsertaEspecialista()
        {
            try
            {
                int especialistaCmp = int.Parse(txtCMPEspecialista.Text.Trim());
                string especialistaNombre = txtEspecialistaNombre.Text.Trim();
                string especialistaApellido = txtEspecialistaApellido.Text.Trim();
                int especialidadCodigo = int.Parse(cbxEspecialidad.SelectedValue.ToString());

                // Validación de datos
                if (!ValidarEspecialista(especialistaCmp, especialistaNombre, especialistaApellido, especialidadCodigo))
                {
                    return;
                }

                NEspecialista.Insertar(especialistaCmp, especialistaNombre, especialistaApellido, especialidadCodigo);
                MessageBox.Show("Especialista insertado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar especialista: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Modulo para modificar la informacion del especialista
        /// </summary>
        private void ModificaEspecialista()
        {
            try
            {
                int especialistaCmp = int.Parse(txtCMPEspecialista.Text.Trim());
                string especialistaNombre = txtEspecialistaNombre.Text.Trim();
                string especialistaApellido = txtEspecialistaApellido.Text.Trim();
                int especialidadCodigo = int.Parse(cbxEspecialidad.SelectedValue.ToString());

                // Validación de datos
                if (!ValidarEspecialista(especialistaCmp, especialistaNombre, especialistaApellido, especialidadCodigo))
                {
                    return;
                }

                NEspecialista.Actualizar(especialistaCmp, especialistaNombre, especialistaApellido, especialidadCodigo);
                MessageBox.Show("Especialista modificado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar especialista: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Modulo´para desarrollar validaciones en los campos del especialista
        /// </summary>
        /// <param name="especialistaCmp"></param>
        /// <param name="especialistaNombre"></param>
        /// <param name="especialistaApellido"></param>
        /// <param name="especialidadCodigo"></param>
        /// <returns></returns>
        private bool ValidarEspecialista(int especialistaCmp, string especialistaNombre, string especialistaApellido, int especialidadCodigo)
        {
            bool valido = true;

            if (especialistaCmp <= 0)
            {
                MessageBox.Show("El campo CMP debe ser un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }

            if (string.IsNullOrEmpty(especialistaNombre))
            {
                MessageBox.Show("El campo nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }

            if (string.IsNullOrEmpty(especialistaApellido))
            {
                MessageBox.Show("El campo apellido es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }

            if (especialidadCodigo <= 0)
            {
                MessageBox.Show("Debe seleccionar una especialidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }

            return valido;
        }

        /// <summary>
        /// Modulo para cargar datos en el control gridview
        /// </summary>
        private void CargarDatosEspecialista()
        {
            try
            {
                DataTable dtEspecialista = NEspecialista.ListarEspecialista();
                if (dtEspecialista != null && dtEspecialista.Rows.Count > 0)
                {
                    this.dgvEspecialista.DataSource = dtEspecialista;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos de especialista.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos de especialista: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertaEspecialista();
            CargarDatosEspecialista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificaEspecialista();
            CargarDatosEspecialista();
        }

        /// <summary>
        /// Funcion para eliminar al especialista
        /// </summary>
        private void EliminaEspecialista()
        {
            // Obtener el ID del registro a eliminar
            int especialistaCmp = int.Parse(txtCMPEspecialista.Text.Trim());

            // Confirmar la eliminación
            if (MessageBox.Show("¿Está seguro de eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Eliminar el registro
                string rpta = NEspecialista.Eliminar(especialistaCmp);

                // Mostrar mensaje de éxito o error
                if (rpta == "Ok")
                {
                    MessageBox.Show("Registro eliminado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar registro: " + rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            EliminaEspecialista();
            CargarDatosEspecialista();
        }

        private void dgvEspecialista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCMPEspecialista.Text = dgvEspecialista.CurrentRow.Cells[0].Value.ToString();
            txtEspecialistaNombre.Text= dgvEspecialista.CurrentRow.Cells[1].Value.ToString();
            txtEspecialistaApellido.Text= dgvEspecialista.CurrentRow.Cells[2].Value.ToString();
            cbxEspecialidad.SelectedValue= dgvEspecialista.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
