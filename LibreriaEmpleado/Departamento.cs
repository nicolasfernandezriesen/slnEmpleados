using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado
{
    public class Departamento
    {
        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }
        public List<Empleado> Empleados { get; set; }
        public Departamento() { }
        public Departamento(int id, string nombre, List<Empleado> empleados)
        {
            IdDepartamento= id;
            Nombre= nombre;
            Empleados= empleados;
        }

    }
}
