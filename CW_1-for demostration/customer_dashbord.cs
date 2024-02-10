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
    public partial class customer_dashbord : Form
    {
        //declare variables
        SqlDataAdapter adpt;
        DataTable dt;

        public customer_dashbord()
        {
            InitializeComponent();
        }
        //establishing the database connection
        SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-DPDLQMP; Initial Catalog = ESOFTADCW1; Integrated Security = True");

        private void button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();   
        }

        private void lnknewjob_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            customer_dashbord_newjob cdn =new customer_dashbord_newjob();
            cdn.Show();
            this.Hide();
        }
        //display data in a datagridview
        private void customer_dashbord_Load(object sender, EventArgs e)
        {


            adpt = new SqlDataAdapter("SELECT job_id,cus_id,starting_from,Destination,no_of_loads,comments,date  FROM job_requests ", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void lnkdetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            customer_customer_details cd = new customer_customer_details(); 
            cd.Show();
            this.Hide();

        }

        private void lnkinspection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            house_inspection_request hs = new house_inspection_request();
            hs.Show();
            this.Hide();
        }
    }
}
