using System.Collections.Generic;

namespace WebApplication1.Entities
{
    public class Departamento
    {
        public int Departamentoid { get; set; }
        public string Nombre { get; set; }
        //public Empleado Director { get; set; }
        public List<Empleado> Empleados { get; set; }
    }
}
