using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bhumi_Healthcare
{
    public partial class Form7 : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public Form7()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\Kevin\Desktop\Bhumi project\Bhumi Healtcare Database.accdb";

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "insert into Bill values('" + txtId.Text + "','" + txtPid.Text + "','" + txtTrans.Text + "','" + txtPay.Text + "','" + txtTot.Text + "')";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Inserted succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Bill";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch
            {
                MessageBox.Show("ERROR LOADING DATA");

            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
