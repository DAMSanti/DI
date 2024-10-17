namespace Ejercicio01 {
    public partial class Calculadora : Form {
        public Calculadora() {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e) {
            double[] numeros = obtenNumeros();
            double resultado = numeros[0] + numeros[1];
            txtResultado.Text = resultado.ToString();
        }


        private void btnRestar_Click(object sender, EventArgs e) {
            double[] numeros = obtenNumeros();
            double resultado = numeros[0] - numeros[1];
            txtResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e) {
            double[] numeros = obtenNumeros();
            double resultado = numeros[0] * numeros[1];
            txtResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e) {
            double[] numeros = obtenNumeros();
            double resultado = numeros[0] / numeros[1];
            txtResultado.Text = resultado.ToString();
        }

        private double[] obtenNumeros() {
            double[] numeros = new double[2]; ;
            try {
                double num1 = double.Parse(txtOperando1.Text);
                double num2 = double.Parse(txtOperando2.Text);
                numeros = [num1, num2];
            } catch (Exception e){
                MessageBox.Show("Error al obtener los números, compruebe que ha introducido valores correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return numeros;
        }
    }
}
