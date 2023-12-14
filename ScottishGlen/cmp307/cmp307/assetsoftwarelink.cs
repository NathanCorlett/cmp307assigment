using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cmp307
{
    public partial class assetsoftwarelink : Form
    {
        public assetsoftwarelink()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void assetsoftwarelink_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2100902DataSet9.SoftwareLink' table. You can move, or remove it, as needed.
            this.softwareLinkTableAdapter.Fill(this.mssql2100902DataSet9.SoftwareLink);
            // TODO: This line of code loads data into the 'mssql2100902DataSet8.Software' table. You can move, or remove it, as needed.
            this.softwareTableAdapter.Fill(this.mssql2100902DataSet8.Software);
            // TODO: This line of code loads data into the 'mssql2100902DataSet7.assets' table. You can move, or remove it, as needed.
            this.assetsTableAdapter.Fill(this.mssql2100902DataSet7.assets);

           

        }

        private void linkBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int ID = 0;
            bool IDCheck = false;
            int min = 0;
            int max = 9999;
            
            try
            {
                string Date = "";
                Date = DateTime.Now.ToString("dd/MM/yyyy");

                do
                {
                    ID = random.Next(min, max);
                    IDCheck = SoftwareLink.CheckIDNum(ID);
                }
                while (IDCheck == false);

                SoftwareLink softwareLink = new SoftwareLink();
                softwareLink.LinkID = ID;
                softwareLink.SoftwareID = Convert.ToInt32(SoftwareIDBox.Text);
                softwareLink.HardwareID = Convert.ToInt32(HardWareIDBox.Text);
                softwareLink.DateOfLink = DateTime.Parse(Date);
                SoftwareLink.AddLink(softwareLink);
                
            }
            catch
            {
                MessageBox.Show("please make sure data is enterd in both boxes");
            }
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView2.Update();
            dataGridView2.Refresh();
            dataGridView3.Update();
            dataGridView3.Refresh();
            this.Update();
            this.Refresh();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex != -1)
            {
                HardWareIDBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentCell.RowIndex != -1)
            {
                SoftwareIDBox.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentCell.RowIndex != -1)
            {
                LinkIDBox.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();

            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(LinkIDBox.Text);
                DialogResult dialogResults = MessageBox.Show("are you sure you want to delete the asset/software link " + id, "Confirmation ", MessageBoxButtons.YesNo);


                if (dialogResults == DialogResult.Yes)
                {
                    SoftwareLink.DelLink(id);
                    MessageBox.Show("asset link deleted");


                }
                else if (dialogResults == DialogResult.Cancel)
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("make sure there is data enterd in the box");
            }
            LinkIDBox.Clear();
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView2.Update();
            dataGridView2.Refresh();
            dataGridView3.Update();
            dataGridView3.Refresh();
            this.Update();
            this.Refresh();
        }
    }
}
