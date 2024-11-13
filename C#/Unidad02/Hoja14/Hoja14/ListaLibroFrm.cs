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
    public partial class ListaLibroFrm : Form {
        public static List<Libro> libros = new List<Libro>();
        public ListaLibroFrm() {
            InitializeComponent();
            InitializeListView();
            InitializeContextMenu();
        }
        private void InitializeListView() {
            lstLibros.View = View.Details;
            lstLibros.Columns.Add("Título", 150);
            lstLibros.Columns.Add("Año", 50);
            lstLibros.Columns.Add("Autor", 150);
            lstLibros.FullRowSelect = true;
            lstLibros.MultiSelect = false;
            lstLibros.DoubleClick += lstLibros_DoubleClick;
        }
        private void InitializeContextMenu() {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem crearItem = new ToolStripMenuItem("Crear", null, crearToolStripMenuItem1_Click);
            ToolStripMenuItem verItem = new ToolStripMenuItem("Ver", null, VerItem_Click);
            ToolStripMenuItem borrarItem = new ToolStripMenuItem("Borrar", null, BorrarItem_Click);

            contextMenu.Items.AddRange(new ToolStripItem[] { crearItem, verItem, borrarItem });
            contextMenu.Opening += ContextMenu_Opening;
            lstLibros.ContextMenuStrip = contextMenu;
        }

        private void ContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e) {
            ContextMenuStrip menu = sender as ContextMenuStrip;
            bool itemSelected = lstLibros.SelectedItems.Count > 0;
            menu.Items[0].Enabled = !itemSelected; // Crear
            menu.Items[1].Enabled = itemSelected;  // Ver
            menu.Items[2].Enabled = itemSelected;  // Borrar
        }

        private void VerItem_Click(object sender, EventArgs e) {
            if (lstLibros.SelectedItems.Count > 0) {
                ListViewItem item = lstLibros.SelectedItems[0];
                Libro libro = (Libro)item.Tag;
                LibroFrm libroFrm = new LibroFrm(libro, 1);
                libroFrm.ShowDialog();
            }
        }

        private void BorrarItem_Click(object sender, EventArgs e) {
            if (lstLibros.SelectedItems.Count > 0) {
                ListViewItem item = lstLibros.SelectedItems[0];
                DialogResult result = MessageBox.Show("¿Está seguro de que desea borrar este libro?", "Confirmar borrado", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    Libro libro = (Libro)item.Tag;
                    libros.Remove(libro);
                    RefrescarLista();
                }
            }
        }

        private void lstLibros_DoubleClick(object sender, EventArgs e) {
            VerItem_Click(sender, e);
        }

        private void RefrescarLista() {
            lstLibros.Items.Clear();
            foreach (var libro in libros) {
                if (libro != null) {
                    ListViewItem item = new ListViewItem(libro.Titulo);
                    item.SubItems.Add(libro.Anno.ToString());
                    item.SubItems.Add(libro.Autor);
                    item.Tag = libro;
                    lstLibros.Items.Add(item);
                }
            }
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e) {
            LibroFrm libroFrm = new LibroFrm();
            if (libroFrm.ShowDialog() == DialogResult.OK) {
                // Lógica para agregar el nuevo libro a la lista
                RefrescarLista();
            }
        }
    }
}
