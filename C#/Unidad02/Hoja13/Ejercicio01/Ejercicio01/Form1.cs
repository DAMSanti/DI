using System.Collections;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Ejercicio01 {
    public partial class Form1 : Form {
        private ListViewColumnSorter lvwColumnSorter;

        public Form1() {
            InitializeComponent();
            InitializeTreeView();
            InitializeListView();
        }

     

        private void InitializeTreeView() {
            treeView.ImageList = imageList;
            treeView.BeforeExpand += TreeView_BeforeExpand;
            treeView.AfterSelect += TreeView_AfterSelect;

            TreeNode rootNode = new TreeNode("C:\\", 0, 1);
            rootNode.Tag = new DirectoryInfo("C:\\");
            rootNode.Nodes.Add(new TreeNode());
            treeView.Nodes.Add(rootNode);
        }

        private void TreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e) {
            TreeNode node = e.Node;
            if (node.Nodes[0].Text == "" && node.Nodes.Count == 1) {
                node.Nodes.Clear();
                DirectoryInfo dir = (DirectoryInfo)node.Tag;
                try {
                    foreach (DirectoryInfo subDir in dir.GetDirectories()) {
                        TreeNode subNode = new TreeNode(subDir.Name, 0, 1);
                        subNode.Tag = subDir;
                        subNode.Nodes.Add(new TreeNode());
                        node.Nodes.Add(subNode);
                    }
                } catch (UnauthorizedAccessException) { }
            }
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e) {
            DirectoryInfo dir = (DirectoryInfo)e.Node.Tag;
            listView.Items.Clear();

            try {
                foreach (DirectoryInfo subDir in dir.GetDirectories()) {
                    ListViewItem item = new ListViewItem(subDir.Name, 0);
                    item.SubItems.Add(subDir.LastWriteTime.ToString());
                    item.SubItems.Add("");
                    listView.Items.Add(item);
                }

                foreach (FileInfo file in dir.GetFiles()) {
                    ListViewItem item = new ListViewItem(file.Name, 2);
                    item.SubItems.Add(file.LastWriteTime.ToString());
                    item.SubItems.Add(file.Length.ToString());
                    listView.Items.Add(item);
                }
            } catch (UnauthorizedAccessException) { }
        }

        private void InitializeListView() {
            lvwColumnSorter = new ListViewColumnSorter();
            listView.ListViewItemSorter = lvwColumnSorter;

            listView.View = View.Details;
            listView.Columns.Add("Nombre", 250);
            listView.Columns.Add("Fecha de Modificación", 150);
            listView.Columns.Add("Tamaño", 100);
            listView.ColumnClick += ListView_ColumnClick;
        }

        private void ListView_ColumnClick(object sender, ColumnClickEventArgs e) {
            if (e.Column == lvwColumnSorter.numeroColumna) {
                lvwColumnSorter.orden = lvwColumnSorter.orden == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            } else {
                lvwColumnSorter.numeroColumna = e.Column;
                lvwColumnSorter.orden = SortOrder.Ascending;
            }
            listView.Sort();
        }

    }

    public class ListViewColumnSorter : IComparer {
        public int numeroColumna { get; set; }
        public SortOrder orden { get; set; }

        public ListViewColumnSorter() {
            numeroColumna = 0;
            orden = SortOrder.None;
        }

        public int Compare(object x, object y) {
            int compareResult;
            ListViewItem listViewX = (ListViewItem)x;
            ListViewItem listViewY = (ListViewItem)y;

            compareResult = string.Compare(listViewX.SubItems[numeroColumna].Text, listViewY.SubItems[numeroColumna].Text);

            if (orden == SortOrder.Ascending) {
                return compareResult;
            } else if (orden == SortOrder.Descending) {
                return -compareResult;
            } else {
                return 0;
            }
        }
    }
}
