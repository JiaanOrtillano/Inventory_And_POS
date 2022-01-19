using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALS;
using BEL;
using System.Data;
using System.Data.SqlClient;

namespace BAL
{
    public class Operation
    {
        // here we declare the all db operation and queries.
        public DBConnection dbconnection = new DBConnection();
        public Informations information = new Informations();
        SqlCommand command = new SqlCommand();
        // view product of every table.
        public DataTable view_product(Informations information)
        {    
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT productId as 'Product ID',quantity as 'Quantity',unit as 'Unit',product as 'Product',brand as 'Brand',price as 'Price',totalprice as 'Total Price' FROM " + information.info_inventory + " ORDER BY productId ASC ";
            return dbconnection.ExeReader(command);
        }   
        // Search product via product name.
        public DataTable search_product(Informations information)
        {
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT productId as 'Product ID',quantity as 'Quantity',unit as 'Unit',product as 'Product',brand as 'Brand',price as 'Price',totalprice as 'Total Price'  FROM " + information.info_inventory + " where product like '" + information.info_product_search + "%'ORDER BY productId ASC";
            return dbconnection.ExeReader(command);
        }
        // Search product via brand.
        public DataTable search_brand(Informations information)
        {
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT productId as 'Product ID',quantity as 'Quantity',unit as 'Unit',product as 'Product',brand as 'Brand',price as 'Price',totalprice as 'Total Price'  FROM " + information.info_inventory + " where brand like '" + information.info_brand_search + "%'ORDER BY productId ASC";
            return dbconnection.ExeReader(command);
        }
        // Add product of every table.
        public int add_product(Informations informations)
        {
            command.CommandType = CommandType.Text;
            command.CommandText =
                "INSERT INTO " + informations.info_inventory + " " +
                "VALUES ('" + informations.info_quantity + "','" + informations.info_unit + "','" + informations.info_product_name + "','" + informations.info_brand + "','" + informations.info_price + "','" + informations.info_total_price + "','" + informations.info_warehouse + "')";
            return dbconnection.ExeNonQuery(command);
        }
        // view product and send back at text box in the "Update" form
        public DataTable textbox_data_view(Informations information)
        {
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM " + information.info_inventory + " where productId = '" + information.info_productid + "'";
            return dbconnection.ExeReader(command);
        }

        public int update_product(Informations informations)
        {
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE " + informations.info_inventory + " SET quantity  = " + informations.info_quantity + ",unit ='"+informations.info_unit+"',product = '"+informations.info_product_name+"',brand = '"+informations.info_brand+"',price = "+informations.info_price+",totalprice = "+informations.info_total_price+" where productId = " + informations.info_productid + " ";
            return dbconnection.ExeNonQuery(command);
        }

        public int delete_product(Informations informations)
        {
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from "+informations.info_inventory+" where  productId = "+informations.info_productid+"";
            return dbconnection.ExeNonQuery(command);
        }


    }
}
