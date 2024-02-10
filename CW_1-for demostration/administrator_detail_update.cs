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
    public partial class administrator_detail_update : Form
    {


        SqlDataAdapter adpt;
        DataTable dt;


        public administrator_detail_update()
        {
            InitializeComponent();
        }
        //establish database connection
        SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-DPDLQMP; Initial Catalog = ESOFTADCW1; Integrated Security = True");
        //display data in a datagridview
        private void administrator_detail_update_Load(object sender, EventArgs e)
        {
            
                adpt = new SqlDataAdapter("SELECT adminid,adminname,adminaddress,admintelno,adminemail  FROM admindetails ", con);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
          


        }

        private void btnback_Click(object sender, EventArgs e)
        {
            administrator_dashbord ad=new administrator_dashbord();
            ad.Show();
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txtaddress.Clear();
            txttel.Clear();
            txtemail.Clear();
            txtid.Focus();  
        }
        //update administrator details table(exception handling used)
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

                    SqlCommand cmd = new SqlCommand(@"UPDATE admindetails SET adminname ='" + txtname.Text + "', adminaddress ='" + txtaddress.Text + "', admintelno ='" + txttel.Text + "', adminemail ='" + txtemail.Text + "' WHERE  adminid ='" + txtid.Text + "'", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Updated succesfully");
                    administrator_detail_update mn = new administrator_detail_update();
                    mn.Show();




                }
            }
            catch
            {

                MessageBox.Show("Error");
            }
        }
        //print datagridview data
        private void btnrpt_Click(object sender, EventArgs e)
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
    }
}
