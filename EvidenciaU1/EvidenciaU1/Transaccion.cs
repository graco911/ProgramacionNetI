using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenciaU1
{
    //clase transaccion para crear objetos del tipo Transaccion
    public class Transaccion
    {
        //declaraciones de atributos
        DateTime fecha { get; set; }
        int cantidad { get; set; }

        //constructor por defecto
        public Transaccion(int cantidad)
        {
            fecha = DateTime.Now;
            this.cantidad = cantidad;
        }

        //metodo public para realizar el calculo del retiro
        public void CalcularRetiro()
        {
            var aux = cantidad;
            var cont = 0;

            //creacion de un objeto del tipo dictionary para almacenar los resultados clave-valor
            Dictionary<int, int> retiro = new Dictionary<int, int>();

            //mientras el valor de auxiliar este dentro del rango de la 
            //denominacion se le resta el valor y se almacena en una 
            //variable contador
            while (aux > 500 && cont < 8)
            {
                aux -= 500;
                cont++;
            }
            retiro.Add((int)Denominaciones.Quinientos,cont);
            cont = 0;

            while (aux > 200 && cont < 12)
            {
                aux -= 200;
                cont++;
            }
            retiro.Add((int)Denominaciones.Doscientos, cont);
            cont = 0;

            while (aux > 100 && cont < 20)
            {
                aux -= 100;
                cont++;
            }
            retiro.Add((int)Denominaciones.Cien, cont);
            cont = 0;

            while (aux >= 50 && cont < 40)
            {
                aux -= 50;
                cont++;
            }
            retiro.Add((int)Denominaciones.Cincuenta, cont);

            //se muestran los resultados en consola
            Console.WriteLine(string.Format("Fecha: {0}", fecha.ToLongDateString()));
            Console.WriteLine(string.Format("Cantidad retirada: {0}", cantidad));

            //se hace un recorrido al diccionario para mostrar los valores
            var num = 0;
            foreach (var item in retiro)
            {
                Console.WriteLine(string.Format("Billetes de {0} : {1}", item.Key, item.Value));
                num += item.Value;
            }

            Console.WriteLine(string.Format("Numero de billetes a entregar: {0}", num));

        }
    }
}
