using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BAL;
namespace POS_DDT
{
    public partial class UpdateWindow : Form
    {
        public Operation operation = new Operation();
        public Informations informations = new Informations();
        public DataTable datatable = new DataTable();
        public UpdateWindow(int ProductID, string TableName)
        {
            InitializeComponent();
            informations.info_productid = ProductID;
            informations.info_inventory = TableName;
            datatable = operation.textbox_data_view(informations);
            if (datatable.Rows.Count > 0)
            {
                quantity_update_txtbox.Text = datatable.Rows[0][1].ToString();
                unit_update_txtbox.Text = datatable.Rows[0][2].ToString();
                product_update_txtbox.Text = datatable.Rows[0][3].ToString();
                brand_update_txtbox.Text = datatable.Rows[0][4].ToString();
                price_update_txtbox.Text = datatable.Rows[0][5].ToString();
                total_price_update_txtbox.Text = datatable.Rows[0][6].ToString();
                warehouse_update_txtbox.Text = datatable.Rows[0][7].ToString();

            }
            else
            {

            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {

            try
            {
                try
                {
                    informations.info_quantity = Int32.Parse(quantity_update_txtbox.Text);
                    informations.info_unit = unit_update_txtbox.Text;
                    informations.info_product_name = product_update_txtbox.Text;
                    informations.info_brand = brand_update_txtbox.Text;
                    informations.info_price = Int32.Parse(price_update_txtbox.Text);
                    informations.info_total_price = Int32.Parse(total_price_update_txtbox.Text);
                    int row = operation.update_product(informations);
                    if (row > 0)
                    {
                        MessageBox.Show("Product Updated");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("The product is failed to update the item.", "Update Product Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        
    }
}
