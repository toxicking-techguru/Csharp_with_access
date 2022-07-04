using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhumi_Healthcare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            
            if(txtUsername.Text == "admin")
            {
                if(txtPassword.Text == "1234")
                {
                    MessageBox.Show("Login succesful");
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }

            }
            else
            {
                MessageBox.Show("Incorrect Details");
            }
        }
    }
}
