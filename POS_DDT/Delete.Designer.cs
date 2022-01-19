namespace POS_DDT
{
    partial class Delete
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
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Dwarehouse_search_cmbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dbrand_txtbox = new MetroFramework.Controls.MetroTextBox();
            this.Dproduct_search_txtbox = new MetroFramework.Controls.MetroTextBox();
            this.Dproduct_datagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dproduct_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 48);
            this.label1.TabIndex = 37;
            this.label1.Text = "Delete Item";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(647, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 33);
            this.label7.TabIndex = 36;
            this.label7.Text = "Warehouse location";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // Dwarehouse_search_cmbox
            // 
            this.Dwarehouse_search_cmbox.BackColor = System.Drawing.Color.White;
            this.Dwarehouse_search_cmbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dwarehouse_search_cmbox.FormattingEnabled = true;
            this.Dwarehouse_search_cmbox.Location = new System.Drawing.Point(674, 165);
            this.Dwarehouse_search_cmbox.Name = "Dwarehouse_search_cmbox";
            this.Dwarehouse_search_cmbox.Size = new System.Drawing.Size(206, 21);
            this.Dwarehouse_search_cmbox.TabIndex = 35;
            this.Dwarehouse_search_cmbox.SelectedIndexChanged += new System.EventHandler(this.Dwarehouse_search_cmbox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 33);
            this.label4.TabIndex = 34;
            this.label4.Text = "Brand";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 33);
            this.label3.TabIndex = 33;
            this.label3.Text = "Product";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Dbrand_txtbox
            // 
            // 
            // 
            // 
            this.Dbrand_txtbox.CustomButton.Image = null;
            this.Dbrand_txtbox.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.Dbrand_txtbox.CustomButton.Name = "";
            this.Dbrand_txtbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Dbrand_txtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Dbrand_txtbox.CustomButton.TabIndex = 1;
            this.Dbrand_txtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Dbrand_txtbox.CustomButton.UseSelectable = true;
            this.Dbrand_txtbox.CustomButton.Visible = false;
            this.Dbrand_txtbox.Lines = new string[0];
            this.Dbrand_txtbox.Location = new System.Drawing.Point(397, 165);
            this.Dbrand_txtbox.MaxLength = 32767;
            this.Dbrand_txtbox.Name = "Dbrand_txtbox";
            this.Dbrand_txtbox.PasswordChar = '\0';
            this.Dbrand_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Dbrand_txtbox.SelectedText = "";
            this.Dbrand_txtbox.SelectionLength = 0;
            this.Dbrand_txtbox.SelectionStart = 0;
            this.Dbrand_txtbox.ShortcutsEnabled = true;
            this.Dbrand_txtbox.Size = new System.Drawing.Size(208, 23);
            this.Dbrand_txtbox.TabIndex = 31;
            this.Dbrand_txtbox.UseSelectable = true;
            this.Dbrand_txtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Dbrand_txtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Dbrand_txtbox.TextChanged += new System.EventHandler(this.Dbrand_txtbox_TextChanged);
            this.Dbrand_txtbox.Click += new System.EventHandler(this.Dbrand_txtbox_Click);
            // 
            // Dproduct_search_txtbox
            // 
            this.Dproduct_search_txtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Dproduct_search_txtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.Dproduct_search_txtbox.CustomButton.Image = null;
            this.Dproduct_search_txtbox.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.Dproduct_search_txtbox.CustomButton.Name = "";
            this.Dproduct_search_txtbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Dproduct_search_txtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Dproduct_search_txtbox.CustomButton.TabIndex = 1;
            this.Dproduct_search_txtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Dproduct_search_txtbox.CustomButton.UseSelectable = true;
            this.Dproduct_search_txtbox.CustomButton.Visible = false;
            this.Dproduct_search_txtbox.Lines = new string[0];
            this.Dproduct_search_txtbox.Location = new System.Drawing.Point(132, 165);
            this.Dproduct_search_txtbox.MaxLength = 32767;
            this.Dproduct_search_txtbox.Name = "Dproduct_search_txtbox";
            this.Dproduct_search_txtbox.PasswordChar = '\0';
            this.Dproduct_search_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Dproduct_search_txtbox.SelectedText = "";
            this.Dproduct_search_txtbox.SelectionLength = 0;
            this.Dproduct_search_txtbox.SelectionStart = 0;
            this.Dproduct_search_txtbox.ShortcutsEnabled = true;
            this.Dproduct_search_txtbox.Size = new System.Drawing.Size(172, 23);
            this.Dproduct_search_txtbox.TabIndex = 30;
            this.Dproduct_search_txtbox.UseSelectable = true;
            this.Dproduct_search_txtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Dproduct_search_txtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Dproduct_search_txtbox.TextChanged += new System.EventHandler(this.Dproduct_search_txtbox_TextChanged);
            this.Dproduct_search_txtbox.Click += new System.EventHandler(this.Dproduct_search_txtbox_Click);
            // 
            // Dproduct_datagrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(191)))), ((int)(((byte)(221)))));
            this.Dproduct_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dproduct_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dproduct_datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dproduct_datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(191)))), ((int)(((byte)(221)))));
            this.Dproduct_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dproduct_datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dproduct_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(191)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(159)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dproduct_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dproduct_datagrid.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(159)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dproduct_datagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dproduct_datagrid.EnableHeadersVisualStyles = false;
            this.Dproduct_datagrid.GridColor = System.Drawing.Color.White;
            this.Dproduct_datagrid.Location = new System.Drawing.Point(67, 222);
            this.Dproduct_datagrid.Name = "Dproduct_datagrid";
            this.Dproduct_datagrid.ReadOnly = true;
            this.Dproduct_datagrid.RowHeadersVisible = false;
            this.Dproduct_datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Dproduct_datagrid.RowTemplate.Height = 40;
            this.Dproduct_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dproduct_datagrid.Size = new System.Drawing.Size(862, 410);
            this.Dproduct_datagrid.TabIndex = 57;
            this.Dproduct_datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dproduct_datagrid_CellClick);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(191)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.Dproduct_datagrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Dwarehouse_search_cmbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dbrand_txtbox);
            this.Controls.Add(this.Dproduct_search_txtbox);
            this.Name = "Delete";
            this.Size = new System.Drawing.Size(991, 709);
            ((System.ComponentModel.ISupportInitialize)(this.Dproduct_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Dwarehouse_search_cmbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox Dbrand_txtbox;
        private MetroFramework.Controls.MetroTextBox Dproduct_search_txtbox;
        private System.Windows.Forms.DataGridView Dproduct_datagrid;
    }
}
