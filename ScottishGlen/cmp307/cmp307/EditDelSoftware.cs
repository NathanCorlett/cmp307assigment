using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static cmp307.mssql2100902DataSet3;

namespace cmp307
{
    public partial class EditDelSoftware : Form
    {
        public EditDelSoftware()
        {
            InitializeComponent();
        }

        private void EditDelSoftware_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2100902DataSet6.Software' table. You can move, or remove it, as needed.
            this.softwareTableAdapter.Fill(this.mssql2100902DataSet6.Software);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex != -1)
            {
                IDBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                NameBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Software software = new Software();
                software.SoftwareID = Convert.ToInt16(IDBox.Text);
                software.SoftwareName = NameBox.Text;
                Software.EditSoftware(software);
                MessageBox.Show("changes confirmed");
            }
            catch
            {
                MessageBox.Show("make sure all boxes have data enterd into them");
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt16(IDBox.Text);

                DialogResult dialogResults = MessageBox.Show("are you sure you want to delete the software asset " + ID, "Confirmation ", MessageBoxButtons.YesNo);

                if (dialogResults == DialogResult.Yes)
                {
                    Software.DelSoftware(ID);
                    MessageBox.Show("software asset deleted");


                }
                else if (dialogResults == DialogResult.Cancel)
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("please make sure to select an option");
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}
