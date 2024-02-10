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
namespace CW_1
{
    public partial class customer_customer_details : Form
    {
        SqlDataAdapter adpt;
        DataTable dt;

        public customer_customer_details()
        {
            InitializeComponent();
        }
        //establishing the database connection
        SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-DPDLQMP; Initial Catalog = ESOFTADCW1; Integrated Security = True");
        //display data in a datagridview
        private void customer_customer_details_Load(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("SELECT cusid,cusname,cusaddress,custelno,cusemail  FROM customerdetails ", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;



        }

        private void btnback_Click(object sender, EventArgs e)
        {
            customer_dashbord cd = new customer_dashbord();
            cd.Show();
            this.Close();
        }
        //update the database with exception handling
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtname.Text) || string.IsNullOrEmpty(txtaddress.Text) || string.IsNullOrEmpty(txtemail.Text) || string.IsNullOrEmpty(txttel.Text) || string.IsNullOrEmpty(txtpass.Text) || string.IsNullOrEmpty(txtid.Text))
                {

                    MessageBox.Show("Fill All the Fields");
                }
                else
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(@"UPDATE customerdetails SET cusname ='" + txtname.Text + "', cusaddress ='" + txtaddress.Text + "', custelno ='" + txttel.Text + "', cusemail ='" + txtemail.Text + "' WHERE  cusid ='" + txtid.Text + "' AND  cuspassword ='" + txtpass.Text + "' ", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Updated succesfully");
                    customer_customer_details mn = new customer_customer_details();
                    mn.Show();
                    this.Close();



                }
            }
            catch
            {

                MessageBox.Show("Error");
            }
        }
    }
}
