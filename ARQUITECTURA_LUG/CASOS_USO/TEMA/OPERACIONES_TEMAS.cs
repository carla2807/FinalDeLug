using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_USO.TEMA
{
    public class OPERACIONES_TEMAS
    {
        public static void AGREGAR_TEMA(CONTEXTO.Biblioteca CATALOGO, MODELO.TEMA TEMA)
        {
            CATALOGO.TEMAS.Add(TEMA);
        }

        public static void ELIMINAR_TEMA(CONTEXTO.Biblioteca CATALOGO, MODELO.TEMA TEMA)
        {
            CATALOGO.TEMAS.Remove(TEMA);
        }

        public static void MODIFICAR_TEMA(CONTEXTO.Biblioteca CATALOGO, MODELO.TEMA TEMA)
        {
            CATALOGO.Entry(TEMA).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
