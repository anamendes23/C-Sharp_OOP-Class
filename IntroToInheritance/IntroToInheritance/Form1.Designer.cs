namespace IntroToInheritance
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCreateCircle = new System.Windows.Forms.Button();
            this.btnCreateCylinder = new System.Windows.Forms.Button();
            this.btnCreateSphere = new System.Windows.Forms.Button();
            this.btnCreateCone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(36, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(989, 330);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Radius";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Height";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Perimeter";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Area";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Volume";
            this.columnHeader6.Width = 150;
            // 
            // btnCreateCircle
            // 
            this.btnCreateCircle.Location = new System.Drawing.Point(36, 393);
            this.btnCreateCircle.Name = "btnCreateCircle";
            this.btnCreateCircle.Size = new System.Drawing.Size(136, 58);
            this.btnCreateCircle.TabIndex = 1;
            this.btnCreateCircle.Text = "Create Circle";
            this.btnCreateCircle.UseVisualStyleBackColor = true;
            this.btnCreateCircle.Click += new System.EventHandler(this.btnCreateCircle_Click);
            // 
            // btnCreateCylinder
            // 
            this.btnCreateCylinder.Location = new System.Drawing.Point(200, 393);
            this.btnCreateCylinder.Name = "btnCreateCylinder";
            this.btnCreateCylinder.Size = new System.Drawing.Size(136, 58);
            this.btnCreateCylinder.TabIndex = 2;
            this.btnCreateCylinder.Text = "Create Cylinder";
            this.btnCreateCylinder.UseVisualStyleBackColor = true;
            this.btnCreateCylinder.Click += new System.EventHandler(this.btnCreateCylinder_Click);
            // 
            // btnCreateSphere
            // 
            this.btnCreateSphere.Location = new System.Drawing.Point(364, 393);
            this.btnCreateSphere.Name = "btnCreateSphere";
            this.btnCreateSphere.Size = new System.Drawing.Size(136, 58);
            this.btnCreateSphere.TabIndex = 3;
            this.btnCreateSphere.Text = "Create Sphere";
            this.btnCreateSphere.UseVisualStyleBackColor = true;
            this.btnCreateSphere.Click += new System.EventHandler(this.btnCreateSphere_Click);
            // 
            // btnCreateCone
            // 
            this.btnCreateCone.Location = new System.Drawing.Point(527, 393);
            this.btnCreateCone.Name = "btnCreateCone";
            this.btnCreateCone.Size = new System.Drawing.Size(136, 58);
            this.btnCreateCone.TabIndex = 4;
            this.btnCreateCone.Text = "Create Cone";
            this.btnCreateCone.UseVisualStyleBackColor = true;
            this.btnCreateCone.Click += new System.EventHandler(this.btnCreateCone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 552);
            this.Controls.Add(this.btnCreateCone);
            this.Controls.Add(this.btnCreateSphere);
            this.Controls.Add(this.btnCreateCylinder);
            this.Controls.Add(this.btnCreateCircle);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnCreateCircle;
        private System.Windows.Forms.Button btnCreateCylinder;
        private System.Windows.Forms.Button btnCreateSphere;
        private System.Windows.Forms.Button btnCreateCone;
    }
}

