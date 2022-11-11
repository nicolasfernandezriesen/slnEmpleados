using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado
{
    public class Cliente : Persona
    {
        public int IdCliente { get; set; }
        public string Cuit { get; set; }
        public string Telefono { get; set; }

        public Cliente() { }
        public Cliente(string cuit, string telefono, int id, string nombre, string apellido) :base(nombre, apellido)
        {
            IdCliente= id;
            Cuit= cuit;
            Telefono= telefono;
        }
    }
}
