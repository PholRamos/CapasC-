using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class NAuxiliares
    {
        SqlConnection SqlCon = new SqlConnection(Conexion.Cn);

        public DataTable CargaComboEspecialidad()
        {
            SqlDataAdapter da = new SqlDataAdapter("usp_CargaComboEspecialidad", SqlCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable CargaComboEECC()
        {
            SqlDataAdapter da = new SqlDataAdapter("usp_CargaComboEECC", SqlCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable CargaComboGenero()
        {
            SqlDataAdapter da = new SqlDataAdapter("usp_CargaComboGenero", SqlCon);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
