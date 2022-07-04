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
    public partial class Form9 : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public Form9()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\Kevin\Desktop\Bhumi project\Bhumi Healtcare Database.accdb";

        }

        private void Form9_Load(object sender, EventArgs e)
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
                cmd.CommandText = "insert into Diagnosis values('" + txtId.Text + "','" + txtPid.Text + "','" + txtDid.Text + "','" + txtDisease.Text + "','" + txtPres.Text + "')";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Inserted succesfully");
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
                cmd.CommandText = "delete from Diagnosis where Disease ='" + txtDisease.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("record deleted succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error YOU need to input disease to delete" + ex);

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
                cmd.CommandText = "select * from Diagnosis ";
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
