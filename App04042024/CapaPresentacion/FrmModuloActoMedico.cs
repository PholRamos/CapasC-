using CapaLogica;
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

using CapaDatos;
using System.Data.Sql;

namespace CapaPresentacion
{
    public partial class FrmModuloActoMedico : Form
    {
        public FrmModuloActoMedico()
        {
            InitializeComponent();
        }

        NAuxiliar auxiliares = new NAuxiliar();

        private void CargarComboEspecialista()
        {
            cbxEspecialista.DataSource = auxiliares.CargaEspecialista();
            cbxEspecialista.DisplayMember = "Nombre";
            cbxEspecialista.ValueMember = "CMP";
        }

        private void FrmModuloActoMedico_Load(object sender, EventArgs e)
        {
            CargarComboEspecialista();
            CargarDatosActoMedico();
        }

        private void CargarDatosActoMedico()
        {
            try
            {
                DataTable dtActoMedico = NActoMedico.ListarActoMedico();
                if (dtActoMedico != null && dtActoMedico.Rows.Count > 0)
                {
                    this.dgvActoMedico.DataSource = dtActoMedico;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos del acto medico.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos del acto medico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            string dni = txtPacienteDNI.Text;            

            using (DataClassesClinicaDataContext db = new DataClassesClinicaDataContext())
            {
                var query = from paciente in db.Paciente
                            join historia in db.HHCC on paciente.PacienteCodigo equals historia.PacienteCodigo
                            where paciente.PacienteCodigo == dni
                            select historia.HHCCCodigo;

                string numeroHistoriaClinica = query.SingleOrDefault().ToString();

                if (numeroHistoriaClinica != null)
                {
                    txtHHCCCodigo.Text = numeroHistoriaClinica;
                }
                else
                {
                    MessageBox.Show("No se encontró ningún paciente con ese DNI");
                }
            }
            CargarDatosActoMedico();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataClassesClinicaDataContext db = new DataClassesClinicaDataContext();
            
            ActoMedico newActoMedico = new ActoMedico()
            {
                ActoMedicoFecha = DateTime.Today, 
                HHCCCodigo = int.Parse(txtHHCCCodigo.Text), 
                EspecialistaCMP = (int?)cbxEspecialista.SelectedValue, 
                ActoMedicoObservacion = txtActoMedicoObservacion.Text
            };
                        
            db.ActoMedico.InsertOnSubmit(newActoMedico);
                       
            db.SubmitChanges();
                        
            try
            {
                db.SubmitChanges();
            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions here
                MessageBox.Show("Error saving data: " + ex.Message);
            }
            CargarDatosActoMedico();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                DataClassesClinicaDataContext db = new DataClassesClinicaDataContext();

                int actoMedicoId = int.Parse(txtActoMedicoCodigo.Text); // Obtiene el ID del acto médico a actualizar

                ActoMedico actoMedicoToUpdate = db.ActoMedico.SingleOrDefault(x => x.ActoMedicoCodigo == actoMedicoId);

                if (actoMedicoToUpdate != null)
                {
                    actoMedicoToUpdate.ActoMedicoFecha = DateTime.Parse(txtActoMedicoFecha.Text);
                    actoMedicoToUpdate.HHCCCodigo = int.Parse(txtHHCCCodigo.Text);
                    actoMedicoToUpdate.EspecialistaCMP = (int?)cbxEspecialista.SelectedValue;
                    actoMedicoToUpdate.ActoMedicoObservacion = txtActoMedicoObservacion.Text;

                    try
                    {
                        db.SubmitChanges();
                        MessageBox.Show("Registro actualizado exitosamente!");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el registro con el ID especificado.");
                }
            CargarDatosActoMedico();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataClassesClinicaDataContext db = new DataClassesClinicaDataContext();

            int actoMedicoId = int.Parse(txtActoMedicoCodigo.Text); // Obtiene el ID del acto médico a eliminar

            ActoMedico actoMedicoToDelete = db.ActoMedico.SingleOrDefault(x => x.ActoMedicoCodigo == actoMedicoId);

            if (actoMedicoToDelete != null)
            {
                DialogResult dialogResult = MessageBox.Show("¿Estás seguro de eliminar el registro?", "Eliminar Registro", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        db.ActoMedico.DeleteOnSubmit(actoMedicoToDelete);
                        db.SubmitChanges();
                        MessageBox.Show("Registro eliminado exitosamente!");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontró el registro con el ID especificado.");
            }
            CargarDatosActoMedico();
        }
    }
}
