using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01 {
    public class Empleado {
        private string nombre;
        private string apellido;
        private int edad;
        private string departamento;

        public Empleado() {

        }

        public Empleado(string nombre, string apellido, int edad, string departamento) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.departamento = departamento;
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }

        public string Apellido { get { return apellido; } set { apellido = value; } }

        public int Edad { get { return edad; } set { edad = value; } }

        public string Departamento { get {return departamento; } set { departamento = value; } }
    }
}
