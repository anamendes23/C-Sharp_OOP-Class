namespace String_Functions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.BtnGetLength = new System.Windows.Forms.Button();
            this.BtnNumOfOccurences = new System.Windows.Forms.Button();
            this.BtnCountLetters = new System.Windows.Forms.Button();
            this.BtnCountDigitsPunctuations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(44, 70);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(705, 120);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input string";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(44, 261);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(357, 312);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // BtnGetLength
            // 
            this.BtnGetLength.Location = new System.Drawing.Point(776, 70);
            this.BtnGetLength.Name = "BtnGetLength";
            this.BtnGetLength.Size = new System.Drawing.Size(335, 51);
            this.BtnGetLength.TabIndex = 4;
            this.BtnGetLength.Text = "Get input string Length";
            this.BtnGetLength.UseVisualStyleBackColor = true;
            this.BtnGetLength.Click += new System.EventHandler(this.BtnGetLength_Click);
            // 
            // BtnNumOfOccurences
            // 
            this.BtnNumOfOccurences.Location = new System.Drawing.Point(776, 139);
            this.BtnNumOfOccurences.Name = "BtnNumOfOccurences";
            this.BtnNumOfOccurences.Size = new System.Drawing.Size(335, 51);
            this.BtnNumOfOccurences.TabIndex = 5;
            this.BtnNumOfOccurences.Text = "Count the number of occurences of char \'a\'";
            this.BtnNumOfOccurences.UseVisualStyleBackColor = true;
            this.BtnNumOfOccurences.Click += new System.EventHandler(this.BtnNumOfOccurences_Click);
            // 
            // BtnCountLetters
            // 
            this.BtnCountLetters.Location = new System.Drawing.Point(776, 207);
            this.BtnCountLetters.Name = "BtnCountLetters";
            this.BtnCountLetters.Size = new System.Drawing.Size(335, 52);
            this.BtnCountLetters.TabIndex = 6;
            this.BtnCountLetters.Text = "Count the number of letters";
            this.BtnCountLetters.UseVisualStyleBackColor = true;
            this.BtnCountLetters.Click += new System.EventHandler(this.BtnCountLetters_Click);
            // 
            // BtnCountDigitsPunctuations
            // 
            this.BtnCountDigitsPunctuations.Location = new System.Drawing.Point(776, 283);
            this.BtnCountDigitsPunctuations.Name = "BtnCountDigitsPunctuations";
            this.BtnCountDigitsPunctuations.Size = new System.Drawing.Size(335, 52);
            this.BtnCountDigitsPunctuations.TabIndex = 7;
            this.BtnCountDigitsPunctuations.Text = "Count digits and punctuations";
            this.BtnCountDigitsPunctuations.UseVisualStyleBackColor = true;
            this.BtnCountDigitsPunctuations.Click += new System.EventHandler(this.BtnCountDigitsPunctuations_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 624);
            this.Controls.Add(this.BtnCountDigitsPunctuations);
            this.Controls.Add(this.BtnCountLetters);
            this.Controls.Add(this.BtnNumOfOccurences);
            this.Controls.Add(this.BtnGetLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button BtnGetLength;
        private System.Windows.Forms.Button BtnNumOfOccurences;
        private System.Windows.Forms.Button BtnCountLetters;
        private System.Windows.Forms.Button BtnCountDigitsPunctuations;
    }
}

