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
    public partial class Home : Form
    {
        public Home()
        {
            this.Refresh();
            InitializeComponent();
            this.ActiveControl = tbSearchBox;
            tbSearchBox.Focus();
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAthlete aa = new AddAthlete(this);
            aa.Show();
        }

        DataTable dbdataset;
        string constring = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\jazzybert26\Documents\Visual Studio 2013\Projects\Athletes Info\Athletes Info\ADB.mdf;Integrated Security=True");

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aDBDataSet1.Athlete' table. You can move, or remove it, as needed.
            this.athleteTableAdapter1.Fill(this.aDBDataSet1.Athlete);
            // TODO: This line of code loads data into the 'aDBDataSet.Athlete' table. You can move, or remove it, as needed.
          //  this.athleteTableAdapter.Fill(this.aDBDataSet.Athlete);

            //datagrid
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand("select * from Athlete ;", conDataBase);

            try
            {


                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();


                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //*datagrid
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Profile pp = new Profile();

            pp.lbl_profileid.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            pp.tbUid.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            pp.tbFname.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            pp.tbLname.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            pp.tbMi.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            pp.cbStatus.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();  
            pp.cbEvent.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();           
            pp.tbCourse.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            pp.cbDepartment.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            pp.tbContact.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            pp.tbAddress.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            pp.tbEmail.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            pp.tbPaddress.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            pp.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
            pp.tbBirth.Text = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
            pp.tbHeight.Text = this.dataGridView1.CurrentRow.Cells[15].Value.ToString();
            pp.tbWeight.Text = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();
            pp.tbYears.Text = this.dataGridView1.CurrentRow.Cells[17].Value.ToString();
            pp.tbClub.Text = this.dataGridView1.CurrentRow.Cells[18].Value.ToString();
            //pp.picturebox_profile.Image = this.dataGridView1.CurrentRow.Cells[19].Value as Image;
            byte[] bytes = (byte[]) this.dataGridView1.CurrentRow.Cells[19].Value;
            MemoryStream ms = new MemoryStream(bytes);
            pp.picturebox_profile.Image = Image.FromStream(ms);

            this.Close();
            pp.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Sports LIKE '%{0}%'", cbEventSearch.Text);
            dataGridView1.DataSource = DV;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Status LIKE '%{0}%'", cbStatus.Text);
            dataGridView1.DataSource = DV;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Lname LIKE '%{0}%'", tbSearchBox.Text);
            dataGridView1.DataSource = DV;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
