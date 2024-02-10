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
    public partial class customer_signup : Form
    {
        public customer_signup()
        {
            InitializeComponent();
        }
        //establishing database connection
        SqlConnection con = new SqlConnection(@"Data Source =DESKTOP-DPDLQMP; Initial Catalog = ESOFTADCW1; Integrated Security = True");

        private void backbtn_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
            this.Hide();
        }
        //clear textbox details
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
        //insert data into database
        private void btnregister_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtname.Text) || string.IsNullOrEmpty(txtaddress.Text) || string.IsNullOrEmpty(txtemail.Text) || string.IsNullOrEmpty(txttel.Text) || string.IsNullOrEmpty(txtuname.Text) || string.IsNullOrEmpty(txtpw.Text))
                {

                    MessageBox.Show("Please Fill All the Fields");
                }
                else
                {


                    con.Open();

                    SqlCommand cmd = new SqlCommand(@"INSERT INTO customerdetails
           ([cususername]
           ,[cuspassword]
           ,[cusname]
           ,[cusaddress]
           ,[custelno]
           ,[cusemail])
    VALUES
           ('" + txtuname.Text + "','" + txtpw.Text + "','" + txtname.Text + "','" + txtaddress.Text + "','" + txttel.Text + "','" + txtemail.Text + "')", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registerd succesfully");

                    customer_login csl = new customer_login();
                    csl.Show();
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
