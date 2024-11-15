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
    public partial class LibroFrm : Form {
        private Libro libro;
        private int estado;
        public LibroFrm() {
            InitializeComponent();
        }
        public LibroFrm(Libro libro, int estado) : this() {
            this.estado = estado;
            if (estado > 0) {
                txtTitulo.Enabled = false;
                txtAnno.Enabled = false;
                txtAutor.Enabled = false;
            }
            this.libro = libro;
            txtTitulo.Text = libro.Titulo;
            txtAnno.Text = libro.Anno.ToString();
            txtAutor.Text = libro.Autor;
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if (estado > 0) {
                this.DialogResult = DialogResult.Cancel;
                return;
            } else { 
                this.libro = new Libro();
                libro.Titulo = txtTitulo.Text;
                libro.Anno = int.Parse(txtAnno.Text);
                libro.Autor = txtAutor.Text;
                ListaLibroFrm.libros.Add(libro);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
