namespace Recursive_Method
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnExample1 = new System.Windows.Forms.Button();
            this.BtnExample2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExample3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(39, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(222, 324);
            this.listBox1.TabIndex = 0;
            // 
            // BtnExample1
            // 
            this.BtnExample1.Location = new System.Drawing.Point(39, 377);
            this.BtnExample1.Name = "BtnExample1";
            this.BtnExample1.Size = new System.Drawing.Size(222, 52);
            this.BtnExample1.TabIndex = 1;
            this.BtnExample1.Text = "Example-1";
            this.BtnExample1.UseVisualStyleBackColor = true;
            this.BtnExample1.Click += new System.EventHandler(this.BtnExample1_Click);
            // 
            // BtnExample2
            // 
            this.BtnExample2.Location = new System.Drawing.Point(297, 377);
            this.BtnExample2.Name = "BtnExample2";
            this.BtnExample2.Size = new System.Drawing.Size(192, 52);
            this.BtnExample2.TabIndex = 5;
            this.BtnExample2.Text = "Example-2";
            this.BtnExample2.UseVisualStyleBackColor = true;
            this.BtnExample2.Click += new System.EventHandler(this.BtnExample2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(297, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(192, 324);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(521, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 324);
            this.panel1.TabIndex = 7;
            // 
            // BtnExample3
            // 
            this.BtnExample3.Location = new System.Drawing.Point(572, 377);
            this.BtnExample3.Name = "BtnExample3";
            this.BtnExample3.Size = new System.Drawing.Size(192, 52);
            this.BtnExample3.TabIndex = 8;
            this.BtnExample3.Text = "Example-3";
            this.BtnExample3.UseVisualStyleBackColor = true;
            this.BtnExample3.Click += new System.EventHandler(this.BtnExample3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 441);
            this.Controls.Add(this.BtnExample3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnExample2);
            this.Controls.Add(this.BtnExample1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnExample1;
        private System.Windows.Forms.Button BtnExample2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExample3;
    }
}

