using System;

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
            //Mensaje de bienvenida
            Console.WriteLine("Evidencia de Aprendizaje");

            //Declaracion de variables
            int categoria = 0;
            int dias = 0;
            int extras = 0;

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

                    //Si el dato es mayor manda mensaje o sale del programa
                    if (categoria < 0 || categoria > 5)
                    {
                        Console.WriteLine("Ingrese la categoria correcta.");
                    }
                    if (categoria == 5)
                    {
                        Console.WriteLine("Programa terminado.");
                        Console.ReadLine();
                    }

                    //Ciclo para leer los dias laborados
                    do
                    {
                        Console.WriteLine("Ingrese los dias laborados.");
                        dias = Convert.ToInt32(Console.ReadLine());

                        //Si los dias son mayores a 6 envia mensaje
                        if (dias < 0 || dias > 6)
                        {
                            Console.WriteLine("Maximo 6 dias.");
                        }

                    } while (dias > 6);

                    do
                    {
                        //Leer las horas
                        Console.WriteLine("Ingrese las horas extras.");
                        extras = Convert.ToInt32(Console.ReadLine());

                        //Si son mayor a 10 se fijan en 10
                        if (extras > 10)
                        {
                            Console.WriteLine("Solo seran pagadas 10 horas.");
                            extras = 10;
                        }

                    } while (extras > 10);

                    //Funcion para calcular el sueldo
                    CalcularSueldo(categoria, dias, extras);

                } while (categoria != 5);

            }
            catch (Exception ex)
            {
                //Entrada a la excepcion
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadLine();
            }
        }
        
        //Funcion que calcula el sueldo recibiendo como parametros la categoria, los dias y
        //el numerod de horas extras
        private static void CalcularSueldo(int categoria, int dias, int extras)
        {
            var sueldo = 0;
            var extra = 0;

            switch (categoria)
            {
                case 1:
                    sueldo = (int)Categorias.Uno * dias;
                    extra = (int)Categorias.ExtraUno * extras;
                    break;
                case 2:
                    sueldo = (int)Categorias.Dos * dias;
                    extra = (int)Categorias.ExtraDos * extras;
                    break;
                case 3:
                    sueldo = (int)Categorias.Tres * dias;
                    extra = (int)Categorias.ExtraTres * extras;
                    break;
                case 4:
                    sueldo = (int)Categorias.Cuatro * dias;
                    extra = (int)Categorias.ExtraCuatro * extras;
                    break;
            }

            //Imprimimos en pantalla el sueldo y las horas extras
            Console.WriteLine("Sueldo total: $" + sueldo);
            Console.WriteLine("Horas extras : $" + extra);
            Console.WriteLine();
        }
    }
}
