using Actividad3U3.Interfaces;
using System;

namespace Actividad3U3.Entities.Libros
{
    //clase base sealed que hereda a la clase abstracta LibroBase e implementa a la interfaz ILibro
    public sealed class Libro : LibroBase, ILibro
    {
        //Constructor por defecto
        public Libro(string Titulo, string Autor, int NumEjemplares)
        {
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.NumEjemplares = NumEjemplares;
            this.Prestados = 0;
        }
        

        //Metodo Datos sobreescrito de la interfaz ILibro
        public void Datos()
        {
            //impresion en pantalla
            Console.WriteLine("////DATOS LIBRO//////");
            Console.WriteLine("Titulo");
            Console.WriteLine(Titulo);
            Console.WriteLine("Autor ");
            Console.WriteLine(Autor);
            Console.WriteLine("Ejemplares");
            Console.WriteLine(NumEjemplares);
            Console.WriteLine("Prestados");
            Console.WriteLine(Prestados);
        }

        //Metodo Devolucion sobreescrito de la interfaz ILibro
        public void Devolucion()
        {
            if (Prestados > 0)
            {
                Prestados--;
                NumEjemplares++;
                Console.WriteLine("El Libro: " + Titulo + " ha sido devuelto.");
            }
            else
            {
                Console.WriteLine("El Libro: " + Titulo + "no se puede devolver un libro que no ha sido prestado.");
            }
        }

        //Metodo Prestamo sobreescrito de la interfaz ILibro
        public void Prestamo()
        {
            if (NumEjemplares > 0)
            {
                NumEjemplares--;
                Prestados++;
                Console.WriteLine("El Libro: " + Titulo + " ha sido prestado.");
            }
            else
            {
                Console.WriteLine("El Libro: " + Titulo + "no tiene ejemplares para prestamo.");
            }
        }
    }
}
