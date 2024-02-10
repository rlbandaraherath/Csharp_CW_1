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
    public partial class mark_completed_jobs : Form
    {
        //declear variables
        SqlDataAdapter adpt;
        DataTable dt;
        SqlDataAdapter adpt1;
        DataTable dt1;

        public mark_completed_jobs()
        {
            InitializeComponent();
        }
        //establish data connection
        SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-DPDLQMP; Initial Catalog = ESOFTADCW1; Integrated Security = True");

        private void button1_Click(object sender, EventArgs e)
        {
            administrator_dashbord ad = new administrator_dashbord();
            ad.Show();
            this.Close();
        }
        //display data in datagridview
        private void mark_completed_jobs_Load(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter(@"SELECT job_id,cus_id,starting_point,destination,no_of_loads,comments  FROM jobs_uncompleted ", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;



            adpt1 = new SqlDataAdapter(@"SELECT job_id,cus_id,starting_point,destination,no_of_loads,comments  FROM jobs_completed ", con);
            dt1 = new DataTable();
            adpt1.Fill(dt1);
            dataGridView2.DataSource = dt1;
        
        con.Close();    
        
        }



        private void btnback_Click(object sender, EventArgs e)
        {
            administrator_dashbord ad = new administrator_dashbord();
            ad.Show();
            this.Close();
        }
        //insert data into database
        private void btnapprove_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();


                SqlCommand cmd3 = new SqlCommand(@"INSERT INTO jobs_completed (job_id,cus_id,starting_point,destination,no_of_loads,comments) SELECT job_id,cus_id,starting_point,destination,no_of_loads,comments FROM jobs_uncompleted WHERE job_id = '" + txtjobid.Text + "'  ", con);
                cmd3.ExecuteNonQuery();

                SqlCommand cmd4 = new SqlCommand(@"DELETE FROM jobs_uncompleted WHERE job_id = '" + txtjobid.Text + "'  ", con);
                cmd4.ExecuteNonQuery();






                MessageBox.Show("Updated succesfully");
               mark_completed_jobs ar = new mark_completed_jobs();
                ar.Show();
                this.Hide();










            }
            catch
            {

                MessageBox.Show("Error");
            }
        }
    }
}
