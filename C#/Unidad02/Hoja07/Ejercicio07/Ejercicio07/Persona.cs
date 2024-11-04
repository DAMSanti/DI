using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07 {
    public class Persona {
        public String nombre { get; set; }
        public String nacimiento { get; set; }
        public String sexo { get; set; }
        public String aficiones { get; set; }
        public String aficionesOtros { get; set; }
        public String situacion { get; set; }

        public Persona(string nombre, string nacimiento, string sexo, string aficiones, string aficionesOtros, string situacion) {
            this.nombre = nombre;
            this.nacimiento = nacimiento;
            this.sexo = sexo;
            this.aficiones = aficiones;
            this.aficionesOtros = aficionesOtros;
            this.situacion = situacion;
        }
    }
}
