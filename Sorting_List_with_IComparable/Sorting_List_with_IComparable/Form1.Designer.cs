namespace Sorting_List_with_IComparable
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnSortNumbers = new System.Windows.Forms.Button();
            this.btnSortByAccNumber = new System.Windows.Forms.Button();
            this.btnSortByBalance = new System.Windows.Forms.Button();
            this.btnSortByDate = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(29, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(166, 384);
            this.listBox1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(250, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(822, 313);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnSortNumbers
            // 
            this.btnSortNumbers.Location = new System.Drawing.Point(29, 441);
            this.btnSortNumbers.Name = "btnSortNumbers";
            this.btnSortNumbers.Size = new System.Drawing.Size(166, 40);
            this.btnSortNumbers.TabIndex = 2;
            this.btnSortNumbers.Text = "Sort Numbers";
            this.btnSortNumbers.UseVisualStyleBackColor = true;
            this.btnSortNumbers.Click += new System.EventHandler(this.btnSortNumbers_Click);
            // 
            // btnSortByAccNumber
            // 
            this.btnSortByAccNumber.Location = new System.Drawing.Point(384, 356);
            this.btnSortByAccNumber.Name = "btnSortByAccNumber";
            this.btnSortByAccNumber.Size = new System.Drawing.Size(567, 37);
            this.btnSortByAccNumber.TabIndex = 3;
            this.btnSortByAccNumber.Text = "Sort by Account Number";
            this.btnSortByAccNumber.UseVisualStyleBackColor = true;
            this.btnSortByAccNumber.Click += new System.EventHandler(this.btnSortByAccNumber_Click);
            // 
            // btnSortByBalance
            // 
            this.btnSortByBalance.Location = new System.Drawing.Point(384, 401);
            this.btnSortByBalance.Name = "btnSortByBalance";
            this.btnSortByBalance.Size = new System.Drawing.Size(567, 37);
            this.btnSortByBalance.TabIndex = 4;
            this.btnSortByBalance.Text = "Sort by Balance";
            this.btnSortByBalance.UseVisualStyleBackColor = true;
            this.btnSortByBalance.Click += new System.EventHandler(this.btnSortByBalance_Click);
            // 
            // btnSortByDate
            // 
            this.btnSortByDate.Location = new System.Drawing.Point(384, 444);
            this.btnSortByDate.Name = "btnSortByDate";
            this.btnSortByDate.Size = new System.Drawing.Size(567, 37);
            this.btnSortByDate.TabIndex = 5;
            this.btnSortByDate.Text = "Sort by Date";
            this.btnSortByDate.UseVisualStyleBackColor = true;
            this.btnSortByDate.Click += new System.EventHandler(this.btnSortByDate_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Account Number";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Balance";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date Created";
            this.columnHeader3.Width = 180;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 516);
            this.Controls.Add(this.btnSortByDate);
            this.Controls.Add(this.btnSortByBalance);
            this.Controls.Add(this.btnSortByAccNumber);
            this.Controls.Add(this.btnSortNumbers);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnSortNumbers;
        private System.Windows.Forms.Button btnSortByAccNumber;
        private System.Windows.Forms.Button btnSortByBalance;
        private System.Windows.Forms.Button btnSortByDate;
    }
}

