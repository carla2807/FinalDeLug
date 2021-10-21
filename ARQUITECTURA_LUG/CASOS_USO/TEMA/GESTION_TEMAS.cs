using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS_USO.TEMA
{
    public class GESTION_TEMAS
    {
        public static MODELO.TEMA OBTENER_TEMA(int CODIGO, CONTEXTO.Biblioteca CATALOGO)
        {
            return CATALOGO.TEMAS.FirstOrDefault(_ => _.CODIGO == CODIGO);

        }

        public static List<MODELO.TEMA> OBTENER_TEMAS(CONTEXTO.Biblioteca CATALOGO)
        {
            return CATALOGO.TEMAS.ToList();
        }

    }
}
