using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3
{
    //    Carlos Alberto Graniel Córdova
    //    Es1611301058
    //    Programacion Net I
    //    Actividad 3 Resolver problemas con C#
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            double a, b, c;

            //Texto en pantalla
            Console.WriteLine("Actividad 3 \n Resolver problemas con C#");

            //Try para atrapar el error en caso de que el usuario ingrese un valor que no sea numerico.
            try
            {
                //Obtener los valores
                Console.WriteLine("Ingrese el valor de a");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el valor de b");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el valor de c");
                c = Convert.ToDouble(Console.ReadLine());

                //Llamado al metodo para calcular los valores
                CalcularESG(a, b, c);

                Console.ReadLine();
            }
            catch (Exception e)
            {
                //Entrada a la excepcion
                Console.WriteLine("Error: " + e.Message);
                Console.ReadLine();
            }

        }

        //Metodo para realizar el calculo de la ecuacion de segundo grado
        private static void CalcularESG(double a, double b, double c)
        {
            //comprobacion del discriminante
            var discriminante = ((b * b) - (4 * (a * c)));

            if (discriminante < 0)
            {
                Console.WriteLine("La ecuación no tiene soluciones reales");
            }
            else if (discriminante == 0)
            {
                var x1 = (-b) / (2 * a);
                Console.WriteLine(string.Format("La ecuación tiene solo una raiz real: x1 = x2 : {0}", x1));
            }
            else
            {
                var x1 = (-b) + Math.Sqrt(discriminante) / (2 * a);
                var x2 = (-b) - Math.Sqrt(discriminante) / (2 * a);
                Console.WriteLine(string.Format("La solucion es X1 = {0} y X2 = {1}", x1, x2));

            }
        }
    }
}
