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
    public partial class admin_house_inspection : Form
    {

        SqlDataAdapter adpt;
        DataTable dt;
        public admin_house_inspection()
        {
            InitializeComponent();
        }
        //establish database connection
        SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-DPDLQMP; Initial Catalog = ESOFTADCW1; Integrated Security = True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void admin_house_inspection_Load(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("SELECT customer_ID,customer_name,location,Date  FROM house_inspection ", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            administrator_dashbord aa = new administrator_dashbord();
            aa.Show();
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {


                con.Open();

                SqlCommand cmd = new SqlCommand(@"DELETE FROM house_inspection  WHERE customer_ID ='" + txtid.Text + "'  ", con);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete succesfully");
               admin_house_inspection mn = new admin_house_inspection();
                mn.Show();
                this.Close();





            }
            catch
            {

                MessageBox.Show("Error");
            }
        }
    }
 }

