namespace Athletes_Info
{
    partial class International
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
            this.tbMonth = new System.Windows.Forms.TextBox();
            this.tbCompetition = new System.Windows.Forms.TextBox();
            this.tbRank = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pbInternational = new System.Windows.Forms.PictureBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.tbUserid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbInternational)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMonth
            // 
            this.tbMonth.Location = new System.Drawing.Point(25, 99);
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(137, 20);
            this.tbMonth.TabIndex = 0;
            this.tbMonth.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbCompetition
            // 
            this.tbCompetition.Location = new System.Drawing.Point(190, 99);
            this.tbCompetition.Name = "tbCompetition";
            this.tbCompetition.Size = new System.Drawing.Size(199, 20);
            this.tbCompetition.TabIndex = 1;
            // 
            // tbRank
            // 
            this.tbRank.Location = new System.Drawing.Point(417, 99);
            this.tbRank.Name = "tbRank";
            this.tbRank.Size = new System.Drawing.Size(100, 20);
            this.tbRank.TabIndex = 2;
            this.tbRank.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(219, 328);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "Save ";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "MONTH & YEAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "NAME OF COMPETITION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "RANK";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(312, 328);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(93, 23);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse Proof";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbInternational
            // 
            this.pbInternational.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbInternational.Location = new System.Drawing.Point(25, 136);
            this.pbInternational.Name = "pbInternational";
            this.pbInternational.Size = new System.Drawing.Size(491, 186);
            this.pbInternational.TabIndex = 8;
            this.pbInternational.TabStop = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(167, 20);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(48, 17);
            this.lbl_id.TabIndex = 10;
            this.lbl_id.Text = "Label";
            this.lbl_id.Click += new System.EventHandler(this.lbl_id_Click);
            // 
            // tbUserid
            // 
            this.tbUserid.Location = new System.Drawing.Point(3, 359);
            this.tbUserid.Name = "tbUserid";
            this.tbUserid.Size = new System.Drawing.Size(137, 20);
            this.tbUserid.TabIndex = 9;
            this.tbUserid.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Student ID number :";
            // 
            // International
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 375);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.tbUserid);
            this.Controls.Add(this.pbInternational);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.tbRank);
            this.Controls.Add(this.tbCompetition);
            this.Controls.Add(this.tbMonth);
            this.Name = "International";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International";
            this.Load += new System.EventHandler(this.International_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbInternational)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMonth;
        private System.Windows.Forms.TextBox tbCompetition;
        private System.Windows.Forms.TextBox tbRank;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pbInternational;
        private System.Windows.Forms.Label lbl_id;
        public System.Windows.Forms.TextBox tbUserid;
        private System.Windows.Forms.Label label4;
    }
}