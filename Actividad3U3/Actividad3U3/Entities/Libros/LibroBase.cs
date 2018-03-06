namespace Actividad3U3.Entities.Libros
{
    //Entidad base abstracta que solo puede ser heredada, contiene todos los atributos del objeto Libro
    public abstract class LibroBase
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumEjemplares { get; set; }
        public int Prestados { get; set; }
    }
}
