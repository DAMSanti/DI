namespace Ejercicio07 {
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
            lblNacimiento = new Label();
            txtNombre = new TextBox();
            lblGenero = new Label();
            rdoMasculino = new RadioButton();
            rdoFemenino = new RadioButton();
            rdoOtro = new RadioButton();
            groupBox1 = new GroupBox();
            txtOtros = new TextBox();
            chkLectura = new CheckBox();
            chkOtros = new CheckBox();
            chkMusica = new CheckBox();
            chkDeportes = new CheckBox();
            lblSituacion = new Label();
            cmbSituacion = new ComboBox();
            dtpNacimiento = new DateTimePicker();
            btnReiniciar = new Button();
            btnAceptar = new Button();
            panel2 = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(43, 41);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblNacimiento
            // 
            lblNacimiento.AutoSize = true;
            lblNacimiento.Location = new Point(43, 91);
            lblNacimiento.Name = "lblNacimiento";
            lblNacimiento.Size = new Size(69, 15);
            lblNacimiento.TabIndex = 1;
            lblNacimiento.Text = "Nacimiento";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(145, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(279, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(43, 166);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(45, 15);
            lblGenero.TabIndex = 3;
            lblGenero.Text = "Genero";
            // 
            // rdoMasculino
            // 
            rdoMasculino.AutoSize = true;
            rdoMasculino.Checked = true;
            rdoMasculino.Location = new Point(124, 162);
            rdoMasculino.Name = "rdoMasculino";
            rdoMasculino.Size = new Size(80, 19);
            rdoMasculino.TabIndex = 4;
            rdoMasculino.TabStop = true;
            rdoMasculino.Text = "Masculino";
            rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // rdoFemenino
            // 
            rdoFemenino.AutoSize = true;
            rdoFemenino.Location = new Point(232, 162);
            rdoFemenino.Name = "rdoFemenino";
            rdoFemenino.Size = new Size(78, 19);
            rdoFemenino.TabIndex = 5;
            rdoFemenino.TabStop = true;
            rdoFemenino.Text = "Femenino";
            rdoFemenino.UseVisualStyleBackColor = true;
            // 
            // rdoOtro
            // 
            rdoOtro.AutoSize = true;
            rdoOtro.Location = new Point(339, 162);
            rdoOtro.Name = "rdoOtro";
            rdoOtro.Size = new Size(54, 19);
            rdoOtro.TabIndex = 6;
            rdoOtro.TabStop = true;
            rdoOtro.Text = "Otros";
            rdoOtro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtOtros);
            groupBox1.Controls.Add(chkLectura);
            groupBox1.Controls.Add(chkOtros);
            groupBox1.Controls.Add(chkMusica);
            groupBox1.Controls.Add(chkDeportes);
            groupBox1.Location = new Point(43, 248);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(393, 179);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aficiones";
            // 
            // txtOtros
            // 
            txtOtros.Enabled = false;
            txtOtros.Location = new Point(14, 64);
            txtOtros.Multiline = true;
            txtOtros.Name = "txtOtros";
            txtOtros.Size = new Size(349, 88);
            txtOtros.TabIndex = 4;
            // 
            // chkLectura
            // 
            chkLectura.AutoSize = true;
            chkLectura.Location = new Point(191, 28);
            chkLectura.Name = "chkLectura";
            chkLectura.Size = new Size(65, 19);
            chkLectura.TabIndex = 3;
            chkLectura.Text = "Lectura";
            chkLectura.UseVisualStyleBackColor = true;
            // 
            // chkOtros
            // 
            chkOtros.AutoSize = true;
            chkOtros.Location = new Point(280, 28);
            chkOtros.Name = "chkOtros";
            chkOtros.Size = new Size(55, 19);
            chkOtros.TabIndex = 2;
            chkOtros.Text = "Otros";
            chkOtros.UseVisualStyleBackColor = true;
            chkOtros.CheckStateChanged += chkOtros_CheckStateChanged;
            // 
            // chkMusica
            // 
            chkMusica.AutoSize = true;
            chkMusica.Location = new Point(102, 28);
            chkMusica.Name = "chkMusica";
            chkMusica.Size = new Size(64, 19);
            chkMusica.TabIndex = 1;
            chkMusica.Text = "Musica";
            chkMusica.UseVisualStyleBackColor = true;
            // 
            // chkDeportes
            // 
            chkDeportes.AutoSize = true;
            chkDeportes.Location = new Point(12, 28);
            chkDeportes.Name = "chkDeportes";
            chkDeportes.Size = new Size(73, 19);
            chkDeportes.TabIndex = 0;
            chkDeportes.Text = "Deportes";
            chkDeportes.UseVisualStyleBackColor = true;
            // 
            // lblSituacion
            // 
            lblSituacion.AutoSize = true;
            lblSituacion.Location = new Point(55, 451);
            lblSituacion.Name = "lblSituacion";
            lblSituacion.Size = new Size(56, 15);
            lblSituacion.TabIndex = 8;
            lblSituacion.Text = "Situacion";
            // 
            // cmbSituacion
            // 
            cmbSituacion.FormattingEnabled = true;
            cmbSituacion.Items.AddRange(new object[] { "Becario", "Empleado", "Excedencia", "Jubilado" });
            cmbSituacion.Location = new Point(124, 448);
            cmbSituacion.Name = "cmbSituacion";
            cmbSituacion.Size = new Size(221, 23);
            cmbSituacion.TabIndex = 9;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.CustomFormat = "";
            dtpNacimiento.Format = DateTimePickerFormat.Short;
            dtpNacimiento.Location = new Point(145, 85);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(261, 23);
            dtpNacimiento.TabIndex = 10;
            dtpNacimiento.Value = new DateTime(2024, 10, 18, 0, 0, 0, 0);
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(280, 506);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(75, 23);
            btnReiniciar.TabIndex = 11;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(361, 506);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(43, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(363, 45);
            panel2.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 564);
            Controls.Add(btnAceptar);
            Controls.Add(btnReiniciar);
            Controls.Add(dtpNacimiento);
            Controls.Add(cmbSituacion);
            Controls.Add(lblSituacion);
            Controls.Add(groupBox1);
            Controls.Add(rdoOtro);
            Controls.Add(rdoFemenino);
            Controls.Add(rdoMasculino);
            Controls.Add(lblGenero);
            Controls.Add(txtNombre);
            Controls.Add(lblNacimiento);
            Controls.Add(lblNombre);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Ficha Socio";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblNacimiento;
        private TextBox txtNombre;
        private Label lblGenero;
        private RadioButton rdoMasculino;
        private RadioButton rdoFemenino;
        private RadioButton rdoOtro;
        private GroupBox groupBox1;
        private CheckBox chkLectura;
        private CheckBox chkMusica;
        private CheckBox chkDeportes;
        private Label lblSituacion;
        private ComboBox cmbSituacion;
        private DateTimePicker dtpNacimiento;
        private Button btnReiniciar;
        private Button btnAceptar;
        private Panel panel2;
        private TextBox txtOtros;
        private CheckBox chkOtros;
    }
}
