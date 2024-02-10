using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;
namespace CW_1
{
    public partial class customer_details_update : Form
    {

        SqlDataAdapter adpt;
        DataTable dt;

        public customer_details_update()
        {
            InitializeComponent();
        }
        //establish database connection
        SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-DPDLQMP; Initial Catalog = ESOFTADCW1; Integrated Security = True");
        //clear textbox details
        private void btnclear_Click(object sender, EventArgs e)
        {

            txtid.Clear();
            txtname.Clear();
            txtaddress.Clear();
            txttel.Clear();
            txtemail.Clear();
            txtid.Focus();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            administrator_dashbord ad = new administrator_dashbord();
            ad.Show();
            this.Close();
        }
        //display data in a datagrid view
        private void customer_details_update_Load(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("SELECT cusid,cusname,cusaddress,custelno,cusemail  FROM customerdetails ", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        //update database
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtname.Text) || string.IsNullOrEmpty(txtaddress.Text) || string.IsNullOrEmpty(txtemail.Text) || string.IsNullOrEmpty(txttel.Text) || string.IsNullOrEmpty(txtid.Text) )
                {

                    MessageBox.Show("Fill All the Fields");
                }
                else
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(@"UPDATE customerdetails SET cusname ='" + txtname.Text + "', cusaddress ='" + txtaddress.Text + "', custelno ='" + txttel.Text + "', cusemail ='" + txtemail.Text + "' WHERE  cusid ='" + txtid.Text + "'", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Updated succesfully");
                    customer_details_update mn = new customer_details_update();
                    mn.Show();




                }
            }
            catch
            {

                MessageBox.Show("Error");
            }
        }
        //print data using dgv printer
        private void button1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "E-Shift ";
            printer.SubTitle = String.Format("Report", printer.SubTitleColor = Color.Black, printer);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.Footer = "E-Shift Reports";
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(dataGridView1);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {

               
                    con.Open();

                    SqlCommand cmd = new SqlCommand(@"DELETE FROM customerdetails  WHERE cusid ='" + txtid.Text + "'  ", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete succesfully");
                    customer_details_update mn = new customer_details_update();
                    mn.Show();
                this.Hide();




                
            }
            catch
            {

                MessageBox.Show("Error");
            }
        }
    }
}
