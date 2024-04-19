using System;
using System.Data;
using CapaDatos;

namespace CapaLogica
{
    public class NHhCc
    {
        public static string Insertar(int HHCCCodigo, DateTime HHCCFecha, string PacienteCodigo)
        {
            DHhCc Objhhcc = new DHhCc();

            Objhhcc.HHCCCodigo = HHCCCodigo;
            Objhhcc.HHCCFecha = HHCCFecha;
            Objhhcc.PacienteCodigo = PacienteCodigo;

            return Objhhcc.Insertar(Objhhcc);
        }

        public static string Actualizar(int HHCCCodigo, DateTime HHCCFecha, string PacienteCodigo)
        {
            DHhCc Objhhcc = new DHhCc();

            Objhhcc.HHCCCodigo = HHCCCodigo;
            Objhhcc.HHCCFecha = HHCCFecha;
            Objhhcc.PacienteCodigo = PacienteCodigo;

            return Objhhcc.Actualizar(Objhhcc);
        }

        public static DataTable ListarHHCC()
        {
            return new DHhCc().ListarHHCC();
        }

        public static DataTable ListarCCHHDni(string CodigoPaciente)
        {
            DHhCc Objhhcc = new DHhCc();
            Objhhcc.PacienteCodigo = CodigoPaciente;

            return Objhhcc.ListarCCHHDni(Objhhcc);
        }
    }
}
