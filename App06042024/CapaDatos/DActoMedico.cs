using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DActoMedico
    {
        /// <summary>
        /// Creacion de los atributos del objeto DEspecialista
        /// </summary>
        #region Propiedades

        public int ActoMedicoCodigo { get; set; }
        public DateTime ActoMedicoFecha { get; set; }
        public int HHCCCodigo { get; set; }
        public int EspecialistaCMP { get; set; }
        public string ActoMedicoObservacion { get; set; }

        #endregion

        #region Constructores

        public DActoMedico() { }

        public DActoMedico
            (int actoMedicoCodigo, DateTime actoMedicoFecha, 
            int hHCCCodigo, int especialistaCMP, 
            string actoMedicoObservacion)
        {
            ActoMedicoCodigo = actoMedicoCodigo;
            ActoMedicoFecha = actoMedicoFecha;
            HHCCCodigo = hHCCCodigo;
            EspecialistaCMP = especialistaCMP;
            ActoMedicoObservacion = actoMedicoObservacion;
        }
        #endregion

        #region Operaciones
        public string Insertar(DActoMedico ActoMedico)
        {
            string rpta = "";

            using (SqlConnection SqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand SqlCmd = new SqlCommand("usp_InsertarActoMedico", SqlCon))
            {
                try
                {
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlCmd.Parameters.Add("@ActoMedicoFecha", SqlDbType.DateTime).Value = ActoMedico.ActoMedicoFecha;
                    SqlCmd.Parameters.Add("@HHCCCodigo", SqlDbType.Int).Value = ActoMedico.HHCCCodigo;
                    SqlCmd.Parameters.Add("@EspecialistaCMP", SqlDbType.Int).Value = ActoMedico.EspecialistaCMP;
                    SqlCmd.Parameters.Add("@ActoMedicoObservacion", SqlDbType.VarChar,250).Value = ActoMedico.ActoMedicoObservacion;                    

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

        public string Actualizar(DActoMedico ActoMedico)
        {
            string rpta = "";

            using (SqlConnection SqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand SqlCmd = new SqlCommand("usp_ActualizarActoMedico", SqlCon))
            {
                try
                {
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlCmd.Parameters.Add("@ActoMedicoCodigo", SqlDbType.Int).Value = ActoMedico.ActoMedicoCodigo;
                    SqlCmd.Parameters.Add("@ActoMedicoFecha", SqlDbType.DateTime).Value = ActoMedico.ActoMedicoFecha;
                    SqlCmd.Parameters.Add("@HHCCCodigo", SqlDbType.Int).Value = ActoMedico.HHCCCodigo;
                    SqlCmd.Parameters.Add("@EspecialistaCMP", SqlDbType.Int).Value = ActoMedico.EspecialistaCMP;
                    SqlCmd.Parameters.Add("@ActoMedicoObservacion", SqlDbType.VarChar, 250).Value = ActoMedico.ActoMedicoObservacion;

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

        public DataTable ListarActoMedico()
        {
            DataTable dtResultado = new DataTable("actomedico");

            using (SqlConnection sqlCon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand("usp_ListarActoMedico", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                    sqlDat.Fill(dtResultado);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener lista de actos medicos: " + ex.Message);
                    dtResultado = null;
                }
            }
            return dtResultado;
        }

        public DataTable ListarActoMedicoCodigo(DActoMedico ActoMedico)
        {
            DataTable dtResultado = new DataTable("actocodigo");

            using (SqlConnection sqlCon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand("usp_ListarActoMedicoCodigo", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter sqlParam = new SqlParameter("@ActoMedicoCodigo", SqlDbType.Int)
                    {
                        Value = ActoMedico.ActoMedicoCodigo
                    };
                    sqlCmd.Parameters.Add(sqlParam);

                    SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                    sqlDat.Fill(dtResultado);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener acto medico por codigo: " + ex.Message);
                    dtResultado = null;
                }
            }
            return dtResultado;
        }
        #endregion
    }
}
