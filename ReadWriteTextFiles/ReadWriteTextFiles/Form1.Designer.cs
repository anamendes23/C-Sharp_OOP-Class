namespace ReadWriteTextFiles
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtTextToWrite = new System.Windows.Forms.TextBox();
            this.btnAppend = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnReadText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text to write";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(106, 29);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(623, 26);
            this.txtFilePath.TabIndex = 2;
            // 
            // txtTextToWrite
            // 
            this.txtTextToWrite.Location = new System.Drawing.Point(28, 121);
            this.txtTextToWrite.Name = "txtTextToWrite";
            this.txtTextToWrite.Size = new System.Drawing.Size(701, 26);
            this.txtTextToWrite.TabIndex = 3;
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(136, 173);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(488, 44);
            this.btnAppend.TabIndex = 4;
            this.btnAppend.Text = "Append (Save to file)";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 241);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(701, 175);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // BtnReadText
            // 
            this.BtnReadText.Location = new System.Drawing.Point(28, 433);
            this.BtnReadText.Name = "BtnReadText";
            this.BtnReadText.Size = new System.Drawing.Size(701, 44);
            this.BtnReadText.TabIndex = 6;
            this.BtnReadText.Text = "Read Text from File";
            this.BtnReadText.UseVisualStyleBackColor = true;
            this.BtnReadText.Click += new System.EventHandler(this.BtnReadText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.BtnReadText);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.txtTextToWrite);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtTextToWrite;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnReadText;
    }
}

