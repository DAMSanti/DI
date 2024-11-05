namespace Ejercicio09
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbTipoBoton = new GroupBox();
            rdbReintCanc = new RadioButton();
            rdbSiNo = new RadioButton();
            rdbSiNoCanc = new RadioButton();
            rdbAboReinIgn = new RadioButton();
            rdbAcepCanc = new RadioButton();
            rdbAceptar = new RadioButton();
            grbIcono = new GroupBox();
            rdbAdvertencia = new RadioButton();
            rdbAlto = new RadioButton();
            rdbPregunta = new RadioButton();
            rdbInformacion = new RadioButton();
            rdbMano = new RadioButton();
            rdbExclamacion = new RadioButton();
            rdbError = new RadioButton();
            rdbAsterisco = new RadioButton();
            lblTitulo = new Label();
            lblMensaje = new Label();
            lblResultado = new Label();
            txtTitulo = new TextBox();
            txtMensaje = new TextBox();
            btnMostrar = new Button();
            grbTipoBoton.SuspendLayout();
            grbIcono.SuspendLayout();
            SuspendLayout();
            // 
            // grbTipoBoton
            // 
            grbTipoBoton.Controls.Add(rdbReintCanc);
            grbTipoBoton.Controls.Add(rdbSiNo);
            grbTipoBoton.Controls.Add(rdbSiNoCanc);
            grbTipoBoton.Controls.Add(rdbAboReinIgn);
            grbTipoBoton.Controls.Add(rdbAcepCanc);
            grbTipoBoton.Controls.Add(rdbAceptar);
            grbTipoBoton.Location = new Point(22, 63);
            grbTipoBoton.Name = "grbTipoBoton";
            grbTipoBoton.Size = new Size(246, 177);
            grbTipoBoton.TabIndex = 0;
            grbTipoBoton.TabStop = false;
            grbTipoBoton.Text = "Tipo de Boton";
            // 
            // rdbReintCanc
            // 
            rdbReintCanc.AutoSize = true;
            rdbReintCanc.Location = new Point(6, 147);
            rdbReintCanc.Name = "rdbReintCanc";
            rdbReintCanc.Size = new Size(130, 19);
            rdbReintCanc.TabIndex = 12;
            rdbReintCanc.TabStop = true;
            rdbReintCanc.Text = "Reintentar/Cancelar";
            rdbReintCanc.UseVisualStyleBackColor = true;
            rdbReintCanc.CheckedChanged += RadioButtonTipoBoton_CheckedChanged;
            // 
            // rdbSiNo
            // 
            rdbSiNo.AutoSize = true;
            rdbSiNo.Location = new Point(6, 122);
            rdbSiNo.Name = "rdbSiNo";
            rdbSiNo.Size = new Size(55, 19);
            rdbSiNo.TabIndex = 11;
            rdbSiNo.TabStop = true;
            rdbSiNo.Text = "Si/No";
            rdbSiNo.UseVisualStyleBackColor = true;
            rdbSiNo.CheckedChanged += RadioButtonTipoBoton_CheckedChanged;
            // 
            // rdbSiNoCanc
            // 
            rdbSiNoCanc.AutoSize = true;
            rdbSiNoCanc.Location = new Point(6, 97);
            rdbSiNoCanc.Name = "rdbSiNoCanc";
            rdbSiNoCanc.Size = new Size(102, 19);
            rdbSiNoCanc.TabIndex = 10;
            rdbSiNoCanc.TabStop = true;
            rdbSiNoCanc.Text = "Si/No/Cancela";
            rdbSiNoCanc.UseVisualStyleBackColor = true;
            rdbSiNoCanc.CheckedChanged += RadioButtonTipoBoton_CheckedChanged;
            // 
            // rdbAboReinIgn
            // 
            rdbAboReinIgn.AutoSize = true;
            rdbAboReinIgn.Location = new Point(6, 72);
            rdbAboReinIgn.Name = "rdbAboReinIgn";
            rdbAboReinIgn.Size = new Size(167, 19);
            rdbAboReinIgn.TabIndex = 9;
            rdbAboReinIgn.TabStop = true;
            rdbAboReinIgn.Text = "Abortar/Reintentar/Ignorar";
            rdbAboReinIgn.UseVisualStyleBackColor = true;
            rdbAboReinIgn.CheckedChanged += RadioButtonTipoBoton_CheckedChanged;
            // 
            // rdbAcepCanc
            // 
            rdbAcepCanc.AutoSize = true;
            rdbAcepCanc.Location = new Point(6, 47);
            rdbAcepCanc.Name = "rdbAcepCanc";
            rdbAcepCanc.Size = new Size(117, 19);
            rdbAcepCanc.TabIndex = 8;
            rdbAcepCanc.TabStop = true;
            rdbAcepCanc.Text = "Aceptar/Cancelar";
            rdbAcepCanc.UseVisualStyleBackColor = true;
            rdbAcepCanc.CheckedChanged += RadioButtonTipoBoton_CheckedChanged;
            // 
            // rdbAceptar
            // 
            rdbAceptar.AutoSize = true;
            rdbAceptar.Location = new Point(6, 22);
            rdbAceptar.Name = "rdbAceptar";
            rdbAceptar.Size = new Size(66, 19);
            rdbAceptar.TabIndex = 7;
            rdbAceptar.TabStop = true;
            rdbAceptar.Text = "Aceptar";
            rdbAceptar.UseVisualStyleBackColor = true;
            rdbAceptar.CheckedChanged += RadioButtonTipoBoton_CheckedChanged;
            // 
            // grbIcono
            // 
            grbIcono.Controls.Add(rdbAdvertencia);
            grbIcono.Controls.Add(rdbAlto);
            grbIcono.Controls.Add(rdbPregunta);
            grbIcono.Controls.Add(rdbInformacion);
            grbIcono.Controls.Add(rdbMano);
            grbIcono.Controls.Add(rdbExclamacion);
            grbIcono.Controls.Add(rdbError);
            grbIcono.Controls.Add(rdbAsterisco);
            grbIcono.Location = new Point(274, 63);
            grbIcono.Name = "grbIcono";
            grbIcono.Size = new Size(230, 226);
            grbIcono.TabIndex = 1;
            grbIcono.TabStop = false;
            grbIcono.Text = "Icono";
            // 
            // rdbAdvertencia
            // 
            rdbAdvertencia.AutoSize = true;
            rdbAdvertencia.Location = new Point(9, 197);
            rdbAdvertencia.Name = "rdbAdvertencia";
            rdbAdvertencia.Size = new Size(88, 19);
            rdbAdvertencia.TabIndex = 7;
            rdbAdvertencia.TabStop = true;
            rdbAdvertencia.Text = "Advertencia";
            rdbAdvertencia.UseVisualStyleBackColor = true;
            rdbAdvertencia.CheckedChanged += RadioButtonIcono_CheckedChanged;
            // 
            // rdbAlto
            // 
            rdbAlto.AutoSize = true;
            rdbAlto.Location = new Point(9, 172);
            rdbAlto.Name = "rdbAlto";
            rdbAlto.Size = new Size(47, 19);
            rdbAlto.TabIndex = 6;
            rdbAlto.TabStop = true;
            rdbAlto.Text = "Alto";
            rdbAlto.UseVisualStyleBackColor = true;
            rdbAlto.CheckedChanged += RadioButtonIcono_CheckedChanged;
            // 
            // rdbPregunta
            // 
            rdbPregunta.AutoSize = true;
            rdbPregunta.Location = new Point(9, 147);
            rdbPregunta.Name = "rdbPregunta";
            rdbPregunta.Size = new Size(73, 19);
            rdbPregunta.TabIndex = 5;
            rdbPregunta.TabStop = true;
            rdbPregunta.Text = "Pregunta";
            rdbPregunta.UseVisualStyleBackColor = true;
            rdbPregunta.CheckedChanged += RadioButtonIcono_CheckedChanged;
            // 
            // rdbInformacion
            // 
            rdbInformacion.AutoSize = true;
            rdbInformacion.Location = new Point(9, 122);
            rdbInformacion.Name = "rdbInformacion";
            rdbInformacion.Size = new Size(90, 19);
            rdbInformacion.TabIndex = 4;
            rdbInformacion.TabStop = true;
            rdbInformacion.Text = "Información";
            rdbInformacion.UseVisualStyleBackColor = true;
            rdbInformacion.CheckedChanged += RadioButtonIcono_CheckedChanged;
            // 
            // rdbMano
            // 
            rdbMano.AutoSize = true;
            rdbMano.Location = new Point(9, 95);
            rdbMano.Name = "rdbMano";
            rdbMano.Size = new Size(56, 19);
            rdbMano.TabIndex = 3;
            rdbMano.TabStop = true;
            rdbMano.Text = "Mano";
            rdbMano.UseVisualStyleBackColor = true;
            rdbMano.CheckedChanged += RadioButtonIcono_CheckedChanged;
            // 
            // rdbExclamacion
            // 
            rdbExclamacion.AutoSize = true;
            rdbExclamacion.Location = new Point(9, 70);
            rdbExclamacion.Name = "rdbExclamacion";
            rdbExclamacion.Size = new Size(92, 19);
            rdbExclamacion.TabIndex = 2;
            rdbExclamacion.TabStop = true;
            rdbExclamacion.Text = "Exclamacion";
            rdbExclamacion.UseVisualStyleBackColor = true;
            rdbExclamacion.CheckedChanged += RadioButtonIcono_CheckedChanged;
            // 
            // rdbError
            // 
            rdbError.AutoSize = true;
            rdbError.Location = new Point(9, 47);
            rdbError.Name = "rdbError";
            rdbError.Size = new Size(50, 19);
            rdbError.TabIndex = 1;
            rdbError.TabStop = true;
            rdbError.Text = "Error";
            rdbError.UseVisualStyleBackColor = true;
            rdbError.CheckedChanged += RadioButtonIcono_CheckedChanged;
            // 
            // rdbAsterisco
            // 
            rdbAsterisco.AutoSize = true;
            rdbAsterisco.Location = new Point(9, 24);
            rdbAsterisco.Name = "rdbAsterisco";
            rdbAsterisco.Size = new Size(73, 19);
            rdbAsterisco.TabIndex = 0;
            rdbAsterisco.TabStop = true;
            rdbAsterisco.Text = "Asterisco";
            rdbAsterisco.UseVisualStyleBackColor = true;
            rdbAsterisco.CheckedChanged += RadioButtonIcono_CheckedChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(22, 310);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(37, 15);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Titulo";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(20, 339);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(51, 15);
            lblMensaje.TabIndex = 3;
            lblMensaje.Text = "Mensaje";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(22, 375);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(125, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado del Mensaje";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(77, 307);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(427, 23);
            txtTitulo.TabIndex = 5;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(77, 336);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(427, 23);
            txtMensaje.TabIndex = 6;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(429, 371);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 7;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 424);
            Controls.Add(btnMostrar);
            Controls.Add(txtMensaje);
            Controls.Add(txtTitulo);
            Controls.Add(lblResultado);
            Controls.Add(lblMensaje);
            Controls.Add(lblTitulo);
            Controls.Add(grbIcono);
            Controls.Add(grbTipoBoton);
            Name = "Form1";
            Text = "RadioButtons y Cajas de Mensajes";
            grbTipoBoton.ResumeLayout(false);
            grbTipoBoton.PerformLayout();
            grbIcono.ResumeLayout(false);
            grbIcono.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbTipoBoton;
        private RadioButton rdbReintCanc;
        private RadioButton rdbSiNo;
        private RadioButton rdbSiNoCanc;
        private RadioButton rdbAboReinIgn;
        private RadioButton rdbAcepCanc;
        private RadioButton rdbAceptar;
        private GroupBox grbIcono;
        private RadioButton rdbAdvertencia;
        private RadioButton rdbAlto;
        private RadioButton rdbPregunta;
        private RadioButton rdbInformacion;
        private RadioButton rdbMano;
        private RadioButton rdbExclamacion;
        private RadioButton rdbError;
        private RadioButton rdbAsterisco;
        private Label lblTitulo;
        private Label lblMensaje;
        private Label lblResultado;
        private TextBox txtTitulo;
        private TextBox txtMensaje;
        private Button btnMostrar;
    }
}
