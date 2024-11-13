namespace EjemploMDI {
    public partial class FrmMdi : Form {
        public FrmMdi() {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmHijo frmHijo = new FrmHijo();
            frmHijo.MdiParent = this;
            frmHijo.Text = "Documento " + this.MdiChildren.Length;
            frmHijo.Show();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.Cascade);

        }

        private void mosaicoHorizontalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mosaicoVerticalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
