using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01 {
    internal class Logica {
        private static List<Empleado> _empleados = new List<Empleado>();

        public static void AgregarEmpleado(Empleado empleado) {
            _empleados.Add(empleado);
        }

        public static List<Empleado> ObtenerEmpleados() {
            return _empleados;
        }

        public static void EditarEmpleado(Empleado empleado) {
            foreach (Empleado emp in _empleados) {
                if (emp.Nombre == empleado.Nombre && emp.Apellido == empleado.Apellido) {
                    emp.Edad = empleado.Edad;
                    emp.Departamento = empleado.Departamento;
                }
            }
        }

        public static void EliminarEmpleado(Empleado empleado) {
            _empleados.Remove(empleado);
        }
    }
}
