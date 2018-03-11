namespace Actividad4U3.Entidades.Personas
{
    public abstract class PersonaBase
    {
        public string RFC { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool MayorEdad { get; set; }
        public char Sexo { get; set; }
        public float Peso  { get; set; }
        public float Altura { get; set; }
        public string IMC { get; set; }
    }
}
