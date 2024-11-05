namespace Ejercicio09
{
    public partial class Form1 : Form
    {
        private MessageBoxButtons tipoBotonSeleccionado;
        private MessageBoxIcon iconoSeleccionado;

        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButtonTipoBoton_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAceptar.Checked)
                tipoBotonSeleccionado = MessageBoxButtons.OK;
            else if (rdbAcepCanc.Checked)
                tipoBotonSeleccionado = MessageBoxButtons.OKCancel;
            else if (rdbAboReinIgn.Checked)
                tipoBotonSeleccionado = MessageBoxButtons.AbortRetryIgnore;
            else if (rdbSiNoCanc.Checked)
                tipoBotonSeleccionado = MessageBoxButtons.YesNoCancel;
            else if (rdbSiNo.Checked)
                tipoBotonSeleccionado = MessageBoxButtons.YesNo;
            else if (rdbReintCanc.Checked)
                tipoBotonSeleccionado = MessageBoxButtons.RetryCancel;
        }

        private void RadioButtonIcono_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAsterisco.Checked)
                iconoSeleccionado = MessageBoxIcon.Asterisk;
            else if (rdbError.Checked)
                iconoSeleccionado = MessageBoxIcon.Error;
            else if (rdbExclamacion.Checked)
                iconoSeleccionado = MessageBoxIcon.Exclamation;
            else if (rdbMano.Checked)
                iconoSeleccionado = MessageBoxIcon.Hand;
            else if (rdbInformacion.Checked)
                iconoSeleccionado = MessageBoxIcon.Information;
            else if (rdbPregunta.Checked)
                iconoSeleccionado = MessageBoxIcon.Question;
            else if (rdbAlto.Checked)
                iconoSeleccionado = MessageBoxIcon.Stop;
            else if (rdbAdvertencia.Checked)
                iconoSeleccionado = MessageBoxIcon.Warning;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string mensaje = txtMensaje.Text;
            DialogResult resultado = MessageBox.Show(mensaje, titulo, tipoBotonSeleccionado, iconoSeleccionado);
            lblResultado.Text = $"Resultado del Mensaje: {resultado}";
        }
    }
}
