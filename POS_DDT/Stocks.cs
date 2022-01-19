using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BEL;
using BAL;


namespace POS_DDT
{
    public partial class Stocks : UserControl
    {
        public Operation orperation = new Operation();
        public Informations information = new Informations();
        public DataTable datatable = new DataTable();
        public string inventory;
        public Stocks()
        {
            InitializeComponent();
            try
            {
                information.info_inventory = "inventory_ddt";
                datatable = orperation.view_product(information);
                product_datagrid.DataSource = datatable;
                warehouse_search_cmbox.Items.Add("DDT INVENTORY");
                warehouse_search_cmbox.Items.Add("DDM INVENTORY");
                warehouse_search_cmbox.Items.Add("DDT 3RD/5TH INVENTORY");
                warehouse_search_cmbox.Items.Add("TAYUMAN");

            }
            catch
            {
                MessageBox.Show("The database has not found");
            }

        }

   
        private void product_search_txtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                information.info_product_search = product_search_txtbox.Text;
                datatable = orperation.search_product(information);
                product_datagrid.DataSource = datatable;
            }
            catch
            {
                Console.WriteLine("well why");
            }

        }

        private void Product_search_txtbox_Click(object sender, EventArgs e)
        {

        }

        private void Brand_txtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                information.info_brand_search = brand_txtbox.Text;
                datatable = orperation.search_brand(information);           
                product_datagrid.DataSource = datatable;

            }
            catch
            {
                Console.WriteLine("well why");
            }


        }

        private void Warehouse_search_cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (warehouse_search_cmbox.SelectedIndex)
            {
                case 0:
                    information.info_inventory = "inventory_ddt";
                    datatable = orperation.view_product(information);
                    product_datagrid.DataSource = datatable;
                    break;
                case 1:
                    information.info_inventory = "inventory_ddm";
                    datatable = orperation.view_product(information);
                    product_datagrid.DataSource = datatable;
                    break;
                case 2:
                    information.info_inventory = "inventory_ddt3rd_5th";
                    datatable = orperation.view_product(information);
                    product_datagrid.DataSource = datatable;
                    break;
                case 3:
                    information.info_inventory = "inventory_tayuman";
                    datatable = orperation.view_product(information);
                    product_datagrid.DataSource = datatable;
                    break;
                default:

                    break;
            }
        }

        private void Product_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Brand_txtbox_Click(object sender, EventArgs e)
        {

        }

        private void Stocks_Load(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }
    }
}
