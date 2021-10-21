using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_USO.MATERIAL
{
   public class GESTION_MATERIALES
    {

        public static MODELO.MATERIAL OBTENER_MATERIAL(int CODIGO, CONTEXTO.Biblioteca CATALOGO)
        {
            return CATALOGO.MATERIALES.Include("TEMA").FirstOrDefault(_ => _.CODIGO == CODIGO);

        }

        public static List<MODELO.MATERIAL> OBTENER_MATERIALES(CONTEXTO.Biblioteca CATALOGO)
        {
            return CATALOGO.MATERIALES.Include("TEMA").ToList();
        }
    }
}
