using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenciaU2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (NumerosPrimos(Leer()))
            {
                Console.WriteLine("Es un numero primo");
            }
            else
            {
                Console.WriteLine("No es numero primo");
            }

            Console.ReadLine();

        }

        private static bool NumerosPrimos(int v)
        {
            int contador = 2;
            var primo = true;
            while (primo && (contador != v))
            {
                if (v % contador == 0)
                {
                    primo = false;
                    contador++;
                }
            }
            return primo;
        }

        private static int Leer()
        {
            var num = 0;
            try
            {
                Console.WriteLine("Ingrese un numero");
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                //Entrada a la excepcion
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadLine();
            }
            return num;
        }
    }
}
