namespace EMarket.Vista
{
    partial class CategoriaVista
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
			this.txtsearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gvproducts = new System.Windows.Forms.DataGridView();
			this.txtdescription = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnsearch = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.btndelete = new System.Windows.Forms.Button();
			this.btnupdate = new System.Windows.Forms.Button();
			this.btnsave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gvproducts)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtsearch
			// 
			this.txtsearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtsearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtsearch.ForeColor = System.Drawing.Color.Silver;
			this.txtsearch.Location = new System.Drawing.Point(40, 68);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new System.Drawing.Size(474, 31);
			this.txtsearch.TabIndex = 25;
			this.txtsearch.Text = "Search";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
			this.label1.Location = new System.Drawing.Point(357, -9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(283, 57);
			this.label1.TabIndex = 24;
			this.label1.Text = "Categories";
			// 
			// gvproducts
			// 
			this.gvproducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gvproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvproducts.Location = new System.Drawing.Point(40, 114);
			this.gvproducts.Name = "gvproducts";
			this.gvproducts.Size = new System.Drawing.Size(534, 273);
			this.gvproducts.TabIndex = 23;
			// 
			// txtdescription
			// 
			this.txtdescription.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtdescription.ForeColor = System.Drawing.Color.Silver;
			this.txtdescription.Location = new System.Drawing.Point(6, 46);
			this.txtdescription.Name = "txtdescription";
			this.txtdescription.Size = new System.Drawing.Size(304, 31);
			this.txtdescription.TabIndex = 15;
			this.txtdescription.Text = "Category Name";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.btnsave);
			this.groupBox1.Controls.Add(this.txtdescription);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
			this.groupBox1.Location = new System.Drawing.Point(613, 68);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(316, 241);
			this.groupBox1.TabIndex = 26;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Categories registration";
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.comboBox1.ForeColor = System.Drawing.Color.Silver;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
			this.comboBox1.Location = new System.Drawing.Point(7, 102);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(303, 30);
			this.comboBox1.TabIndex = 20;
			this.comboBox1.Text = "State";
			// 
			// btnsearch
			// 
			this.btnsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnsearch.BackgroundImage = global::EMarket.Properties.Resources.search;
			this.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnsearch.Enabled = false;
			this.btnsearch.FlatAppearance.BorderSize = 0;
			this.btnsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
			this.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
			this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnsearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
			this.btnsearch.Location = new System.Drawing.Point(520, 68);
			this.btnsearch.Name = "btnsearch";
			this.btnsearch.Size = new System.Drawing.Size(54, 31);
			this.btnsearch.TabIndex = 30;
			this.btnsearch.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.BackgroundImage = global::EMarket.Properties.Resources.back;
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
			this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
			this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.Location = new System.Drawing.Point(40, 12);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(52, 38);
			this.button5.TabIndex = 29;
			this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click_1);
			// 
			// btndelete
			// 
			this.btndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btndelete.FlatAppearance.BorderSize = 0;
			this.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
			this.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
			this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btndelete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btndelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
			this.btndelete.Image = global::EMarket.Properties.Resources.delete02;
			this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btndelete.Location = new System.Drawing.Point(224, 397);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(163, 45);
			this.btndelete.TabIndex = 28;
			this.btndelete.Text = "Delete";
			this.btndelete.UseVisualStyleBackColor = true;
			// 
			// btnupdate
			// 
			this.btnupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnupdate.FlatAppearance.BorderSize = 0;
			this.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
			this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
			this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
			this.btnupdate.Image = global::EMarket.Properties.Resources.update02;
			this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnupdate.Location = new System.Drawing.Point(40, 397);
			this.btnupdate.Name = "btnupdate";
			this.btnupdate.Size = new System.Drawing.Size(163, 45);
			this.btnupdate.TabIndex = 27;
			this.btnupdate.Text = "Update ";
			this.btnupdate.UseVisualStyleBackColor = true;
			// 
			// btnsave
			// 
			this.btnsave.FlatAppearance.BorderSize = 0;
			this.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
			this.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
			this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnsave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
			this.btnsave.Image = global::EMarket.Properties.Resources.save01;
			this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnsave.Location = new System.Drawing.Point(7, 185);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(304, 45);
			this.btnsave.TabIndex = 19;
			this.btnsave.Text = "Save Category";
			this.btnsave.UseVisualStyleBackColor = true;
			// 
			// CategoriaVista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(968, 457);
			this.Controls.Add(this.btnsearch);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.btndelete);
			this.Controls.Add(this.btnupdate);
			this.Controls.Add(this.txtsearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gvproducts);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "CategoriaVista";
			this.Text = "CategoriaVista";
			((System.ComponentModel.ISupportInitialize)(this.gvproducts)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button btndelete;
		private System.Windows.Forms.Button btnupdate;
		private System.Windows.Forms.TextBox txtsearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView gvproducts;
		private System.Windows.Forms.Button btnsave;
		private System.Windows.Forms.TextBox txtdescription;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button btnsearch;
	}
}