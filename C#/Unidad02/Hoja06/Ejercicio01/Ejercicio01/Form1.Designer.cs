namespace Ejercicio01 {
    partial class Calculadora {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblOperando1 = new Label();
            lblOperando2 = new Label();
            lblResultado = new Label();
            txtOperando1 = new TextBox();
            txtOperando2 = new TextBox();
            txtResultado = new TextBox();
            btnSuma = new Button();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            SuspendLayout();
            // 
            // lblOperando1
            // 
            lblOperando1.AutoSize = true;
            lblOperando1.Location = new Point(24, 26);
            lblOperando1.Name = "lblOperando1";
            lblOperando1.Size = new Size(69, 15);
            lblOperando1.TabIndex = 0;
            lblOperando1.Text = "Operando 1";
            // 
            // lblOperando2
            // 
            lblOperando2.AutoSize = true;
            lblOperando2.Location = new Point(24, 73);
            lblOperando2.Name = "lblOperando2";
            lblOperando2.Size = new Size(69, 15);
            lblOperando2.TabIndex = 1;
            lblOperando2.Text = "Operando 2";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(24, 122);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado";
            // 
            // txtOperando1
            // 
            txtOperando1.Location = new Point(24, 45);
            txtOperando1.Name = "txtOperando1";
            txtOperando1.Size = new Size(100, 23);
            txtOperando1.TabIndex = 3;
            // 
            // txtOperando2
            // 
            txtOperando2.Location = new Point(24, 96);
            txtOperando2.Name = "txtOperando2";
            txtOperando2.Size = new Size(100, 23);
            txtOperando2.TabIndex = 4;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(24, 140);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 5;
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(144, 45);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(75, 23);
            btnSuma.TabIndex = 6;
            btnSuma.Text = "Sumar";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(144, 76);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(75, 23);
            btnRestar.TabIndex = 7;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(144, 108);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 8;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(144, 139);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 9;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 197);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(btnSuma);
            Controls.Add(txtResultado);
            Controls.Add(txtOperando2);
            Controls.Add(txtOperando1);
            Controls.Add(lblResultado);
            Controls.Add(lblOperando2);
            Controls.Add(lblOperando1);
            MaximumSize = new Size(257, 236);
            MinimumSize = new Size(257, 236);
            Name = "Calculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOperando1;
        private Label lblOperando2;
        private Label lblResultado;
        private TextBox txtOperando1;
        private TextBox txtOperando2;
        private TextBox txtResultado;
        private Button btnSuma;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
    }
}
