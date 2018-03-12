using Actividad4U3.Entidades.Personas;
using System;
using System.Collections.Generic;

namespace Actividad4U3
{
    class Program
    {
        //    Carlos Alberto Graniel Córdova
        //    Es1611301058
        //    Programacion Net I
        //    Actividad 4 Unidad 3

        static List<PersonaData> lista = new List<PersonaData>();

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
                    Console.WriteLine("1.-Listar personas");
                    Console.WriteLine("2.-Mostrar datos de las personas");
                    Console.WriteLine("3.-Ingresar persona");
                    Console.WriteLine("4.-Salir");

                    //leer el dato desde teclado
                    opcion = Convert.ToInt32(Console.ReadLine());

                    //Switch de opciones
                    switch (opcion)
                    {
                        //Cada case tiene su propia función
                        case 1:
                            ListarPersonas();
                            break;
                        case 2:
                            MostrarPersonas();
                            break;
                        case 3:
                            IngresarPersona();
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

        //Metodo para mostrar personas
        private static void MostrarPersonas()
        {
            int opcion = 0;
            Console.WriteLine("Selecciona la persona para mostrar la informacion");
            var hayPersonas = ListarPersonas();
            if (hayPersonas)
            {
                opcion = Convert.ToInt32(Console.ReadLine());
                var data = lista[opcion].MostrarInformacion();
                Console.WriteLine("Nombre: " + data.Nombre);
                Console.WriteLine("RFC : " + data.RFC);
                Console.WriteLine("Edad : " + data.Edad);
                Console.WriteLine("Sexo : " + data.Sexo);
                Console.WriteLine("Peso : " + data.Peso);
                Console.WriteLine("Altura : " + data.Altura);
                Console.WriteLine("IMC : " + data.IMC);
                if (data.MayorEdad)
                {
                    Console.WriteLine("Esta persona es mayor de edad");
                }
                else
                {
                    Console.WriteLine("Esta persona es menor de edad");
                }
                Console.ReadLine();
            }
        }

        //Metodo para ingresar personas a la lista
        private static void IngresarPersona()
        {
            Console.WriteLine("Ingresar una persona");
            Console.WriteLine("Nombre");
            var nombre = Console.ReadLine();
            Console.WriteLine("RFC");
            var RFC = Console.ReadLine();
            Console.WriteLine("Edad");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Sexo");
            char sexo = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Peso");
            var peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Altura");
            var altura = float.Parse(Console.ReadLine());
            var persona = new PersonaData(RFC, nombre, edad, sexo, peso, altura);
            lista.Add(persona);
        }

        //Metodo para listar personas
        private static bool ListarPersonas()
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("No hay personas en la lista.");
                return false;
            }
            Console.WriteLine("Lista de personas");
            foreach (var item in lista)
            {
                Console.WriteLine(lista.IndexOf(item) + ".-"+ item.Nombre);
            }
            return true;
        }
    }
}
