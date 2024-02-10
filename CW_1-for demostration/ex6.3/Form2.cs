using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex6._3
{
    public partial class Form2 : Form
    {
        public string strname;
        public Form2(string strName)


        {
            InitializeComponent();
            strname = strName;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = strname;
        }
    }
}
