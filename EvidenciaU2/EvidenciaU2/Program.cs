using System;

namespace EvidenciaU2
{
    class Program
    {
        //    Carlos Alberto Graniel Córdova
        //    Es1611301058
        //    Programacion Net I
        //    Evidencia de Aprendizaje Unidad 2
        static void Main(string[] args)
        {

            Console.WriteLine("Inicio del programa.");

            //Creacion de la variable numero y llamada ala funcion leer()
            var numero = Leer();

            //Condicional que evalua el resultado de la funcion que calcula un numero primo
            if (NumerosPrimos(numero))
            {
                Console.WriteLine("Es un numero primo");
            }
            else
            {
                Console.WriteLine("No es numero primo");
            }

            //impresion en pantalla del factorial de un numero, llamando dentro de este a la funcion Factorial
            Console.WriteLine(string.Format("El factorial del numero {0} es {1}", numero, Factorial(numero)));            

            Console.ReadLine();

        }

        private static int Factorial(int numero)
        {
            //Esta funcion calcula el factorial de un numero, recibe como parametro un numero 
            //y mediante una estructura ciclia evalua que el numero sea distinto de 0 para realizar 
            //el calculo, suma el numero al factorial y lo reduce en una unidad por cada iteracion
            Console.WriteLine("Entrada a la funcion que calcula el factorial de un numero");

            var factorial = 1;
            while (numero != 0)
            {
                factorial =factorial * numero;
                numero--;
            }
            return factorial;
        }

        private static bool NumerosPrimos(int v)
        {
            //Esta funcion calcula si un numero es o no primo, devolviendo un valor booleano
            //mediante una estructura ciclica compara que el valor de la variable primo sea verdadera
            //y que el valor de contador sea distinto al numero a calcular
            //si esto se cumple mediente una evaluacion condicional
            //el programa evalua si el residuo del numero es igual a cero de ser asi, significa 
            //que el numero no es primo, por lo tanto ya no entra en la siguiente iteracion y
            //devuelve el valor de la variable primo.
            Console.WriteLine("Entrada a la funcion que muestra si un numero es o no primo");
            int contador = 2;
            var primo = true;
            while (primo && (contador != v))
            {
                if (v % contador == 0)
                {
                    primo = false;
                }
                contador++;
            }
            return primo;
        }

        private static int Leer()
        {
            //la funcion Leer, lee un valor desde el teclado
            //usando igual un try-catch para detectar si el usuario
            //ingresa un valor que no sea numerico.
            Console.WriteLine("Función que lee un numero introducido por el teclado");
            var num = 0;
            try
            {
                Console.WriteLine("Ingrese un numero");
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                //Entrada a la excepcion
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadLine();
            }
            return num;
        }
    }
}
