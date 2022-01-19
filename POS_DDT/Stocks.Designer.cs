namespace POS_DDT
{
    partial class Stocks
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
            this.product_search_txtbox = new MetroFramework.Controls.MetroTextBox();
            this.brand_txtbox = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.warehouse_search_cmbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.product_datagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.product_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // product_search_txtbox
            // 
            this.product_search_txtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.product_search_txtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.product_search_txtbox.CustomButton.Image = null;
            this.product_search_txtbox.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.product_search_txtbox.CustomButton.Name = "";
            this.product_search_txtbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.product_search_txtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.product_search_txtbox.CustomButton.TabIndex = 1;
            this.product_search_txtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.product_search_txtbox.CustomButton.UseSelectable = true;
            this.product_search_txtbox.CustomButton.Visible = false;
            this.product_search_txtbox.Lines = new string[0];
            this.product_search_txtbox.Location = new System.Drawing.Point(68, 152);
            this.product_search_txtbox.MaxLength = 32767;
            this.product_search_txtbox.Name = "product_search_txtbox";
            this.product_search_txtbox.PasswordChar = '\0';
            this.product_search_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.product_search_txtbox.SelectedText = "";
            this.product_search_txtbox.SelectionLength = 0;
            this.product_search_txtbox.SelectionStart = 0;
            this.product_search_txtbox.ShortcutsEnabled = true;
            this.product_search_txtbox.Size = new System.Drawing.Size(172, 23);
            this.product_search_txtbox.TabIndex = 0;
            this.product_search_txtbox.UseSelectable = true;
            this.product_search_txtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.product_search_txtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.product_search_txtbox.TextChanged += new System.EventHandler(this.product_search_txtbox_TextChanged);
            this.product_search_txtbox.Click += new System.EventHandler(this.Product_search_txtbox_Click);
            // 
            // brand_txtbox
            // 
            // 
            // 
            // 
            this.brand_txtbox.CustomButton.Image = null;
            this.brand_txtbox.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.brand_txtbox.CustomButton.Name = "";
            this.brand_txtbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.brand_txtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.brand_txtbox.CustomButton.TabIndex = 1;
            this.brand_txtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.brand_txtbox.CustomButton.UseSelectable = true;
            this.brand_txtbox.CustomButton.Visible = false;
            this.brand_txtbox.Lines = new string[0];
            this.brand_txtbox.Location = new System.Drawing.Point(390, 152);
            this.brand_txtbox.MaxLength = 32767;
            this.brand_txtbox.Name = "brand_txtbox";
            this.brand_txtbox.PasswordChar = '\0';
            this.brand_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.brand_txtbox.SelectedText = "";
            this.brand_txtbox.SelectionLength = 0;
            this.brand_txtbox.SelectionStart = 0;
            this.brand_txtbox.ShortcutsEnabled = true;
            this.brand_txtbox.Size = new System.Drawing.Size(195, 23);
            this.brand_txtbox.TabIndex = 1;
            this.brand_txtbox.UseSelectable = true;
            this.brand_txtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.brand_txtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.brand_txtbox.TextChanged += new System.EventHandler(this.Brand_txtbox_TextChanged);
            this.brand_txtbox.Click += new System.EventHandler(this.Brand_txtbox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Brand";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(711, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 26);
            this.label7.TabIndex = 28;
            this.label7.Text = "Warehouse location";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // warehouse_search_cmbox
            // 
            this.warehouse_search_cmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.warehouse_search_cmbox.FormattingEnabled = true;
            this.warehouse_search_cmbox.Location = new System.Drawing.Point(713, 154);
            this.warehouse_search_cmbox.Name = "warehouse_search_cmbox";
            this.warehouse_search_cmbox.Size = new System.Drawing.Size(206, 21);
            this.warehouse_search_cmbox.TabIndex = 27;
            this.warehouse_search_cmbox.SelectedIndexChanged += new System.EventHandler(this.Warehouse_search_cmbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 48);
            this.label1.TabIndex = 29;
            this.label1.Text = "Inventory List";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // product_datagrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(191)))), ((int)(((byte)(221)))));
            this.product_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.product_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.product_datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.product_datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(191)))), ((int)(((byte)(221)))));
            this.product_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.product_datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.product_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(191)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(159)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.product_datagrid.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(159)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.product_datagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.product_datagrid.EnableHeadersVisualStyles = false;
            this.product_datagrid.GridColor = System.Drawing.Color.White;
            this.product_datagrid.Location = new System.Drawing.Point(68, 216);
            this.product_datagrid.Name = "product_datagrid";
            this.product_datagrid.ReadOnly = true;
            this.product_datagrid.RowHeadersVisible = false;
            this.product_datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.product_datagrid.RowTemplate.Height = 40;
            this.product_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.product_datagrid.Size = new System.Drawing.Size(862, 410);
            this.product_datagrid.TabIndex = 41;
            // 
            // Stocks
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(191)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.product_datagrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.warehouse_search_cmbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brand_txtbox);
            this.Controls.Add(this.product_search_txtbox);
            this.Name = "Stocks";
            this.Size = new System.Drawing.Size(991, 709);
            this.Load += new System.EventHandler(this.Stocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

     
        private MetroFramework.Controls.MetroTextBox product_search_txtbox;
        private MetroFramework.Controls.MetroTextBox brand_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox warehouse_search_cmbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView product_datagrid;
    }
}
