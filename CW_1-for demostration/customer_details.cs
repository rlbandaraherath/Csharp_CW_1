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
    public partial class customer_details : Form
    {

        SqlDataAdapter adpt;
        DataTable dt;

        public customer_details()
        {
            InitializeComponent();
        }
        //establish database connection
        SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-DPDLQMP; Initial Catalog = ESOFTADCW1; Integrated Security = True");
        //show data in a datagridview
        private void customer_details_Load(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("SELECT cusid,cusname,cusaddress,custelno,cusemail  FROM customerdetails ", con);
            dt = new DataTable();   
            adpt.Fill(dt);
            dgvcustomer.DataSource = dt;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Close();   
        }
    }
}
