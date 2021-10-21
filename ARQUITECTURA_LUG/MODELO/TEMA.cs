using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class TEMA
    {
        public int CODIGO { get; set; }
        public string TEMA_LIBRO { get; set; }

        //Metodo
        public override string ToString()
        {
            return TEMA_LIBRO;
        }
    }
}
