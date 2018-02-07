using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2U2
{
    class Program
    {
        //    Carlos Alberto Graniel Córdova
        //    Es1611301058
        //    Programacion Net I Unidad 2
        //    Unidad 2. Actividad 2. Programa con estructuras de control selectivas

        static void Main(string[] args)
        {
            Console.WriteLine("Evidencia de Aprendizaje");
            int categoria = 0;
            int dias = 0;
            int horas = 0;

            //Try para la excepcion en caso de que se inserte un valor no numerico
            try
            {
                //Obtener los valores
                //ciclo para esperar un valor correcto
                do
                {
                    Console.WriteLine("Ingrese la categoria del trabajador");
                    Console.WriteLine("1.-Categoria Uno");
                    Console.WriteLine("2.-Categoria Dos");
                    Console.WriteLine("3.-Categoria Tres");
                    Console.WriteLine("4.-Categoria Cuatro");
                    Console.WriteLine("5.-Salir");
                    //leer el dato desde teclado
                    categoria = Convert.ToInt32(Console.ReadLine());

                    if (categoria < 0 || categoria > 5)
                    {
                        Console.WriteLine("Ingrese la categoria correcta.");
                    }

                    Console.WriteLine("Ingrese los dias laborados.");
                    dias = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese las horas laboradas.");
                    horas = Convert.ToInt32(Console.ReadLine());

                    var sueldo = 0;

                    switch (categoria)
                    {
                        case 1:
                            sueldo = (int)Categorias.Uno;
                            break;
                        case 2:
                            sueldo = (int)Categorias.Dos;
                            break;
                        case 3:
                            sueldo = (int)Categorias.Tres;
                            break;
                        case 4:
                            sueldo = (int)Categorias.Cuatro;
                            break;
                    }

                    CalcularSueldo(categoria, dias, horas);

                } while (categoria != 5);

                ////creacion de un objeto del tipo transaccion pasandole como parametro la cantidad a retirar
                //var transaccion = new Transaccion(cantidad);
                ////llamada al metodo publico calcular retiro
                //transaccion.CalcularRetiro();
                Console.WriteLine("Programa terminado.");
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
