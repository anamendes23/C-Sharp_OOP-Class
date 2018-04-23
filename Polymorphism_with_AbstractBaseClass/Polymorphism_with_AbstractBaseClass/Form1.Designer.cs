namespace Polymorphism_with_AbstractBaseClass
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
            this.btnCreateCone = new System.Windows.Forms.Button();
            this.btnSphere = new System.Windows.Forms.Button();
            this.btnCreateCylinder = new System.Windows.Forms.Button();
            this.btnCreateCircle = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnCreateCone
            // 
            this.btnCreateCone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCone.Location = new System.Drawing.Point(435, 424);
            this.btnCreateCone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateCone.Name = "btnCreateCone";
            this.btnCreateCone.Size = new System.Drawing.Size(404, 43);
            this.btnCreateCone.TabIndex = 14;
            this.btnCreateCone.Text = "Create Cone";
            this.btnCreateCone.UseVisualStyleBackColor = true;
            this.btnCreateCone.Click += new System.EventHandler(this.btnCreateCone_Click);
            // 
            // btnSphere
            // 
            this.btnSphere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSphere.Location = new System.Drawing.Point(435, 372);
            this.btnSphere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSphere.Name = "btnSphere";
            this.btnSphere.Size = new System.Drawing.Size(404, 43);
            this.btnSphere.TabIndex = 13;
            this.btnSphere.Text = "Create Sphere";
            this.btnSphere.UseVisualStyleBackColor = true;
            this.btnSphere.Click += new System.EventHandler(this.btnSphere_Click);
            // 
            // btnCreateCylinder
            // 
            this.btnCreateCylinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCylinder.Location = new System.Drawing.Point(23, 424);
            this.btnCreateCylinder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateCylinder.Name = "btnCreateCylinder";
            this.btnCreateCylinder.Size = new System.Drawing.Size(404, 43);
            this.btnCreateCylinder.TabIndex = 12;
            this.btnCreateCylinder.Text = "Create Cylinder";
            this.btnCreateCylinder.UseVisualStyleBackColor = true;
            this.btnCreateCylinder.Click += new System.EventHandler(this.btnCreateCylinder_Click);
            // 
            // btnCreateCircle
            // 
            this.btnCreateCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCircle.Location = new System.Drawing.Point(23, 371);
            this.btnCreateCircle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateCircle.Name = "btnCreateCircle";
            this.btnCreateCircle.Size = new System.Drawing.Size(404, 43);
            this.btnCreateCircle.TabIndex = 11;
            this.btnCreateCircle.Text = "Create Circle";
            this.btnCreateCircle.UseVisualStyleBackColor = true;
            this.btnCreateCircle.Click += new System.EventHandler(this.btnCreateCircle_Click);
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
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(23, 24);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(994, 307);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Radius";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Height";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Perimeter";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Area";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Volume";
            this.columnHeader6.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 485);
            this.Controls.Add(this.btnCreateCone);
            this.Controls.Add(this.btnSphere);
            this.Controls.Add(this.btnCreateCylinder);
            this.Controls.Add(this.btnCreateCircle);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateCone;
        private System.Windows.Forms.Button btnSphere;
        private System.Windows.Forms.Button btnCreateCylinder;
        private System.Windows.Forms.Button btnCreateCircle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

