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

        }

        private void administrator_loginbtn_Click(object sender, EventArgs e)
        {
            Administrator_Login alg = new Administrator_Login();
            alg.Show();
            this.Hide();
        }
    }
}
