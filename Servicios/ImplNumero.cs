using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerci2.Servicios
{
    internal class ImplNumero:InterfazNumero
    {
        public double pedirNumero(int k)
        {
            
            if(k == 0)
            {
                Console.WriteLine("Introduzca un número double: ");
            }
            else
            {
                Console.WriteLine("Introduzca un número entero: ");
            }

            double num=Convert.ToDouble(Console.ReadLine());

            return num;

        }
    }
}
