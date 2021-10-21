using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_USO.COMPARTIR
{
    public class OPERACIONES_COMPARTIR
    {
        public static void AGREGAR_COMPARTIR(CONTEXTO.Biblioteca CATALOGO, MODELO.COMPARTIR COMPARTIR)
        {
            CATALOGO.COMPARTIDOS.Add(COMPARTIR);
        }

        public static void ELIMINAR_COMPARTIR(CONTEXTO.Biblioteca CATALOGO, MODELO.COMPARTIR COMPARTIR)
        {
            CATALOGO.COMPARTIDOS.Remove(COMPARTIR);
        }

        public static void MODIFICAR_COMPARTIR(CONTEXTO.Biblioteca CATALOGO, MODELO.COMPARTIR COMPARTIR)
        {
            CATALOGO.Entry(COMPARTIR).State = System.Data.Entity.EntityState.Modified;
        }

    }
}
