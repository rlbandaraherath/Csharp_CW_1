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
    public partial class Administrator_Login : Form
    {
        public Administrator_Login()
        {
            InitializeComponent();
        }
        //establish database connection
        SqlConnection conna = new SqlConnection(@"Data Source =DESKTOP-DPDLQMP; Initial Catalog = ESOFTADCW1; Integrated Security = True");

        private void button2_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
            this.Hide();    
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            txtpass.Clear();
            txtuser.Focus();
        }
        //login validation code
        private void btnlogin_Click(object sender, EventArgs e)
        {

            String username, user_password;

            username = txtuser.Text;
            user_password = txtpass.Text;

            try
            {
                string querry = "SELECT * FROM  admindetails WHERE adminusername ='" + txtuser.Text + "'  AND adminpassword ='" + txtpass.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conna);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txtuser.Text;
                    user_password = txtpass.Text;

                    administrator_dashbord cd = new administrator_dashbord();
                    cd.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtuser.Clear();
                    txtpass.Clear();

                    txtuser.Focus();


                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conna.Close();
            }

        }
    }
}
