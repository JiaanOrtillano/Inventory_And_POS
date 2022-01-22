using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BAL;
using BEL;

namespace POS_DDT
{
    public partial class PrintDDT : Form
    {
        public Operation op = new Operation();
        public Informations info = new Informations();
        public DataTable printTable = new DataTable();
        string printLocation;

        public PrintDDT(string location)
        {
            InitializeComponent();
            try
            {
                StringLocation(location);
                info.info_inventory = location; //specify the location by passing an argument in creating this form
                printTable = op.view_product(info); //create dataTable to use for printing
                printTable.TableName = "PDT";
            }
            catch (Exception e)
            {
                MessageBox.Show("Database not found: " + e);
            }
        }

        void StringLocation(string location)
        {
            switch(location)
            {
                case "inventory_ddt": printLocation = "DDT Inventory"; break;
                case "inventory_ddm":  printLocation = "DDM Inventory"; break;
                case "inventory_ddt3rd_5th": printLocation = "DDT 3RD/5TH INVENTORY"; break;
                case "inventory_tayuman": printLocation = "TAYUMAN"; break;
            }
        }

        private void LoadReport()
        {
            MessageBox.Show("Location: " + printLocation);
            ReportDataSource printSource = new ReportDataSource("DataSet1", printTable);
            ReportParameter p = new ReportParameter("WarehouseLoc", printLocation);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p });
            //reportViewer1.LocalReport.ReportPath = "Report1.rdlc"; this searches at bin/debug maybe create a folder specific to reports
            reportViewer1.LocalReport.ReportEmbeddedResource = "POS_DDT.PrintReport.rdlc";
            reportViewer1.LocalReport.DataSources.Add(printSource);

            this.reportViewer1.RefreshReport();
        }

        private void PrintDDT_Load(object sender, EventArgs e)
            => LoadReport();

        private void button1_Click(object sender, EventArgs e)
            => LoadReport();

        private void button2_Click(object sender, EventArgs e)
            => this.Close();

        //Make the window draggable
        private Point _mouseLoc;

        private void PrintDDT_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void PrintDDT_MouseMove(object sender, MouseEventArgs e)
        {
            MouseUpdate(sender, e);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            MouseUpdate(sender, e);
        }

        private void MouseUpdate(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }
    }
}
