namespace Ejercicio01 {
    partial class Agregar {
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
            components = new System.ComponentModel.Container();
            lblEmpleado = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblEdad = new Label();
            lblDepartamento = new Label();
            bindingSource1 = new BindingSource(components);
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEdad = new TextBox();
            txtDepartamento = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Segoe UI", 29F);
            lblEmpleado.Location = new Point(93, 27);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(194, 52);
            lblEmpleado.TabIndex = 0;
            lblEmpleado.Text = "Empleado";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 139);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(20, 181);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(20, 224);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad";
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Location = new Point(20, 266);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(83, 15);
            lblDepartamento.TabIndex = 4;
            lblDepartamento.Text = "Departamento";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(119, 136);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(218, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(119, 178);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(218, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(119, 221);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(218, 23);
            txtEdad.TabIndex = 7;
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(119, 258);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(218, 23);
            txtDepartamento.TabIndex = 8;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(93, 323);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(203, 323);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 396);
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
            Name = "Agregar";
            Text = "Agregar";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmpleado;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblEdad;
        private Label lblDepartamento;
        private BindingSource bindingSource1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEdad;
        private TextBox txtDepartamento;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}