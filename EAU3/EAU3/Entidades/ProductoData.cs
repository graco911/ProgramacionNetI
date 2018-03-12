using EAU3.Interfaces;
using System;

namespace EAU3.Entidades
{
    //Clase sealed que hereda de ProductoBase e implementa la interfaz IProducto
    public sealed class ProductoData : ProductoBase, IProducto
    {
        //Constructor por defecto
        public ProductoData(DateTime FechaFactura, string NumPieza, string Descripcion, int Cantidad, double Precio)
        {
            this.FechaFactura = FechaFactura;
            this.NumPieza = NumPieza;
            this.Descripcion = Descripcion;
            if (Cantidad < 0)
            {
                this.Cantidad = 0;
            }
            else
            {
                this.Cantidad = Cantidad;
            }
            if (Precio < 0)
            {
                this.Precio = 0.0f;
            }
            else
            {
                this.Precio = Precio;
            }
        }


        //Metodo para calcular la Factura
        public double CalculoFactura()
        {
            return Precio * Cantidad;
        }

        //Metodo que devuelve un objeto del tipo ProductoData
        public ProductoData MonstrarInformacion()
        {
            return this;
        }


        //Metodo que regresa la cantidad de producto comprado en la factura.
        public int PedirCompra()
        {
            return Cantidad;
        }
    }
}
