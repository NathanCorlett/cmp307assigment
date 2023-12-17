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

        private void BackBtn_Click(object sender, EventArgs e) //go back to main form when button clicked
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

    //cerate new link
        private void linkBtn_Click(object sender, EventArgs e) 
        {
            
            Random random = new Random();
            int ID = 0;
            bool IDCheck = false;
            int min = 0;
            int max = 9999;
            
            try
            {
                //gets date automatically for link
                string Date = "";
                Date = DateTime.Now.ToString("dd/MM/yyyy");
                if (string.IsNullOrWhiteSpace(SoftwareIDBox.Text) || string.IsNullOrWhiteSpace(HardWareIDBox.Text))
                {
                    MessageBox.Show("please make sure data is enterd in both boxes");
                    return;
                }
                do
                {
                    //make random id and check if it exists, if id does not exist program continuies if not makes new id
                    ID = random.Next(min, max);
                    IDCheck = SoftwareLink.CheckIDNum(ID);
                }
                while (IDCheck == false);

                //cerate new software link object with data from textboxes and id and date
                SoftwareLink softwareLink = new SoftwareLink();
                softwareLink.LinkID = ID;
                softwareLink.SoftwareID = Convert.ToInt32(SoftwareIDBox.Text);
                softwareLink.HardwareID = Convert.ToInt32(HardWareIDBox.Text);
                softwareLink.DateOfLink = DateTime.Parse(Date);

                //update database to show link
                SoftwareLink.AddLink(softwareLink); 
                
            }
            //if exeption is thrown it means not all data is enterd properly informs the user of this
            catch
            {
                MessageBox.Show("please make sure data is enterd in both boxes");
            }

            //updates datagrid views and refreshes page
            this.softwareLinkTableAdapter.Fill(this.mssql2100902DataSet9.SoftwareLink);
            this.softwareTableAdapter.Fill(this.mssql2100902DataSet8.Software);
            this.assetsTableAdapter.Fill(this.mssql2100902DataSet7.assets);
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView2.Update();
            dataGridView2.Refresh();
            dataGridView3.Update();
            dataGridView3.Refresh();
            this.Update();
            this.Refresh();


        }

        //next 3 functoions do the same thing for there respective datagridview
        //when text in grid is clicked all respecteve information is placed in the correct textboxes 
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

        //deleted link
        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //checks if user would like to continiue
                int id = Convert.ToInt32(LinkIDBox.Text);
                DialogResult dialogResults = MessageBox.Show("are you sure you want to delete the asset/software link " + id, "Confirmation ", MessageBoxButtons.YesNo);


                if (dialogResults == DialogResult.Yes)
                {
                    //if yes delete link using link id
                    SoftwareLink.DelLink(id);
                    MessageBox.Show("asset link deleted");


                }
                else if (dialogResults == DialogResult.Cancel)
                {
                    //if no do nothing and return
                    return;
                }
            }
            //if exeption is thrown it means not all data is enterd properly informs the user of this
            catch
            {
                MessageBox.Show("make sure there is data enterd in the box");
            }

            //updates datagrid views and refreshes page
            this.softwareLinkTableAdapter.Fill(this.mssql2100902DataSet9.SoftwareLink);
            this.softwareTableAdapter.Fill(this.mssql2100902DataSet8.Software);
            this.assetsTableAdapter.Fill(this.mssql2100902DataSet7.assets);
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
