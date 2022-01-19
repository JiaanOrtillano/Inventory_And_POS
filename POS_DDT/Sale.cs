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
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
            Stocks stocks = new Stocks();
            showControl(stocks);
            stock_btn.ForeColor = Color.FromArgb(118, 159, 205);
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
        private void Stock_btn_Click(object sender, EventArgs e)
        {
            Stocks stocks = new Stocks();
            showControl(stocks);
            stock_btn.ForeColor = Color.FromArgb(118, 159, 205);
            update_product_btn.ForeColor = Color.Black;
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out ?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }


        }

    }

    
}
