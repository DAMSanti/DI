using System.Windows.Forms.VisualStyles;

namespace Ejercicio03 {
    public partial class Form1 : Form {

        private readonly Dictionary<string, decimal> conversionRates = new Dictionary<string, decimal> {
            { "EUR_PTA", 166.386m },
            { "PTA_EUR", 1 / 166.386m },
            { "EUR_LIRA", 1936.27m },
            { "LIRA_EUR", 1 / 1936.27m },
            { "EUR_FRANC", 6.55957m },
            { "FRANC_EUR", 1 / 6.55957m },
            { "PTA_LIRA", 1936.27m / 166.386m },
            { "LIRA_PTA", 166.386m / 1936.27m },
            { "PTA_FRANC", 6.55957m / 166.386m },
            { "FRANC_PTA", 166.386m / 6.55957m },
            { "LIRA_FRANC", 6.55957m / 1936.27m },
            { "FRANC_LIRA", 1936.27m / 6.55957m }
        };

        public Form1() {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e) {
            try {
                if (!txtCantidad.Text.Equals("")) {
                    string fromCurrency = cmbMonedaOrigen.SelectedItem.ToString();
                    string toCurrency = cmbMonedaDestino.SelectedItem.ToString();
                    if (!fromCurrency.Equals(toCurrency)) {
                        string conversionKey = $"{fromCurrency}_{toCurrency}";
                        decimal conversionRate = conversionRates[conversionKey];
                        decimal convertedAmount = int.Parse(txtCantidad.Text) * conversionRate;
                        lblResultado.Text = $"{int.Parse(txtCantidad.Text)} {fromCurrency} = {convertedAmount:F2} {toCurrency}";
                    } else {
                        MessageBox.Show("Las monedas de origen y destino deben ser diferentes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else {
                    MessageBox.Show("Debe ingresar una cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show("Valores introducidos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
