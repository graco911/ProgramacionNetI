using Actividad4U3.Enumerators;
using Actividad4U3.Interfaces;
using System;

namespace Actividad4U3.Entidades.Personas
{
    public sealed class PersonaData : PersonaBase, IUsable
    {
        //Constructor por defecto
        public PersonaData(string RFC, string Nombre, int Edad, char Sexo, float Peso, float Altura)
        {
            this.RFC = RFC;
            this.Nombre = Nombre;
            this.Edad = Edad;
            MayorEdad = Mayor_MenorEdad(Edad);
            //Metodo para validar el sexo
            this.Sexo = ValidarSexo(Sexo);
            this.Peso = Peso;
            this.Altura = Altura;
            //Metodo para calcular el IMC (Indice de Masa Corporal)
            IMC = CalcularIMC(this.Peso, this.Altura);
        }

        //Calculo del IMC
        public string CalcularIMC(float peso, float altura)
        {
            var imc = peso / (altura * altura);

            if (imc < 18)
            {
                return StringEnum.GetStringValue(IMCEnumerator.pesobajo);
            }
            else if (imc > 18 && imc < 25)
            {
                return StringEnum.GetStringValue(IMCEnumerator.normal);
            }
            else if (imc >= 25 && imc < 27 )
            {
                return StringEnum.GetStringValue(IMCEnumerator.sobrepeso);
            }
            else if (imc >= 27 && imc < 30)
            {
                return StringEnum.GetStringValue(IMCEnumerator.obesidadI);
            }
            else if (imc >= 30 && imc < 40)
            {
                return StringEnum.GetStringValue(IMCEnumerator.obesisdadII);
            }
            else
            {
                return StringEnum.GetStringValue(IMCEnumerator.obesidadIII);
            }
        }

        //Funcion para saber si es o no mayor de Edad
        public bool Mayor_MenorEdad(int edad)
        {
            return edad > 18 ? true : false;
        }

        public PersonaData MostrarInformacion()
        {
            return this;
        }

        public char ValidarSexo(char sexo)
        {
            if (sexo != 'h' || sexo != 'f')
            {
                return 'h';
            }
            else
            {
                return sexo;
            }
        }
    }
}
