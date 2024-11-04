namespace Ejercicio01 {
    public partial class Form1 : Form {
        private String Nombre = "";
        private String Telefono = "";
        private String Email = "";
        public Form1() {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e) {
            if (txtNombre.Text != "" && txtTelefono.Text != "" && txtEmail.Text != "") {
                Nombre = txtNombre.Text;
                Telefono = txtTelefono.Text;
                Email = txtEmail.Text;
                MessageBox.Show("Datos guardados con exito");
            } else {
                MessageBox.Show("Debes rellenar todos los campos");
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e) {
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnMostrar_Click(object sender, EventArgs e) {
            if (Nombre != "" && Telefono != "" && Email != "") {
                MessageBox.Show("Nombre: " + Nombre + "\nTeléfono: " + Telefono + "\nEmail: " + Email);
            } else {
                MessageBox.Show("No hay datos que mostrar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            Nombre = "";
            Telefono = "";
            Email = "";
            MessageBox.Show("Contacto eliminado con exito");
        }
    }
}
