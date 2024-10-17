namespace Ejercicio02 {
    partial class GestionTareas {
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
            lblTareas = new Label();
            txtTareas = new TextBox();
            btnAceptar = new Button();
            btnBorrar = new Button();
            lstTareas = new ListBox();
            SuspendLayout();
            // 
            // lblTareas
            // 
            lblTareas.AutoSize = true;
            lblTareas.Location = new Point(25, 58);
            lblTareas.Name = "lblTareas";
            lblTareas.Size = new Size(39, 15);
            lblTareas.TabIndex = 0;
            lblTareas.Text = "Tareas";
            // 
            // txtTareas
            // 
            txtTareas.Location = new Point(70, 50);
            txtTareas.Name = "txtTareas";
            txtTareas.Size = new Size(285, 23);
            txtTareas.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(70, 95);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(125, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(228, 95);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(127, 23);
            btnBorrar.TabIndex = 3;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // lstTareas
            // 
            lstTareas.FormattingEnabled = true;
            lstTareas.ItemHeight = 15;
            lstTareas.Location = new Point(70, 135);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(285, 169);
            lstTareas.TabIndex = 4;
            // 
            // GestionTareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 429);
            Controls.Add(lstTareas);
            Controls.Add(btnBorrar);
            Controls.Add(btnAceptar);
            Controls.Add(txtTareas);
            Controls.Add(lblTareas);
            Name = "GestionTareas";
            Text = "Gestion de Tareas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTareas;
        private TextBox txtTareas;
        private Button btnAceptar;
        private Button btnBorrar;
        private ListBox lstTareas;
    }
}
