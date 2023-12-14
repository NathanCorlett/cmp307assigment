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
    public partial class AddSoftware : Form
    {
        public AddSoftware()
        {
            InitializeComponent();
        }

        private void AddSoftware_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2100902DataSet5.Software' table. You can move, or remove it, as needed.
            this.softwareTableAdapter.Fill(this.mssql2100902DataSet5.Software);

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();

        }

        private void AddSoftwareBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int min = 0;
            int max = 9999;
            int newID = 0;

            try
            {
                bool checkidexists = true;
                do
                {
                    newID = random.Next(min, max);
                    checkidexists = Software.CheckID(newID);
                }
                while (checkidexists == true);

                Software New = new Software();
                New.SoftwareName = SoftwareNameBox.Text;
                New.SoftwareID = newID;

                Software.AddSoftware(New);

                MessageBox.Show("Software added");
                SoftwareNameBox.Clear();
            }
            catch 
            {
                MessageBox.Show("please make sure all data is enterd correcty and try again");
           
            }
        }
    }
}
