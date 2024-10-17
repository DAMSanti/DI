namespace Ejercicio04 {
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
            lblNombre = new Label();
            lblContraseña = new Label();
            lblEmail = new Label();
            txtNombre = new TextBox();
            txtContraseña = new TextBox();
            txtEmail = new TextBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(33, 48);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(33, 95);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(33, 142);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(155, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(111, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(155, 87);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(111, 23);
            txtContraseña.TabIndex = 4;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(155, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(111, 23);
            txtEmail.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(155, 189);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(111, 23);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 421);
            Controls.Add(btnRegistrar);
            Controls.Add(txtEmail);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombre);
            Controls.Add(lblEmail);
            Controls.Add(lblContraseña);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblContraseña;
        private Label lblEmail;
        private TextBox txtNombre;
        private TextBox txtContraseña;
        private TextBox txtEmail;
        private Button btnRegistrar;
    }
}
