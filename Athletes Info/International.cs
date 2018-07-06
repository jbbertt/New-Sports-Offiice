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

namespace Athletes_Info
{
    public partial class International : Form
    {
        
        
        Image File;

        public International(string value)
        {
            InitializeComponent();
          // tbUserid.Text = value;
            lbl_id.Text = value; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)| *.jpg";

            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                pbInternational.Image = File;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string con = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\jazzybert26\Documents\Visual Studio 2013\Projects\Athletes Info\Athletes Info\ADB.mdf;Integrated Security=True");
            string Query = "Insert into International(idnum,Imonth,Icompetition,Irank,Iproof) values ('" + this.lbl_id.Text + "','" + this.tbMonth.Text + "', '" + this.tbCompetition.Text + "', '" + this.tbRank.Text + "', '" + this.pbInternational.Image + "');";
            SqlConnection conDB = new SqlConnection(con);
            SqlCommand cmdDB = new SqlCommand(Query, conDB);
            SqlDataReader myReader;


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
            this.Hide();

        }

        private void International_Load(object sender, EventArgs e)
        {

        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }
    }
}
