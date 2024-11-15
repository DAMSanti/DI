namespace Hoja14 {
    partial class ListaLibroFrm {
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
            menuStrip1 = new MenuStrip();
            librosToolStripMenuItem = new ToolStripMenuItem();
            crearToolStripMenuItem1 = new ToolStripMenuItem();
            lstLibros = new ListView();
            CmsLibros = new ContextMenuStrip(components);
            crearToolStripMenuItem = new ToolStripMenuItem();
            verToolStripMenuItem = new ToolStripMenuItem();
            borrarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            CmsLibros.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { librosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(695, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // librosToolStripMenuItem
            // 
            librosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearToolStripMenuItem1 });
            librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            librosToolStripMenuItem.Size = new Size(51, 20);
            librosToolStripMenuItem.Text = "Libros";
            // 
            // crearToolStripMenuItem1
            // 
            crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            crearToolStripMenuItem1.Size = new Size(102, 22);
            crearToolStripMenuItem1.Text = "Crear";
            crearToolStripMenuItem1.Click += crearToolStripMenuItem1_Click;
            // 
            // lstLibros
            // 
            lstLibros.ContextMenuStrip = CmsLibros;
            lstLibros.Dock = DockStyle.Fill;
            lstLibros.FullRowSelect = true;
            lstLibros.GridLines = true;
            lstLibros.Location = new Point(0, 24);
            lstLibros.MultiSelect = false;
            lstLibros.Name = "lstLibros";
            lstLibros.Size = new Size(695, 161);
            lstLibros.TabIndex = 1;
            lstLibros.UseCompatibleStateImageBehavior = false;
            lstLibros.View = View.Details;
            // 
            // CmsLibros
            // 
            CmsLibros.Items.AddRange(new ToolStripItem[] { crearToolStripMenuItem, verToolStripMenuItem, borrarToolStripMenuItem });
            CmsLibros.Name = "CmsLibros";
            CmsLibros.Size = new Size(107, 70);
            // 
            // crearToolStripMenuItem
            // 
            crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            crearToolStripMenuItem.Size = new Size(106, 22);
            crearToolStripMenuItem.Text = "Crear";
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(106, 22);
            verToolStripMenuItem.Text = "Ver";
            // 
            // borrarToolStripMenuItem
            // 
            borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            borrarToolStripMenuItem.Size = new Size(106, 22);
            borrarToolStripMenuItem.Text = "Borrar";
            // 
            // ListaLibroFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 185);
            Controls.Add(lstLibros);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ListaLibroFrm";
            Text = "Mantenimiento de Libros";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            CmsLibros.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem librosToolStripMenuItem;
        private ListView lstLibros;
        private ContextMenuStrip CmsLibros;
        private ToolStripMenuItem crearToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem borrarToolStripMenuItem;
        private ToolStripMenuItem crearToolStripMenuItem1;
    }
}