using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class COMPARTIR
    {
        public int CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public DateTime FECHA { get; set; }
        public MATERIAL MATERIAL {get;set;}

        public int REGISTRAR_DIAS
        {
            //Llamo al metodo
            get { return CALCULAR_DIAS(); }
        }

        //Creo metodo CALCULAR_DIAS. Con TimeSpan voy a obtener dias transcurridos
        public int CALCULAR_DIAS()
        {
            TimeSpan tSpan = FECHA - DateTime.Now;
            int dias = tSpan.Days;
            return dias;
        }

    }
}
