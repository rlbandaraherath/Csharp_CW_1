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
    public partial class house_inspection_request : Form
    {//establish database connection
        SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-DPDLQMP; Initial Catalog = ESOFTADCW1; Integrated Security = True");

        public house_inspection_request()
        {
            InitializeComponent();
        }

        private void txtsubmit_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrEmpty(txtcusid.Text) || string.IsNullOrEmpty(txtcusname.Text) || string.IsNullOrEmpty(txtlocation.Text) )
                {

                    MessageBox.Show("Fill All the Fields");
                }
                else
                {

                    con.Open();

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO house_inspection
           (
            [customer_id]
           ,[customer_name]
           ,[location]
            ,[date])
    VALUES
           ('" + txtcusid.Text + "','" + txtcusname.Text + "','" + txtlocation.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "')", con);

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

        private void txtclear_Click(object sender, EventArgs e)
        {
            txtcusid.Clear();
            txtcusname.Clear();
            txtlocation.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            customer_dashbord cc = new customer_dashbord();
            cc.Show();
            this.Close();
        }
    }
}
