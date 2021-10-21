using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_USO.MATERIAL
{
    public class OPERACIONES_MATERIALES
    {
        public static void AGREGAR_MATERIAL(CONTEXTO.Biblioteca CATALOGO, MODELO.MATERIAL MATERIAL)
        {
            CATALOGO.MATERIALES.Add(MATERIAL);
        }

        public static void ELIMINAR_MATERIAL(CONTEXTO.Biblioteca CATALOGO, MODELO.MATERIAL MATERIAL)
        {
            CATALOGO.MATERIALES.Remove(MATERIAL);
        }

        public static void MODIFICAR_MATERIAL(CONTEXTO.Biblioteca CATALOGO, MODELO.MATERIAL MATERIAL)
        {
            CATALOGO.Entry(MATERIAL).State = System.Data.Entity.EntityState.Modified;
        }

    }
}
