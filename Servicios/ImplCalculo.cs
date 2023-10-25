using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerci2.Servicios
{
    internal class ImplCalculo: InterfazCalculo
    {
        public double calculoExpo(int num, double num1)
        {
            double resultado = 1.0;

            for (int i = 0; i < Math.Abs(num); i++)
            {
                resultado *= num1;
            }

            if (num < 0)
            {
                resultado = 1.0 / resultado;
            }
            Console.WriteLine(resultado);

            return resultado;

        }
    }
}
