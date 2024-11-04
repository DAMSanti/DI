namespace Listas {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtEdad.Text)) {
                MessageBox.Show("Por favor, llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem item = new ListViewItem(new[] { txtNombre.Text, txtEdad.Text });

            listView1.Items.Add(item);

            txtNombre.Clear();
            txtEdad.Clear();
            txtNombre.Focus();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            foreach (ListViewItem item in listView1.CheckedItems) {
                listView1.Items.Remove(item);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e) {
            if (listView1.SelectedItems.Count > 0) {
                foreach (ListViewItem item in listView1.SelectedItems) {
                    listView1.Items.Remove(item);
                }
            } else {
                MessageBox.Show("No hay elementos seleccionados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
