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
            this.BtnDequeue = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnEnqueueRandomValue = new System.Windows.Forms.Button();
            this.BtnEnqueueValue = new System.Windows.Forms.Button();
            this.txtAddValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPeek = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnDequeue2 = new System.Windows.Forms.Button();
            this.BtnEnqueueRandomValue2 = new System.Windows.Forms.Button();
            this.BtnEnqueueValue2 = new System.Windows.Forms.Button();
            this.BtnPeek2 = new System.Windows.Forms.Button();
            this.BtnMerge = new System.Windows.Forms.Button();
            this.BtnRemoveOdds = new System.Windows.Forms.Button();
            this.BtnRemoveOdds2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.BtnRemoveOdds2);
            this.panel1.Controls.Add(this.BtnRemoveOdds);
            this.panel1.Controls.Add(this.BtnMerge);
            this.panel1.Controls.Add(this.BtnPeek2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BtnDequeue2);
            this.panel1.Controls.Add(this.BtnEnqueueRandomValue2);
            this.panel1.Controls.Add(this.BtnEnqueueValue2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnPeek);
            this.panel1.Controls.Add(this.BtnDequeue);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.BtnEnqueueRandomValue);
            this.panel1.Controls.Add(this.BtnEnqueueValue);
            this.panel1.Controls.Add(this.txtAddValue);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 441);
            this.panel1.TabIndex = 0;
            // 
            // BtnDequeue
            // 
            this.BtnDequeue.Location = new System.Drawing.Point(31, 247);
            this.BtnDequeue.Name = "BtnDequeue";
            this.BtnDequeue.Size = new System.Drawing.Size(197, 39);
            this.BtnDequeue.TabIndex = 6;
            this.BtnDequeue.Text = "DeQueue";
            this.BtnDequeue.UseVisualStyleBackColor = true;
            this.BtnDequeue.Click += new System.EventHandler(this.BtnDequeue_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(466, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 384);
            this.listBox1.TabIndex = 5;
            // 
            // BtnEnqueueRandomValue
            // 
            this.BtnEnqueueRandomValue.Location = new System.Drawing.Point(31, 202);
            this.BtnEnqueueRandomValue.Name = "BtnEnqueueRandomValue";
            this.BtnEnqueueRandomValue.Size = new System.Drawing.Size(197, 39);
            this.BtnEnqueueRandomValue.TabIndex = 4;
            this.BtnEnqueueRandomValue.Text = "EnQueue Random Value";
            this.BtnEnqueueRandomValue.UseVisualStyleBackColor = true;
            this.BtnEnqueueRandomValue.Click += new System.EventHandler(this.BtnEnqueueRandomValue_Click);
            // 
            // BtnEnqueueValue
            // 
            this.BtnEnqueueValue.Location = new System.Drawing.Point(31, 157);
            this.BtnEnqueueValue.Name = "BtnEnqueueValue";
            this.BtnEnqueueValue.Size = new System.Drawing.Size(197, 39);
            this.BtnEnqueueValue.TabIndex = 3;
            this.BtnEnqueueValue.Text = "EnQueue";
            this.BtnEnqueueValue.UseVisualStyleBackColor = true;
            this.BtnEnqueueValue.Click += new System.EventHandler(this.BtnEnqueueValue_Click);
            // 
            // txtAddValue
            // 
            this.txtAddValue.Location = new System.Drawing.Point(104, 81);
            this.txtAddValue.Name = "txtAddValue";
            this.txtAddValue.Size = new System.Drawing.Size(336, 26);
            this.txtAddValue.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Queue Collection";
            // 
            // BtnPeek
            // 
            this.BtnPeek.Location = new System.Drawing.Point(31, 292);
            this.BtnPeek.Name = "BtnPeek";
            this.BtnPeek.Size = new System.Drawing.Size(197, 39);
            this.BtnPeek.TabIndex = 7;
            this.BtnPeek.Text = "Peek";
            this.BtnPeek.UseVisualStyleBackColor = true;
            this.BtnPeek.Click += new System.EventHandler(this.BtnPeek_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Queue 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Queue 2";
            // 
            // BtnDequeue2
            // 
            this.BtnDequeue2.Location = new System.Drawing.Point(243, 247);
            this.BtnDequeue2.Name = "BtnDequeue2";
            this.BtnDequeue2.Size = new System.Drawing.Size(197, 39);
            this.BtnDequeue2.TabIndex = 11;
            this.BtnDequeue2.Text = "DeQueue";
            this.BtnDequeue2.UseVisualStyleBackColor = true;
            this.BtnDequeue2.Click += new System.EventHandler(this.BtnDequeue2_Click);
            // 
            // BtnEnqueueRandomValue2
            // 
            this.BtnEnqueueRandomValue2.Location = new System.Drawing.Point(243, 202);
            this.BtnEnqueueRandomValue2.Name = "BtnEnqueueRandomValue2";
            this.BtnEnqueueRandomValue2.Size = new System.Drawing.Size(197, 39);
            this.BtnEnqueueRandomValue2.TabIndex = 10;
            this.BtnEnqueueRandomValue2.Text = "EnQueue Random Value";
            this.BtnEnqueueRandomValue2.UseVisualStyleBackColor = true;
            this.BtnEnqueueRandomValue2.Click += new System.EventHandler(this.BtnEnqueueRandomValue2_Click);
            // 
            // BtnEnqueueValue2
            // 
            this.BtnEnqueueValue2.Location = new System.Drawing.Point(243, 157);
            this.BtnEnqueueValue2.Name = "BtnEnqueueValue2";
            this.BtnEnqueueValue2.Size = new System.Drawing.Size(197, 39);
            this.BtnEnqueueValue2.TabIndex = 9;
            this.BtnEnqueueValue2.Text = "EnQueue";
            this.BtnEnqueueValue2.UseVisualStyleBackColor = true;
            this.BtnEnqueueValue2.Click += new System.EventHandler(this.BtnEnqueueValue2_Click);
            // 
            // BtnPeek2
            // 
            this.BtnPeek2.Location = new System.Drawing.Point(243, 292);
            this.BtnPeek2.Name = "BtnPeek2";
            this.BtnPeek2.Size = new System.Drawing.Size(197, 39);
            this.BtnPeek2.TabIndex = 13;
            this.BtnPeek2.Text = "Peek";
            this.BtnPeek2.UseVisualStyleBackColor = true;
            this.BtnPeek2.Click += new System.EventHandler(this.BtnPeek2_Click);
            // 
            // BtnMerge
            // 
            this.BtnMerge.Location = new System.Drawing.Point(104, 384);
            this.BtnMerge.Name = "BtnMerge";
            this.BtnMerge.Size = new System.Drawing.Size(281, 39);
            this.BtnMerge.TabIndex = 14;
            this.BtnMerge.Text = "MEEEEEEEERGE";
            this.BtnMerge.UseVisualStyleBackColor = true;
            this.BtnMerge.Click += new System.EventHandler(this.BtnMerge_Click);
            // 
            // BtnRemoveOdds
            // 
            this.BtnRemoveOdds.Location = new System.Drawing.Point(31, 337);
            this.BtnRemoveOdds.Name = "BtnRemoveOdds";
            this.BtnRemoveOdds.Size = new System.Drawing.Size(197, 39);
            this.BtnRemoveOdds.TabIndex = 15;
            this.BtnRemoveOdds.Text = "Remove Odds :(";
            this.BtnRemoveOdds.UseVisualStyleBackColor = true;
            this.BtnRemoveOdds.Click += new System.EventHandler(this.BtnRemoveOdds_Click);
            // 
            // BtnRemoveOdds2
            // 
            this.BtnRemoveOdds2.Location = new System.Drawing.Point(243, 337);
            this.BtnRemoveOdds2.Name = "BtnRemoveOdds2";
            this.BtnRemoveOdds2.Size = new System.Drawing.Size(197, 39);
            this.BtnRemoveOdds2.TabIndex = 16;
            this.BtnRemoveOdds2.Text = "Remove Odds :(";
            this.BtnRemoveOdds2.UseVisualStyleBackColor = true;
            this.BtnRemoveOdds2.Click += new System.EventHandler(this.BtnRemoveOdds2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(791, 476);
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
        private System.Windows.Forms.Button BtnPeek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnDequeue2;
        private System.Windows.Forms.Button BtnEnqueueRandomValue2;
        private System.Windows.Forms.Button BtnEnqueueValue2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnPeek2;
        private System.Windows.Forms.Button BtnMerge;
        private System.Windows.Forms.Button BtnRemoveOdds;
        private System.Windows.Forms.Button BtnRemoveOdds2;
    }
}

