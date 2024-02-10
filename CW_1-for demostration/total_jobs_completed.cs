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
    public partial class total_jobs_completed : Form
    {


        SqlDataAdapter adpt;
        DataTable dt;
        public total_jobs_completed()
        {
            InitializeComponent();
        }
        //establish database connection
        SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-DPDLQMP; Initial Catalog = ESOFTADCW1; Integrated Security = True");


        private void btnback_Click(object sender, EventArgs e)
        {
           administrator_dashbord ad = new administrator_dashbord();    
            ad.Show();
            this.Close();   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //display data in a datagridview
        private void total_jobs_completed_Load(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("SELECT job_id,cus_id,starting_point,destination,no_of_loads,comments  FROM jobs_completed ", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
