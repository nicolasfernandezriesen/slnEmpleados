using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado
{
    public abstract class Persona
    {
        public string Nombre;
        public string Apellido;

        public Persona() { }

        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
