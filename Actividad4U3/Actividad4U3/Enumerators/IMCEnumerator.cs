namespace Actividad4U3.Enumerators
{
    ///<summary>
    ///Enumerator con los valores para el calculo del IMC
    ///</summary>
    ///<remarks>
    ///Metodos necesarios para la actividad
    ///</remarks>
    public enum IMCEnumerator
    {
        [StringValue("PESO BAJO")]
        pesobajo = 1,
        [StringValue("NORMAL")]
        normal = 2,
        [StringValue("SOBREPESO")]
        sobrepeso = 3,
        [StringValue("OBESIDAD GRADO I")]
        obesidadI = 4,
        [StringValue("OBESIDAD GRADO II")]
        obesisdadII = 5,
        [StringValue("OBESIDAD GRADO III")]
        obesidadIII = 6,
    }

    public class StringValueAttribute : System.Attribute
    {
        private string _value;
        public StringValueAttribute(string value)
        {
            _value = value;
        }
        public string Value
        {
            get { return _value; }
        }
    }
}
