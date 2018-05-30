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
            this.BtnCountUpperCase = new System.Windows.Forms.Button();
            this.BtnIndexFirstSpace = new System.Windows.Forms.Button();
            this.BtnIndexSecondSpace = new System.Windows.Forms.Button();
            this.BtnReplaceFirstSpace = new System.Windows.Forms.Button();
            this.BtnSplit = new System.Windows.Forms.Button();
            this.BtnSwap = new System.Windows.Forms.Button();
            this.BtnReplaceBlanks = new System.Windows.Forms.Button();
            this.BtnUppercaseFirst = new System.Windows.Forms.Button();
            this.BtnGetVowels = new System.Windows.Forms.Button();
            this.BtnGetIndexFirstVowel = new System.Windows.Forms.Button();
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
            // BtnCountUpperCase
            // 
            this.BtnCountUpperCase.Location = new System.Drawing.Point(776, 359);
            this.BtnCountUpperCase.Name = "BtnCountUpperCase";
            this.BtnCountUpperCase.Size = new System.Drawing.Size(335, 52);
            this.BtnCountUpperCase.TabIndex = 8;
            this.BtnCountUpperCase.Text = "Count the upper case characters";
            this.BtnCountUpperCase.UseVisualStyleBackColor = true;
            this.BtnCountUpperCase.Click += new System.EventHandler(this.BtnCountUpperCase_Click);
            // 
            // BtnIndexFirstSpace
            // 
            this.BtnIndexFirstSpace.Location = new System.Drawing.Point(776, 434);
            this.BtnIndexFirstSpace.Name = "BtnIndexFirstSpace";
            this.BtnIndexFirstSpace.Size = new System.Drawing.Size(335, 52);
            this.BtnIndexFirstSpace.TabIndex = 9;
            this.BtnIndexFirstSpace.Text = "Index of First Space";
            this.BtnIndexFirstSpace.UseVisualStyleBackColor = true;
            this.BtnIndexFirstSpace.Click += new System.EventHandler(this.BtnIndexFirstSpace_Click);
            // 
            // BtnIndexSecondSpace
            // 
            this.BtnIndexSecondSpace.Location = new System.Drawing.Point(776, 504);
            this.BtnIndexSecondSpace.Name = "BtnIndexSecondSpace";
            this.BtnIndexSecondSpace.Size = new System.Drawing.Size(335, 52);
            this.BtnIndexSecondSpace.TabIndex = 10;
            this.BtnIndexSecondSpace.Text = "Index of Second Space";
            this.BtnIndexSecondSpace.UseVisualStyleBackColor = true;
            this.BtnIndexSecondSpace.Click += new System.EventHandler(this.BtnIndexSecondSpace_Click);
            // 
            // BtnReplaceFirstSpace
            // 
            this.BtnReplaceFirstSpace.Location = new System.Drawing.Point(776, 567);
            this.BtnReplaceFirstSpace.Name = "BtnReplaceFirstSpace";
            this.BtnReplaceFirstSpace.Size = new System.Drawing.Size(335, 52);
            this.BtnReplaceFirstSpace.TabIndex = 11;
            this.BtnReplaceFirstSpace.Text = "Replace First Space";
            this.BtnReplaceFirstSpace.UseVisualStyleBackColor = true;
            this.BtnReplaceFirstSpace.Click += new System.EventHandler(this.BtnReplaceFirstSpace_Click);
            // 
            // BtnSplit
            // 
            this.BtnSplit.Location = new System.Drawing.Point(425, 567);
            this.BtnSplit.Name = "BtnSplit";
            this.BtnSplit.Size = new System.Drawing.Size(335, 52);
            this.BtnSplit.TabIndex = 12;
            this.BtnSplit.Text = "Split(char[] separator)";
            this.BtnSplit.UseVisualStyleBackColor = true;
            this.BtnSplit.Click += new System.EventHandler(this.BtnSplit_Click);
            // 
            // BtnSwap
            // 
            this.BtnSwap.Location = new System.Drawing.Point(425, 504);
            this.BtnSwap.Name = "BtnSwap";
            this.BtnSwap.Size = new System.Drawing.Size(335, 52);
            this.BtnSwap.TabIndex = 13;
            this.BtnSwap.Text = "Swap First and Last Words";
            this.BtnSwap.UseVisualStyleBackColor = true;
            this.BtnSwap.Click += new System.EventHandler(this.BtnSwap_Click);
            // 
            // BtnReplaceBlanks
            // 
            this.BtnReplaceBlanks.Location = new System.Drawing.Point(425, 434);
            this.BtnReplaceBlanks.Name = "BtnReplaceBlanks";
            this.BtnReplaceBlanks.Size = new System.Drawing.Size(335, 52);
            this.BtnReplaceBlanks.TabIndex = 14;
            this.BtnReplaceBlanks.Text = "Replace all Blanks with \'--\'";
            this.BtnReplaceBlanks.UseVisualStyleBackColor = true;
            this.BtnReplaceBlanks.Click += new System.EventHandler(this.BtnReplaceBlanks_Click);
            // 
            // BtnUppercaseFirst
            // 
            this.BtnUppercaseFirst.Location = new System.Drawing.Point(425, 359);
            this.BtnUppercaseFirst.Name = "BtnUppercaseFirst";
            this.BtnUppercaseFirst.Size = new System.Drawing.Size(335, 52);
            this.BtnUppercaseFirst.TabIndex = 15;
            this.BtnUppercaseFirst.Text = "Uppercase First Letter";
            this.BtnUppercaseFirst.UseVisualStyleBackColor = true;
            this.BtnUppercaseFirst.Click += new System.EventHandler(this.BtnUppercaseFirst_Click);
            // 
            // BtnGetVowels
            // 
            this.BtnGetVowels.Location = new System.Drawing.Point(425, 283);
            this.BtnGetVowels.Name = "BtnGetVowels";
            this.BtnGetVowels.Size = new System.Drawing.Size(335, 52);
            this.BtnGetVowels.TabIndex = 16;
            this.BtnGetVowels.Text = "Get Number of Vowels";
            this.BtnGetVowels.UseVisualStyleBackColor = true;
            this.BtnGetVowels.Click += new System.EventHandler(this.BtnGetVowels_Click);
            // 
            // BtnGetIndexFirstVowel
            // 
            this.BtnGetIndexFirstVowel.Location = new System.Drawing.Point(425, 207);
            this.BtnGetIndexFirstVowel.Name = "BtnGetIndexFirstVowel";
            this.BtnGetIndexFirstVowel.Size = new System.Drawing.Size(335, 52);
            this.BtnGetIndexFirstVowel.TabIndex = 17;
            this.BtnGetIndexFirstVowel.Text = "Get Index of First Vowel";
            this.BtnGetIndexFirstVowel.UseVisualStyleBackColor = true;
            this.BtnGetIndexFirstVowel.Click += new System.EventHandler(this.BtnGetIndexFirstVowel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 624);
            this.Controls.Add(this.BtnGetIndexFirstVowel);
            this.Controls.Add(this.BtnGetVowels);
            this.Controls.Add(this.BtnUppercaseFirst);
            this.Controls.Add(this.BtnReplaceBlanks);
            this.Controls.Add(this.BtnSwap);
            this.Controls.Add(this.BtnSplit);
            this.Controls.Add(this.BtnReplaceFirstSpace);
            this.Controls.Add(this.BtnIndexSecondSpace);
            this.Controls.Add(this.BtnIndexFirstSpace);
            this.Controls.Add(this.BtnCountUpperCase);
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
        private System.Windows.Forms.Button BtnCountUpperCase;
        private System.Windows.Forms.Button BtnIndexFirstSpace;
        private System.Windows.Forms.Button BtnIndexSecondSpace;
        private System.Windows.Forms.Button BtnReplaceFirstSpace;
        private System.Windows.Forms.Button BtnSplit;
        private System.Windows.Forms.Button BtnSwap;
        private System.Windows.Forms.Button BtnReplaceBlanks;
        private System.Windows.Forms.Button BtnUppercaseFirst;
        private System.Windows.Forms.Button BtnGetVowels;
        private System.Windows.Forms.Button BtnGetIndexFirstVowel;
    }
}

