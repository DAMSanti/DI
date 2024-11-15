namespace Hoja14 {
    partial class ListaPeliculasFrm {
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
            stpMenuPelis = new MenuStrip();
            TsmiPeliculas = new ToolStripMenuItem();
            TsmiNuevo = new ToolStripMenuItem();
            lstPelis = new ListView();
            stpMenuPelis.SuspendLayout();
            SuspendLayout();
            // 
            // stpMenuPelis
            // 
            stpMenuPelis.Items.AddRange(new ToolStripItem[] { TsmiPeliculas });
            stpMenuPelis.Location = new Point(0, 0);
            stpMenuPelis.Name = "stpMenuPelis";
            stpMenuPelis.Size = new Size(690, 24);
            stpMenuPelis.TabIndex = 0;
            stpMenuPelis.Text = "menuStrip1";
            // 
            // TsmiPeliculas
            // 
            TsmiPeliculas.DropDownItems.AddRange(new ToolStripItem[] { TsmiNuevo });
            TsmiPeliculas.Name = "TsmiPeliculas";
            TsmiPeliculas.Size = new Size(65, 20);
            TsmiPeliculas.Text = "Peliculas";
            // 
            // TsmiNuevo
            // 
            TsmiNuevo.Name = "TsmiNuevo";
            TsmiNuevo.Size = new Size(180, 22);
            TsmiNuevo.Text = "Nuevo";
            //TsmiNuevo.Click += TsmiNuevo_Click;
            // 
            // lstPelis
            // 
            lstPelis.Dock = DockStyle.Fill;
            lstPelis.Location = new Point(0, 24);
            lstPelis.Name = "lstPelis";
            lstPelis.Size = new Size(690, 166);
            lstPelis.TabIndex = 1;
            lstPelis.UseCompatibleStateImageBehavior = false;
            // 
            // ListaPeliculasFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 190);
            Controls.Add(lstPelis);
            Controls.Add(stpMenuPelis);
            MainMenuStrip = stpMenuPelis;
            Name = "ListaPeliculasFrm";
            Text = "Mantenimiento de Peliculas";
            stpMenuPelis.ResumeLayout(false);
            stpMenuPelis.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip stpMenuPelis;
        private ToolStripMenuItem TsmiPeliculas;
        private ToolStripMenuItem TsmiNuevo;
        private ListView lstPelis;
    }
}