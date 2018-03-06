using Actividad3U3.Entities.Libros;
using System;
using System.Collections.Generic;

namespace Actividad3U3
{
    class Program
    {
        //    Carlos Alberto Graniel Córdova
        //    Es1611301058
        //    Programacion Net I
        //    Actividad 3 Unidad 3

        //Declaracion de una lista que contiene objetos del tipo Libro
        public static List<Libro> libros = new List<Libro>()
            {
                new Libro("La Biblia","Varios",5),
                new Libro("Citas del Presidente Mao Tse-Tung","Mao Tse-Tung",8),
                new Libro("Harry Potter","J.K. Rowling",8),
                new Libro("El señor de los anillos","J.R.R. Tolkien",12),
                new Libro("El alquimista","Paulo Coelho",3),
                new Libro("El Codigo Da Vinci","Dan Brown",4),
            };

        static void Main(string[] args)
        {

            var opcion = 0;

            Console.WriteLine("Actividad 3 Unidad 3");

            //Try para la excepcion en caso de que se inserte un valor no numerico
            try
            {
                //ciclo para elegir las opciones del menu
                do
                {
                    Console.WriteLine("Selecciona una opcion");
                    Console.WriteLine("1.-Listar los libros");
                    Console.WriteLine("2.-Mostrar datos libro");
                    Console.WriteLine("3.-Prestar un libro");
                    Console.WriteLine("4.-Devolver un libro");
                    Console.WriteLine("5.-Salir");

                    //leer el dato desde teclado
                    opcion = Convert.ToInt32(Console.ReadLine());

                    //Switch de opciones
                    switch (opcion)
                    {
                        //Cada case tiene su propia función
                        case 1:
                            ListarLibros();
                            break;
                        case 2:
                            MostrarDatosLibros();
                            break;
                        case 3:
                            PrestarLibro();
                            break;
                        case 4:
                            DevolverLibro();
                            break;
                    }

                    //Si el dato es mayor manda mensaje
                    if (opcion < 0 || opcion > 5)
                    {
                        Console.WriteLine("Ingrese la categoria correcta.");
                    }

                } while (opcion != 5);

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

        private static void DevolverLibro()
        {
            int opcion = 0;
            Console.WriteLine("Elige el libro a devolver");
            ListarLibros();
            opcion = Convert.ToInt32(Console.ReadLine());
            libros[opcion].Devolucion();
        }

        private static void PrestarLibro()
        {
            int opcion = 0;
            Console.WriteLine("Elige el libro a prestar");
            ListarLibros();
            opcion = Convert.ToInt32(Console.ReadLine());
            libros[opcion].Prestamo();
        }

        private static void ListarLibros()
        {
            for (int i = 0; i < libros.Count; i++)
            {
                Console.WriteLine(i+".-"+libros[i].Titulo);
            }
        }

        private static void MostrarDatosLibros()
        {
            int opcion = 0;
            Console.WriteLine("Elige el libro a mostrar");
            ListarLibros();
            opcion = Convert.ToInt32(Console.ReadLine());
            libros[opcion].Datos();
        }
    }
}
