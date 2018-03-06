using System;

namespace Actividad3U2
{
    class Program
    {
        //    Carlos Alberto Graniel Córdova
        //    Es1611301058
        //    Programacion Net I Unidad 2
        //    Unidad 2. Actividad 3. Programa con estructuras de control cíclicas

        static void Main(string[] args)
        {
            var opcion = 0;
            //Try para la excepcion en caso de que se inserte un valor no numerico
            try
            {
                //ciclo para elegir las opciones del menu
                do
                {
                    Console.WriteLine("Selecciona una opcion");
                    Console.WriteLine("1.-Imprimir los números impares del 1 al 100, (utilizando la estructura while).");
                    Console.WriteLine("2.-Introducir números positivos y calcular la suma de ellos, se terminará cuando se introduzca un número negativo o cero. (utilizando do while)");
                    Console.WriteLine("3.-Mostrar los primeros 8 números pares positivos. (utilizando for)");
                    Console.WriteLine("4.-Salir");

                    //leer el dato desde teclado
                    opcion = Convert.ToInt32(Console.ReadLine());

                    //Switch de opciones
                    switch (opcion)
                    {
                        //Cada case tiene su propia función
                        case 1:
                            ImpNumerosImpares();
                            break;
                        case 2:
                            SumarNumero();
                            break;
                        case 3:
                            NumeroPares();
                            break;
                    }

                    //Si el dato es mayor manda mensaje
                    if (opcion < 0 || opcion > 4)
                    {
                        Console.WriteLine("Ingrese la categoria correcta.");
                    }

                } while (opcion != 4);

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

        private static void NumeroPares()
        {
            //El ciclo for recorre los primeros 17 numeros
            //mediante el operador de modulo compara si el resultado
            //regresa o no residuo, si no regresa
            //quiere decir que es un numero par
            for (int i = 1; i <= 17; i++)
            {
                //implementacion del operador modulo
                if (i % 2 == 0)
                {
                    Console.WriteLine(string.Format("El {0} es un numero par.", i));
                }
            }
            Console.WriteLine("Funcion terminada");
        }

        private static void SumarNumero()
        {
            var suma = 0;
            var aux = 0;
            //el ciclo do-while se ejecuta hasta que el valor auxiliar
            //el cual es ingresado por el usuario es igual o menor a cero
            //mientras tanto, va sumando los valores en la variable suma
            do
            {
                Console.WriteLine("Ingresa un numero");
                aux = Convert.ToInt32(Console.ReadLine());
                suma += aux;

            } while (aux > 0);

            Console.WriteLine("suma terminada");
            Console.WriteLine("Total " + suma);
        }

        private static void ImpNumerosImpares()
        {
            var num = 0;

            //mientras el valor num es menor o igual a 100
            //el operador modulo compara si el residuo es distinto
            //a cero para saber que el numero en cuestion es impar
            //usando una variable bandera para ir incrementando hasta llegar a 100
            while (num <= 100)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine("Numero impar: " + num);
                }
                num++;
            }
            Console.WriteLine("Funcion terminada");
        }
    }
}
