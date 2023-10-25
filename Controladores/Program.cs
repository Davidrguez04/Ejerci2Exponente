using Ejerci2.Servicios;
/*Escribe un programa que solicite dos números al usuario (uno tipo double y otro tipo int), 
             * los lea de la consola y calcule el número tipo double elevado al número tipo int, es decir,
             * el tipo double multiplicado por sí mismo tantas veces como indique el tipo int.
              Para hacer la operación deberá utilizarse un bucle.
              El método que solicite los números deberá estar definido en un servicio. El método mostrará el mensaje de 
              petición de los números, recogerá los números escritos en la consola y los devolverá al método main.
              El método que haga el cálculo y muestre el resultado por pantalla también deberá ser definido en 
              un servicio.*/

namespace Ejerci2.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Actividad realizada en la pizarra

            InterfazNumero ni=new ImplNumero();
            InterfazCalculo mi=new ImplCalculo();

            double num = ni.pedirNumero(0);
            int num2=(int)ni.pedirNumero(1);

            mi.calculoExpo(num2, num);

            
        }
    }
}
