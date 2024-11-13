namespace Hoja14 {
    partial class FrmCatalogo {
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
            StpMenu = new MenuStrip();
            TsmiArchivo = new ToolStripMenuItem();
            tsmlSalir = new ToolStripMenuItem();
            TsmiMantenimiento = new ToolStripMenuItem();
            TsmiPeliculas = new ToolStripMenuItem();
            TsmiLibros = new ToolStripMenuItem();
            TsmiVentanas = new ToolStripMenuItem();
            TsmiCascada = new ToolStripMenuItem();
            TsmiHorizontal = new ToolStripMenuItem();
            TsmiVertical = new ToolStripMenuItem();
            StpMenu.SuspendLayout();
            SuspendLayout();
            // 
            // StpMenu
            // 
            StpMenu.Items.AddRange(new ToolStripItem[] { TsmiArchivo, TsmiMantenimiento, TsmiVentanas });
            StpMenu.Location = new Point(0, 0);
            StpMenu.MdiWindowListItem = TsmiVentanas;
            StpMenu.Name = "StpMenu";
            StpMenu.Size = new Size(800, 24);
            StpMenu.TabIndex = 1;
            StpMenu.Text = "Menu";
            // 
            // TsmiArchivo
            // 
            TsmiArchivo.DropDownItems.AddRange(new ToolStripItem[] { tsmlSalir });
            TsmiArchivo.Name = "TsmiArchivo";
            TsmiArchivo.Size = new Size(60, 20);
            TsmiArchivo.Text = "Archivo";
            // 
            // tsmlSalir
            // 
            tsmlSalir.Name = "tsmlSalir";
            tsmlSalir.Size = new Size(96, 22);
            tsmlSalir.Text = "Salir";
            // 
            // TsmiMantenimiento
            // 
            TsmiMantenimiento.DropDownItems.AddRange(new ToolStripItem[] { TsmiPeliculas, TsmiLibros });
            TsmiMantenimiento.Name = "TsmiMantenimiento";
            TsmiMantenimiento.Size = new Size(101, 20);
            TsmiMantenimiento.Text = "Mantenimiento";
            // 
            // TsmiPeliculas
            // 
            TsmiPeliculas.Name = "TsmiPeliculas";
            TsmiPeliculas.Size = new Size(180, 22);
            TsmiPeliculas.Text = "Peliculas";
            TsmiPeliculas.Click += TsmiPeliculas_Click;
            // 
            // TsmiLibros
            // 
            TsmiLibros.Name = "TsmiLibros";
            TsmiLibros.Size = new Size(180, 22);
            TsmiLibros.Text = "Libros";
            TsmiLibros.Click += TsmiLibros_Click;
            // 
            // TsmiVentanas
            // 
            TsmiVentanas.DropDownItems.AddRange(new ToolStripItem[] { TsmiCascada, TsmiHorizontal, TsmiVertical });
            TsmiVentanas.Name = "TsmiVentanas";
            TsmiVentanas.Size = new Size(66, 20);
            TsmiVentanas.Text = "Ventanas";
            // 
            // TsmiCascada
            // 
            TsmiCascada.Name = "TsmiCascada";
            TsmiCascada.Size = new Size(177, 22);
            TsmiCascada.Text = "Cascada";
            // 
            // TsmiHorizontal
            // 
            TsmiHorizontal.Name = "TsmiHorizontal";
            TsmiHorizontal.Size = new Size(177, 22);
            TsmiHorizontal.Text = "Mosaico Horizontal";
            // 
            // TsmiVertical
            // 
            TsmiVertical.Name = "TsmiVertical";
            TsmiVertical.Size = new Size(177, 22);
            TsmiVertical.Text = "Mosaico Vertical";
            // 
            // FrmCatalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StpMenu);
            IsMdiContainer = true;
            MainMenuStrip = StpMenu;
            Name = "FrmCatalogo";
            Text = "Catálogo";
            StpMenu.ResumeLayout(false);
            StpMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip StpMenu;
        private ToolStripMenuItem TsmiArchivo;
        private ToolStripMenuItem tsmlSalir;
        private ToolStripMenuItem TsmiMantenimiento;
        private ToolStripMenuItem TsmiPeliculas;
        private ToolStripMenuItem TsmiLibros;
        private ToolStripMenuItem TsmiVentanas;
        private ToolStripMenuItem TsmiCascada;
        private ToolStripMenuItem TsmiHorizontal;
        private ToolStripMenuItem TsmiVertical;
    }
}
