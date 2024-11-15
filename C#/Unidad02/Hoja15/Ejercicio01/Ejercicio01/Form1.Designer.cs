namespace Ejercicio01 {
    partial class MdiEmpleados {
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
            agregarToolStripMenuItem = new ToolStripMenuItem();
            verToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            StpMenu.SuspendLayout();
            SuspendLayout();
            // 
            // StpMenu
            // 
            StpMenu.Items.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, verToolStripMenuItem, editarToolStripMenuItem, buscarToolStripMenuItem, eliminarToolStripMenuItem });
            StpMenu.Location = new Point(0, 0);
            StpMenu.Name = "StpMenu";
            StpMenu.Size = new Size(902, 24);
            StpMenu.TabIndex = 1;
            StpMenu.Text = "StpMenu";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(61, 20);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(35, 20);
            verToolStripMenuItem.Text = "Ver";
            verToolStripMenuItem.Click += verToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(54, 20);
            buscarToolStripMenuItem.Text = "Buscar";
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(62, 20);
            eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // MdiEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 549);
            Controls.Add(StpMenu);
            IsMdiContainer = true;
            MainMenuStrip = StpMenu;
            Name = "MdiEmpleados";
            Text = "Gestión de Empleados";
            StpMenu.ResumeLayout(false);
            StpMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip StpMenu;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
    }
}
