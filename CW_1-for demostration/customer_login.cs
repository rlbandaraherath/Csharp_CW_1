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
    public partial class customer_login : Form
    {
        public customer_login()
        {
            InitializeComponent();
        }
        //establish database connection
        SqlConnection conn = new SqlConnection(@"Data Source =DESKTOP-DPDLQMP; Initial Catalog = ESOFTADCW1; Integrated Security = True");
        private void button2_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
            this.Hide();
        }
        //validate login details
        private void txtlogin_Click(object sender, EventArgs e)
        {
            string username, user_password;

            username =txtuser.Text;
            user_password =txtpass.Text;

            try {
            string querry = "SELECT * FROM  customerdetails WHERE cususername ='"+txtuser.Text+"'  AND cuspassword ='"+txtpass.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(querry,conn);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txtuser.Text;
                    user_password = txtpass.Text;

                    customer_dashbord cd = new customer_dashbord();
                    cd.Show();
                    this.Hide();

                }
                else {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtuser.Clear();
                    txtpass.Clear();   

                    txtuser.Focus();    


                }
            }
            catch {
                MessageBox.Show("Error");
            }   
            finally {
            conn.Close();
            }



        }
        //clear text
        private void txtclear_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            txtpass.Clear();
            txtuser.Focus();
        }

        private void linksignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            customer_signup cs = new customer_signup();
            cs.Show();  
            this.Close();
        }
    }
}
