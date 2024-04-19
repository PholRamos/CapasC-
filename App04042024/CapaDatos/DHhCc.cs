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
        /// <summary>
        /// Creacion de los atributos del objeto Historia clinica
        /// </summary>
        #region Propiedades
        public int HHCCCodigo { get; set; }
        public DateTime HHCCFecha { get; set; }
        public string PacienteCodigo { get; set; }
        #endregion

        #region Constructores
        public DHhCc() { }

        public DHhCc(int hhccCodigo, DateTime hhccFecha, string pacienteCodigo)
        {
            HHCCCodigo = hhccCodigo;
            HHCCFecha = hhccFecha;
            PacienteCodigo = pacienteCodigo;
        }
        #endregion

        /// <summary>
        /// Operacion insertar del Objeto Historia Clinica
        /// </summary>
        /// <param name="hhcc"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string Insertar(DHhCc hhcc)
        {
            using (SqlConnection sqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand sqlCmd = new SqlCommand("usp_InsertarHHCC", sqlCon))
            {
                try
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    
                    sqlCmd.Parameters.AddWithValue("@PacienteCodigo", hhcc.PacienteCodigo);
                    //sqlCmd.Parameters.AddWithValue("@HHCCFecha", hhcc.HHCCFecha); 

                    sqlCon.Open();
                    int rowsAffected = sqlCmd.ExecuteNonQuery();
                    return rowsAffected == 1 ? "Ok" : "No se Ingreso el Registro";
                }
                catch (Exception ex)
                {                    
                    throw new Exception($"Error al insertar registro HHCC: {ex.Message}");
                }
            } 
        }

        /// <summary>
        /// Operacion actualizar del Objeto Historia Clinica
        /// </summary>
        /// <param name="hhcc"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string Actualizar(DHhCc hhcc)
        {
            using (SqlConnection sqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand sqlCmd = new SqlCommand("usp_ActualizarHHCC", sqlCon))
            {
                try
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    
                    sqlCmd.Parameters.AddWithValue("@HHCCCodigo", hhcc.HHCCCodigo);
                    sqlCmd.Parameters.AddWithValue("@PacienteCodigo", hhcc.PacienteCodigo);
                    //sqlCmd.Parameters.AddWithValue("@HHCCFecha", hhcc.HHCCFecha);

                    sqlCon.Open();
                    int rowsAffected = sqlCmd.ExecuteNonQuery();
                    return rowsAffected == 1 ? "Ok" : "No se Actualizo el Registro";
                }
                catch (Exception ex)
                {                    
                    throw new Exception($"Error al actualizar registro HHCC: {ex.Message}");
                }
            } 
        }

        /// <summary>
        ///Operacion listar del Objeto Historia Clinica 
        /// </summary>
        /// <returns></returns>
        public DataTable ListarHHCC()
        {
            DataTable dtResultado = new DataTable("hhcc");

            using (SqlConnection sqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand sqlCmd = new SqlCommand("usp_ListarHHCC", sqlCon))
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
                    Console.WriteLine($"Error al obtener lista de HHCC: {ex.Message}");
                    throw; 
                }
            }
            return dtResultado;
        }

        /// <summary>
        /// Operacion listar por DNI del Objeto Historia Clinica
        /// </summary>
        /// <param name="hhcc"></param>
        /// <returns></returns>
        public DataTable ListarHHCCDni(DHhCc hhcc)
        {
            DataTable dtResultado = new DataTable("hhcc"); 
            using (SqlConnection sqlCon = new SqlConnection(Conexion.Cn))
            using (SqlCommand sqlCmd = new SqlCommand("usp_ListarHHCCDni", sqlCon))
            {
                try
                {
                    sqlCmd.CommandType = CommandType.StoredProcedure;                    
                    sqlCmd.Parameters.AddWithValue("@PacienteCodigo", hhcc.PacienteCodigo);
                    using (SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd))
                    {
                        sqlDat.Fill(dtResultado);
                    }
                }
                catch (Exception ex)
                {                    
                    Console.WriteLine($"Error al obtener HHCC por Dni: {ex.Message}");
                    throw; 
                }
            }
            return dtResultado;
        }


    }
}
