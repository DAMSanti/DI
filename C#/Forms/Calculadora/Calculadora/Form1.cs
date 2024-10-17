namespace Calculadora {
    public partial class Form1 : Form {

        private TextBox hiddenTextBox;

        long num1 = 0;
        long operador = 0;
        long num2 = 0;
        long resultado = 0;
        public Form1() {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);

            hiddenTextBox = new TextBox();
            hiddenTextBox.Size = new System.Drawing.Size(0, 0);
            hiddenTextBox.Location = new System.Drawing.Point(-10, -10);

            this.Controls.Add(hiddenTextBox);
        }

        private void Form1_KeyUp(object? sender, KeyEventArgs e) {
            hiddenTextBox.Focus();
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e) {
            switch (e.KeyChar) {
                case '0':
                    button16_Click(button16, EventArgs.Empty);
                    break;
                case '1':
                    button1_Click(button1, EventArgs.Empty);
                    break;
                case '2':
                    button2_Click(button2, EventArgs.Empty);
                    break;
                case '3':
                    button3_Click(button3, EventArgs.Empty);
                    break;
                case '4':
                    button4_Click(button4, EventArgs.Empty);
                    break;
                case '5':
                    button5_Click(button5, EventArgs.Empty);
                    break;
                case '6':
                    button6_Click(button6, EventArgs.Empty);
                    break;
                case '7':
                    button7_Click(button7, EventArgs.Empty);
                    break;
                case '8':
                    button8_Click(button8, EventArgs.Empty);
                    break;
                case '9':
                    button9_Click(button9, EventArgs.Empty);
                    break;
                case '/':
                    button13_Click(button13, EventArgs.Empty);
                    break;
                case '*':
                    button12_Click(button12, EventArgs.Empty);
                    break;
                case '-':
                    button11_Click(button11, EventArgs.Empty);
                    break;
                case '+':
                    button10_Click(button10, EventArgs.Empty);
                    break;
                case '%':
                    button14_Click(button14, EventArgs.Empty);
                    break;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                button15_Click(button15, EventArgs.Empty);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (resultado != 0) {
                num1 = 0;
                operador = 0;
                num2 = 0;
                resultado = 0;
                label1.Text = String.Empty;
                label2.Text = String.Empty;
                label3.Text = String.Empty;
                label4.Text = String.Empty;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text == String.Empty ? 0 : textBox1.Text) * 10 + 1);
            } else { 
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text == String.Empty ? 0 : textBox1.Text) * 10 + 1);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (resultado != 0) {
                num1 = 0;
                operador = 0;
                num2 = 0;
                resultado = 0;
                label1.Text = String.Empty;
                label2.Text = String.Empty;
                label3.Text = String.Empty;
                label4.Text = String.Empty;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text == String.Empty ? 0 : textBox1.Text) * 10 + 2);
            } else { 
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text == String.Empty ? 0 : textBox1.Text) * 10 + 2);
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            if (resultado != 0) {
                num1 = 0;
                operador = 0;
                num2 = 0;
                resultado = 0;
                label1.Text = String.Empty;
                label2.Text = String.Empty;
                label3.Text = String.Empty;
                label4.Text = String.Empty;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text == String.Empty ? 0 : textBox1.Text) * 10 + 3);
            } else { 
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text == String.Empty ? 0 : textBox1.Text) * 10 + 3);
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            if (resultado != 0) {
                num1 = 0;
                operador = 0;
                num2 = 0;
                resultado = 0;
                label1.Text = String.Empty;
                label2.Text = String.Empty;
                label3.Text = String.Empty;
                label4.Text = String.Empty;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text == String.Empty ? 0 : textBox1.Text) * 10 + 4);
            } else { 
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text == String.Empty ? 0 : textBox1.Text) * 10 + 4);
            }
        }
        private void button5_Click(object sender, EventArgs e) {
            if (resultado != 0) {
                num1 = 0;
                operador = 0;
                num2 = 0;
                resultado = 0;
                label1.Text = String.Empty;
                label2.Text = String.Empty;
                label3.Text = String.Empty;
                label4.Text = String.Empty;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text == String.Empty ? 0 : textBox1.Text) * 10 + 5);
            } else { 
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text == String.Empty ? 0 : textBox1.Text) * 10 + 5);
            }
        }

        private void button6_Click(object sender, EventArgs e) {
            if (resultado != 0) {
                num1 = 0;
                operador = 0;
                num2 = 0;
                resultado = 0;
                label1.Text = String.Empty;
                label2.Text = String.Empty;
                label3.Text = String.Empty;
                label4.Text = String.Empty;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text == String.Empty ? 0 : textBox1.Text) * 10 + 6);
            } else { 
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text == String.Empty ? 0 : textBox1.Text) * 10 + 6);
            }

        }

        private void button9_Click(object sender, EventArgs e) {
            if (resultado != 0) {
                num1 = 0;
                operador = 0;
                num2 = 0;
                resultado = 0;
                label1.Text = String.Empty;
                label2.Text = String.Empty;
                label3.Text = String.Empty;
                label4.Text = String.Empty;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text == String.Empty ? 0 : textBox1.Text) * 10 + 7);
            } else { 
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text == String.Empty ? 0 : textBox1.Text) * 10 + 7);
            }
        }

        private void button8_Click(object sender, EventArgs e) {
            if (resultado != 0) {
                num1 = 0;
                operador = 0;
                num2 = 0;
                resultado = 0;
                label1.Text = String.Empty;
                label2.Text = String.Empty;
                label3.Text = String.Empty;
                label4.Text = String.Empty;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text == String.Empty ? 0 : textBox1.Text) * 10 + 8);
            } else { 
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text == String.Empty ? 0 : textBox1.Text) * 10 + 8);
            }
        }

        private void button7_Click(object sender, EventArgs e) {
            if (resultado != 0) {
                num1 = 0;
                operador = 0;
                num2 = 0;
                resultado = 0;
                label1.Text = String.Empty;
                label2.Text = String.Empty;
                label3.Text = String.Empty;
                label4.Text = String.Empty;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text == String.Empty ? 0 : textBox1.Text) * 10 + 9);
            } else { 
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text == String.Empty ? 0 : textBox1.Text) * 10 + 9);
            }
        }

        private void button16_Click(object sender, EventArgs e) {
            if (resultado != 0) {
                num1 = 0;
                operador = 0;
                num2 = 0;
                resultado = 0;
                label1.Text = String.Empty;
                label2.Text = String.Empty;
                label3.Text = String.Empty;
                label4.Text = String.Empty;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text == String.Empty ? 0 : textBox1.Text) * 10);
            } else { 
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text == String.Empty ? 0 : textBox1.Text) * 10);
            }
        }

        private void button10_Click(object sender, EventArgs e) {
            if (textBox1.Text != String.Empty && num1 == 0) {
                num1 = Convert.ToInt32(textBox1.Text);
                operador = 1; // suma
                label1.Text = textBox1.Text;
                label2.Text = "+";
                label1.Visible = true;
                label2.Visible = true;
                textBox1.Text = String.Empty;
            }
        }

        private void button11_Click(object sender, EventArgs e) {
            if (textBox1.Text != String.Empty && num1 == 0) {
                num1 = Convert.ToInt32(textBox1.Text);
                operador = 2; // resta
                label1.Text = textBox1.Text;
                label2.Text = "-";
                label1.Visible = true;
                label2.Visible = true;
                textBox1.Text = String.Empty;
            }
        }

        private void button12_Click(object sender, EventArgs e) {
            if (textBox1.Text != String.Empty && num1 == 0) {
                num1 = Convert.ToInt32(textBox1.Text);
                operador = 3; // multiplicacion
                label1.Text = textBox1.Text;
                label2.Text = "*";
                label1.Visible = true;
                label2.Visible = true;
                textBox1.Text = String.Empty;
            }
        }

        private void button13_Click(object sender, EventArgs e) {
            if (textBox1.Text != String.Empty && num1 == 0) {
                num1 = Convert.ToInt32(textBox1.Text);
                operador = 4; // division
                label1.Text = textBox1.Text;
                label2.Text = "/";
                label1.Visible = true;
                label2.Visible = true;
                textBox1.Text = String.Empty;
            }
        }

        private void button14_Click(object sender, EventArgs e) {
            if (textBox1.Text != String.Empty && num1 == 0) {
                num1 = Convert.ToInt32(textBox1.Text);
                operador = 5; // resto
                label1.Text = textBox1.Text;
                label2.Text = "%";
                label1.Visible = true;
                label2.Visible = true;
                textBox1.Text = String.Empty;
            }
        }

        private void button15_Click(object sender, EventArgs e) {
            if (textBox1.Text != String.Empty && num1 != 0) {
                num2 = Convert.ToInt32(textBox1.Text);
                switch (operador) {
                    case 1: // suma
                        resultado = num1 + num2;
                        break;
                    case 2:
                        resultado = num1 - num2;
                        break;
                    case 3:
                        resultado = num1 + num2;
                        break;
                    case 4:
                        resultado = num1 / num2;
                        break;
                    case 5:
                        resultado = num1 % num2;
                        break;
                }
                label3.Text = textBox1.Text;
                label3.Visible = true;
                label4.Text = resultado.ToString();
                label4.Visible = true;
                textBox1.Text = String.Empty;
            }
        }
    }
}
