using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BAL;

namespace POS_DDT
{
    
    public partial class Update : UserControl
    {
        public Operation operation = new Operation();
        public Informations informations = new Informations();
        public DataTable datatable = new DataTable();
        int productId;
        string table_name = "inventory_ddt";
        DataGridViewButtonColumn button = new DataGridViewButtonColumn();
        public Update()
        {
            InitializeComponent();
            informations.info_inventory = table_name;
            datatable = operation.view_product(informations);
            product_view_update_datagrid.DataSource = datatable;
            
            button.Text = "Update";    
            button.UseColumnTextForButtonValue = true;
            product_view_update_datagrid.Columns.Add(button);
            warehouse_update_cmbox.Items.Add("DDT INVENTORY");
            warehouse_update_cmbox.Items.Add("DDM INVENTORY");
            warehouse_update_cmbox.Items.Add("DDT 3RD/5TH INVENTORY");
            warehouse_update_cmbox.Items.Add("TAYUMAN");
        }

        private void Warehouse_update_cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (warehouse_update_cmbox.SelectedIndex)
                {
                    case 0:
                        informations.info_inventory = "inventory_ddt";
                        table_name = "inventory_ddt";
                        datatable = operation.view_product(informations);
                        product_view_update_datagrid.DataSource = datatable;
                        break;
                    case 1:
                        informations.info_inventory = "inventory_ddm";
                        table_name = "inventory_ddm";
                        datatable = operation.view_product(informations);
                        product_view_update_datagrid.DataSource = datatable;
                        break;
                    case 2:
                        informations.info_inventory = "inventory_ddt3rd_5th";
                        table_name = "inventory_ddt3rd_5th";
                        datatable = operation.view_product(informations);
                        product_view_update_datagrid.DataSource = datatable;
                        break;
                    case 3:
                        informations.info_inventory = "inventory_tayuman";
                        table_name = "inventory_tayuman";
                        datatable = operation.view_product(informations);
                        product_view_update_datagrid.DataSource = datatable;
                        break;
                    default:

                        break;
                }
            }
            catch
            {

            }
            

        }

        private void Product_view_update_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                productId = Int32.Parse(product_view_update_datagrid.Rows[e.RowIndex].Cells["Product Id"].FormattedValue.ToString());
                UpdateWindow updatewindorw = new UpdateWindow(productId,table_name);
                updatewindorw.FormClosed += new FormClosedEventHandler(updatewindorw_FormClosed); 
                updatewindorw.Show();
                
            }
            catch
            {

            }
            
        }

        private void updatewindorw_FormClosed(object sender, FormClosedEventArgs e)
        {
            informations.info_inventory = table_name;
            datatable = operation.view_product(informations);
            product_view_update_datagrid.DataSource = datatable;
        }

        private void Producttxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                informations.info_product_search = producttxt.Text;
                datatable = operation.search_product(informations);
                product_view_update_datagrid.DataSource = datatable;
            }
            catch
            {
                Console.WriteLine("well why");
            }
        }

        private void Brandtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {

                informations.info_brand_search = brandtxt.Text;
                datatable = operation.search_brand(informations);
                product_view_update_datagrid.DataSource = datatable;

            }
            catch
            {
                Console.WriteLine("well why");
            }
        }

        private void ProductID_update_txtbox_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
   
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }
    }
}
