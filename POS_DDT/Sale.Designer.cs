namespace POS_DDT
{
    partial class Sale
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
            this.display_pnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout_btn = new System.Windows.Forms.Button();
            this.update_product_btn = new System.Windows.Forms.Button();
            this.stock_btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // display_pnl
            // 
            this.display_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(191)))), ((int)(((byte)(221)))));
            this.display_pnl.Location = new System.Drawing.Point(296, 12);
            this.display_pnl.Name = "display_pnl";
            this.display_pnl.Size = new System.Drawing.Size(984, 709);
            this.display_pnl.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(58)))), ((int)(((byte)(116)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.update_product_btn);
            this.panel2.Controls.Add(this.stock_btn);
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 709);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(168)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(25, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sales Representative";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(191)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(110, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sale";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_DDT.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(79, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Transparent;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(191)))), ((int)(((byte)(221)))));
            this.logout_btn.Location = new System.Drawing.Point(12, 629);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(254, 54);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.Text = "Log out";
            this.logout_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // update_product_btn
            // 
            this.update_product_btn.BackColor = System.Drawing.Color.Transparent;
            this.update_product_btn.FlatAppearance.BorderSize = 0;
            this.update_product_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_product_btn.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_product_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(191)))), ((int)(((byte)(221)))));
            this.update_product_btn.Location = new System.Drawing.Point(12, 379);
            this.update_product_btn.Name = "update_product_btn";
            this.update_product_btn.Size = new System.Drawing.Size(254, 54);
            this.update_product_btn.TabIndex = 4;
            this.update_product_btn.Text = "Update Product";
            this.update_product_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_product_btn.UseVisualStyleBackColor = false;
            // 
            // stock_btn
            // 
            this.stock_btn.BackColor = System.Drawing.Color.Transparent;
            this.stock_btn.FlatAppearance.BorderSize = 0;
            this.stock_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock_btn.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(191)))), ((int)(((byte)(221)))));
            this.stock_btn.Location = new System.Drawing.Point(12, 300);
            this.stock_btn.Name = "stock_btn";
            this.stock_btn.Size = new System.Drawing.Size(254, 52);
            this.stock_btn.TabIndex = 1;
            this.stock_btn.Text = "Stocks";
            this.stock_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stock_btn.UseVisualStyleBackColor = false;
            this.stock_btn.Click += new System.EventHandler(this.Stock_btn_Click);
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(119)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.display_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel display_pnl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button stock_btn;
        private System.Windows.Forms.Button update_product_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}