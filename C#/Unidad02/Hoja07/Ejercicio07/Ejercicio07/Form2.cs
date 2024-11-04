using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio07 {
    public partial class Form2 : Form {
        private Persona persona;
        public Form2(Persona p) {
            InitializeComponent();
            persona = p;
            txtNombre.Text = p.nombre;
            txtNacimiento.Text = p.nacimiento;
            txtSexo.Text = p.sexo;
            txtAficiones.Text = p.aficiones;
            rtxtAficiones.Text = p.aficionesOtros;
            txtSituacion.Text = p.situacion;
        }

        private void btnConfirmar_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
