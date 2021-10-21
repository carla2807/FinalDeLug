using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_USO.COMPARTIR
{
    public class GESTION_COMPARTIR
    {
        public static MODELO.COMPARTIR OBTENER_COMPARTIR(int CODIGO, CONTEXTO.Biblioteca CATALOGO)
        {
            return CATALOGO.COMPARTIDOS.Include("MATERIAL").FirstOrDefault(_ => _.CODIGO == CODIGO);

        }

        public static List<MODELO.COMPARTIR> OBTENER_COMPARTIR(CONTEXTO.Biblioteca CATALOGO)
        {
            return CATALOGO.COMPARTIDOS.Include("MATERIAL").ToList();
        }

    }
}
