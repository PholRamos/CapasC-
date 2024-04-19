using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class NActoMedico
    {
        public static string Insertar
            (DateTime actomedicofecha, int hhcccodigo, 
            int especialistacmp,string ActoMedicoObservacion)
        {
            DActoMedico ObjActoMedico = new DActoMedico();

            ObjActoMedico.ActoMedicoFecha = actomedicofecha;
            ObjActoMedico.HHCCCodigo = hhcccodigo;
            ObjActoMedico.EspecialistaCMP = especialistacmp;
            ObjActoMedico.ActoMedicoObservacion = ActoMedicoObservacion;

            return ObjActoMedico.Insertar(ObjActoMedico);
        }

        public static string Actualizar
            (int actomedicocodigo, DateTime actomedicofecha, int hhcccodigo,
            int especialistacmp, string ActoMedicoObservacion)
        {
            DActoMedico ObjActoMedico = new DActoMedico();

            ObjActoMedico.ActoMedicoCodigo = actomedicocodigo;
            ObjActoMedico.ActoMedicoFecha = actomedicofecha;
            ObjActoMedico.HHCCCodigo = hhcccodigo;
            ObjActoMedico.EspecialistaCMP = especialistacmp;
            ObjActoMedico.ActoMedicoObservacion = ActoMedicoObservacion;

            return ObjActoMedico.Actualizar(ObjActoMedico);
        }

        public static DataTable ListarActoMedico()
        {
            return new DActoMedico().ListarActoMedico();
        }

        public static DataTable ListarActoMedicoCodigo(int actomedicocodigo)
        {
            DActoMedico ObjActoMedico = new DActoMedico();

            ObjActoMedico.ActoMedicoCodigo = actomedicocodigo;

            return ObjActoMedico.ListarActoMedicoCodigo(ObjActoMedico);
        }
    }
}
