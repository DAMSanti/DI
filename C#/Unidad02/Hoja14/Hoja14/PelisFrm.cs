using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoja14 {
    public partial class PelisFrm : Form {
        private Pelicula pelicula;
        private int estado;
        public PelisFrm() {
            InitializeComponent();
        }
        public PelisFrm(Pelicula pelicula, int estado) : this() {
            this.estado = estado;
            if (estado > 0) {
                txtTitulo.Enabled = false;
                txtAnno.Enabled = false;
                txtGenero.Enabled = false;
            }
            this.pelicula = pelicula;
            txtTitulo.Text = pelicula.Titulo;
            txtAnno.Text = pelicula.Anno.ToString();
            txtGenero.Text = pelicula.Genero;
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if (estado > 0 ) {
                this.DialogResult = DialogResult.Cancel;
                return;
            } else {
                this.pelicula = new Pelicula();
                pelicula.Titulo = txtTitulo.Text;
                pelicula.Anno = int.Parse(txtAnno.Text);
                pelicula.Genero = txtGenero.Text;
                ListaPeliculasFrm.peliculas.Add(pelicula);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
