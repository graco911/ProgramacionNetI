using Actividad4U3.Entidades.Personas;

namespace Actividad4U3.Interfaces
{
    ///<summary>
    ///Interfaz con los metodos para la clase Persona
    ///</summary>
    ///<remarks>
    ///Metodos necesarios para la actividad
    ///</remarks>
    public interface IPersona
    {
        ///<summary>
        ///comprueba que el sexo introducido es correcto. Si no es correcto, por default será H.
        ///</summary>
        ///<return>
        ///Devuelve un caracter con el sexo de la persona introducida.
        ///</return>
        ///<param name="sexo">
        ///el caracter introducido por el usuario.
        ///</param>
        char ValidarSexo(char sexo);

        ///<summary>
        ///indica si es mayor de edad, devuelve  booleano true si es Mayor de Edad, de lo contrario devuelve false si es Menor de Edad.
        ///</summary>
        ///<return>
        ///Devuelve un caracter true si el usuario es mayor de edad.
        ///</return>
        ///<param name="edad">
        ///la edad introducida por el usuario.
        ///</param>
        bool Mayor_MenorEdad(int edad);

        ///<summary>
        ///debe de calcular el peso ideal de la persona 
        ///</summary>
        ///<return>
        ///onsidera las siguientes condiciones con base al IMC que resulte:
        // Si el IMC es un valor menor que 18, el método devuelve el string “PESO BAJO”
        // Si el IMC es un valor entre 18 y menor que 25, el método devuelve el string “NORMAL”
        // Si el IMC es un valor entre 25 y menor que 27, el método devuelve el string “SOBREPESO”
        // Si el IMC es un valor entre 27 y menor que 30, el método devuelve el string “OBESIDAD GRADO I”
        // Si el IMC es un valor entre 30 y menor que 40, el método devuelve el string “OBESIDAD GRADO II”
        // Si el IMC es un valor mayor o igual a 40, el método devuelve el string “OBESIDAD GRADO III”
        ///</return>
        ///<param name="peso">
        ///el peso introducido por el usuario.
        ///</param>
        ///<param name="altura">
        ///la altura introducida por el usuario.
        ///</param>
        string CalcularIMC(float peso, float altura);

        ///<summary>
        /// devuelve toda la información del objeto Persona.
        ///</summary>
        ///<return>
        ///Devuelve un objeto del tipo PersonaData
        ///</return>
        PersonaData MostrarInformacion();
    }
}
