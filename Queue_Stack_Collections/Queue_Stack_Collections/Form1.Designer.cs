namespace Queue_Stack_Collections
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddValue = new System.Windows.Forms.TextBox();
            this.BtnEnqueueValue = new System.Windows.Forms.Button();
            this.BtnEnqueueRandomValue = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnDequeue = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.BtnDequeue);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.BtnEnqueueRandomValue);
            this.panel1.Controls.Add(this.BtnEnqueueValue);
            this.panel1.Controls.Add(this.txtAddValue);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 382);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Queue Collection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value";
            // 
            // txtAddValue
            // 
            this.txtAddValue.Location = new System.Drawing.Point(104, 81);
            this.txtAddValue.Name = "txtAddValue";
            this.txtAddValue.Size = new System.Drawing.Size(203, 26);
            this.txtAddValue.TabIndex = 2;
            // 
            // BtnEnqueueValue
            // 
            this.BtnEnqueueValue.Location = new System.Drawing.Point(330, 75);
            this.BtnEnqueueValue.Name = "BtnEnqueueValue";
            this.BtnEnqueueValue.Size = new System.Drawing.Size(106, 39);
            this.BtnEnqueueValue.TabIndex = 3;
            this.BtnEnqueueValue.Text = "EnQueue";
            this.BtnEnqueueValue.UseVisualStyleBackColor = true;
            this.BtnEnqueueValue.Click += new System.EventHandler(this.BtnEnqueueValue_Click);
            // 
            // BtnEnqueueRandomValue
            // 
            this.BtnEnqueueRandomValue.Location = new System.Drawing.Point(27, 120);
            this.BtnEnqueueRandomValue.Name = "BtnEnqueueRandomValue";
            this.BtnEnqueueRandomValue.Size = new System.Drawing.Size(206, 39);
            this.BtnEnqueueRandomValue.TabIndex = 4;
            this.BtnEnqueueRandomValue.Text = "EnQueue Random Value";
            this.BtnEnqueueRandomValue.UseVisualStyleBackColor = true;
            this.BtnEnqueueRandomValue.Click += new System.EventHandler(this.BtnEnqueueRandomValue_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(27, 180);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 184);
            this.listBox1.TabIndex = 5;
            // 
            // BtnDequeue
            // 
            this.BtnDequeue.Location = new System.Drawing.Point(239, 120);
            this.BtnDequeue.Name = "BtnDequeue";
            this.BtnDequeue.Size = new System.Drawing.Size(197, 39);
            this.BtnDequeue.TabIndex = 6;
            this.BtnDequeue.Text = "DeQueue";
            this.BtnDequeue.UseVisualStyleBackColor = true;
            this.BtnDequeue.Click += new System.EventHandler(this.BtnDequeue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(504, 426);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnEnqueueRandomValue;
        private System.Windows.Forms.Button BtnEnqueueValue;
        private System.Windows.Forms.TextBox txtAddValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDequeue;
    }
}

