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
    public partial class our_fleet : Form
    {
        public our_fleet()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Main mn=new Main(); 
            mn.Show();
            this.Hide();
        }
    }
}
