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
    public partial class Profile : Form
    {
        Image File;

        public Profile()
        {
            InitializeComponent();

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home ss = new Home();
            this.Close();
            ss.Show();
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(picturebox_profile.Image == null)
            {
                MessageBox.Show("Please Upload Image!");
            }

            string con = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\jazzybert26\Documents\Visual Studio 2013\Projects\Athletes Info\Athletes Info\ADB.mdf;Integrated Security=True");
            string Query = "Update Athlete set Fname='" + this.tbFname.Text + "',Lname='" + this.tbLname.Text + "',Mname='" + this.tbMi.Text + "', Idnum='" + this.tbUid.Text + "',Course='" + this.tbCourse.Text + "', College='" + this.cbDepartment.Text + "', Contact='" + this.tbContact.Text + "', Address='" + this.tbAddress.Text + "', Email='" + this.tbEmail.Text + "', Paddress='" + this.tbPaddress.Text + "', Bdate='" + this.dateTimePicker1.Value.Date + "', Pbirth='" + this.tbBirth.Text + "', Height='" + this.tbHeight.Text + "', Weight='" + this.tbWeight.Text + "', Sports='" + this.cbEvent.Text + "', Played='" + this.tbYears.Text + "', Club='" + this.tbClub.Text + "',Status='" + this.cbStatus.Text + "', image='" + this.picturebox_profile.Image + "' where Id='" + this.lbl_profileid.Text + "'";
            
            SqlConnection conDB = new SqlConnection(con);
            SqlCommand cmdDB = new SqlCommand(Query, conDB);
            SqlDataReader myReader;


            try
            {
                conDB.Open();
                myReader = cmdDB.ExecuteReader();
                MessageBox.Show("Updated");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pbInternational_Click(object sender, EventArgs e)
        {
            if (tbUid.Text == "")
            {
                MessageBox.Show("please don't leave any textbox is empty");
            }
            else
            {
               International ii = new International(tbUid.Text);
                ii.ShowDialog();
            }
           
        }

        //end international

        private void pbNational_Click(object sender, EventArgs e)
        {
            if (tbUid.Text == "")
            {
                MessageBox.Show("please don't leave any textbox is empty");
            }
            else
            {
                National nn = new National(tbUid.Text);
                nn.ShowDialog();
            }
           
        }
        //end national

        private void pbLocal_Click(object sender, EventArgs e)
        {
            if (tbUid.Text == "")
            {
                MessageBox.Show("please don't leave any textbox is empty");
            }
            else
            {
                Local ll = new Local(tbUid.Text);
                ll.ShowDialog();
            }     
        }
        //end local

        private void pbRegional_Click(object sender, EventArgs e)
        {
            if (tbUid.Text == "")
            {
                MessageBox.Show("please don't leave any textbox is empty");
            }
            else
            {
                Regional rr = new Regional(tbUid.Text);
                rr.ShowDialog();
            }
        }
        //end regional
        
        private void Profile_Load(object sender, EventArgs e)
        {

        }

        //add image
        private void btn_add_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)| *.jpg";

            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
               // pbInternational.Image = File;
                picturebox_profile.Image = File;
            }
        }
    }
}
