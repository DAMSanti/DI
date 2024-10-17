using System.Drawing.Drawing2D;

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EjemploWForms {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void roundedButton_Click(object sender, EventArgs e) {
            if (textBox1.Text.Length > 0) { 
                MessageBox.Show("Hola " + textBox1.Text + "!", "Contenido del TextBox");
            } else {
                MessageBox.Show("Debes introducir un nombre antes.", "Mensaje de Error");
            }
        }
    }


    public class RoundedButton : Button {
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(new Rectangle(0, 0, 20, 20), 180, 90);
            path.AddArc(new Rectangle(Width - 20, 0, 20, 20), 270, 90);
            path.AddArc(new Rectangle(Width - 20, Height - 20, 20, 20), 0, 90);
            path.AddArc(new Rectangle(0, Height - 20, 20, 20), 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);

            using (Pen pen = new Pen(Color.Black, 1)) {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}
