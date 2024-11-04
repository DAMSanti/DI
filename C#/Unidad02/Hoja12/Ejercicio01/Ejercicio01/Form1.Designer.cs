namespace Ejercicio01 {
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
            lstNumeros = new ListView();
            lblNumElementos = new Label();
            lblSumatorio = new Label();
            lblMedia = new Label();
            lblMaximo = new Label();
            lblMinimo = new Label();
            lblNuevo = new Label();
            txtNumeroElementos = new TextBox();
            txtSumatorio = new TextBox();
            txtMedia = new TextBox();
            txtMaximo = new TextBox();
            txtMinimo = new TextBox();
            txtNuevo = new TextBox();
            btnAñadir = new Button();
            btnEliminar = new Button();
            btnOrdenar = new Button();
            SuspendLayout();
            // 
            // lstNumeros
            // 
            lstNumeros.Location = new Point(12, 12);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(371, 271);
            lstNumeros.TabIndex = 0;
            lstNumeros.UseCompatibleStateImageBehavior = false;
            lstNumeros.View = View.List;
            // 
            // lblNumElementos
            // 
            lblNumElementos.AutoSize = true;
            lblNumElementos.Location = new Point(414, 23);
            lblNumElementos.Name = "lblNumElementos";
            lblNumElementos.Size = new Size(125, 15);
            lblNumElementos.TabIndex = 1;
            lblNumElementos.Text = "Numero de Elementos";
            // 
            // lblSumatorio
            // 
            lblSumatorio.AutoSize = true;
            lblSumatorio.Location = new Point(414, 62);
            lblSumatorio.Name = "lblSumatorio";
            lblSumatorio.Size = new Size(62, 15);
            lblSumatorio.TabIndex = 2;
            lblSumatorio.Text = "Sumatorio";
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Location = new Point(414, 100);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(40, 15);
            lblMedia.TabIndex = 3;
            lblMedia.Text = "Media";
            // 
            // lblMaximo
            // 
            lblMaximo.AutoSize = true;
            lblMaximo.Location = new Point(414, 131);
            lblMaximo.Name = "lblMaximo";
            lblMaximo.Size = new Size(51, 15);
            lblMaximo.TabIndex = 4;
            lblMaximo.Text = "Maximo";
            // 
            // lblMinimo
            // 
            lblMinimo.AutoSize = true;
            lblMinimo.Location = new Point(414, 163);
            lblMinimo.Name = "lblMinimo";
            lblMinimo.Size = new Size(49, 15);
            lblMinimo.TabIndex = 5;
            lblMinimo.Text = "Minimo";
            // 
            // lblNuevo
            // 
            lblNuevo.AutoSize = true;
            lblNuevo.Location = new Point(414, 197);
            lblNuevo.Name = "lblNuevo";
            lblNuevo.Size = new Size(95, 15);
            lblNuevo.TabIndex = 6;
            lblNuevo.Text = "Nuevo Elemento";
            // 
            // txtNumeroElementos
            // 
            txtNumeroElementos.Location = new Point(548, 18);
            txtNumeroElementos.Name = "txtNumeroElementos";
            txtNumeroElementos.Size = new Size(134, 23);
            txtNumeroElementos.TabIndex = 7;
            // 
            // txtSumatorio
            // 
            txtSumatorio.Location = new Point(548, 54);
            txtSumatorio.Name = "txtSumatorio";
            txtSumatorio.Size = new Size(134, 23);
            txtSumatorio.TabIndex = 8;
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(548, 94);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(134, 23);
            txtMedia.TabIndex = 9;
            // 
            // txtMaximo
            // 
            txtMaximo.Location = new Point(548, 128);
            txtMaximo.Name = "txtMaximo";
            txtMaximo.Size = new Size(134, 23);
            txtMaximo.TabIndex = 10;
            // 
            // txtMinimo
            // 
            txtMinimo.Location = new Point(548, 160);
            txtMinimo.Name = "txtMinimo";
            txtMinimo.Size = new Size(134, 23);
            txtMinimo.TabIndex = 11;
            // 
            // txtNuevo
            // 
            txtNuevo.Location = new Point(548, 194);
            txtNuevo.Name = "txtNuevo";
            txtNuevo.Size = new Size(134, 23);
            txtNuevo.TabIndex = 12;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(688, 194);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(75, 23);
            btnAñadir.TabIndex = 13;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(414, 251);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(495, 251);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(75, 23);
            btnOrdenar.TabIndex = 15;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // Form1
            // 
            AcceptButton = btnAñadir;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 304);
            Controls.Add(btnOrdenar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAñadir);
            Controls.Add(txtNuevo);
            Controls.Add(txtMinimo);
            Controls.Add(txtMaximo);
            Controls.Add(txtMedia);
            Controls.Add(txtSumatorio);
            Controls.Add(txtNumeroElementos);
            Controls.Add(lblNuevo);
            Controls.Add(lblMinimo);
            Controls.Add(lblMaximo);
            Controls.Add(lblMedia);
            Controls.Add(lblSumatorio);
            Controls.Add(lblNumElementos);
            Controls.Add(lstNumeros);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstNumeros;
        private Label lblNumElementos;
        private Label lblSumatorio;
        private Label lblMedia;
        private Label lblMaximo;
        private Label lblMinimo;
        private Label lblNuevo;
        private TextBox txtNumeroElementos;
        private TextBox txtSumatorio;
        private TextBox txtMedia;
        private TextBox txtMaximo;
        private TextBox txtMinimo;
        private TextBox txtNuevo;
        private Button btnAñadir;
        private Button btnEliminar;
        private Button btnOrdenar;
    }
}
