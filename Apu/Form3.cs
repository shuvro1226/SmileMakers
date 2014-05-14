using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ApuApp
{
    public partial class Form3 : Form
    {
        public Form3(string sid)
        {
            InitializeComponent();
            this.CenterToScreen();
            SearchData(sid);
        }

        private void SearchData(string id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost;Initial Catalog=ApuChamber;Integrated Security=True;";
            string sql = "SELECT date,name,age,sex,mobile,address,oral,diagnosis,complain,investigation,history,treatment,medicine,schedule FROM prescription WHERE mobile = '" + id + "'";
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
            DataGridViewRow row = this.dataGridView1.RowTemplate;
            row.Height = 100;
            DataGridViewColumn column0 = dataGridView1.Columns[0];
            column0.Width = 60;
            column0.HeaderText = "Date";
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.Width = 100;
            column1.HeaderText = "Name";
            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.Width = 30;
            column2.HeaderText = "Age";
            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.Width = 50;
            column3.HeaderText = "Sex";
            DataGridViewColumn column4 = dataGridView1.Columns[4];
            column4.Width = 80;
            column4.HeaderText = "Mobile";
            DataGridViewColumn column5 = dataGridView1.Columns[5];
            column5.Width = 120;
            column5.HeaderText = "Address";
            DataGridViewColumn column6 = dataGridView1.Columns[6];
            column6.Width = 100;
            column6.HeaderText = "Oral Examination";
            DataGridViewColumn column7 = dataGridView1.Columns[7];
            column7.Width = 80;
            column7.HeaderText = "Diagnosis";
            DataGridViewColumn column8 = dataGridView1.Columns[8];
            column8.Width = 80;
            column8.HeaderText = "Complaints";
            DataGridViewColumn column9 = dataGridView1.Columns[9];
            column9.Width = 80;
            column9.HeaderText = "Investigations";
            DataGridViewColumn column10 = dataGridView1.Columns[10];
            column10.Width = 80;
            column10.HeaderText = "History";
            DataGridViewColumn column11 = dataGridView1.Columns[11];
            column11.Width = 100;
            column11.HeaderText = "Advices";
            DataGridViewColumn column12 = dataGridView1.Columns[12];
            column12.Width = 150;
            column12.HeaderText = "Medicine's";
            DataGridViewColumn column13 = dataGridView1.Columns[13];
            column13.Width = 60;
            column13.HeaderText = "Appointment";
        }

        private void Prescription(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=localhost;Initial Catalog=ApuChamber;Integrated Security=True;";
            SqlConnection con = new SqlConnection(ConnectionString);
            string sql = "SELECT COUNT(mobile) FROM prescription WHERE mobile='" + id.Text + "'";
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
                Form3 form = new Form3(id.Text);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Hide();
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void id_Click(object sender, EventArgs e)
        {
            id.Text = String.Empty;
        }
    }
}
