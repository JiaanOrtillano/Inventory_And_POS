namespace POS_DDT
{
    partial class Update
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.warehouse_update_cmbox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.brandtxt = new MetroFramework.Controls.MetroTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.producttxt = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.product_view_update_datagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.product_view_update_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(713, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 29);
            this.label7.TabIndex = 34;
            this.label7.Text = "Warehouse location";
            // 
            // warehouse_update_cmbox
            // 
            this.warehouse_update_cmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.warehouse_update_cmbox.FormattingEnabled = true;
            this.warehouse_update_cmbox.Location = new System.Drawing.Point(711, 163);
            this.warehouse_update_cmbox.Name = "warehouse_update_cmbox";
            this.warehouse_update_cmbox.Size = new System.Drawing.Size(215, 21);
            this.warehouse_update_cmbox.TabIndex = 33;
            this.warehouse_update_cmbox.SelectedIndexChanged += new System.EventHandler(this.Warehouse_update_cmbox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(92, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 29);
            this.label10.TabIndex = 52;
            this.label10.Text = "Search Product";
            // 
            // brandtxt
            // 
            this.brandtxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.brandtxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.brandtxt.CustomButton.Image = null;
            this.brandtxt.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.brandtxt.CustomButton.Name = "";
            this.brandtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.brandtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.brandtxt.CustomButton.TabIndex = 1;
            this.brandtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.brandtxt.CustomButton.UseSelectable = true;
            this.brandtxt.CustomButton.Visible = false;
            this.brandtxt.Lines = new string[0];
            this.brandtxt.Location = new System.Drawing.Point(395, 163);
            this.brandtxt.MaxLength = 32767;
            this.brandtxt.Name = "brandtxt";
            this.brandtxt.PasswordChar = '\0';
            this.brandtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.brandtxt.SelectedText = "";
            this.brandtxt.SelectionLength = 0;
            this.brandtxt.SelectionStart = 0;
            this.brandtxt.ShortcutsEnabled = true;
            this.brandtxt.Size = new System.Drawing.Size(215, 23);
            this.brandtxt.TabIndex = 51;
            this.brandtxt.UseSelectable = true;
            this.brandtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.brandtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.brandtxt.TextChanged += new System.EventHandler(this.Brandtxt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(420, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 29);
            this.label11.TabIndex = 50;
            this.label11.Text = "Search Brand";
            // 
            // producttxt
            // 
            // 
            // 
            // 
            this.producttxt.CustomButton.Image = null;
            this.producttxt.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.producttxt.CustomButton.Name = "";
            this.producttxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.producttxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.producttxt.CustomButton.TabIndex = 1;
            this.producttxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.producttxt.CustomButton.UseSelectable = true;
            this.producttxt.CustomButton.Visible = false;
            this.producttxt.Lines = new string[0];
            this.producttxt.Location = new System.Drawing.Point(74, 163);
            this.producttxt.MaxLength = 32767;
            this.producttxt.Name = "producttxt";
            this.producttxt.PasswordChar = '\0';
            this.producttxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.producttxt.SelectedText = "";
            this.producttxt.SelectionLength = 0;
            this.producttxt.SelectionStart = 0;
            this.producttxt.ShortcutsEnabled = true;
            this.producttxt.Size = new System.Drawing.Size(215, 23);
            this.producttxt.TabIndex = 49;
            this.producttxt.UseSelectable = true;
            this.producttxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.producttxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.producttxt.TextChanged += new System.EventHandler(this.Producttxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 48);
            this.label1.TabIndex = 54;
            this.label1.Text = "Update Inventory";
            // 
            // product_view_update_datagrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(191)))), ((int)(((byte)(221)))));
            this.product_view_update_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.product_view_update_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.product_view_update_datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.product_view_update_datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(191)))), ((int)(((byte)(221)))));
            this.product_view_update_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.product_view_update_datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.product_view_update_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(191)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(159)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_view_update_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.product_view_update_datagrid.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(159)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.product_view_update_datagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.product_view_update_datagrid.EnableHeadersVisualStyles = false;
            this.product_view_update_datagrid.GridColor = System.Drawing.Color.White;
            this.product_view_update_datagrid.Location = new System.Drawing.Point(74, 221);
            this.product_view_update_datagrid.Name = "product_view_update_datagrid";
            this.product_view_update_datagrid.ReadOnly = true;
            this.product_view_update_datagrid.RowHeadersVisible = false;
            this.product_view_update_datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.product_view_update_datagrid.RowTemplate.Height = 40;
            this.product_view_update_datagrid.RowTemplate.ReadOnly = true;
            this.product_view_update_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.product_view_update_datagrid.Size = new System.Drawing.Size(862, 410);
            this.product_view_update_datagrid.TabIndex = 56;
            this.product_view_update_datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Product_view_update_datagrid_CellClick);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(191)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.product_view_update_datagrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.brandtxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.producttxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.warehouse_update_cmbox);
            this.Name = "Update";
            this.Size = new System.Drawing.Size(991, 709);
            this.Load += new System.EventHandler(this.Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_view_update_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox warehouse_update_cmbox;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Controls.MetroTextBox brandtxt;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroTextBox producttxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView product_view_update_datagrid;
    }
}
