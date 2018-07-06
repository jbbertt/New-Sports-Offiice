using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Athletes_Info
{
    public partial class AddAthlete : Form
    {
        string imgLoc = "";
        private readonly Home hh;

        public AddAthlete(Home aa)
        {
            InitializeComponent();

            hh = aa;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void AddAthlete_Load(object sender, EventArgs e)
        {
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void btn_add_image_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.Filter = "JPG(*.JPG)| *.jpg";

                if (f.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = f.FileName.ToString();
                    picturebox_profile.ImageLocation = imgLoc;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (picturebox_profile.Image == null)
            {
                MessageBox.Show("Please Upload Image!");
            }
            else
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                string con = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\jazzybert26\Documents\Visual Studio 2013\Projects\Athletes Info\Athletes Info\ADB.mdf;Integrated Security=True");
                string Query = "Insert into Athlete(Fname,Lname,Mname,Idnum,Course,College,Contact,Address,Email,Paddress,Bdate,Pbirth,Height,Weight,Sports,Played,Club,image) values ('" + this.tbFname.Text + "','" + this.tbLname.Text + "','" + this.tbMi.Text + "', '" + this.tbUid.Text + "','" + this.tbCourse.Text + "', '" + this.cmbox_department.Text + "', '" + this.tbContact.Text + "', '" + this.tbAddress.Text + "', '" + this.tbEmail.Text + "', '" + this.tbPaddress.Text + "', '" + this.dateTimePicker1.Value.Date + "', '" + this.tbBirth.Text + "', '" + this.tbHeight.Text + "', '" + this.tbWeight.Text + "', '" + this.cbEvent.Text + "', '" + this.tbYears.Text + "', '" + this.tbClub.Text + "', @img);";
                SqlConnection conDB = new SqlConnection(con);
                SqlCommand cmdDB = new SqlCommand(Query, conDB);
                SqlDataReader myReader;

                cmdDB.Parameters.Add(new SqlParameter("@img", img));

                try
                {
                    conDB.Open();
                    myReader = cmdDB.ExecuteReader();
                    MessageBox.Show("Saved!");

                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                hh.Refresh();
                this.Hide();
            }
        }

        private void cmbox_department_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbEvent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbYears_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbClub_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCourse_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbMi_TextChanged(object sender, EventArgs e)
        {

        }

        private void pcturebox_profile_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUsepID_Click(object sender, EventArgs e)
        {

        }

        private void lblFname_Click(object sender, EventArgs e)
        {

        }

        private void tbLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
