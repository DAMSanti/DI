using DevExpress.LookAndFeel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiniReto
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("Visual Studio 2013 Dark");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listados listadosForm = new Listados();
            listadosForm.ShowDialog();
            this.Close();
        }
    }
}
