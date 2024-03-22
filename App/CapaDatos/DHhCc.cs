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
    public class DHhCc
    {
        private int _hhccCodigo;

        public int HHCCCodigo
        {
            get { return _hhccCodigo; }
            set { _hhccCodigo = value; }
        }

        private DateTime _hhccFecha;

        public DateTime HHCCFecha
        {
            get { return _hhccFecha; }
            set { _hhccFecha = value; }
        }

        private string _pacienteCodigo;

        public string PacienteCodigo
        {
            get { return _pacienteCodigo; }
            set { _pacienteCodigo = value; }
        }

        public DHhCc() { }

        public DHhCc(int HHCCCodigo,
            DateTime HHCCFecha,
            string PacienteCodigo)
        {
            this.HHCCCodigo = HHCCCodigo;
            this.HHCCFecha = HHCCFecha;
            this.PacienteCodigo = PacienteCodigo;            
        }

        public string Insertar(DHhCc Hhcc)
        {
            string rpta = "";

            using (SqlConnection SqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand SqlCmd = new SqlCommand("usp_InsertarHHCC", SqlCon))
            {
                try
                {
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlCmd.Parameters.Add ("@PacienteCodigo", SqlDbType.VarChar,8).Value = Hhcc.PacienteCodigo;
                    

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
        public string Actualizar(DHhCc Hhcc)
        {
            string rpta = "";

            using (SqlConnection SqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand SqlCmd = new SqlCommand("usp_ActualizarHHCC", SqlCon))
            {
                try
                {
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlCmd.Parameters.Add("@HHCCCodigo", SqlDbType.Int).Value = Hhcc.HHCCCodigo;
                    SqlCmd.Parameters.Add("@PacienteCodigo", SqlDbType.VarChar, 8).Value = Hhcc.PacienteCodigo;
                    

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

        public DataTable ListarHHCC()
        {
            DataTable dtResultado = new DataTable("hhcc");

            using (SqlConnection sqlCon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand("usp_ListarHHCC", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                    sqlDat.Fill(dtResultado);
                }
                catch (Exception ex)
                {
                    // Log the exception for further investigation
                    Console.WriteLine("Error al obtener lista de HHCC: " + ex.Message);
                    dtResultado = null;
                }
            }

            return dtResultado;
        }

        public DataTable ListarHHCCDni(DHhCc pacienteCodigo)
        {
            DataTable dtResultado = new DataTable("paciente");

            using (SqlConnection sqlCon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    SqlCommand sqlCmd = new SqlCommand("usp_ListarHHCCDni", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter sqlParam = new SqlParameter("@PacienteCodigo", SqlDbType.VarChar,8)
                    {
                        Value = pacienteCodigo.PacienteCodigo
                    };
                    sqlCmd.Parameters.Add(sqlParam);

                    SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                    sqlDat.Fill(dtResultado);
                }
                catch (Exception ex)
                {
                    // Log the exception for further investigation
                    Console.WriteLine("Error al obtener HHCC por Dni: " + ex.Message);
                    dtResultado = null;
                }
            }

            return dtResultado;
        }

    }
}
