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
    public class DEspecialista
    {
        /// <summary>
        /// Creacion de los atributos del objeto DEspecialista
        /// </summary>
        #region Propiedades

        public int EspecialistaCMP { get; set; }
        public string EspecialistaNombre { get; set; }
        public string EspecialistaApellido { get; set; }
        public int EspecialidadCodigo { get; set; }

        #endregion

        #region Constructores

        public DEspecialista() { }

        public DEspecialista(int especialistaCMP, string especialistaNombre, string especialistaApellido, int especialidadCodigo)
        {
            EspecialistaCMP = especialistaCMP;
            EspecialistaNombre = especialistaNombre;
            EspecialistaApellido = especialistaApellido;
            EspecialidadCodigo = especialidadCodigo;
        }

        #endregion

        /// <summary>
        /// Creacion de las operacion o metodos
        /// </summary>
        /// <param name="Paciente"></param>
        /// <returns></returns>
        public string Insertar(DEspecialista Especialista)
        {
            string rpta = "";

            using (SqlConnection SqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand SqlCmd = new SqlCommand("usp_InsertarEspecialista", SqlCon))
            {
                try
                {
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlCmd.Parameters.Add("@EspecialistaCMP", SqlDbType.Int).Value = Especialista.EspecialistaCMP;
                    SqlCmd.Parameters.Add("@EspecialistaNombre", SqlDbType.VarChar, 30).Value = Especialista.EspecialistaNombre;
                    SqlCmd.Parameters.Add("@EspecialistaApellido", SqlDbType.VarChar, 50).Value = Especialista.EspecialistaApellido;
                    SqlCmd.Parameters.Add("@EspecialidadCodigo", SqlDbType.Int).Value = Especialista.EspecialidadCodigo;
                    
                    SqlCon.Open();
                    rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se Ingreso el Registro";

                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                finally
                {
                    if (SqlCon.State == ConnectionState.Open) { SqlCon.Close(); }
                }
                return rpta;
            }
        }

        public string Actualizar(DEspecialista Especialista)
        {
            string rpta = "";

            using (SqlConnection SqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand SqlCmd = new SqlCommand("usp_ActualizarEspecialista", SqlCon))
            {
                try
                {
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlCmd.Parameters.Add("@EspecialistaCMP", SqlDbType.Int).Value = Especialista.EspecialistaCMP;
                    SqlCmd.Parameters.Add("@EspecialistaNombre", SqlDbType.VarChar, 30).Value = Especialista.EspecialistaNombre;
                    SqlCmd.Parameters.Add("@EspecialistaApellido", SqlDbType.VarChar, 50).Value = Especialista.EspecialistaApellido;
                    SqlCmd.Parameters.Add("@EspecialidadCodigo", SqlDbType.Int).Value = Especialista.EspecialidadCodigo;

                    SqlCon.Open();
                    rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se Actualizo el Registro";

                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                finally
                {
                    if (SqlCon.State == ConnectionState.Open) { SqlCon.Close(); }
                }
                return rpta;
            }
        }

        public string Eliminar(DEspecialista Especialista)
        {
            string rpta = "";

            using (SqlConnection SqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand SqlCmd = new SqlCommand("EliminarEspecialista", SqlCon))
            {
                try
                {
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlCmd.Parameters.Add("@EspecialistaCMP", SqlDbType.Int).Value = Especialista.EspecialistaCMP;
                    

                    SqlCon.Open();
                    rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se Elimino el Registro";

                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
                finally
                {
                    if (SqlCon.State == ConnectionState.Open) { SqlCon.Close(); }
                }
                return rpta;
            }
        }

        public DataTable ListarEspecialista()
        {
            DataTable dtResultado = new DataTable("especialista");

            using (SqlConnection sqlCon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand("usp_ListaEspecialista", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                    sqlDat.Fill(dtResultado);
                }
                catch (Exception ex)
                {                    
                    Console.WriteLine("Error al obtener lista de especialistas: " + ex.Message);
                    dtResultado = null;
                }
            }
            return dtResultado;
        }

        public DataTable ListarEspecialistaCMP(DEspecialista Especialista)
        {
            DataTable dtResultado = new DataTable("especialista");

            using (SqlConnection sqlCon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand("usp_ListaEspecialistaCMP", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter sqlParam = new SqlParameter("@EspecialistaCMP", SqlDbType.Int)
                    {
                        Value = Especialista.EspecialistaCMP
                    };
                    sqlCmd.Parameters.Add(sqlParam);

                    SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                    sqlDat.Fill(dtResultado);
                }
                catch (Exception ex)
                {                    
                    Console.WriteLine("Error al obtener especislista por CMP: " + ex.Message);
                    dtResultado = null;
                }
            }
            return dtResultado;
        }
    }
}
