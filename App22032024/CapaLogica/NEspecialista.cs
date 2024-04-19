using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class NEspecialista
    {
        /// <summary>
        /// Creacion de las condiciones, variables y entornos 
        /// para ejecutar y hacer funcionar las operaciones de la capa de datos
        /// </summary>
        /// <param name="especialistacmp"></param>
        /// <param name="especialistanombre"></param>
        /// <param name="especialistaapellido"></param>
        /// <param name="especialidadcodigo"></param>
        /// <returns></returns>
        public static string Insertar(int especialistacmp, string especialistanombre, string especialistaapellido, int especialidadcodigo)
        {
            DEspecialista ObjEspecialista = new DEspecialista();

            ObjEspecialista.EspecialistaCMP = especialistacmp;
            ObjEspecialista.EspecialistaNombre = especialistanombre;
            ObjEspecialista.EspecialistaApellido = especialistaapellido;
            ObjEspecialista.EspecialidadCodigo = especialidadcodigo;

            return ObjEspecialista.Insertar(ObjEspecialista);
        }

        public static string Actualizar(int especialistacmp, string especialistanombre, string especialistaapellido, int especialidadcodigo)
        {
            DEspecialista ObjEspecialista = new DEspecialista();

            ObjEspecialista.EspecialistaCMP = especialistacmp;
            ObjEspecialista.EspecialistaNombre = especialistanombre;
            ObjEspecialista.EspecialistaApellido = especialistaapellido;
            ObjEspecialista.EspecialidadCodigo = especialidadcodigo;

            return ObjEspecialista.Actualizar(ObjEspecialista);
        }

        public static string Eliminar(int especialistacmp)
        {
            DEspecialista ObjEspecialista = new DEspecialista();

            ObjEspecialista.EspecialistaCMP = especialistacmp;            

            return ObjEspecialista.Eliminar(ObjEspecialista);
        }

        public static DataTable ListarEspecialista()
        {
            return new DEspecialista().ListarEspecialista();
        }

        public static DataTable ListarEspecialistaCMP(int especialistacmp)
        {
            DEspecialista ObjEspecialista = new DEspecialista();

            ObjEspecialista.EspecialistaCMP = especialistacmp;

            return ObjEspecialista.ListarEspecialistaCMP(ObjEspecialista);
        }
    }
}
