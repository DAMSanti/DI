namespace Ejercicio07 {
    partial class Form2 {
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
            lblNombre = new Label();
            lblNacimiento = new Label();
            lblSexo = new Label();
            lblAficiones = new Label();
            lblSituacion = new Label();
            txtNombre = new TextBoxLikeLabel();
            txtNacimiento = new TextBoxLikeLabel();
            txtSexo = new TextBoxLikeLabel();
            txtAficiones = new TextBoxLikeLabel();
            txtSituacion = new TextBoxLikeLabel();
            btnCerrar = new Button();
            btnConfirmar = new Button();
            rtxtAficiones = new RichTextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(39, 45);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblNacimiento
            // 
            lblNacimiento.AutoSize = true;
            lblNacimiento.Location = new Point(39, 91);
            lblNacimiento.Name = "lblNacimiento";
            lblNacimiento.Size = new Size(69, 15);
            lblNacimiento.TabIndex = 1;
            lblNacimiento.Text = "Nacimiento";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(39, 135);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(32, 15);
            lblSexo.TabIndex = 2;
            lblSexo.Text = "Sexo";
            // 
            // lblAficiones
            // 
            lblAficiones.AutoSize = true;
            lblAficiones.Location = new Point(39, 177);
            lblAficiones.Name = "lblAficiones";
            lblAficiones.Size = new Size(56, 15);
            lblAficiones.TabIndex = 3;
            lblAficiones.Text = "Aficiones";
            // 
            // lblSituacion
            // 
            lblSituacion.AutoSize = true;
            lblSituacion.Location = new Point(39, 344);
            lblSituacion.Name = "lblSituacion";
            lblSituacion.Size = new Size(56, 15);
            lblSituacion.TabIndex = 4;
            lblSituacion.Text = "Situacion";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Window;
            txtNombre.BorderStyle = BorderStyle.Fixed3D;
            txtNombre.Location = new Point(126, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(243, 20);
            txtNombre.TabIndex = 5;
            txtNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNacimiento
            // 
            txtNacimiento.BackColor = SystemColors.Window;
            txtNacimiento.BorderStyle = BorderStyle.Fixed3D;
            txtNacimiento.Location = new Point(126, 86);
            txtNacimiento.Name = "txtNacimiento";
            txtNacimiento.Size = new Size(243, 20);
            txtNacimiento.TabIndex = 6;
            txtNacimiento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSexo
            // 
            txtSexo.BackColor = SystemColors.Window;
            txtSexo.BorderStyle = BorderStyle.Fixed3D;
            txtSexo.Location = new Point(126, 132);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(243, 20);
            txtSexo.TabIndex = 7;
            txtSexo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAficiones
            // 
            txtAficiones.BackColor = SystemColors.Window;
            txtAficiones.BorderStyle = BorderStyle.Fixed3D;
            txtAficiones.Location = new Point(126, 174);
            txtAficiones.Name = "txtAficiones";
            txtAficiones.Size = new Size(243, 20);
            txtAficiones.TabIndex = 8;
            txtAficiones.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSituacion
            // 
            txtSituacion.BackColor = SystemColors.Window;
            txtSituacion.BorderStyle = BorderStyle.Fixed3D;
            txtSituacion.Location = new Point(126, 341);
            txtSituacion.Name = "txtSituacion";
            txtSituacion.Size = new Size(243, 20);
            txtSituacion.TabIndex = 9;
            txtSituacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(212, 405);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(307, 405);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 11;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // rtxtAficiones
            // 
            rtxtAficiones.BorderStyle = BorderStyle.None;
            rtxtAficiones.Location = new Point(126, 211);
            rtxtAficiones.Name = "rtxtAficiones";
            rtxtAficiones.ReadOnly = true;
            rtxtAficiones.Size = new Size(243, 114);
            rtxtAficiones.TabIndex = 12;
            rtxtAficiones.Text = "";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 450);
            Controls.Add(rtxtAficiones);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCerrar);
            Controls.Add(txtSituacion);
            Controls.Add(txtAficiones);
            Controls.Add(txtSexo);
            Controls.Add(txtNacimiento);
            Controls.Add(lblSituacion);
            Controls.Add(lblAficiones);
            Controls.Add(lblSexo);
            Controls.Add(lblNacimiento);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Name = "Form2";
            Text = "Resumen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblNacimiento;
        private Label lblSexo;
        private Label lblAficiones;
        private Label lblSituacion;
        private TextBoxLikeLabel txtNombre;
        private TextBoxLikeLabel txtNacimiento;
        private TextBoxLikeLabel txtSexo;
        private TextBoxLikeLabel txtAficiones;
        private TextBoxLikeLabel txtSituacion;
        private Button btnCerrar;
        private Button btnConfirmar;
        private RichTextBox rtxtAficiones;
    }
}