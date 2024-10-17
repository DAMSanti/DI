namespace Ejercicio02 {
    public partial class GestionTareas : Form {
        public GestionTareas() {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if (!txtTareas.Text.Equals("")) {
                lstTareas.Items.Add(txtTareas.Text);
                txtTareas.Text = "";
            } else {
                MessageBox.Show("Debe ingresar una tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e) {
            if (lstTareas.SelectedIndex != -1) {
                lstTareas.Items.RemoveAt(lstTareas.SelectedIndex);
            } else {
                MessageBox.Show("Debe seleccionar una tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
