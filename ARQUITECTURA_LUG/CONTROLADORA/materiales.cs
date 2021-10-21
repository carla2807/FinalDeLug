using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class materiales
    {
        private static materiales instancia;

        public static materiales obtener_instancia()
        {
            if (instancia == null)
                instancia = new materiales();
            return instancia;
        }


        CONTEXTO.Biblioteca oCONTEXTO;

        private materiales()
        {
            oCONTEXTO = CONTEXTO.Biblioteca.obtener_instancia();
        }

        public void AGREGAR_MATERIAL(MODELO.MATERIAL MATERIAL)
        {
            CASOS_USO.MATERIAL.OPERACIONES_MATERIALES.AGREGAR_MATERIAL(oCONTEXTO, MATERIAL);
            oCONTEXTO.SaveChanges();
        }
        public void ELIMINAR_MATERIAL(MODELO.MATERIAL MATERIAL)
        {
            CASOS_USO.MATERIAL.OPERACIONES_MATERIALES.ELIMINAR_MATERIAL(oCONTEXTO, MATERIAL);
            oCONTEXTO.SaveChanges();
        }
        public void MODIFICAR_MATERIAL(MODELO.MATERIAL MATERIAL)
        {
            CASOS_USO.MATERIAL.OPERACIONES_MATERIALES.MODIFICAR_MATERIAL(oCONTEXTO, MATERIAL);
            oCONTEXTO.SaveChanges();
        }


        public MODELO.MATERIAL OBTENER_MATERIAL(int CODIGO)
        {
            return CASOS_USO.MATERIAL.GESTION_MATERIALES.OBTENER_MATERIAL(CODIGO, oCONTEXTO);
        }


        public List<MODELO.MATERIAL> OBTENER_MATERIAL()
        {
            return CASOS_USO.MATERIAL.GESTION_MATERIALES.OBTENER_MATERIALES(oCONTEXTO);
        }


    }
}
