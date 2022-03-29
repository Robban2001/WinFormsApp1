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
        private string? filename;

        public Notepad()
        {
            InitializeComponent();
            UpdateTitle();
        }

        private void UpdateTitle()
        {
            string file;
            if (string.IsNullOrEmpty(filename))
                file = "Unnamed";
            else
                file = Path.GetFileName(filename);

            Text = file + " - Notepad";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Text = String.Empty;
            filename = null;
            UpdateTitle();
        }
        

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
                filename = openFileDialog.FileName;
                UpdateTitle();
            }
                
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filename))
                return;

            File.WriteAllText(filename, textBox.Text);
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
