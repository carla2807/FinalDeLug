using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MATERIAL
    {
        public int CODIGO { get; set; }
        public string TITULO { get; set; }
        public TEMA TEMA { get; set; }
        public string NOMBRE_AUTOR { get; set; }
        public int AÑO_EDICION { get; set; }
        public string TIPO_MATERIAL { get; set; }

       
        public override string ToString()
        {
            return TITULO;
        }
    }

    

    public class IMPRESO: MATERIAL
    {
        public int CANTIDAD_HOJAS { get; set; }
        public string ENCUADERNADO { get; set; }
    }

    public class DIGITAL: MATERIAL
    {
        public string NOMBRE_ARCHIVO { get; set; }
        public int TAMAÑO_MEGABYTE { get; set; }
    }
}
