namespace Ejercicio01 {
    public partial class Form1 : Form {
        private int contador = 0;
        private int sumatorio = 0;
        private int maximo = 0;
        private int minimo = 0;
        private int media = 0;
        public Form1() {
            InitializeComponent();
            actualizaDatos();
        }

        private void btnAñadir_Click(object sender, EventArgs e) {
            if (txtNuevo.Text != "" && int.TryParse(txtNuevo.Text, out int numero)) {
                lstNumeros.Items.Add(txtNuevo.Text);
                txtNuevo.Text = "";
                contador++;
                actualizaDatos();
            } else {
                MessageBox.Show("Introduce un número");
            }
        }

        private void actualizaDatos() {
            sumatorio = 0;
            txtNumeroElementos.Text = contador.ToString();


            foreach (ListViewItem item in lstNumeros.Items) {
                if (item != null) {
                    int numero;
                    sumatorio += int.Parse(item.Text);
                }
            }
            txtSumatorio.Text = sumatorio.ToString();


            if (lstNumeros.Items.Count > 0) {
                maximo = int.Parse(lstNumeros.Items[0].Text);
                minimo = int.Parse(lstNumeros.Items[0].Text);
                foreach (ListViewItem item in lstNumeros.Items) {
                    if (int.Parse(item.Text) > maximo) {
                        maximo = int.Parse(item.Text);
                    }
                    if (int.Parse(item.Text) < minimo) {
                        minimo = int.Parse(item.Text);
                    }
                }
            }
            txtMaximo.Text = maximo.ToString();
            txtMinimo.Text = minimo.ToString();

            if (contador > 0) {
                media = sumatorio / contador;
            }

            txtMedia.Text = media.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (lstNumeros.SelectedItems.Count > 0 && lstNumeros.SelectedItems.Count < 2) {
                lstNumeros.Items.Remove(lstNumeros.SelectedItems[0]);
                contador--;
                actualizaDatos();
            } else {
                MessageBox.Show("Por favor, seleccione un unico elemento para eliminar.");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e) {
            List<int> numeros = new List<int>();

            foreach (ListViewItem item in lstNumeros.Items) {
                if (item != null) {
                    int numero;
                    if (int.TryParse(item.Text, out numero)) {
                        numeros.Add(numero);
                    }
                }
            }
            numeros.Sort();
            lstNumeros.Items.Clear();
            foreach (int numero in numeros) {
                lstNumeros.Items.Add(new ListViewItem(numero.ToString()));
            }
        }
    }
}
