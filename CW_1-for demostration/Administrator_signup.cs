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
    public partial class Administrator_signup : Form
    {
        public Administrator_signup()
        {
            InitializeComponent();
        }
        //establish database connection
        SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-DPDLQMP; Initial Catalog = ESOFTADCW1; Integrated Security = True");

        private void btnback_Click(object sender, EventArgs e)
        {
            administrator_dashbord mn = new administrator_dashbord();
            mn.Show();
            this.Hide();    
        }
        //clar data in textboxes
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtaddress.Clear();
            txtemail.Clear();
            txttel.Clear();
            txtuname.Clear();
            txtpw.Clear();
            txtname.Focus();
        }
        //registation/update  the database
        private void btnregister_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrEmpty(txtname.Text) || string.IsNullOrEmpty(txtaddress.Text) || string.IsNullOrEmpty(txtemail.Text) || string.IsNullOrEmpty(txttel.Text) || string.IsNullOrEmpty(txtuname.Text) || string.IsNullOrEmpty(txtpw.Text)) {

                    MessageBox.Show("Fill All the Fields"); }
                else { 
                    con.Open();

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO admindetails
           ([adminusername]
           ,[adminpassword]
           ,[adminname]
           ,[adminaddress]
           ,[admintelno]
           ,[adminemail])
    VALUES
           ('" + txtuname.Text + "','" + txtpw.Text + "','" + txtname.Text + "','" + txtaddress.Text + "','" + txttel.Text + "','" + txtemail.Text + "')", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registerd succesfully");

                    Administrator_Login adl = new Administrator_Login();
                    adl.Show();
                    this.Hide();
                }
             

                   
            }
            catch
            {

                MessageBox.Show("Error");
            }
        }
    }
}
