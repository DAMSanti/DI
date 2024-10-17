namespace Ejercicio03 {
    partial class Form1 {
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
            lblCantidad = new Label();
            lblMonedaOrigen = new Label();
            lblMonedaDestino = new Label();
            txtCantidad = new TextBox();
            cmbMonedaOrigen = new ComboBox();
            cmbMonedaDestino = new ComboBox();
            btnConvertir = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(30, 50);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 0;
            lblCantidad.Text = "Cantidad";
            // 
            // lblMonedaOrigen
            // 
            lblMonedaOrigen.AutoSize = true;
            lblMonedaOrigen.Location = new Point(30, 97);
            lblMonedaOrigen.Name = "lblMonedaOrigen";
            lblMonedaOrigen.Size = new Size(106, 15);
            lblMonedaOrigen.TabIndex = 1;
            lblMonedaOrigen.Text = "Moneda de Origen";
            // 
            // lblMonedaDestino
            // 
            lblMonedaDestino.AutoSize = true;
            lblMonedaDestino.Location = new Point(30, 147);
            lblMonedaDestino.Name = "lblMonedaDestino";
            lblMonedaDestino.Size = new Size(110, 15);
            lblMonedaDestino.TabIndex = 2;
            lblMonedaDestino.Text = "Moneda de Destino";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(163, 42);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(121, 23);
            txtCantidad.TabIndex = 3;
            // 
            // cmbMonedaOrigen
            // 
            cmbMonedaOrigen.FormattingEnabled = true;
            cmbMonedaOrigen.Items.AddRange(new object[] { "EUR", "PTA", "FRANC", "LIRA" });
            cmbMonedaOrigen.Location = new Point(163, 89);
            cmbMonedaOrigen.Name = "cmbMonedaOrigen";
            cmbMonedaOrigen.Size = new Size(121, 23);
            cmbMonedaOrigen.TabIndex = 4;
            // 
            // cmbMonedaDestino
            // 
            cmbMonedaDestino.FormattingEnabled = true;
            cmbMonedaDestino.Items.AddRange(new object[] { "EUR", "PTA", "FRANC", "LIRA" });
            cmbMonedaDestino.Location = new Point(163, 139);
            cmbMonedaDestino.Name = "cmbMonedaDestino";
            cmbMonedaDestino.Size = new Size(121, 23);
            cmbMonedaDestino.TabIndex = 5;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(163, 198);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(121, 23);
            btnConvertir.TabIndex = 6;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(163, 251);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 350);
            Controls.Add(lblResultado);
            Controls.Add(btnConvertir);
            Controls.Add(cmbMonedaDestino);
            Controls.Add(cmbMonedaOrigen);
            Controls.Add(txtCantidad);
            Controls.Add(lblMonedaDestino);
            Controls.Add(lblMonedaOrigen);
            Controls.Add(lblCantidad);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCantidad;
        private Label lblMonedaOrigen;
        private Label lblMonedaDestino;
        private TextBox txtCantidad;
        private ComboBox cmbMonedaOrigen;
        private ComboBox cmbMonedaDestino;
        private Button btnConvertir;
        private Label lblResultado;
    }
}
