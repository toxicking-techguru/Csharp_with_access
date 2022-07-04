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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void cmdCALLS_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdAddNew_Click(object sender, EventArgs e)
        {
            Form6 f6=new Form6();
            f6.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 f7=new Form7();
            f7.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
