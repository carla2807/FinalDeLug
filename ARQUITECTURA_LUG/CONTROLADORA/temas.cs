using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class temas
    {
        private static temas instancia;

        public static temas obtener_instancia()
        {
            if (instancia == null)
                instancia = new temas();
            return instancia;
        }

        CONTEXTO.Biblioteca oCONTEXTO;

        private temas()
        {
            oCONTEXTO = CONTEXTO.Biblioteca.obtener_instancia();
        }


        public void AGREGAR_TEMA(MODELO.TEMA TEMA)
        {
            CASOS_USO.TEMA.OPERACIONES_TEMAS.AGREGAR_TEMA(oCONTEXTO, TEMA);
            oCONTEXTO.SaveChanges();
        }


        public void ELIMINAR_TEMA(MODELO.TEMA TEMA)
        {
            CASOS_USO.TEMA.OPERACIONES_TEMAS.ELIMINAR_TEMA(oCONTEXTO, TEMA);
            oCONTEXTO.SaveChanges();
        }

        public void MODIFICAR_TEMA(MODELO.TEMA TEMA)
        {
            CASOS_USO.TEMA.OPERACIONES_TEMAS.MODIFICAR_TEMA(oCONTEXTO, TEMA);
            oCONTEXTO.SaveChanges();
        }

        public MODELO.TEMA OBTENER_TEMA(int CODIGO)
        {
            return CASOS_USO.TEMA.GESTION_TEMAS.OBTENER_TEMA(CODIGO, oCONTEXTO);
        }


        public List<MODELO.TEMA> OBTENER_TEMAS()
        {
            return CASOS_USO.TEMA.GESTION_TEMAS.OBTENER_TEMAS(oCONTEXTO);
        }
    }
}
