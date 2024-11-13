namespace Hoja14 {
    partial class LibroFrm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblTitulo = new Label();
            lblAño = new Label();
            lblAutor = new Label();
            txtTitulo = new TextBox();
            txtAnno = new TextBox();
            txtAutor = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(37, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(37, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Location = new Point(37, 72);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(29, 15);
            lblAño.TabIndex = 1;
            lblAño.Text = "Año";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(37, 111);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(37, 15);
            lblAutor.TabIndex = 2;
            lblAutor.Text = "Autor";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(110, 21);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(458, 23);
            txtTitulo.TabIndex = 3;
            // 
            // txtAnno
            // 
            txtAnno.Location = new Point(110, 64);
            txtAnno.Name = "txtAnno";
            txtAnno.Size = new Size(154, 23);
            txtAnno.TabIndex = 4;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(110, 103);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(458, 23);
            txtAutor.TabIndex = 5;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(216, 142);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(297, 142);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // LibroFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 174);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtAutor);
            Controls.Add(txtAnno);
            Controls.Add(txtTitulo);
            Controls.Add(lblAutor);
            Controls.Add(lblAño);
            Controls.Add(lblTitulo);
            Name = "LibroFrm";
            Text = "Libro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblAño;
        private Label lblAutor;
        private TextBox txtTitulo;
        private TextBox txtAnno;
        private TextBox txtAutor;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}