using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio01 {
    public partial class Ver : Form {
        public static List<Empleado> empleados = new List<Empleado>();
        public Ver() {
            InitializeComponent();
            InitializeListView();
        }
        private void InitializeListView() {
            lstEmpleados.View = View.Details;
            lstEmpleados.Columns.Add("Nombre", 150);
            lstEmpleados.Columns.Add("Apellidos", 350);
            lstEmpleados.Columns.Add("Edad", 50);
            lstEmpleados.Columns.Add("Departamento", 150);
            lstEmpleados.FullRowSelect = true;
            lstEmpleados.MultiSelect = false;
        }

        private void RefrescarLista() {
            lstEmpleados.Items.Clear();
            foreach (var emp in empleados) {
                if (emp != null) {
                    ListViewItem item = new ListViewItem(emp.Nombre);
                    item.SubItems.Add(emp.Apellido);
                    item.SubItems.Add(emp.Edad.ToString());
                    item.SubItems.Add(emp.Departamento);
                    item.Tag = emp;
                    lstEmpleados.Items.Add(item);
                }
            }
        }
    }
}
