namespace Ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initialText = textBox1.Text;
        }

        private void NuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (IsDocumentModified())
            {
                var result = MessageBox.Show("El documento ha sido modificado. ¿Desea descartarlo?", "Confirmar", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            textBox1.Clear();
            initialText = textBox1.Text;
            currentFilePath = string.Empty;
        }

        private void AbrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (IsDocumentModified())
            {
                var result = MessageBox.Show("El documento ha sido modificado. ¿Desea descartarlo?", "Confirmar", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = openFileDialog.FileName;
                    textBox1.Text = File.ReadAllText(currentFilePath);
                    initialText = textBox1.Text;
                }
            }
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                GuardarComoToolStripMenuItem_Click(sender, e);
            }
            else
            {
                File.WriteAllText(currentFilePath, textBox1.Text);
                initialText = textBox1.Text;
            }
        }

        private void GuardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                    File.WriteAllText(currentFilePath, textBox1.Text);
                    initialText = textBox1.Text;
                }
            }
        }

        private void SalirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (IsDocumentModified())
            {
                var result = MessageBox.Show("El documento ha sido modificado. ¿Desea descartarlo?", "Confirmar", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            Application.Exit();
        }

        private bool IsDocumentModified()
        {
            return !textBox1.Text.Equals(initialText);
        }

        private void DeshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.CanUndo)
            {
                textBox1.Undo();
                textBox1.ClearUndo();
            }
        }

        private void CortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != string.Empty)
            {
                textBox1.Cut();
            }
        }

        private void CopiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != string.Empty)
            {
                textBox1.Copy();
            }
        }

        private void PegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                textBox1.Paste();
            }
        }

        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != string.Empty)
            {
                textBox1.SelectedText = string.Empty;
            }
        }

        private void BuscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var buscarForm = new BuscarForm())
            {
                if (buscarForm.ShowDialog() == DialogResult.OK)
                {
                    searchText = buscarForm.SearchText;
                    BuscarTexto(searchText);
                }
            }
        }

        private void BuscarSiguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(searchText))
            {
                BuscarTexto(searchText, lastSearchIndex + searchText.Length);
            }
        }

        private void SeleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void BuscarTexto(string texto, int startIndex = 0)
        {
            lastSearchIndex = textBox1.Text.IndexOf(texto, startIndex, StringComparison.OrdinalIgnoreCase);
            if (lastSearchIndex != -1)
            {
                textBox1.Select(lastSearchIndex, texto.Length);
                textBox1.ScrollToCaret();
            }
            else
            {
                MessageBox.Show("Texto no encontrado.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void WordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Alternar el ajuste de línea en el TextBox
            textBox1.WordWrap = !textBox1.WordWrap;
            // Actualizar el estado del menú para reflejar el cambio
            ajusteDeLineaToolStripMenuItem.Checked = textBox1.WordWrap;
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear un cuadro de diálogo de selección de fuente
            using (FontDialog fontDialog = new FontDialog())
            {
                // Establecer la fuente actual del TextBox como la fuente seleccionada por defecto
                fontDialog.Font = textBox1.Font;

                // Mostrar el cuadro de diálogo y verificar si el usuario hizo clic en "Aceptar"
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    // Aplicar la fuente seleccionada al TextBox
                    textBox1.Font = fontDialog.Font;
                }
            }
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();*/
        }

    }

}

