using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_1
{
    public partial class administrator_dashbord : Form
    {
        public administrator_dashbord()
        {
            InitializeComponent();
        }

        private void lablesignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Administrator_signup ads = new Administrator_signup();
            ads.Show();
            this.Hide();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mark_completed_jobs mark_Completed_Jobs = new mark_completed_jobs();
            mark_Completed_Jobs.Show();
            this.Hide();

        }

        private void lblchangeadmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            administrator_detail_update adu = new administrator_detail_update();
            adu.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           admin_total_jobs_completed tjc = new admin_total_jobs_completed();  
            tjc.Show(); 
            this.Close();   
        }

        private void lblcusdet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            customer_details_update cdu = new customer_details_update();
            cdu.Show();
            this.Hide();
        }

        private void btnapprove_Click(object sender, EventArgs e)
        {
            approve_reject_jobs arj=new approve_reject_jobs();
            arj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main m =new Main();
            m.Show();
            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rejected_jobs arj = new rejected_jobs();
            arj.Show();
            this.Hide();
        }

        private void lblapproved_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin_approved_jobs apj = new admin_approved_jobs();    
            apj.Show();
            this.Hide();
        }

        private void txtjobrequests_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin_job_request ajr =new admin_job_request();
            ajr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_house_inspection aa = new admin_house_inspection();
            aa.Show();
            this.Close();
        }
    }
}
