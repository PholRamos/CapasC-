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

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Assuming you have a connection established to your SQL Server database and a DataContext class named 'hospitalContext'
            DataClassesClinicaDataContext db = new DataClassesClinicaDataContext();
            // Create an instance of the ActoMedico class with the desired data
            ActoMedico newActoMedico = new ActoMedico()
            {
                ActoMedicoFecha = DateTime.Today, 
                HHCCCodigo = int.Parse(txtHHCCCodigo.Text), 
                EspecialistaCMP = (int?)cbxEspecialista.SelectedValue, 
                ActoMedicoObservacion = txtActoMedicoObservacion.Text
            };

            // Insert the new record using LINQ
            db.ActoMedico.InsertOnSubmit(newActoMedico);

            // Save changes to the database
            db.SubmitChanges();

            // Handle any exceptions (optional)
            try
            {
                db.SubmitChanges();
            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions here
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Load sample data (unchanged)
            var sampleData = new MLModelInfluenza.ModelInput()
            {
                Fiebre = cbxFiebre.SelectedItem.ToString(),
                Tos = cbxTos.SelectedItem.ToString(),
                Dolor_de_cabeza = cbxDolorCabeza.SelectedItem.ToString(),
                Dolor_muscular = cbxDolorMuscular.SelectedItem.ToString(),
                Malestar_general = cbxMalestar.SelectedItem.ToString(),
                Dolor_de_garganta = cbxDolorGarganta.SelectedItem.ToString(),
                Secreción_nasal = cbxSecrecionNasal.SelectedItem.ToString(),
            };

            // Load model and predict output
            var result = MLModelInfluenza.Predict(sampleData);
            txtDiagnosticoIA.Text=result.PredictedLabel;
            
        }

    }
}
