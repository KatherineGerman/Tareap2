namespace EMarket
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btndelete = new System.Windows.Forms.Button();
			this.btnupdate = new System.Windows.Forms.Button();
			this.btncategories = new System.Windows.Forms.Panel();
			this.btnproducts = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.panel1.Controls.Add(this.btnproducts);
			this.panel1.Controls.Add(this.btncategories);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(269, 499);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(483, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 42);
			this.label1.TabIndex = 1;
			this.label1.Text = "Stock Product";
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(91)))));
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(280, 103);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(761, 327);
			this.dataGridView1.TabIndex = 2;
			// 
			// btndelete
			// 
			this.btndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btndelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
			this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(91)))));
			this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btndelete.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btndelete.Location = new System.Drawing.Point(280, 436);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(202, 51);
			this.btndelete.TabIndex = 3;
			this.btndelete.Text = "Delete";
			this.btndelete.UseVisualStyleBackColor = true;
			// 
			// btnupdate
			// 
			this.btnupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnupdate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
			this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(91)))));
			this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnupdate.Location = new System.Drawing.Point(490, 436);
			this.btnupdate.Name = "btnupdate";
			this.btnupdate.Size = new System.Drawing.Size(202, 51);
			this.btnupdate.TabIndex = 4;
			this.btnupdate.Text = "Update";
			this.btnupdate.UseVisualStyleBackColor = true;
			// 
			// btncategories
			// 
			this.btncategories.BackgroundImage = global::EMarket.Properties.Resources.categories;
			this.btncategories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btncategories.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btncategories.Location = new System.Drawing.Point(0, 152);
			this.btncategories.Name = "btncategories";
			this.btncategories.Size = new System.Drawing.Size(269, 100);
			this.btncategories.TabIndex = 0;
			// 
			// btnproducts
			// 
			this.btnproducts.BackgroundImage = global::EMarket.Properties.Resources.products;
			this.btnproducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnproducts.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnproducts.Location = new System.Drawing.Point(0, 12);
			this.btnproducts.Name = "btnproducts";
			this.btnproducts.Size = new System.Drawing.Size(269, 100);
			this.btnproducts.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(1048, 499);
			this.Controls.Add(this.btnupdate);
			this.Controls.Add(this.btndelete);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "Management System";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btndelete;
		private System.Windows.Forms.Button btnupdate;
		private System.Windows.Forms.Panel btnproducts;
		private System.Windows.Forms.Panel btncategories;
	}
}

