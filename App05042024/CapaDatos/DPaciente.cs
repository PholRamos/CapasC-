using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace CapaDatos
{
    /// <summary>
    /// Creacion del objeto Paciente
    /// </summary>
    public class DPaciente
    {
        /// <summary>
        /// Creacion de los atributos del objeto paciente
        /// </summary>
        #region Propiedades
        public string PacienteCodigo { get; set; }
        public string PacienteNombre { get; set; }
        public string PacienteApellido { get; set; }
        public string PacienteDireccion { get; set; }
        public int PacienteTelefono { get; set; }
        public string PacienteNacimiento { get; set; }
        public int EECCCodigo { get; set; }
        public int GeneroCCodigo { get; set; }
        #endregion

        #region Constructores
        public DPaciente() { }

        public DPaciente(string pacienteCodigo,
                         string pacienteNombre,
                         string pacienteApellido,
                         string pacienteDireccion,
                         int pacienteTelefono,
                         string pacienteNacimiento,
                         int eECCCodigo,
                         int generoCCodigo)
        {
            PacienteCodigo = pacienteCodigo;
            PacienteNombre = pacienteNombre;
            PacienteApellido = pacienteApellido;
            PacienteDireccion = pacienteDireccion;
            PacienteTelefono = pacienteTelefono;
            PacienteNacimiento = pacienteNacimiento;
            EECCCodigo = eECCCodigo;
            GeneroCCodigo = generoCCodigo;
        }
        #endregion

        /// <summary>
        /// Metodo Insertar Pacientes
        /// </summary>
        /// <param name="Paciente"></param>
        /// <returns></returns>
        public string Insertar(DPaciente paciente)
        {
            using (SqlConnection sqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand sqlCmd = new SqlCommand("usp_InsertarPaciente", sqlCon))
            {
                try
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    // Use AddWithValue for cleaner parameter addition
                    sqlCmd.Parameters.AddWithValue("@PacienteCodigo", paciente.PacienteCodigo);
                    sqlCmd.Parameters.AddWithValue("@PacienteNombre", paciente.PacienteNombre);
                    sqlCmd.Parameters.AddWithValue("@PacienteApellido", paciente.PacienteApellido);
                    sqlCmd.Parameters.AddWithValue("@PacienteDireccion", paciente.PacienteDireccion);
                    sqlCmd.Parameters.AddWithValue("@PacienteTelefono", paciente.PacienteTelefono);
                    sqlCmd.Parameters.AddWithValue("@PacienteNacimiento", paciente.PacienteNacimiento);
                    sqlCmd.Parameters.AddWithValue("@EECCCodigo", paciente.EECCCodigo);
                    sqlCmd.Parameters.AddWithValue("@GeneroCCodigo", paciente.GeneroCCodigo);

                    sqlCon.Open();
                    int rowsAffected = sqlCmd.ExecuteNonQuery();
                    return rowsAffected == 1 ? "Ok" : "No se Ingreso el Registro";
                }
                catch (Exception ex)
                {                    
                    throw new Exception($"Error al insertar paciente: {ex.Message}");
                }
            } 
        }

        /// <summary>
        /// Metodo Actualizar Pacientes
        /// </summary>
        /// <param name="Paciente"></param>
        /// <returns></returns>        
        public string Actualizar(DPaciente paciente)
        {
            using (SqlConnection sqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand sqlCmd = new SqlCommand("usp_ActualizarPaciente", sqlCon))
            {
                try
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    // Use AddWithValue for cleaner parameter addition
                    sqlCmd.Parameters.AddWithValue("@PacienteCodigo", paciente.PacienteCodigo);
                    sqlCmd.Parameters.AddWithValue("@PacienteNombre", paciente.PacienteNombre);
                    sqlCmd.Parameters.AddWithValue("@PacienteApellido", paciente.PacienteApellido);
                    sqlCmd.Parameters.AddWithValue("@PacienteDireccion", paciente.PacienteDireccion);
                    sqlCmd.Parameters.AddWithValue("@PacienteTelefono", paciente.PacienteTelefono);
                    sqlCmd.Parameters.AddWithValue("@PacienteNacimiento", paciente.PacienteNacimiento);
                    sqlCmd.Parameters.AddWithValue("@EECCCodigo", paciente.EECCCodigo);
                    sqlCmd.Parameters.AddWithValue("@GeneroCCodigo", paciente.GeneroCCodigo);

                    sqlCon.Open();
                    int rowsAffected = sqlCmd.ExecuteNonQuery();
                    return rowsAffected == 1 ? "Ok" : "No se Actualizo el Registro";
                }
                catch (Exception ex)
                {                    
                    throw new Exception($"Error al actualizar paciente: {ex.Message}");
                }
            } 
        }

        /// <summary>
        /// Metodo eliminar pacientes
        /// </summary>
        /// <param name="Paciente"></param>
        /// <returns></returns>
        public string Eliminar(DPaciente paciente)
        {
            using (SqlConnection sqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand sqlCmd = new SqlCommand("usp_EliminarPaciente", sqlCon))
            {
                try
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    // Use AddWithValue for cleaner parameter addition
                    sqlCmd.Parameters.AddWithValue("@PacienteCodigo", paciente.PacienteCodigo);

                    sqlCon.Open();
                    int rowsAffected = sqlCmd.ExecuteNonQuery();
                    return rowsAffected == 1 ? "Ok" : "No se Elimino el Registro";
                }
                catch (Exception ex)
                {                    
                    throw new Exception($"Error al eliminar paciente: {ex.Message}");
                }
            } 
        }

        /// <summary>
        /// Metodo para listar pacientes
        /// </summary>
        /// <returns></returns>
        public DataTable ListarPaciente()
        {
            DataTable dtResultado = new DataTable("paciente");

            using (SqlConnection sqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand sqlCmd = new SqlCommand("usp_ListarPaciente", sqlCon))
            {
                try
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd))
                    {
                        sqlDat.Fill(dtResultado);
                    }
                }
                catch (Exception ex)
                {                    
                    Console.WriteLine($"Error al obtener lista de pacientes: {ex.Message}");
                    throw; 
                }
            }
            return dtResultado;
        }

        /// <summary>
        /// Metodo para buscar pacientes por DNI
        /// </summary>
        /// <returns></returns>
        public DataTable ListarPacienteDNI(DPaciente paciente)
        {
            DataTable dtResultado = new DataTable("paciente");

            using (SqlConnection sqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand sqlCmd = new SqlCommand("usp_ListarPacienteDNI", sqlCon))
            {
                try
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;                    
                    sqlCmd.Parameters.AddWithValue("@PacienteCodigo", paciente.PacienteCodigo);
                    using (SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd))
                    {
                        sqlDat.Fill(dtResultado);
                    }
                }
                catch (Exception ex)
                {                    
                    Console.WriteLine($"Error al obtener paciente por DNI: {ex.Message}");
                    throw; 
                }
            }
            return dtResultado;
        }

        public DataTable BuscaHHCCDni(DPaciente paciente)
        {
            DataTable dtResultado = new DataTable("paciente");

            using (SqlConnection sqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand sqlCmd = new SqlCommand("usp_BuscaHHCCDni", sqlCon))
            {
                try
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@PacienteCodigo", paciente.PacienteCodigo);
                    using (SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd))
                    {
                        sqlDat.Fill(dtResultado);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al obtener HHCC por DNI: {ex.Message}");
                    throw;
                }
            }
            return dtResultado;
        }

    }
}
