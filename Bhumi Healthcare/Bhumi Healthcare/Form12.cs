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
    public partial class Form12 : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public Form12()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\Kevin\Desktop\Bhumi project\Bhumi Healtcare Database.accdb";

        }

        private void Form12_Load(object sender, EventArgs e)
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
                cmd.CommandText = "insert into Staff values('" + txtId.Text + "','" + txtName.Text + "','" + txtDesg.Text + "','" + txtDid.Text + "','" + txtPid.Text + "','" + txtRoom.Text + "')";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Inserted succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Staff ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);

            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Staff where StaffName='" + txtName.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("record deleted succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error YOU need to input Staff Name to delete" + ex);

            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
