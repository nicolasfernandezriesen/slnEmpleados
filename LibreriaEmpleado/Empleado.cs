using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado
{
    public class Empleado : Persona
    {
        public int IdEmpleado { get; set; }
        public string Legajo { get; set; }
        public Empleado() { }

        public Empleado(int id, string legajo, string nombre, string apellido) : base(nombre, apellido)
        {
            IdEmpleado= id;
            Legajo= legajo;
        }
    }
}
