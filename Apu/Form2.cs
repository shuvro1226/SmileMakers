using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.IO;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ApuApp
{
    public partial class Form2 : Form
    {
        public bool update;
        public Form2(string name, string age, string sex, string schedule, string time, string address, string mobile, string complain, string oral, string diagnosis, string investigation, string treatment, string history, string medicine, string trtdone, string datetime)
        {
            InitializeComponent();
            this.CenterToScreen();
            label2.Text = address;
            label3.Text = complain;
            label4.Text = oral;
            label5.Text = history;
            label6.Text = sex;
            label7.Text = diagnosis;
            label8.Text = trtdone;
            label9.Text = datetime;
            label1.Text = schedule;
            var pos8 = this.PointToScreen(label1.Location);
            pos8 = pictureBox1.PointToClient(pos8);
            label1.Parent = pictureBox1;
            label1.Location = pos8;
            label1.BackColor = Color.Transparent;
            label1.Text = name;
            var pos2 = this.PointToScreen(namelabel.Location);
            pos2 = pictureBox1.PointToClient(pos2);
            namelabel.Parent = pictureBox1;
            namelabel.Location = pos2;
            namelabel.BackColor = Color.Transparent;
            agelabel.Text = age;
            var pos3 = this.PointToScreen(agelabel.Location);
            pos3 = pictureBox1.PointToClient(pos3);
            agelabel.Parent = pictureBox1;
            agelabel.Location = pos3;
            agelabel.BackColor = Color.Transparent;
            mobilelabel.Text = mobile;
            var pos7 = this.PointToScreen(mobilelabel.Location);
            pos7 = pictureBox1.PointToClient(pos7);
            mobilelabel.Parent = pictureBox1;
            mobilelabel.Location = pos7;
            mobilelabel.BackColor = Color.Transparent;
            datelabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
            var pos4 = this.PointToScreen(datelabel.Location);
            pos4 = pictureBox1.PointToClient(pos4);
            datelabel.Parent = pictureBox1;
            datelabel.Location = pos4;
            datelabel.BackColor = Color.Transparent;
            investigationlabel.Text = investigation;
            var pos5 = this.PointToScreen(investigationlabel.Location);
            pos5 = pictureBox1.PointToClient(pos5);
            investigationlabel.Parent = pictureBox1;
            investigationlabel.Location = pos5;
            investigationlabel.BackColor = Color.Transparent;
            treatmentlabel.Text = treatment;
            var pos6 = this.PointToScreen(treatmentlabel.Location);
            pos6 = pictureBox1.PointToClient(pos6);
            treatmentlabel.Parent = pictureBox1;
            treatmentlabel.Location = pos6;
            treatmentlabel.BackColor = Color.Transparent;
            medicinelabel.Text = medicine;
            var pos1 = this.PointToScreen(medicinelabel.Location);
            pos1 = pictureBox1.PointToClient(pos1);
            medicinelabel.Parent = pictureBox1;
            medicinelabel.Location = pos1;
            medicinelabel.BackColor = Color.Transparent;
            if (schedule != DateTime.Now.ToString("dd/MM/yyyy"))
            {
                label1.Text = schedule + " at " + time;
            }
            else
            {
                label1.Text = "No appointment was made.";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void mobilelabel_Click(object sender, EventArgs e)
        {

        }

        private void investigationlabel_Click(object sender, EventArgs e)
        {

        }

        private void treatmentlabel_Click(object sender, EventArgs e)
        {

        }

        private void Prescription(object sender, EventArgs e)
        {
            PID.update = true;
            Form1 form = new Form1(namelabel.Text,agelabel.Text,mobilelabel.Text,investigationlabel.Text,treatmentlabel.Text,medicinelabel.Text,label1.Text,label2.Text,label3.Text,label4.Text,label5.Text,label6.Text,label7.Text,label8.Text,label9.Text);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Hide();
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        private PageSettings pgSettings = new PageSettings();
        private PrinterSettings prntrSettings = new PrinterSettings();
        private void CaptureScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, 630, 741, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }
        private void printDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        private void printButton_Click(System.Object sender, System.EventArgs e)
        {
            printDocument1.DefaultPageSettings = pgSettings;
            PrintDialog dlg = new PrintDialog();
            dlg.Document = printDocument1;
            if(dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CaptureScreen();
                printDocument1.Print();
            }
        }

        private void button4_Click(object sender, EventArgs e)
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
    }
}
