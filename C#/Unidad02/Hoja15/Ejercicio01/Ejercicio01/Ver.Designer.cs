namespace Ejercicio01 {
    partial class Ver {
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
            lstEmpleados = new ListView();
            SuspendLayout();
            // 
            // lstEmpleados
            // 
            lstEmpleados.Dock = DockStyle.Fill;
            lstEmpleados.Location = new Point(0, 0);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(800, 450);
            lstEmpleados.TabIndex = 0;
            lstEmpleados.UseCompatibleStateImageBehavior = false;
            // 
            // Ver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstEmpleados);
            Name = "Ver";
            Text = "Ver";
            ResumeLayout(false);
        }

        #endregion

        private ListView lstEmpleados;
    }
}