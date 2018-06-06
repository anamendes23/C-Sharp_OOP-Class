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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(39, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(344, 364);
            this.listBox1.TabIndex = 0;
            // 
            // BtnExample1
            // 
            this.BtnExample1.Location = new System.Drawing.Point(419, 121);
            this.BtnExample1.Name = "BtnExample1";
            this.BtnExample1.Size = new System.Drawing.Size(183, 52);
            this.BtnExample1.TabIndex = 1;
            this.BtnExample1.Text = "Example-1";
            this.BtnExample1.UseVisualStyleBackColor = true;
            this.BtnExample1.Click += new System.EventHandler(this.BtnExample1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(419, 78);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(183, 26);
            this.txtInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter max value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.BtnExample1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnExample1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
    }
}

