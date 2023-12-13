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
    public partial class AddDelUpdateEmployee : Form
    {
        public AddDelUpdateEmployee()
        {
            InitializeComponent();
        }

        private void AddDelUpdateEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2100902DataSet4.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.mssql2100902DataSet4.Employee);
            // TODO: This line of code loads data into the 'mssql2100902DataSet3.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.mssql2100902DataSet3.Department);

        }
    }
}
