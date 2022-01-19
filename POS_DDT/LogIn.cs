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
    public partial class LogIn : Form
    {
        
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
             string user = username_txt.Text;
            string pass = password_txt.Text;

            if(user == "admin"&&pass == "admin")
            {
                this.Hide();
                Inventory pos = new Inventory();
                pos.ShowDialog();
                this.Close();
            }
            else if(user == "sales" && pass == "sales")
            {
                this.Hide();
                Sale sale = new Sale();
                sale.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
    }
}
