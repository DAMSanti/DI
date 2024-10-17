using System.Text.RegularExpressions;

namespace Ejercicio04 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            if (txtNombre.Equals("") && txtEmail.Equals("") && txtContraseña.Equals("")) {
                MessageBox.Show("Debe llenar todos los campos");
            } else {
                if (EsCorreoValido(txtEmail.Text)) {
                    MessageBox.Show("Usuario registrado correctamente");
                } else {
                    MessageBox.Show("Correo inválido");
                }
            }
        }

        public static bool EsCorreoValido(string correo) {
            // Expresión regular para validar un correo electrónico
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$";
            Regex regex = new Regex(patron);
            return regex.IsMatch(correo);
        }
    }

}



/// expresion regular correo electrónico  ^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$