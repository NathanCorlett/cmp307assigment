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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex != -1)
            {
                EmployeeIDBox.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                FNameBox.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                SNameBox.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                EmailBox.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                DepartmentBox.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex != -1)
            {
                DepartmentBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int min = 1000;
            int max = 9999;
            int NewID = 0;

            try
            {
                bool EmployeeIDCheck = true;

                do
                {
                    NewID = random.Next(min, max);
                    EmployeeIDCheck = Employee.CheckIfExists(NewID);
                }
                while (EmployeeIDCheck == true);

                Employee employee = new Employee();
                employee.EmployeeID = NewID;
                employee.FName = FNameBox.Text;
                employee.SName = SNameBox.Text;
                employee.Email = EmailBox.Text;
                employee.DepartmentID = Convert.ToInt16(DepartmentBox.Text);

                Employee.AddEmployee(employee);
                MessageBox.Show("employee added");
                FNameBox.Clear();
                SNameBox.Clear();
                EmailBox.Clear();
                DepartmentBox.Clear();
                EmployeeIDBox.Clear();
            }
            catch
            {
                MessageBox.Show("please make sure all data is enterd correctly (i.e nothing is blank)");
            }


        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                Employee ToUpdate = new Employee();
                ToUpdate.EmployeeID = Convert.ToInt16(EmployeeIDBox.Text);
                ToUpdate.FName = FNameBox.Text;
                ToUpdate.SName = SNameBox.Text;
                ToUpdate.Email = EmailBox.Text;
                ToUpdate.DepartmentID = Convert.ToInt16(DepartmentBox.Text);

                if (Employee.CheckIfExists(Convert.ToInt16(EmployeeIDBox.Text)) == false)
                {
                    MessageBox.Show("this employee does not exist please try again");
                    return;
                }

                Employee.UpdateEmployee(ToUpdate);

                MessageBox.Show("Employee updated");
            }
            catch
            {
                MessageBox.Show("please make sure all data is enterd correctly (i.e nothing is blank");
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt16(EmployeeIDBox.Text);
                DialogResult dialogResults = MessageBox.Show("are you sure you want to delete the employee: " + ID, "Confirmation ", MessageBoxButtons.YesNo);


                if (dialogResults == DialogResult.Yes)
                {
                    Employee.DelEmployee(ID);
                    MessageBox.Show("employee deleted");


                }
                else if (dialogResults == DialogResult.Cancel)
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("please make sure an employee is selected");
            }
        }
    }
}
