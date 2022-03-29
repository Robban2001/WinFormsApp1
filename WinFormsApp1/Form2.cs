using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Text = String.Empty;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
                filename = openFileDialog.FileName;
            }
                
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileName))
                return;

            File.WriteAllText(fileName, textBox.Text);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // Form2
        //    // 
        //    this.ClientSize = new System.Drawing.Size(536, 523);
        //    this.Name = "Form2";
        //    this.ResumeLayout(false);

        //}
    }
}
