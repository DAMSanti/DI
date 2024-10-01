using System.Windows.Forms;

namespace PruebaForms {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || comboBox1.Text == string.Empty) {
                MessageBox.Show("ERROR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                double result = 0;
                switch (comboBox1.Text) {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                }
                label1.Text = $"El resultado es: {result}"; 
                label1.Visible = true; // Hacer visible el Label
            }

                
            }

        private void button2_Click(object sender, EventArgs e) {
            comboBox1.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }
    }
}
