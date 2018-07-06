namespace Athletes_Info
{
    partial class AddAthlete
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbox_department = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_add_image = new System.Windows.Forms.Button();
            this.cbEvent = new System.Windows.Forms.ComboBox();
            this.tbYears = new System.Windows.Forms.TextBox();
            this.tbClub = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbBirth = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.tbCourse = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbPaddress = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbUid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMi = new System.Windows.Forms.TextBox();
            this.picturebox_profile = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblUsepID = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbox_department);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btn_add_image);
            this.panel1.Controls.Add(this.cbEvent);
            this.panel1.Controls.Add(this.tbYears);
            this.panel1.Controls.Add(this.tbClub);
            this.panel1.Controls.Add(this.tbWeight);
            this.panel1.Controls.Add(this.tbBirth);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.tbContact);
            this.panel1.Controls.Add(this.tbCourse);
            this.panel1.Controls.Add(this.tbHeight);
            this.panel1.Controls.Add(this.tbPaddress);
            this.panel1.Controls.Add(this.tbAddress);
            this.panel1.Controls.Add(this.tbUid);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbMi);
            this.panel1.Controls.Add(this.picturebox_profile);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblUsepID);
            this.panel1.Controls.Add(this.lblFname);
            this.panel1.Controls.Add(this.tbLname);
            this.panel1.Controls.Add(this.tbFname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 480);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbox_department
            // 
            this.cmbox_department.FormattingEnabled = true;
            this.cmbox_department.Items.AddRange(new object[] {
            "IC",
            "CE",
            "CT",
            "CED",
            "CAS",
            "CGB",
            "SAeC"});
            this.cmbox_department.Location = new System.Drawing.Point(354, 202);
            this.cmbox_department.Name = "cmbox_department";
            this.cmbox_department.Size = new System.Drawing.Size(109, 24);
            this.cmbox_department.TabIndex = 74;
            this.cmbox_department.SelectedIndexChanged += new System.EventHandler(this.cmbox_department_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 83);
            this.panel2.TabIndex = 73;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(293, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 32);
            this.label14.TabIndex = 0;
            this.label14.Text = "ADD ATHLETE";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(332, 290);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 21);
            this.dateTimePicker1.TabIndex = 72;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_add_image
            // 
            this.btn_add_image.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_image.Location = new System.Drawing.Point(77, 262);
            this.btn_add_image.Name = "btn_add_image";
            this.btn_add_image.Size = new System.Drawing.Size(90, 36);
            this.btn_add_image.TabIndex = 71;
            this.btn_add_image.Text = "Add Image";
            this.btn_add_image.UseVisualStyleBackColor = true;
            this.btn_add_image.Click += new System.EventHandler(this.btn_add_image_Click_1);
            // 
            // cbEvent
            // 
            this.cbEvent.FormattingEnabled = true;
            this.cbEvent.Items.AddRange(new object[] {
            "Basketball",
            "Volleyball",
            "Table Tennis",
            "Lawn Tennis",
            "Swimming",
            "Softball",
            "Sepak Takraw",
            "Baseball",
            "Badminton",
            "Chess",
            "Karatedo",
            "Futsal",
            "Wu Shu"});
            this.cbEvent.Location = new System.Drawing.Point(220, 358);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(121, 24);
            this.cbEvent.TabIndex = 70;
            this.cbEvent.SelectedIndexChanged += new System.EventHandler(this.cbEvent_SelectedIndexChanged);
            // 
            // tbYears
            // 
            this.tbYears.Location = new System.Drawing.Point(533, 372);
            this.tbYears.Name = "tbYears";
            this.tbYears.Size = new System.Drawing.Size(112, 21);
            this.tbYears.TabIndex = 69;
            this.tbYears.TextChanged += new System.EventHandler(this.tbYears_TextChanged);
            // 
            // tbClub
            // 
            this.tbClub.Location = new System.Drawing.Point(220, 390);
            this.tbClub.Name = "tbClub";
            this.tbClub.Size = new System.Drawing.Size(121, 21);
            this.tbClub.TabIndex = 68;
            this.tbClub.TextChanged += new System.EventHandler(this.tbClub_TextChanged);
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(553, 317);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(137, 21);
            this.tbWeight.TabIndex = 67;
            this.tbWeight.TextChanged += new System.EventHandler(this.tbWeight_TextChanged);
            // 
            // tbBirth
            // 
            this.tbBirth.Location = new System.Drawing.Point(553, 289);
            this.tbBirth.Name = "tbBirth";
            this.tbBirth.Size = new System.Drawing.Size(137, 21);
            this.tbBirth.TabIndex = 66;
            this.tbBirth.TextChanged += new System.EventHandler(this.tbBirth_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(559, 233);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(137, 21);
            this.tbEmail.TabIndex = 65;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(577, 199);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(119, 21);
            this.tbContact.TabIndex = 64;
            this.tbContact.TextChanged += new System.EventHandler(this.tbContact_TextChanged);
            // 
            // tbCourse
            // 
            this.tbCourse.Location = new System.Drawing.Point(559, 169);
            this.tbCourse.Name = "tbCourse";
            this.tbCourse.Size = new System.Drawing.Size(137, 21);
            this.tbCourse.TabIndex = 63;
            this.tbCourse.TextChanged += new System.EventHandler(this.tbCourse_TextChanged);
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(332, 318);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(133, 21);
            this.tbHeight.TabIndex = 61;
            this.tbHeight.TextChanged += new System.EventHandler(this.tbHeight_TextChanged);
            // 
            // tbPaddress
            // 
            this.tbPaddress.Location = new System.Drawing.Point(332, 262);
            this.tbPaddress.Name = "tbPaddress";
            this.tbPaddress.Size = new System.Drawing.Size(364, 21);
            this.tbPaddress.TabIndex = 60;
            this.tbPaddress.TextChanged += new System.EventHandler(this.tbPaddress_TextChanged);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(330, 233);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(133, 21);
            this.tbAddress.TabIndex = 59;
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
            // 
            // tbUid
            // 
            this.tbUid.Location = new System.Drawing.Point(332, 165);
            this.tbUid.Name = "tbUid";
            this.tbUid.Size = new System.Drawing.Size(133, 21);
            this.tbUid.TabIndex = 57;
            this.tbUid.TextChanged += new System.EventHandler(this.tbUid_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(409, 375);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 16);
            this.label13.TabIndex = 56;
            this.label13.Text = "No. of Playing Years";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(95, 391);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 16);
            this.label12.TabIndex = 55;
            this.label12.Text = "Current Club, if any";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(98, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 16);
            this.label11.TabIndex = 54;
            this.label11.Text = "Sport/Event Played";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(471, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 53;
            this.label10.Text = "Weight (kg)";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(231, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 52;
            this.label9.Text = "Height (cm)";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(471, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 51;
            this.label8.Text = "Place of Birth";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(231, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "Date of Birth";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(231, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Provincial Address";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(472, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "E-mail Address";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "City Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(471, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Contact Number";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "College/Department";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = " Course / Year";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbMi
            // 
            this.tbMi.Location = new System.Drawing.Point(578, 128);
            this.tbMi.Name = "tbMi";
            this.tbMi.Size = new System.Drawing.Size(31, 21);
            this.tbMi.TabIndex = 43;
            this.tbMi.TextChanged += new System.EventHandler(this.tbMi_TextChanged);
            // 
            // picturebox_profile
            // 
            this.picturebox_profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturebox_profile.Location = new System.Drawing.Point(36, 89);
            this.picturebox_profile.Name = "picturebox_profile";
            this.picturebox_profile.Size = new System.Drawing.Size(171, 166);
            this.picturebox_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_profile.TabIndex = 42;
            this.picturebox_profile.TabStop = false;
            this.picturebox_profile.Click += new System.EventHandler(this.pcturebox_profile_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(299, 437);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 31);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // lblUsepID
            // 
            this.lblUsepID.AutoSize = true;
            this.lblUsepID.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsepID.Location = new System.Drawing.Point(231, 172);
            this.lblUsepID.Name = "lblUsepID";
            this.lblUsepID.Size = new System.Drawing.Size(96, 16);
            this.lblUsepID.TabIndex = 40;
            this.lblUsepID.Text = "USeP ID Number";
            this.lblUsepID.Click += new System.EventHandler(this.lblUsepID_Click);
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(229, 131);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(98, 16);
            this.lblFname.TabIndex = 39;
            this.lblFname.Text = "Complete Name";
            this.lblFname.Click += new System.EventHandler(this.lblFname_Click);
            // 
            // tbLname
            // 
            this.tbLname.Location = new System.Drawing.Point(472, 128);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(100, 21);
            this.tbLname.TabIndex = 38;
            this.tbLname.TextChanged += new System.EventHandler(this.tbLname_TextChanged);
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(330, 128);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(136, 21);
            this.tbFname.TabIndex = 37;
            this.tbFname.TextChanged += new System.EventHandler(this.tbFname_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // AddAthlete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 480);
            this.Controls.Add(this.panel1);
            this.Name = "AddAthlete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Athletes Data Management System v1.0";
            this.Load += new System.EventHandler(this.AddAthlete_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add_image;
        private System.Windows.Forms.ComboBox cbEvent;
        private System.Windows.Forms.TextBox tbYears;
        private System.Windows.Forms.TextBox tbClub;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbBirth;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.TextBox tbCourse;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbPaddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbUid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMi;
        private System.Windows.Forms.PictureBox picturebox_profile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblUsepID;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbox_department;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;

    }
}