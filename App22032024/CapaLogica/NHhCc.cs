using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class NHhCc
    {
        public static string Insertar(string pacientecodigo)
        {
            DHhCc ObjDHhCc = new DHhCc();

            ObjDHhCc.PacienteCodigo = pacientecodigo;
            

            return ObjDHhCc.Insertar(ObjDHhCc);
        }

        public static string Actualizar(int hhccCodigo, string pacientecodigo)
        {
            DHhCc ObjDHhCc = new DHhCc();

            ObjDHhCc.HHCCCodigo = hhccCodigo;
            ObjDHhCc.PacienteCodigo = pacientecodigo;            

            return ObjDHhCc.Actualizar(ObjDHhCc);
        }

        public static DataTable ListarHHCC()
        {
            return new DHhCc().ListarHHCC();
        }

        public static DataTable ListarHHCCDNI(string pacientecodigo)
        {
            DHhCc ObjDHhCc = new DHhCc();

            ObjDHhCc.PacienteCodigo = pacientecodigo;

            return ObjDHhCc.ListarHHCCDni(ObjDHhCc);
        }
    }
}
