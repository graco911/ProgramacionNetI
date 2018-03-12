using EAU3.Entidades;

namespace EAU3.Interfaces
{
    //Intefaz publica con los metodos para la clas Producto
    public interface IProducto
    {
        int PedirCompra();
        double CalculoFactura();
        ProductoData MonstrarInformacion();
    }
}
