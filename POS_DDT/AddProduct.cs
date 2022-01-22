using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;

namespace POS_DDT
{
    
    public partial class AddProduct : UserControl
    {
        public Informations informations = new Informations();
        public Operation operation = new Operation();
        public DataTable datatable = new DataTable();
        public string warehouse;
        public string inventory;
        public AddProduct()
        {
            InitializeComponent();
            informations.info_inventory = "inventory_ddt";
            try
            {
                datatable = operation.view_product(informations);
                add_product_datagrid.DataSource = datatable;
                warehouse_location_cmbox.Items.Add("DDT INVENTORY");
                warehouse_location_cmbox.Items.Add("DDM INVENTORY");
                warehouse_location_cmbox.Items.Add("DDT 3RD/5TH INVENTORY");
                warehouse_location_cmbox.Items.Add("TAYUMAN");
            }
            catch
            {

            }
            
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_product_btn_Click(object sender, EventArgs e)
        {
            add_inventory();
        }

        private void Print_btn_Click(object sender, EventArgs e)
        {
            //printing function
            if (!String.IsNullOrEmpty(inventory))
            {
                PrintDDT Print = new PrintDDT(this.inventory); //create instance of report viewer
                Print.Show();
            } else { MessageBox.Show("Unspecified Warehouse Location"); }
        }

        private void Warehouse_location_cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (warehouse_location_cmbox.SelectedIndex)
            {
                case 0:
                    warehouse = "DDT INVENTORY";
                    inventory = "inventory_ddt";
                    break;
                case 1:
                    warehouse = "DDM INVENTORY";
                    inventory = "inventory_ddm";
                    break;
                case 2:
                    warehouse = "DDT 3RD/5TH INVENTORY";
                    inventory = "inventory_ddt3rd_5th";
                    break;
                case 3:
                    warehouse = "TAYUMAN";
                    inventory = "inventory_tayuman";
                    break;
                default:
                    
                    break;
            }
        }
        private void add_inventory()
        {
            try
            {
                try
                {
                    informations.info_quantity = Int32.Parse(quantity_txtbox.Text);
                    informations.info_unit = unit_txtbox.Text;
                    informations.info_product_name = product_name_txtbox.Text;
                    informations.info_brand = brand_txtbox.Text;
                    informations.info_price = Int32.Parse(price_txtbox.Text);
                    informations.info_total_price = Int32.Parse(total_price_txtbox.Text);
                    informations.info_warehouse = warehouse;
                    informations.info_inventory = inventory;

                    int row = operation.add_product(informations);
                    if (row > 0)
                    {
                        MessageBox.Show("Product Added");
                        datatable = operation.view_product(informations);
                        add_product_datagrid.DataSource = datatable;
                        quantity_txtbox.Clear();
                        unit_txtbox.Clear();
                        product_name_txtbox.Clear();
                        brand_txtbox.Clear();
                        price_txtbox.Clear();
                        total_price_txtbox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("The product is failed to add the item.", "Add Product Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Please fill-up all forms", "Missing Something", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
          
            }
            catch
            {
               
            }
                
           
        }
        


    }
}
