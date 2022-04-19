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
        private bool isUnsaved = false;
        private bool ignoreTextChangedEvent = false;

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

            if (isUnsaved)
                Text = file + "* - Notepad";
            else
                Text = file + " - Notepad";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var eventArgs = new FormClosingEventArgs(CloseReason.None, false);
            Notepad_FormClosing(null, eventArgs);

            if (eventArgs.Cancel)
                return;

            textBox.Text = String.Empty;
            filename = null;
            isUnsaved = false;
            UpdateTitle();
        }
        
        private void SaveFile()
        {
            if (string.IsNullOrEmpty(filename))
            {
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    filename = saveFileDialog.FileName;
                else
                    return;
            }

            File.WriteAllText(filename, textBox.Text);
            isUnsaved = false;
            UpdateTitle();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var eventArgs = new FormClosingEventArgs(CloseReason.None, false);
            Notepad_FormClosing(null, eventArgs);

            if (eventArgs.Cancel)
                return;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ignoreTextChangedEvent = true;
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
                filename = openFileDialog.FileName;
                UpdateTitle();
            }
                
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
       

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
           if (ignoreTextChangedEvent)
            {
                ignoreTextChangedEvent = false;
                return;
            }
            isUnsaved = true;
            UpdateTitle();
        }

        private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isUnsaved)
            {
                 var dialogResult = MessageBox.Show(this, "Would you like to save?","Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                
                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    SaveFile();
                }
                else if(dialogResult == System.Windows.Forms.DialogResult.No)
                {
                    //Do Nothing
                }
                else if (dialogResult == System.Windows.Forms.DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
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
