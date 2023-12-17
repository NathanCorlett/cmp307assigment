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
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e) //cerates new menu fourm and closes this one
        {
            Form1 form1 = new Form1();
            this.Hide();   
            form1.ShowDialog();
            this.Close();
        }

        private void Instructions_Load(object sender, EventArgs e) //loads needed data into gridview when page loaded
        {
            // TODO: This line of code loads data into the 'mssql2100902DataSet10.Software' table. You can move, or remove it, as needed.
            this.softwareTableAdapter.Fill(this.mssql2100902DataSet10.Software);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) //when cell anywhere in the row is clicked on data from cell 0 added to textbox
        {
            if (dataGridView1.CurrentCell.RowIndex != -1)
            {
                SoftwareIDBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            }
        }

        private void ClearBtn_Click(object sender, EventArgs e) //when button is pressed clears all textboxes
        {
            SoftwareIDBox.Clear();
            textBox1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
