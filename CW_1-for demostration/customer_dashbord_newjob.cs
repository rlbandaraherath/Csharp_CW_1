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
    public partial class customer_dashbord_newjob : Form
    {
        public customer_dashbord_newjob()
        {
            InitializeComponent();
        }
        //establish database connection
        SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-DPDLQMP; Initial Catalog = ESOFTADCW1; Integrated Security = True");

        private void customer_dashbord_newjob_Load(object sender, EventArgs e)
        {

        }
        //clear text fields
        private void txtclear_Click(object sender, EventArgs e)
        {
            txtcusid.Clear();
            txtslocation.Clear();
            txtdestination.Clear();
          
            txtloads.Clear();
            txtcomment.Clear();
            txtcusid.Focus();
        }
        //insert data into database
        private void txtsubmit_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtcusid.Text) || string.IsNullOrEmpty(txtslocation.Text) || string.IsNullOrEmpty(txtdestination.Text) || string.IsNullOrEmpty(txtloads.Text) || string.IsNullOrEmpty(txtcomment.Text))
                {

                    MessageBox.Show("Fill All the Fields");
                }
                else
                {

                    con.Open();

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO job_requests
           (
            [cus_id]
           ,[starting_from]
           ,[Destination]
           ,[no_of_loads]
           ,[comments]
           ,[date])
    VALUES
           ('" + txtcusid.Text + "','" + txtslocation.Text + "','" + txtdestination.Text + "','" + txtloads.Text + "','" + txtcomment.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "')", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Submited succesfully");
                    customer_dashbord cs = new customer_dashbord();
                    cs.Show();
                    this.Close();


                }
            }
            catch
            {

                MessageBox.Show("Error");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            customer_dashbord cd = new customer_dashbord();
            cd.Show();
            this.Close();
        }
    }
}
