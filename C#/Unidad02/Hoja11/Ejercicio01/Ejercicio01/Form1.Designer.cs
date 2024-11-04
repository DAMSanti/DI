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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            lblNombre = new Label();
            lvlTelefono = new Label();
            lvlEmail = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            btnAñadir = new Button();
            btnMostrar = new Button();
            btnEliminar = new Button();
            grpDatos = new GroupBox();
            menuStrip1.SuspendLayout();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(494, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            nuevoToolStripMenuItem.Size = new Size(152, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            salirToolStripMenuItem.Size = new Size(152, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(32, 32);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lvlTelefono
            // 
            lvlTelefono.AutoSize = true;
            lvlTelefono.Location = new Point(32, 66);
            lvlTelefono.Name = "lvlTelefono";
            lvlTelefono.Size = new Size(52, 15);
            lvlTelefono.TabIndex = 2;
            lvlTelefono.Text = "Telefono";
            // 
            // lvlEmail
            // 
            lvlEmail.AutoSize = true;
            lvlEmail.Location = new Point(32, 99);
            lvlEmail.Name = "lvlEmail";
            lvlEmail.Size = new Size(36, 15);
            lvlEmail.TabIndex = 3;
            lvlEmail.Text = "Email";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(122, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(330, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(134, 104);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(330, 23);
            txtTelefono.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(134, 137);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(330, 23);
            txtEmail.TabIndex = 6;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(56, 139);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(75, 23);
            btnAñadir.TabIndex = 7;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(204, 139);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 8;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(377, 139);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(btnEliminar);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(btnMostrar);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(btnAñadir);
            grpDatos.Controls.Add(lvlTelefono);
            grpDatos.Controls.Add(lvlEmail);
            grpDatos.Location = new Point(12, 41);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(470, 168);
            grpDatos.TabIndex = 10;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos Personales";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 225);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(menuStrip1);
            Controls.Add(grpDatos);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label lblNombre;
        private Label lvlTelefono;
        private Label lvlEmail;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private Button btnAñadir;
        private Button btnMostrar;
        private Button btnEliminar;
        private GroupBox grpDatos;
    }
}
