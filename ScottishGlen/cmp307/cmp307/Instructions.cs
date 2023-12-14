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

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();   
            form1.ShowDialog();
            this.Close();
        }

        private void Instructions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2100902DataSet10.Software' table. You can move, or remove it, as needed.
            this.softwareTableAdapter.Fill(this.mssql2100902DataSet10.Software);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex != -1)
            {
                SoftwareIDBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            }
        }
    }
}
