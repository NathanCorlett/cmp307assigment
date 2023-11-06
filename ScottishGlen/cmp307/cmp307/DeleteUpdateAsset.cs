﻿using System;
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
    public partial class DeleteUpdateAsset : Form
    {
        public DeleteUpdateAsset()
        {
            InitializeComponent();
        }

        private void DeleteAsset_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2100902DataSet2.assets' table. You can move, or remove it, as needed.
            this.assetsTableAdapter1.Fill(this.mssql2100902DataSet2.assets);
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
                ModelBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                ManufacturerBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                TypeBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                IPTextBox.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                DateBox.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                systemnamebox.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            }
            
           
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                long ID = Convert.ToInt64(txtSelectedAsset.Text);
                DialogResult dialogResults = MessageBox.Show("are you sure you want to delete the asset " + ID, "Confirmation ", MessageBoxButtons.YesNo);
 

                if (dialogResults == DialogResult.Yes)
                {
                    asset.DeleteAsset(ID);
                    MessageBox.Show("asset deleted");
                   

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
            txtSelectedAsset.Clear();
            EmployeeTextBox.Clear();
            AssetNameTextBox.Clear();
            CommentTextBox.Clear();
            ModelBox.Clear();
            ManufacturerBox.Clear();
            TypeBox.Clear();
            IPTextBox.Clear();
            DateBox.Clear();
            systemnamebox.Clear();
            this.assetsTableAdapter1.Fill(this.mssql2100902DataSet2.assets);
            dataGridView1.Update();
            dataGridView1.Refresh();
            this.Update();
            this.Refresh();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                asset ToUpdate = new asset();
                ToUpdate.HardwareID = (int)(long)Convert.ToDouble(txtSelectedAsset.Text);
                ToUpdate.AssetName = AssetNameTextBox.Text;
                ToUpdate.EmployeeResponsible = Convert.ToInt32(EmployeeTextBox.Text);
                ToUpdate.model = ModelBox.Text;
                ToUpdate.type = TypeBox.Text;
                ToUpdate.IPadress = IPTextBox.Text;
                ToUpdate.DatePurchesed = DateTime.Parse(DateBox.Text);
                ToUpdate.SystemName = systemnamebox.Text;
                ToUpdate.comment = CommentTextBox.Text;
                ToUpdate.manufacturer = ManufacturerBox.Text;

                if (Employee.CheckIfExists(ToUpdate.EmployeeResponsible) == false)
                {
                    MessageBox.Show("this employee does not exist please try again");
                    return;
                }

                asset.UpdateAsset(ToUpdate);

                MessageBox.Show("asset updated");

            }
            catch
            {
                MessageBox.Show("make sure all data is enterd correctly, Employee ID can not have letters");
            }

            txtSelectedAsset.Clear();
            EmployeeTextBox.Clear();
            AssetNameTextBox.Clear();
            CommentTextBox.Clear();
            ModelBox.Clear();
            ManufacturerBox.Clear();
            TypeBox.Clear();
            IPTextBox.Clear();
            DateBox.Clear();
            systemnamebox.Clear();
            this.assetsTableAdapter1.Fill(this.mssql2100902DataSet2.assets);
            dataGridView1.Update();
            dataGridView1.Refresh();
            this.Update();
            this.Refresh();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex != -1)
            {
                txtSelectedAsset.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                EmployeeTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                AssetNameTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                CommentTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                ModelBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                ManufacturerBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                TypeBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                IPTextBox.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                DateBox.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                systemnamebox.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            }
        }
    }
}
