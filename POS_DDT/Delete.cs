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
    public partial class Delete : UserControl
    {
        public Operation operation = new Operation();
        public Informations informations = new Informations();
        public DataTable datatable = new DataTable();
        public string inventory="inventory_ddt";
        public int productId = 0;
        public string product_name;
        DataGridViewButtonColumn button = new DataGridViewButtonColumn();
        public Delete()
        {
            InitializeComponent();
           
            informations.info_inventory = inventory;
            datatable = operation.view_product(informations);
            Dproduct_datagrid.DataSource = datatable;
            Dwarehouse_search_cmbox.Items.Add("DDT INVENTORY");
            Dwarehouse_search_cmbox.Items.Add("DDM INVENTORY");
            Dwarehouse_search_cmbox.Items.Add("DDT 3RD/5TH INVENTORY");
            Dwarehouse_search_cmbox.Items.Add("TAYUMAN");
            
            button.Text = "Delete";           
            button.UseColumnTextForButtonValue = true;
            Dproduct_datagrid.Columns.Add(button);
        }

        private void Dproduct_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                informations.info_inventory = inventory;
                productId = Int32.Parse(Dproduct_datagrid.Rows[e.RowIndex].Cells["Product ID"].FormattedValue.ToString());
                informations.info_productid = productId;
                datatable = operation.textbox_data_view(informations);
                product_name = datatable.Rows[0][3].ToString();
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + product_name + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int row = operation.delete_product(informations);
                    if (row > 0)
                    {
                        MessageBox.Show("Deleted");
                        datatable = operation.view_product(informations);
                        Dproduct_datagrid.DataSource = datatable;
                    }
                    else
                    {

                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            catch
            {
                
            }
           
        }

        private void Dproduct_search_txtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                informations.info_product_search = Dproduct_search_txtbox.Text;
                datatable = operation.search_product(informations);
                Dproduct_datagrid.DataSource = datatable;

            }
            catch
            {
                Console.WriteLine("well why");
            }
        }

        private void Dbrand_txtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                informations.info_brand_search = Dbrand_txtbox.Text;
                datatable = operation.search_brand(informations);
                Dproduct_datagrid.DataSource = datatable;

            }
            catch
            {
                Console.WriteLine("well why");
            }

        }

        private void Dwarehouse_search_cmbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Dwarehouse_search_cmbox.SelectedIndex)
            {
                case 0:                  
                    inventory = "inventory_ddt";
                    informations.info_inventory = inventory;
                    datatable = operation.view_product(informations);
                    Dproduct_datagrid.DataSource = datatable;
                    break;
                case 1:           
                    inventory = "inventory_ddm";
                    informations.info_inventory = inventory;
                    datatable = operation.view_product(informations);
                    Dproduct_datagrid.DataSource = datatable;
                    break;
                case 2:
                    inventory = "inventory_ddt3rd_5th";
                    informations.info_inventory = inventory;
                    datatable = operation.view_product(informations);
                    Dproduct_datagrid.DataSource = datatable;
                    break;
                case 3:    
                    inventory = "inventory_tayuman";
                    informations.info_inventory = inventory;
                    datatable = operation.view_product(informations);
                    Dproduct_datagrid.DataSource = datatable;
                    break;
                default:

                    break;
            }
        }

        private void Dproduct_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Dbrand_txtbox_Click(object sender, EventArgs e)
        {

        }

        private void Dproduct_search_txtbox_Click(object sender, EventArgs e)
        {

        }
    }
}
