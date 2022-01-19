using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_DDT
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            Stocks stocks = new Stocks();
            showControl(stocks);
            stock_btn.ForeColor = Color.FromArgb(118, 159, 205);
            add_stock_btn.ForeColor = Color.Black;
            delete_btn.ForeColor = Color.Black;
            update_product_btn.ForeColor = Color.Black;

        }

        public void showControl(Control control)
        {
            display_pnl.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            display_pnl.Controls.Add(control);
        }

        private void add_stock_btn_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            showControl(addProduct);
            stock_btn.ForeColor = Color.Black;
            add_stock_btn.ForeColor = Color.FromArgb(118, 159, 205);
            delete_btn.ForeColor = Color.Black;
            update_product_btn.ForeColor = Color.Black;
        }

        private void Stock_btn_Click(object sender, EventArgs e)
        {
            Stocks stocks = new Stocks();
            showControl(stocks);
            stock_btn.ForeColor = Color.FromArgb(118, 159, 205);
            add_stock_btn.ForeColor = Color.Black;
            delete_btn.ForeColor = Color.Black;
            update_product_btn.ForeColor = Color.Black;
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            showControl(delete);
            stock_btn.ForeColor = Color.Black;
            add_stock_btn.ForeColor = Color.Black;
            delete_btn.ForeColor = Color.FromArgb(118, 159, 205);
            update_product_btn.ForeColor = Color.Black;
        }

        private void Update_product_btn_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            showControl(update);
            stock_btn.ForeColor = Color.Black;
            add_stock_btn.ForeColor = Color.Black;
            delete_btn.ForeColor = Color.Black;
            update_product_btn.ForeColor = Color.FromArgb(118, 159, 205);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out ?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

      
    }
}
