namespace ApuApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.prescription = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.sid = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.agelabel = new System.Windows.Forms.Label();
            this.mobile = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.mobilelabel = new System.Windows.Forms.Label();
            this.addresslabel = new System.Windows.Forms.Label();
            this.sexlabel = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.ComboBox();
            this.complainlabel = new System.Windows.Forms.Label();
            this.investigation = new System.Windows.Forms.RichTextBox();
            this.diagnosislabel = new System.Windows.Forms.Label();
            this.medicineslabel = new System.Windows.Forms.Label();
            this.medicine = new System.Windows.Forms.RichTextBox();
            this.donebutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.complain = new System.Windows.Forms.TextBox();
            this.diagnosis = new System.Windows.Forms.TextBox();
            this.investigationlabel = new System.Windows.Forms.Label();
            this.treatmentlabel = new System.Windows.Forms.Label();
            this.treatment = new System.Windows.Forms.RichTextBox();
            this.history = new System.Windows.Forms.RichTextBox();
            this.historylabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.oral = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.trtdone = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // prescription
            // 
            this.prescription.BackColor = System.Drawing.Color.Indigo;
            this.prescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescription.ForeColor = System.Drawing.Color.White;
            this.prescription.Location = new System.Drawing.Point(224, 147);
            this.prescription.Name = "prescription";
            this.prescription.Size = new System.Drawing.Size(120, 44);
            this.prescription.TabIndex = 0;
            this.prescription.Text = "Reset Data";
            this.prescription.UseVisualStyleBackColor = false;
            this.prescription.Click += new System.EventHandler(this.Reset);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Indigo;
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(677, 147);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(120, 44);
            this.search.TabIndex = 1;
            this.search.Text = "Search Patient";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // sid
            // 
            this.sid.BackColor = System.Drawing.SystemColors.Info;
            this.sid.Location = new System.Drawing.Point(476, 161);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(195, 20);
            this.sid.TabIndex = 3;
            this.sid.Text = "Enter Mobile No.";
            this.sid.Click += new System.EventHandler(this.sid_Click);
            this.sid.TextChanged += new System.EventHandler(this.sid_TextChanged);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.namelabel.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(98, 209);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(77, 14);
            this.namelabel.TabIndex = 5;
            this.namelabel.Text = "Enter Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(212, 209);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(237, 20);
            this.name.TabIndex = 6;
            // 
            // agelabel
            // 
            this.agelabel.AutoSize = true;
            this.agelabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.agelabel.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agelabel.Location = new System.Drawing.Point(504, 209);
            this.agelabel.Name = "agelabel";
            this.agelabel.Size = new System.Drawing.Size(29, 14);
            this.agelabel.TabIndex = 9;
            this.agelabel.Text = "Age";
            // 
            // mobile
            // 
            this.mobile.Location = new System.Drawing.Point(663, 235);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(134, 20);
            this.mobile.TabIndex = 12;
            this.mobile.TextChanged += new System.EventHandler(this.mobile_TextChanged);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(212, 235);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(321, 20);
            this.address.TabIndex = 13;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(539, 210);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(54, 20);
            this.age.TabIndex = 14;
            // 
            // mobilelabel
            // 
            this.mobilelabel.AutoSize = true;
            this.mobilelabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mobilelabel.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilelabel.Location = new System.Drawing.Point(581, 235);
            this.mobilelabel.Name = "mobilelabel";
            this.mobilelabel.Size = new System.Drawing.Size(76, 14);
            this.mobilelabel.TabIndex = 16;
            this.mobilelabel.Text = "Contact No.";
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addresslabel.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslabel.Location = new System.Drawing.Point(98, 235);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(55, 14);
            this.addresslabel.TabIndex = 17;
            this.addresslabel.Text = "Address";
            // 
            // sexlabel
            // 
            this.sexlabel.AutoSize = true;
            this.sexlabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sexlabel.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexlabel.Location = new System.Drawing.Point(677, 209);
            this.sexlabel.Name = "sexlabel";
            this.sexlabel.Size = new System.Drawing.Size(27, 14);
            this.sexlabel.TabIndex = 18;
            this.sexlabel.Text = "Sex";
            // 
            // sex
            // 
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sex.Location = new System.Drawing.Point(710, 209);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(87, 21);
            this.sex.TabIndex = 19;
            // 
            // complainlabel
            // 
            this.complainlabel.AutoSize = true;
            this.complainlabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.complainlabel.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complainlabel.Location = new System.Drawing.Point(98, 261);
            this.complainlabel.Name = "complainlabel";
            this.complainlabel.Size = new System.Drawing.Size(111, 14);
            this.complainlabel.TabIndex = 20;
            this.complainlabel.Text = "Chief Complaints";
            this.complainlabel.Click += new System.EventHandler(this.complainlabel_Click);
            // 
            // investigation
            // 
            this.investigation.BackColor = System.Drawing.SystemColors.Window;
            this.investigation.Location = new System.Drawing.Point(212, 313);
            this.investigation.Multiline = false;
            this.investigation.Name = "investigation";
            this.investigation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.investigation.Size = new System.Drawing.Size(294, 20);
            this.investigation.TabIndex = 24;
            this.investigation.Text = "";
            this.investigation.TextChanged += new System.EventHandler(this.investigation_TextChanged);
            // 
            // diagnosislabel
            // 
            this.diagnosislabel.AutoSize = true;
            this.diagnosislabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.diagnosislabel.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosislabel.Location = new System.Drawing.Point(98, 287);
            this.diagnosislabel.Name = "diagnosislabel";
            this.diagnosislabel.Size = new System.Drawing.Size(64, 14);
            this.diagnosislabel.TabIndex = 25;
            this.diagnosislabel.Text = "Diagnosis";
            // 
            // medicineslabel
            // 
            this.medicineslabel.AutoSize = true;
            this.medicineslabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.medicineslabel.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineslabel.Location = new System.Drawing.Point(95, 451);
            this.medicineslabel.Name = "medicineslabel";
            this.medicineslabel.Size = new System.Drawing.Size(67, 14);
            this.medicineslabel.TabIndex = 26;
            this.medicineslabel.Text = "Medicines";
            this.medicineslabel.Click += new System.EventHandler(this.label11_Click);
            // 
            // medicine
            // 
            this.medicine.Location = new System.Drawing.Point(212, 451);
            this.medicine.Name = "medicine";
            this.medicine.Size = new System.Drawing.Size(585, 74);
            this.medicine.TabIndex = 27;
            this.medicine.Text = "";
            // 
            // donebutton
            // 
            this.donebutton.BackColor = System.Drawing.Color.Indigo;
            this.donebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.donebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donebutton.Location = new System.Drawing.Point(677, 578);
            this.donebutton.Name = "donebutton";
            this.donebutton.Size = new System.Drawing.Size(120, 44);
            this.donebutton.TabIndex = 28;
            this.donebutton.Text = "Done";
            this.donebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.donebutton.UseVisualStyleBackColor = false;
            this.donebutton.Click += new System.EventHandler(this.Done);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-24, -30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 661);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // complain
            // 
            this.complain.Location = new System.Drawing.Point(212, 261);
            this.complain.Name = "complain";
            this.complain.Size = new System.Drawing.Size(288, 20);
            this.complain.TabIndex = 31;
            // 
            // diagnosis
            // 
            this.diagnosis.Location = new System.Drawing.Point(212, 287);
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.Size = new System.Drawing.Size(294, 20);
            this.diagnosis.TabIndex = 32;
            this.diagnosis.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // investigationlabel
            // 
            this.investigationlabel.AutoSize = true;
            this.investigationlabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.investigationlabel.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investigationlabel.Location = new System.Drawing.Point(98, 313);
            this.investigationlabel.Name = "investigationlabel";
            this.investigationlabel.Size = new System.Drawing.Size(91, 14);
            this.investigationlabel.TabIndex = 33;
            this.investigationlabel.Text = "Investigations";
            // 
            // treatmentlabel
            // 
            this.treatmentlabel.AutoSize = true;
            this.treatmentlabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.treatmentlabel.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentlabel.Location = new System.Drawing.Point(98, 339);
            this.treatmentlabel.Name = "treatmentlabel";
            this.treatmentlabel.Size = new System.Drawing.Size(47, 14);
            this.treatmentlabel.TabIndex = 34;
            this.treatmentlabel.Text = "Advice";
            // 
            // treatment
            // 
            this.treatment.Location = new System.Drawing.Point(212, 339);
            this.treatment.Name = "treatment";
            this.treatment.Size = new System.Drawing.Size(585, 50);
            this.treatment.TabIndex = 35;
            this.treatment.Text = "";
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(212, 395);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(585, 50);
            this.history.TabIndex = 36;
            this.history.Text = "";
            this.history.TextChanged += new System.EventHandler(this.history_TextChanged);
            // 
            // historylabel
            // 
            this.historylabel.AutoSize = true;
            this.historylabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.historylabel.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historylabel.Location = new System.Drawing.Point(95, 395);
            this.historylabel.Name = "historylabel";
            this.historylabel.Size = new System.Drawing.Size(99, 14);
            this.historylabel.TabIndex = 37;
            this.historylabel.Text = "Medical History";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(542, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 40;
            this.button2.Text = "Oral Examination";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Oral_Examination);
            // 
            // oral
            // 
            this.oral.Location = new System.Drawing.Point(623, 287);
            this.oral.Name = "oral";
            this.oral.Size = new System.Drawing.Size(174, 46);
            this.oral.TabIndex = 41;
            this.oral.Text = "";
            this.oral.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Indigo;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(98, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 44);
            this.button3.TabIndex = 42;
            this.button3.Text = "Main";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd MM yyyy HH mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(599, 261);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 43;
            this.dateTimePicker1.Value = new System.DateTime(2014, 4, 12, 4, 49, 40, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(506, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 14);
            this.label1.TabIndex = 44;
            this.label1.Text = "Appointment";
            // 
            // trtdone
            // 
            this.trtdone.Location = new System.Drawing.Point(212, 531);
            this.trtdone.Name = "trtdone";
            this.trtdone.Size = new System.Drawing.Size(585, 36);
            this.trtdone.TabIndex = 45;
            this.trtdone.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 14);
            this.label2.TabIndex = 46;
            this.label2.Text = "Treatment\'s Done";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(878, 634);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trtdone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.oral);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.historylabel);
            this.Controls.Add(this.history);
            this.Controls.Add(this.treatment);
            this.Controls.Add(this.treatmentlabel);
            this.Controls.Add(this.investigationlabel);
            this.Controls.Add(this.diagnosis);
            this.Controls.Add(this.complain);
            this.Controls.Add(this.donebutton);
            this.Controls.Add(this.medicine);
            this.Controls.Add(this.medicineslabel);
            this.Controls.Add(this.diagnosislabel);
            this.Controls.Add(this.investigation);
            this.Controls.Add(this.complainlabel);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.sexlabel);
            this.Controls.Add(this.addresslabel);
            this.Controls.Add(this.mobilelabel);
            this.Controls.Add(this.age);
            this.Controls.Add(this.address);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.agelabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.sid);
            this.Controls.Add(this.search);
            this.Controls.Add(this.prescription);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Prescription";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exit);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prescription;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox sid;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label agelabel;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label mobilelabel;
        private System.Windows.Forms.Label addresslabel;
        private System.Windows.Forms.Label sexlabel;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.Label complainlabel;
        private System.Windows.Forms.RichTextBox investigation;
        private System.Windows.Forms.Label diagnosislabel;
        private System.Windows.Forms.Label medicineslabel;
        private System.Windows.Forms.RichTextBox medicine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button donebutton;
        private System.Windows.Forms.TextBox complain;
        private System.Windows.Forms.TextBox diagnosis;
        private System.Windows.Forms.Label investigationlabel;
        private System.Windows.Forms.Label treatmentlabel;
        private System.Windows.Forms.RichTextBox treatment;
        private System.Windows.Forms.RichTextBox history;
        private System.Windows.Forms.Label historylabel;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.RichTextBox oral;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox trtdone;
        private System.Windows.Forms.Label label2;
    }
}

