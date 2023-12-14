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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddAsset_Click(object sender, EventArgs e)
        {
           AddAsset addAsset = new AddAsset();
           this.Hide();
           addAsset.ShowDialog();
           this.Close();
           


        }

        private void DeleteAsset_Click(object sender, EventArgs e)
        {
            DeleteUpdateAsset deleteAsset = new DeleteUpdateAsset();
            this.Hide();
            deleteAsset.ShowDialog(); 
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDelUpdateEmployee addDelUpdateEmployee = new AddDelUpdateEmployee();
            this.Hide();
            addDelUpdateEmployee.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddSoftware addSoftware = new AddSoftware();
            this.Hide();
            addSoftware.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditDelSoftware editSoftware = new EditDelSoftware();
            this.Hide();
            editSoftware.ShowDialog();
            this.Close();
        }

        private void LinkBtn_Click(object sender, EventArgs e)
        {
            assetsoftwarelink assetsoftwarelink = new assetsoftwarelink();
            this.Hide();
            assetsoftwarelink.ShowDialog();
            this.Close();
        }

        private void instructionBtn_Click(object sender, EventArgs e)
        {
            Instructions instructions = new Instructions();
            this.Hide();
            instructions.ShowDialog();
            this.Close();
        }
    }
}
