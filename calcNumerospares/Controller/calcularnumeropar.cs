using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcNumerospares.Controller
{
    internal class calcularnumeropar
    {
        public string Calcular(int valor)
        {

            string resul = "";

            for (int  i = 0; i <= valor; i += 2 )
            {
                resul +=  + i + ",";
            }
            return resul;
        }
    }
}
