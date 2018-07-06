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
    public partial class National : Form
    {
        Image File;
        public National(string value)
        {
            InitializeComponent();
            lbl_id.Text = value;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string con = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\jazzybert26\Documents\Visual Studio 2013\Projects\Athletes Info\Athletes Info\ADB.mdf;Integrated Security=True");
            string Query = "Insert into International(idnum,Imonth,Icompetition,Irank,Iproof) values ('" + this.lbl_id.Text + "','" + this.tbMonth.Text + "', '" + this.tbCompetition.Text + "', '" + this.tbRank.Text + "', '" + this.pbNational.Image + "');";
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*.JPG)| *.jpg";

            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                pbNational.Image = File;
            }
        }
    }
}
