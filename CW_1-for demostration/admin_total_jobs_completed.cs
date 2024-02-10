using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using System.Data.SqlClient;
namespace CW_1
{
    public partial class admin_total_jobs_completed : Form
    {
        SqlDataAdapter adpt;
        DataTable dt;

        public admin_total_jobs_completed()
        {
            InitializeComponent();
        }
       //establish database connection
        SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-DPDLQMP; Initial Catalog = ESOFTADCW1; Integrated Security = True");

        private void btnback_Click(object sender, EventArgs e)
        {
            administrator_dashbord ad = new administrator_dashbord();   
            ad.Show();  
            this.Hide();    
        }

        private void btnrpt_Click(object sender, EventArgs e)
        {
            //DGV printer
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

        private void admin_total_jobs_completed_Load(object sender, EventArgs e)
        {
            //display data in a datagridview
            adpt = new SqlDataAdapter("SELECT job_id,cus_id,starting_point,destination,no_of_loads,comments  FROM jobs_completed ", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
