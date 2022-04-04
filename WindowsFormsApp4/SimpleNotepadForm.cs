using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class SimpleNotepadForm : Form
    {
        public SimpleNotepadForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SimpleNotepadForm_Load(object sender, EventArgs e)
        {

        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuFileNew_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() ==
     System.Windows.Forms.DialogResult.OK &&
     openFileDialog1.FileName.Length > 0)
            {
                try
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName,
                       RichTextBoxStreamType.RichText);
                }
                catch (System.ArgumentException ex)
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName,
                       RichTextBoxStreamType.PlainText);
                }

                this.Text = "Файл [" + openFileDialog1.FileName + "]";
            }
        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(saveFileDialog1.FileName);

        }

        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {
            
            if (saveFileDialog1.ShowDialog() ==
                   System.Windows.Forms.DialogResult.OK &&
                saveFileDialog1.FileName.Length > 0)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                    this.Text = "Файл [" + saveFileDialog1.FileName + "]";

                }
            }

        private void menuFilePrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.WindowState = FormWindowState.Maximized;
            dlg.Document = printDocument1;
            dlg.ShowDialog();
            if (printDialog1.ShowDialog(this) == DialogResult.OK)
                printDocument1.Print();
        }
    }
    }




