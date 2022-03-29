namespace WinFormsApp1
{
    partial class Interface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.SystemColors.Window;
            this.Button.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button.Location = new System.Drawing.Point(479, 12);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(37, 41);
            this.Button.TabIndex = 0;
            this.Button.Text = "+";
            this.Button.UseVisualStyleBackColor = false;
            this.Button.Click += new System.EventHandler(this.Open_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Search.Location = new System.Drawing.Point(81, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(301, 33);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listView1.Location = new System.Drawing.Point(1, 331);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(525, 305);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(159, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recently Opened";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(528, 637);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Button);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Interface";
            this.Text = "Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Button;
        private TextBox Search;
        private ListView listView1;
        private Label label1;
    }
}