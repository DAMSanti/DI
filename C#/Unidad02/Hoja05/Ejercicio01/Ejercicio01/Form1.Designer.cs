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
            nombreField = new TextBox();
            telefonoField = new TextBox();
            mailField = new TextBox();
            masculinoButon = new RadioButton();
            femeninoButon = new RadioButton();
            direccionField = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox = new GroupBox();
            SuspendLayout();
            // 
            // nombreField
            // 
            nombreField.Location = new Point(156, 90);
            nombreField.Name = "nombreField";
            nombreField.Size = new Size(331, 23);
            nombreField.TabIndex = 0;
            // 
            // telefonoField
            // 
            telefonoField.Location = new Point(156, 192);
            telefonoField.Name = "telefonoField";
            telefonoField.Size = new Size(331, 23);
            telefonoField.TabIndex = 1;
            // 
            // mailField
            // 
            mailField.Location = new Point(156, 242);
            mailField.Name = "mailField";
            mailField.Size = new Size(331, 23);
            mailField.TabIndex = 2;
            // 
            // masculinoButon
            // 
            masculinoButon.AutoSize = true;
            masculinoButon.Location = new Point(175, 145);
            masculinoButon.Name = "masculinoButon";
            masculinoButon.Size = new Size(80, 19);
            masculinoButon.TabIndex = 3;
            masculinoButon.TabStop = true;
            masculinoButon.Text = "Masculino";
            masculinoButon.UseVisualStyleBackColor = true;
            // 
            // femeninoButon
            // 
            femeninoButon.AutoSize = true;
            femeninoButon.Location = new Point(347, 145);
            femeninoButon.Name = "femeninoButon";
            femeninoButon.Size = new Size(78, 19);
            femeninoButon.TabIndex = 4;
            femeninoButon.TabStop = true;
            femeninoButon.Text = "Femenino";
            femeninoButon.UseVisualStyleBackColor = true;
            // 
            // direccionField
            // 
            direccionField.Location = new Point(156, 293);
            direccionField.Name = "direccionField";
            direccionField.Size = new Size(331, 23);
            direccionField.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(175, 370);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(311, 370);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 98);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 149);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 9;
            label2.Text = "Sexo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 200);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 10;
            label3.Text = "Teléfono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 250);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 11;
            label4.Text = "E-mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 296);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 12;
            label5.Text = "Dirección";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(229, 26);
            label6.Name = "label6";
            label6.Size = new Size(157, 15);
            label6.TabIndex = 13;
            label6.Text = "Formulario Datos Personales";
            // 
            // groupBox
            // 
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(200, 100);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 457);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(direccionField);
            Controls.Add(femeninoButon);
            Controls.Add(masculinoButon);
            Controls.Add(mailField);
            Controls.Add(telefonoField);
            Controls.Add(nombreField);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombreField;
        private TextBox telefonoField;
        private TextBox mailField;
        private RadioButton masculinoButon;
        private RadioButton femeninoButon;
        private TextBox direccionField;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox;
    }
}
