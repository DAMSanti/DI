namespace Ejercicio07 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void chkOtros_CheckStateChanged(object sender, EventArgs e) {
            txtOtros.Enabled = chkOtros.Checked;
        }
        private void btnReiniciar_Click(object sender, EventArgs e) {
            ReiniciarFormulario();
        }

        private void ReiniciarFormulario() {
            chkOtros.Checked = false;
            chkLectura.Checked = false;
            chkDeportes.Checked = false;
            chkMusica.Checked = false;
            txtOtros.Text = string.Empty;
            txtNombre.Text = "";
            cmbSituacion.SelectedIndex = -1;
            rdoMasculino.Checked = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            Persona p = new Persona(txtNombre.Text, dtpNacimiento.Value.ToShortDateString().ToString(), rdoMasculino.Checked ? "Masculino" : "Femenino", ObtenerNombresCheckBoxSeleccionados(), txtOtros.Text, cmbSituacion.Text);
            Form2 formResumen = new Form2(p);
            DialogResult result = formResumen.ShowDialog();
            if (result == DialogResult.OK) {
                MessageBox.Show("Datos confirmados.");
            } else if (result == DialogResult.Cancel) {
                MessageBox.Show("Datos no confirmados.");
            }
        }

        private string ObtenerNombresCheckBoxSeleccionados() {
            List<string> nombresSeleccionados = new List<string>();
            
            if (chkDeportes.Checked) {
                nombresSeleccionados.Add(chkDeportes.Text);
            } 
            if (chkLectura.Checked) {
                nombresSeleccionados.Add(chkLectura.Text);
            }
            if (chkMusica.Checked) {
                nombresSeleccionados.Add(chkMusica.Text);
            }
            if (chkOtros.Checked) {
                nombresSeleccionados.Add(chkOtros.Text);
            }
            

            return string.Join(", ", nombresSeleccionados);
        }
    }
}
