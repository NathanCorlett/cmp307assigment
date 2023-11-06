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

namespace cmp307
{
    public partial class AddAsset : Form
    {
        Random random = new Random();
        public AddAsset()
        {
            InitializeComponent();
        }

        private void AddAssetButton_Click(object sender, EventArgs e)
        {
            bool HWIDCHECK = false;
            int ID = 0;
            asset NewAsset = new asset();

            do
            {
                ID = random.Next();
                HWIDCHECK = asset.CheckIDNum(ID);
            }
            while (HWIDCHECK == false);
            
            NewAsset.HardwareID = ID;
            NewAsset.AssetName = AddAssetTextBox.Text;
            NewAsset.EmployeeResponsible = Convert.ToInt32(AddAssetEmployeeIDTextBox.Text);
            NewAsset.comment = AddAssetCommentTextBox.Text;
            if (Employee.CheckIfExists(NewAsset.EmployeeResponsible) == false)
            {
                MessageBox.Show("this employee does not exist please try again");
                return;
            }
            asset.AddAsset(NewAsset);
            MessageBox.Show("asset added");
            AddAssetTextBox.Clear();
            AddAssetEmployeeIDTextBox.Clear();
            AddAssetCommentTextBox.Clear();
        }

        private void AddAssetBackButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();


        }
    }
}
