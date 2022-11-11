using LibreriaEmpleado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        Departamento departamento;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Empleado empleado1 = new Empleado(0, "AAA000", "Manuel", "Gavioli");
            Empleado empleado2 = new Empleado(1, "AAA001", "Javier", "Rojas");
            Empleado empleado3 = new Empleado(2, "AAA002", "Tomy", "Martin");

            List<Empleado> empleados = new List<Empleado>();
            empleados.Add(empleado1);
            empleados.Add(empleado2);
            empleados.Add(empleado3);
            departamento= new Departamento(0, "Fisica Nuclear", empleados);

            ShowEmpleados(departamento);
        }

        private void ShowEmpleados(Departamento departamento)
        {
            gridEmpleados.DataSource = departamento.Empleados;
        }
    }
}
