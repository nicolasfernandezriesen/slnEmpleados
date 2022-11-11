using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado
{
    [Table("Empleado")]
    public class Empleado : Persona
    {
        [Key]
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
