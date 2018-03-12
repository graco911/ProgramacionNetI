using EAU3.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAU3
{
    class Program
    {
        //    Carlos Alberto Graniel Córdova
        //    Es1611301058
        //    Programacion Net I
        //    Evidencia de Aprendizaje Unidad 3

        //Objeto estatico del tipo lista
        static List<ProductoData> lista = new List<ProductoData>();

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
                    Console.Clear();
                    Console.WriteLine("Selecciona una opcion");
                    Console.WriteLine("1.-Listar facturas");
                    Console.WriteLine("2.-Mostrar datos de una factura");
                    Console.WriteLine("3.-Ingresar factura");
                    Console.WriteLine("4.-Salir");

                    //leer el dato desde teclado
                    opcion = Convert.ToInt32(Console.ReadLine());

                    //Switch de opciones
                    switch (opcion)
                    {
                        //Cada case tiene su propia función
                        case 1:
                            ListarFacturas();
                            Console.ReadLine();
                            break;
                        case 2:
                            MostrarFactura();
                            break;
                        case 3:
                            IngresarFactura();
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


        //Metodo para ingresar una factura a la lista
        private static void IngresarFactura()
        {
            Console.WriteLine("Ingresar una factura");
            Console.WriteLine("Numero de pieza");
            var numPieza = Console.ReadLine();
            Console.WriteLine("Descripcion");
            var descripcion = Console.ReadLine();
            Console.WriteLine("Cantidad");
            int cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Precio");
            var precio = double.Parse(Console.ReadLine());
            var factura = new ProductoData(DateTime.Now, numPieza, descripcion, cantidad, precio);
            lista.Add(factura);
            Console.ReadLine();
        }


        //metodo para mostrar una factura seleccionada por el cliente
        private static void MostrarFactura()
        {
            var hayFacturas = ListarFacturas();
            if (hayFacturas)
            {
                int opcion = 0;
                Console.WriteLine("Selecciona la factura para mostrar la informacion");
                opcion = Convert.ToInt32(Console.ReadLine());
                var data = lista[opcion].MonstrarInformacion();
                Console.WriteLine("Fecha de factura: " + data.FechaFactura.ToShortDateString());
                Console.WriteLine("Numero de pieza: " + data.NumPieza);
                Console.WriteLine("Descripcion : " + data.Descripcion);
                Console.WriteLine("Cantidad : " + data.Cantidad);
                Console.WriteLine("Precio : " + data.Precio);
                Console.WriteLine("Total : " + data.CalculoFactura());
            }
            Console.ReadLine();
        }

        //metodo para el listado de facturas
        private static bool ListarFacturas()
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("No hay facturas en la lista.");
                return false;
            }
            Console.WriteLine("Lista de personas");
            foreach (var item in lista)
            {
                Console.WriteLine(lista.IndexOf(item) + ".-" + item.NumPieza + " fecha: " + item.FechaFactura.ToShortDateString());
            }
            return true;
        }
    }
}
