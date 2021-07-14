namespace WebApplication1.Entities
{
    public class Hijo
    {
        public int Hijoid { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Empleado Empleado { get; set; }
    }
}