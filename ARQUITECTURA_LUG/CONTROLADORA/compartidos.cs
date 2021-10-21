using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
   public class compartidos
    {
        private static compartidos instancia;

        public static compartidos obtener_instancia()
        {
            if (instancia == null)
                instancia = new compartidos();
            return instancia;
        }



        CONTEXTO.Biblioteca oCONTEXTO;
        private compartidos()
        {
            oCONTEXTO = CONTEXTO.Biblioteca.obtener_instancia();
        }


        public void AGREGAR_COMPARTIR(MODELO.COMPARTIR COMPARTIR)
        {
            CASOS_USO.COMPARTIR.OPERACIONES_COMPARTIR.AGREGAR_COMPARTIR(oCONTEXTO, COMPARTIR);
            oCONTEXTO.SaveChanges();
        }
        public void ELIMINAR_COMPARTIR(MODELO.COMPARTIR COMPARTIR)
        {
            CASOS_USO.COMPARTIR.OPERACIONES_COMPARTIR.ELIMINAR_COMPARTIR(oCONTEXTO, COMPARTIR);
            oCONTEXTO.SaveChanges();
        }
        public void MODIFICAR_COMPARTIR(MODELO.COMPARTIR COMPARTIR)
        {
            CASOS_USO.COMPARTIR.OPERACIONES_COMPARTIR.MODIFICAR_COMPARTIR(oCONTEXTO, COMPARTIR);
            oCONTEXTO.SaveChanges();
        }


        public MODELO.COMPARTIR OBTENER_COMPARTIR(int CODIGO)
        {
            return CASOS_USO.COMPARTIR.GESTION_COMPARTIR.OBTENER_COMPARTIR(CODIGO, oCONTEXTO);
        }


        public List<MODELO.COMPARTIR> OBTENER_COMPARTIR()
        {
            return CASOS_USO.COMPARTIR.GESTION_COMPARTIR.OBTENER_COMPARTIR(oCONTEXTO);
        }



    }
}
