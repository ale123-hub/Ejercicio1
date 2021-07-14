using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities
{
    public class Conyuge
    {
        public int Conyugeid { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [ForeignKey("Empleado")]
        public int Empleadoid { get; set; }
        public Empleado Empleado { get; set; }
    }
}
