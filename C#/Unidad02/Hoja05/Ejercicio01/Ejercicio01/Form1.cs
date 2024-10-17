namespace Ejercicio01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            nombreField.Text = string.Empty;
            telefonoField.Text = string.Empty;
            mailField.Text = string.Empty;
            direccionField.Text = string.Empty;

            masculinoButon.Checked = false;
            femeninoButon.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            String genero = null;
            if (masculinoButon.Checked) {
                genero = "Bienvenido!";
            } else if (femeninoButon.Checked) {
                genero = "Bienvenida!";
            }
            if (nombreField.Text.Length > 0) {
                MessageBox.Show("Hola " + nombreField.Text + " " + genero);
            } else {
                MessageBox.Show("El campo nombre no puede estar vacío");
            }
        }
    }
}
