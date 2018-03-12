using System;

namespace EAU3.Entidades
{
    //Clase abstracta base con las propiedades del objeto Producto
    public abstract class ProductoBase
    {
        public DateTime FechaFactura { get; set; }
        public string NumPieza { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
    }
}
