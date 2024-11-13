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
    public partial class ListaPeliculasFrm : Form {
        public static List<Pelicula> peliculas = new List<Pelicula>();
        public ListaPeliculasFrm() {
            InitializeComponent();
            InitializeListView();
            InitializeContextMenu();
        }
        private void InitializeListView() {
            lstPelis.View = View.Details;
            lstPelis.Columns.Add("Título", 150);
            lstPelis.Columns.Add("Año", 50);
            lstPelis.Columns.Add("Género", 150);
            lstPelis.FullRowSelect = true;
            lstPelis.MultiSelect = false;
            lstPelis.DoubleClick += lstPelis_DoubleClick;
        }
        private void InitializeContextMenu() {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem crearItem = new ToolStripMenuItem("Crear", null, crearToolStripMenuItem1_Click);
            ToolStripMenuItem verItem = new ToolStripMenuItem("Ver", null, VerItem_Click);
            ToolStripMenuItem borrarItem = new ToolStripMenuItem("Borrar", null, BorrarItem_Click);

            contextMenu.Items.AddRange(new ToolStripItem[] { crearItem, verItem, borrarItem });
            contextMenu.Opening += ContextMenu_Opening;
            lstPelis.ContextMenuStrip = contextMenu;
        }

        private void ContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e) {
            ContextMenuStrip menu = sender as ContextMenuStrip;
            bool itemSelected = lstPelis.SelectedItems.Count > 0;
            menu.Items[0].Enabled = !itemSelected; // Crear
            menu.Items[1].Enabled = itemSelected;  // Ver
            menu.Items[2].Enabled = itemSelected;  // Borrar
        }

        private void VerItem_Click(object sender, EventArgs e) {
            if (lstPelis.SelectedItems.Count > 0) {
                ListViewItem item = lstPelis.SelectedItems[0];
                Pelicula pelicula = (Pelicula)item.Tag;
                PelisFrm peliculaFrm = new PelisFrm();
                peliculaFrm.ShowDialog();
            }
        }

        private void BorrarItem_Click(object sender, EventArgs e) {
            if (lstPelis.SelectedItems.Count > 0) {
                ListViewItem item = lstPelis.SelectedItems[0];
                DialogResult result = MessageBox.Show("¿Está seguro de que desea borrar esta pelicula?", "Confirmar borrado", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    Pelicula pelicula = (Pelicula)item.Tag;
                    peliculas.Remove(pelicula);
                    RefrescarLista();
                }
            }
        }

        private void lstPelis_DoubleClick(object sender, EventArgs e) {
            VerItem_Click(sender, e);
        }

        private void RefrescarLista() {
            lstPelis.Items.Clear();
            foreach (var pelicula in peliculas) {
                if (pelicula != null) {
                    ListViewItem item = new ListViewItem(pelicula.Titulo);
                    item.SubItems.Add(pelicula.Anno.ToString());
                    item.SubItems.Add(pelicula.Genero);
                    item.Tag = pelicula;
                    lstPelis.Items.Add(item);
                }
            }
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e) {
            PelisFrm pelisFrm = new PelisFrm();
            if (pelisFrm.ShowDialog() == DialogResult.OK) {
                // Lógica para agregar el nuevo libro a la lista
                RefrescarLista();
            }
        }
    }
}

