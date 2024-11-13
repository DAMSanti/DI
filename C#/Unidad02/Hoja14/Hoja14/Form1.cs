namespace Hoja14 {
    public partial class FrmCatalogo : Form {
        public FrmCatalogo() {
            InitializeComponent();
        }

        private void TsmiLibros_Click(object sender, EventArgs e) {
            ListaLibroFrm listaLibroFrm = new ListaLibroFrm();
            listaLibroFrm.MdiParent = this;
            listaLibroFrm.Show();
        }

        private void TsmiPeliculas_Click(object sender, EventArgs e) {
            ListaPeliculasFrm listaPeliculasFrm = new ListaPeliculasFrm();
            listaPeliculasFrm.MdiParent = this;
            listaPeliculasFrm.Show();
        }
    }
}
