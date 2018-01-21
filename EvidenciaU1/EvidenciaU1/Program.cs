using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenciaU1
{
    //    Carlos Alberto Graniel Córdova
    //    Es1611301058
    //    Programacion Net I
    //    Evidencia de Aprendizaje
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variable
            int cantidad;
            //Mensaje de bienvenida
            Console.WriteLine("Evidencia de Aprendizaje");

            //Try para la excepcion en caso de que se inserte un valor no numerico
            try
            {
                //Obtener los valores
                //ciclo para esperar un valor correcto
                do
                {
                    Console.WriteLine("Ingrese la cantidad a retirar");
                    //leer el dato desde teclado
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    //uso del modulo para saber si el dato es correcto
                    if (cantidad % 50 > 1)
                    {
                        Console.WriteLine("Ingrese una cantidad con multiplos de 50");
                        Console.ReadLine();
                        Console.Clear();
                    }


                } while (cantidad % 50 > 1);

                //creacion de un objeto del tipo transaccion pasandole como parametro la cantidad a retirar
                var transaccion = new Transaccion(cantidad);
                //llamada al metodo publico calcular retiro
                transaccion.CalcularRetiro();
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                //Entrada a la excepcion
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadLine();
            }

        }
    }
}
