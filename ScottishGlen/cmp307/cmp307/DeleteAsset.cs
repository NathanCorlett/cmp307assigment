using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cmp307
{
    public partial class DeleteAsset : Form
    {
        public DeleteAsset()
        {
            InitializeComponent();
        }

        private void DeleteAsset_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2100902DataSet.assets' table. You can move, or remove it, as needed.
            this.assetsTableAdapter.Fill(this.mssql2100902DataSet.assets);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex != -1)
            {
                txtSelectedAsset.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                EmployeeTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                AssetNameTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                CommentTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            
           
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                long ID = Convert.ToInt64(txtSelectedAsset.Text);
                DialogResult dialogResult = MessageBox.Show("are you sure you want to delete the asset" + ID, "Confirmation ", MessageBoxButtons.YesNo);


                if (dialogResult == DialogResult.OK)
                {
                    asset.DeleteAsset(ID);
                    MessageBox.Show("asset deleted");
                   

                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("please make sure to select an option");
            }

            txtSelectedAsset.Clear();
            EmployeeTextBox.Clear();
            AssetNameTextBox.Clear();
            CommentTextBox.Clear();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }
}
