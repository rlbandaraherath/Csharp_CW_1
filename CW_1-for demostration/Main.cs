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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customer_signup cs = new customer_signup();
            cs.Show();
            this.Hide();
        }

        private void customer_loginbtn_Click(object sender, EventArgs e)
        {
            customer_login cl = new customer_login();
            cl.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            customer_loginbtn.Focus();
        }

        private void administrator_loginbtn_Click(object sender, EventArgs e)
        {
            Administrator_Login alg = new Administrator_Login();
            alg.Show();
            this.Hide();
        }

        private void linkourfeet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            our_fleet of = new our_fleet(); 
            of.Show();
            this.Hide();
        }

        private void lnkcustomerd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            customer_details cds=new customer_details();
            cds.Show();
            this.Hide();

        }

        private void totaljobslink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            total_jobs_completed tjc = new total_jobs_completed();
            tjc.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            packing_Experts pk = new packing_Experts();
            pk.Show();
            this.Hide();

        }
    }
}
