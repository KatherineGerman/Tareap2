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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            
            this.btnMantP = new System.Windows.Forms.Button();
            this.btnListP = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 36);
            this.panel1.TabIndex = 7;
            // 
            
            // 
            // btnMantP
            // 
            this.btnMantP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMantP.FlatAppearance.BorderSize = 0;
            this.btnMantP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantP.Font = new System.Drawing.Font("SimSun-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantP.ForeColor = System.Drawing.Color.White;
            this.btnMantP.Image = global::EMarket.Properties.Resources.maintenance_30px;
            this.btnMantP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantP.Location = new System.Drawing.Point(720, 240);
            this.btnMantP.Name = "btnMantP";
            this.btnMantP.Size = new System.Drawing.Size(200, 70);
            this.btnMantP.TabIndex = 2;
            this.btnMantP.Text = "PRODUCTOS";
            this.btnMantP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMantP.UseVisualStyleBackColor = false;
            // 
            // btnListP
            // 
            this.btnListP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnListP.FlatAppearance.BorderSize = 0;
            this.btnListP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListP.Font = new System.Drawing.Font("MingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListP.ForeColor = System.Drawing.Color.White;
            this.btnListP.Image = global::EMarket.Properties.Resources.ingredients_24px;
            this.btnListP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListP.Location = new System.Drawing.Point(84, 240);
            this.btnListP.Name = "btnListP";
            this.btnListP.Size = new System.Drawing.Size(185, 70);
            this.btnListP.TabIndex = 0;
            this.btnListP.Text = "LISTADO DE PRODUCTOS";
            this.btnListP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListP.UseVisualStyleBackColor = false;
            this.btnListP.Click += new System.EventHandler(this.btnListP_Click);
            // 
            // btnCat
            // 
            this.btnCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCat.FlatAppearance.BorderSize = 0;
            this.btnCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCat.Font = new System.Drawing.Font("SimSun-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCat.ForeColor = System.Drawing.Color.White;
            this.btnCat.Image = global::EMarket.Properties.Resources.maintenance_30px;
            this.btnCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCat.Location = new System.Drawing.Point(393, 240);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(189, 70);
            this.btnCat.TabIndex = 1;
            this.btnCat.Text = "CATEGORIA";
            this.btnCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCat.UseVisualStyleBackColor = false;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMantP);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.btnListP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMantP;
        private System.Windows.Forms.Button btnListP;
        private System.Windows.Forms.Button btnCat;
       
      
    }
}

