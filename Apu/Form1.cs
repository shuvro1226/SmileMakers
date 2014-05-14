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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public Form1(string pname, string page, string pmobile, string pinvestigation, string ptreatment, string pmedicine, string pschedule, string paddress, string pcomplain, string poral, string phistory, string psex, string pdiagnosis, string ptrtdone, string pdatetime)
        {
            InitializeComponent();
            this.CenterToScreen();
            name.Text = pname;
            age.Text = page;
            mobile.Text = pmobile;
            investigation.Text = pinvestigation;
            treatment.Text = ptreatment;
            medicine.Text = pmedicine;
            address.Text = paddress;
            complain.Text = pcomplain;
            oral.Text = poral;
            history.Text = phistory;
            diagnosis.Text = pdiagnosis;
            sex.SelectedItem = psex;
            trtdone.Text = ptrtdone;
            DateTime dt = DateTime.ParseExact(pdatetime, "dd/MM/yyyy HH:mm", null);
            dateTimePicker1.Value = dt;
        }

        private void Search_Click(object sender, EventArgs e)
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

        private void Pres_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Done(object sender, EventArgs e)
        {
            if (name.Text==String.Empty || age.Text==String.Empty || sex.SelectedItem.ToString()==String.Empty || address.Text==String.Empty || mobile.Text==String.Empty)
            {
                MessageBox.Show("Every patient detail(name,age,sex,address,mobile no.) must be provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (PID.update != true)
                {
                    DataInsert(name.Text, age.Text, sex.SelectedItem.ToString(), dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker1.Value.ToString("HH:mm"), address.Text, mobile.Text, complain.Text, oral.Text, diagnosis.Text, investigation.Text, treatment.Text, history.Text, medicine.Text, trtdone.Text);
                }
                else
                {
                    DataUpdate(name.Text, age.Text, sex.SelectedItem.ToString(), dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker1.Value.ToString("HH:mm"), address.Text, mobile.Text, complain.Text, oral.Text, diagnosis.Text, investigation.Text, treatment.Text, history.Text, medicine.Text, trtdone.Text);
                }
                Form2 form = new Form2(name.Text, age.Text, sex.SelectedItem.ToString(), dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker1.Value.ToString("HH:mm"), address.Text, mobile.Text, complain.Text, oral.Text, diagnosis.Text, investigation.Text, treatment.Text, history.Text, medicine.Text, trtdone.Text, dateTimePicker1.Value.ToString("dd/MM/yyyy HH:mm"));
                form.Show();
                this.Hide();
            }
        }

        private void DataInsert(string name, string age, string sex, string schedule, string time, string address, string mobile, string complain, string oral, string diagnosis, string investigation, string treatment, string history, string medicine, string trtdone)
        {
            PID.pid = DateTime.Now;
            if (schedule == DateTime.Now.ToString("dd/MM/yyyy"))
            {
                schedule = "No appointment was made.";
                time = "N/A";
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost;Initial Catalog=ApuChamber;Integrated Security=True;";
            string sql = "INSERT INTO prescription(name,date,age,sex,schedule,address,mobile,complain,oral,diagnosis,investigation,treatment,history,medicine,trtdone,time)" +
                "VALUES (@name,@date,@age,@sex,@schedule,@address,@mobile,@complain,@oral,@diagnosis,@investigation,@treatment,@history,@medicine,@trtdone,@time)";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlParameter[] par = new SqlParameter[16];

                par[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
                par[1] = new SqlParameter("@date", SqlDbType.DateTime);
                par[2] = new SqlParameter("@age", SqlDbType.VarChar, 3);
                par[3] = new SqlParameter("@sex", SqlDbType.VarChar, 6);
                par[4] = new SqlParameter("@schedule", SqlDbType.VarChar, 50);
                par[5] = new SqlParameter("@address", SqlDbType.VarChar, 100);
                par[6] = new SqlParameter("@mobile", SqlDbType.VarChar, 15);
                par[7] = new SqlParameter("@complain", SqlDbType.VarChar, 100);
                par[8] = new SqlParameter("@oral", SqlDbType.VarChar, 100);
                par[9] = new SqlParameter("@diagnosis", SqlDbType.VarChar, 100);
                par[10] = new SqlParameter("@investigation", SqlDbType.VarChar, 500);
                par[11] = new SqlParameter("@treatment", SqlDbType.VarChar, 500);
                par[12] = new SqlParameter("@history", SqlDbType.VarChar, 500);
                par[13] = new SqlParameter("@medicine", SqlDbType.VarChar, 500);
                par[14] = new SqlParameter("@trtdone", SqlDbType.VarChar, 500);
                par[15] = new SqlParameter("@time", SqlDbType.VarChar, 20);

                par[0].Value = name;
                par[1].Value = PID.pid.ToString();
                par[2].Value = age;
                par[3].Value = sex;
                par[4].Value = schedule;
                par[5].Value = address;
                par[6].Value = mobile;
                par[7].Value = complain;
                par[8].Value = oral;
                par[9].Value = diagnosis;
                par[10].Value = investigation;
                par[11].Value = treatment;
                par[12].Value = history;
                par[13].Value = medicine;
                par[14].Value = trtdone;
                par[15].Value = time;

                for (int i = 0; i < 16; i++)
                {
                    cmd.Parameters.Add(par[i]);
                }

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Insert Error";
                msg += ex.Message;
                throw new Exception(msg);
            }

            finally
            {
                con.Close();
            }
        }

        private void DataUpdate(string name, string age, string sex, string schedule, string time, string address, string mobile, string complain, string oral, string diagnosis, string investigation, string treatment, string history, string medicine, string trtdone)
        {
            if (schedule == DateTime.Now.ToString("dd/MM/yyyy"))
            {
                schedule = "No appointment was made.";
                time = "N/A";
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost;Initial Catalog=ApuChamber;Integrated Security=True;";
            string sql = "UPDATE prescription SET name=@name,age=@age,sex=@sex,schedule=@schedule,address=@address,mobile=@mobile,complain=@complain,oral=@oral,diagnosis=@diagnosis,investigation=@investigation,treatment=@treatment,history=@history,medicine=@medicine,trtdone=@trtdone,time=@time WHERE date='"+ PID.pid.ToString() +"'";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlParameter[] par = new SqlParameter[15];

                par[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
                par[1] = new SqlParameter("@age", SqlDbType.VarChar, 3);
                par[2] = new SqlParameter("@sex", SqlDbType.VarChar, 6);
                par[3] = new SqlParameter("@schedule", SqlDbType.VarChar, 50);
                par[4] = new SqlParameter("@address", SqlDbType.VarChar, 100);
                par[5] = new SqlParameter("@mobile", SqlDbType.VarChar, 15);
                par[6] = new SqlParameter("@complain", SqlDbType.VarChar, 100);
                par[7] = new SqlParameter("@oral", SqlDbType.VarChar, 100);
                par[8] = new SqlParameter("@diagnosis", SqlDbType.VarChar, 100);
                par[9] = new SqlParameter("@investigation", SqlDbType.VarChar, 500);
                par[10] = new SqlParameter("@treatment", SqlDbType.VarChar, 500);
                par[11] = new SqlParameter("@history", SqlDbType.VarChar, 500);
                par[12] = new SqlParameter("@medicine", SqlDbType.VarChar, 500);
                par[13] = new SqlParameter("@trtdone", SqlDbType.VarChar, 500);
                par[14] = new SqlParameter("@time", SqlDbType.VarChar, 20);

                par[0].Value = name;
                par[1].Value = age;
                par[2].Value = sex;
                par[3].Value = schedule;
                par[4].Value = address;
                par[5].Value = mobile;
                par[6].Value = complain;
                par[7].Value = oral;
                par[8].Value = diagnosis;
                par[9].Value = investigation;
                par[10].Value = treatment;
                par[11].Value = history;
                par[12].Value = medicine;
                par[13].Value = trtdone;
                par[14].Value = time;

                for (int i = 0; i < 15; i++)
                {
                    cmd.Parameters.Add(par[i]);
                }

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Insert Error";
                msg += ex.Message;
                throw new Exception(msg);
            }

            finally
            {
                con.Close();
                PID.update = false;
            }
        }

        public void mobile_TextChanged(object sender, EventArgs e)
        {

        }

        public void complainlabel_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void history_TextChanged(object sender, EventArgs e)
        {

        }

        private void sid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
                else if (c is RichTextBox)
                {
                    ((RichTextBox)c).Text = String.Empty;
                }
            }
        }

        private void investigation_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public string TextBoxText
        {
            get { return oral.Text; }
            set { oral.Text += value; }
        }

        private void Oral_Examination(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Owner = this;
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void sid_Click(object sender, EventArgs e)
        {
            sid.Text = String.Empty;
        }
    }

    public static class PID
    {
        public static System.DateTime pid;
        public static bool update;
    }
}
