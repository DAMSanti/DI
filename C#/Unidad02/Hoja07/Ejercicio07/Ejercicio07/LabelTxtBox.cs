using System;
using System.Drawing;
using System.Windows.Forms;

public class TextBoxLikeLabel : Label {
    public TextBoxLikeLabel() {
        this.BorderStyle = BorderStyle.Fixed3D;
        this.BackColor = SystemColors.Window;
        this.AutoSize = false;
        this.TextAlign = ContentAlignment.MiddleLeft;
    }
}