using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio01 {
    public partial class Agregar : Form {
        public Agregar() {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtApellido.Text) && !string.IsNullOrWhiteSpace(txtEdad.Text) && !string.IsNullOrWhiteSpace(txtDepartamento.Text)) {
                try {
                    Empleado empleado = new Empleado();
                    empleado.Nombre = txtNombre.Text;
                    empleado.Apellido = txtApellido.Text;
                    empleado.Edad = int.Parse(txtEdad.Text);
                    empleado.Departamento = txtDepartamento.Text;
                    Logica.AgregarEmpleado(empleado);
                    MessageBox.Show("Empleado agregado correctamente");
                    this.DialogResult = DialogResult.OK;
                } catch (FormatException) {
                    MessageBox.Show("El formato del número ingresado en la edad no es correcto.");
                }
            } else {
                MessageBox.Show("Por favor, complete todos los campos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
