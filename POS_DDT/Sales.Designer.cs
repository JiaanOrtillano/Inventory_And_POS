namespace DALS
{
    partial class Sales
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
            this.receipt_pnl = new System.Windows.Forms.Panel();
            this.display_pnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // receipt_pnl
            // 
            this.receipt_pnl.Location = new System.Drawing.Point(999, 43);
            this.receipt_pnl.Name = "receipt_pnl";
            this.receipt_pnl.Size = new System.Drawing.Size(260, 621);
            this.receipt_pnl.TabIndex = 0;
            // 
            // display_pnl
            // 
            this.display_pnl.Location = new System.Drawing.Point(24, 43);
            this.display_pnl.Name = "display_pnl";
            this.display_pnl.Size = new System.Drawing.Size(959, 621);
            this.display_pnl.TabIndex = 1;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.display_pnl);
            this.Controls.Add(this.receipt_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel receipt_pnl;
        private System.Windows.Forms.Panel display_pnl;
    }
}