using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace First_WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusStrip1.Items[0].Text = DateTime.Today.ToShortDateString();
            statusStrip1.Items[1].Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            statusStrip1.Items[1].Text = DateTime.Now.ToLongTimeString();
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Закрыть?", "Предупреждение!", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;

            }
            else
            {
                e.Cancel = false;
            
                
            }
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                Text = openFileDialog1.FileName;
                
            }
        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(richTextBox1.TextLength == 0)
            {
                MessageBox.Show("Документ пустой, нельзя сохранять!");
            }
            else
            {
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);


                }
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

       
    }
}
