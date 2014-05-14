using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ApuApp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=localhost;Initial Catalog=ApuChamber;Integrated Security=True;";
            SqlConnection con = new SqlConnection(ConnectionString);
            string sql = "SELECT COUNT(mobile) FROM prescription WHERE mobile='" + sid.Text + "'";
            con.Open();
            int count = 0;
            SqlCommand cmd = new SqlCommand(sql, con);
            count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count == 0)
            {
                MessageBox.Show("Patient not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form3 form = new Form3(sid.Text);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
                this.Hide();
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost;Initial Catalog=ApuChamber;Integrated Security=True;";
            string sql = "SELECT date,name,age,sex,mobile,investigation,schedule FROM prescription WHERE schedule = '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "'";
            SqlConnection connection = new SqlConnection(con.ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            da.Fill(ds, "prescription");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "prescription";
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToResizeRows = false;
            DataGridViewColumn column0 = dataGridView1.Columns[0];
            column0.Width = 120;
            column0.HeaderText = "Date";
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.Width = 120;
            column1.HeaderText = "Name";
            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.Width = 40;
            column2.HeaderText = "Age";
            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.Width = 60;
            column3.HeaderText = "Sex";
            DataGridViewColumn column4 = dataGridView1.Columns[4];
            column4.Width = 100;
            column4.HeaderText = "Mobile";
            DataGridViewColumn column5 = dataGridView1.Columns[5];
            column5.Width = 120;
            column5.HeaderText = "Investigation";
            DataGridViewColumn column6 = dataGridView1.Columns[6];
            column6.Width = 100;
            column6.HeaderText = "Time";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost;Initial Catalog=ApuChamber;Integrated Security=True;";
            string sql = "SELECT date,name,age,sex,mobile,investigation,time FROM prescription WHERE schedule = '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "'";
            SqlConnection connection = new SqlConnection(con.ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            da.Fill(ds, "prescription");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "prescription";
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToResizeRows = false;
            DataGridViewColumn column0 = dataGridView1.Columns[0];
            column0.Width = 120;
            column0.HeaderText = "Date";
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.Width = 120;
            column1.HeaderText = "Name";
            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.Width = 40;
            column2.HeaderText = "Age";
            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.Width = 60;
            column3.HeaderText = "Sex";
            DataGridViewColumn column4 = dataGridView1.Columns[4];
            column4.Width = 100;
            column4.HeaderText = "Mobile";
            DataGridViewColumn column5 = dataGridView1.Columns[5];
            column5.Width = 120;
            column5.HeaderText = "Investigation";
            DataGridViewColumn column6 = dataGridView1.Columns[6];
            column6.Width = 100;
            column6.HeaderText = "Time";
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void sid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sid_Click(object sender, EventArgs e)
        {
            sid.Text = String.Empty;
        }
    }
}
