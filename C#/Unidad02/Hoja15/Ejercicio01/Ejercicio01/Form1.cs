namespace Ejercicio01 {
    public partial class MdiEmpleados : Form {
        public MdiEmpleados() {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e) {
            Agregar agregarFrm = new Agregar();
            agregarFrm.MdiParent = this;
            agregarFrm.Show();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e) {
            Ver verFrm = new Ver();
            verFrm.MdiParent = this;
            verFrm.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e) {
            Editar editarFrm = new Editar();
            editarFrm.MdiParent = this;
            editarFrm.Show();
        }
    }
}
