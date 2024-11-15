namespace Ejercicio01 {
    partial class Editar {
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtDepartamento = new TextBox();
            txtEdad = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblDepartamento = new Label();
            lblEdad = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblEmpleado = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(208, 336);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(98, 336);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 20;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(124, 271);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(218, 23);
            txtDepartamento.TabIndex = 19;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(124, 234);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(218, 23);
            txtEdad.TabIndex = 18;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(124, 191);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(218, 23);
            txtApellido.TabIndex = 17;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(124, 149);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(218, 23);
            txtNombre.TabIndex = 16;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(25, 279);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(83, 15);
            lblDepartamento.TabIndex = 15;
            lblDepartamento.Text = "Departamento";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(25, 237);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 14;
            lblEdad.Text = "Edad";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(25, 194);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 13;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(25, 152);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre";
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Segoe UI", 29F);
            lblEmpleado.Location = new Point(98, 40);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(194, 52);
            lblEmpleado.TabIndex = 11;
            lblEmpleado.Text = "Empleado";
            // 
            // Editar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 412);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDepartamento);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblDepartamento);
            Controls.Add(lblEdad);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblEmpleado);
            Name = "Editar";
            Text = "Editar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtDepartamento;
        private TextBox txtEdad;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblDepartamento;
        private Label lblEdad;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblEmpleado;
    }
}