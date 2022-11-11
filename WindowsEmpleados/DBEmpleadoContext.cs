using LibreriaEmpleado;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEmpleados
{
    public class DBEmpleadoContext : DbContext
    {
        public DBEmpleadoContext() : base("KeyDBEmpleados") { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set;}

    }
}
