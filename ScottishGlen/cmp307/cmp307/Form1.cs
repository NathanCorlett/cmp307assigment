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
            DeleteAsset deleteAsset = new DeleteAsset();
            this.Hide();
            deleteAsset.ShowDialog(); 
            this.Close();
        }
    }
}
