using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApuApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public string total;

        private void Caries(object sender, EventArgs e)
        {
            List<string> values = new List<string>();

            foreach (object obj1 in listBox1.SelectedItems)
                values.Add(obj1.ToString());
            string Items = String.Join(", ", values);
            total = "Caries (" + Items + "), ";
            Form1 form = (Form1)this.Owner;
            form.TextBoxText = total;
            this.Hide();
        }

        private void Gross(object sender, EventArgs e)
        {
            List<string> values = new List<string>();

            foreach (object obj1 in listBox2.SelectedItems)
                values.Add(obj1.ToString());
            string Items = String.Join(", ", values);
            total = "Gross Caries (" + Items + "), ";
            Form1 form = (Form1)this.Owner;
            form.TextBoxText = total;
            this.Hide();
        }

        private void Deciduous(object sender, EventArgs e)
        {
            List<string> values = new List<string>();

            foreach (object obj1 in listBox3.SelectedItems)
                values.Add(obj1.ToString());
            string Items = String.Join(", ", values);
            total = "Deciduous Teeth (" + Items + "), ";
            Form1 form = (Form1)this.Owner;
            form.TextBoxText = total;
            this.Hide();
        }
        

        private void Missing(object sender, EventArgs e)
        {
            List<string> values = new List<string>();

            foreach (object obj1 in listBox4.SelectedItems)
                values.Add(obj1.ToString());
            string Items = String.Join(", ", values);
            total = "Missing Teeth (" + Items + "), ";
            Form1 form = (Form1)this.Owner;
            form.TextBoxText = total;
            this.Hide();
        }

        private void Pocket(object sender, EventArgs e)
        {
            total = "Periodontal Pocket, ";
            Form1 form = (Form1)this.Owner;
            form.TextBoxText = total;
            this.Hide();
        }
    }
}
