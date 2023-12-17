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

        //loads data to grid view 
        private void AddSoftware_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2100902DataSet12.Software' table. You can move, or remove it, as needed.
            this.softwareTableAdapter2.Fill(this.mssql2100902DataSet12.Software);


        }

        //goes back to main form
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();

        }

        //adds software
        private void AddSoftwareBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int min = 0;
            int max = 9999;
            int newID = 0;

            try
            {
                //makes sure the text box has info enterd before continuing
                if (string.IsNullOrWhiteSpace(SoftwareNameBox.Text))
                {
                    MessageBox.Show("please make sure all data is enterd correcty and try again");
                    return;
                }
                bool checkidexists = true;
                do
                {
                    //makes new id and checks if it exists if keep doing until id that is new is made
                    newID = random.Next(min, max);
                    checkidexists = Software.CheckID(newID);
                }
                while (checkidexists == true);

                //cerates new software object with name from textbox and new id
                Software New = new Software();
                New.SoftwareName = SoftwareNameBox.Text;
                New.SoftwareID = newID;

                //adds new sotware asses
                Software.AddSoftware(New);

                //informs user and clears box
                MessageBox.Show("Software added");
                SoftwareNameBox.Clear();
            }
            catch 
            {
                //if no data was enterd an exeption will be thown
                MessageBox.Show("please make sure all data is enterd correcty and try again");
           
            }

        }
    }
}
