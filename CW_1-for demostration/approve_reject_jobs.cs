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
    public partial class approve_reject_jobs : Form
    {

        SqlDataAdapter adpt;
        DataTable dt;
        SqlDataAdapter adpt1;
        DataTable dt1;
        public approve_reject_jobs()
        {
            InitializeComponent();
        }
        //establish database connection
        SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-DPDLQMP; Initial Catalog = ESOFTADCW1; Integrated Security = True");


        private void btnback_Click(object sender, EventArgs e)
        {
            administrator_dashbord add =new administrator_dashbord();
            add.Show();
            this.Close();
        }
        //show data in a datagridview
        private void approve_reject_jobs_Load(object sender, EventArgs e)
        {

            adpt = new SqlDataAdapter("SELECT job_id,cus_id,starting_from,Destination,no_of_loads,comments,date  FROM job_requests ", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;



            adpt1 = new SqlDataAdapter(@"SELECT job_id,cus_id,starting_point,destination,no_of_loads,comments  FROM jobs_uncompleted ", con);
            dt1 = new DataTable();
            adpt1.Fill(dt1);
            dataGridView2.DataSource = dt1;



        }
        //insert data into new table and delete from initial table with exception handling
        private void btnapprove_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();


                SqlCommand cmd3 = new SqlCommand(@"INSERT INTO jobs_uncompleted (job_id,cus_id,starting_point,destination,no_of_loads,comments) SELECT job_id,cus_id,starting_from,Destination,no_of_loads,comments FROM job_requests WHERE job_id = '" + txtjobid.Text + "'  ", con);
                cmd3.ExecuteNonQuery();

                SqlCommand cmd4 = new SqlCommand(@"DELETE FROM job_requests WHERE job_id = '" + txtjobid.Text + "'  ", con);
                cmd4.ExecuteNonQuery();






                MessageBox.Show("Updated succesfully");
                approve_reject_jobs ar=new approve_reject_jobs();   
                ar.Show();
                this.Hide();    










            }
            catch
            {

                MessageBox.Show("Error");
            }







           



        }
        //insert data into new table and delete from initial table with exception handling

        private void btnreject_Click(object sender, EventArgs e)
        {

            try
            {

               con.Open();


                SqlCommand cmd = new SqlCommand(@"INSERT INTO jobs_rejected (job_id,cus_id,starting_point,destination,no_of_loads,comments) SELECT job_id,cus_id,starting_from,Destination,no_of_loads,comments FROM job_requests WHERE job_id = '" + txtjobid.Text + "'  ", con);
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand(@"DELETE FROM job_requests WHERE job_id = '" + txtjobid.Text + "'  ", con);
                cmd1.ExecuteNonQuery();






                MessageBox.Show("Updated succesfully");






                approve_reject_jobs a = new approve_reject_jobs();
                a.Show();
                this.Close();



            }
            catch
            {

                MessageBox.Show("Error");
            }

        }
    }
}
