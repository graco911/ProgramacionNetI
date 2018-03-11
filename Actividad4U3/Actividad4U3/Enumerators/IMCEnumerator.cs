using System;
using System.Reflection;

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

    public class StringValue : System.Attribute
    {
        private readonly string _value;
        public StringValue(string value)
        {
            _value = value;
        }
        public string Value
        {
            get { return _value; }
        }
    }

    public static class StringEnum
    {
        public static string GetStringValue(IMCEnumerator value)
        {
            string output = null;
            Type type = value.GetType();
            FieldInfo fi = type.GetField(value.ToString());
            StringValue[] attrs =
               fi.GetCustomAttributes(typeof(StringValue),
                                       false) as StringValue[];
            if (attrs.Length > 0)
            {
                output = attrs[0].Value;
            }
            return output;
        }
    }
}
