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

        //hash and salt password so it is securly saved
        private static string HashPassword(string password)
        {
            var NewPass = System.Text.ASCIIEncoding.ASCII.GetBytes(password);
            NewPass = System.Security.Cryptography.MD5.Create().ComputeHash(NewPass);
            return Convert.ToBase64String(NewPass);
        }
        private void AddDelUpdateEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2100902DataSet4.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.mssql2100902DataSet4.Employee);
            // TODO: This line of code loads data into the 'mssql2100902DataSet3.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.mssql2100902DataSet3.Department);

        }

        //if data in grid selected add info to text boxes
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

        //
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex != -1)
            {
                DepartmentBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
        }

        //addes new uses to database
        private void AddButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int min = 1000;
            int max = 9999;
            int NewID = 0;

            //hashes and salts password
            string NewPass = HashPassword(PsswordBox.Text);

            if (string.IsNullOrWhiteSpace(FNameBox.Text) || string.IsNullOrWhiteSpace(SNameBox.Text) || string.IsNullOrWhiteSpace(EmailBox.Text) || string.IsNullOrWhiteSpace(PsswordBox.Text))
            {
                MessageBox.Show("please make sure all data is enterd correctly (i.e nothing is blank)");
                return;
            }

            try
            {
                bool EmployeeIDCheck = true;

                do
                {
                    //makes and checks id can be used if not try again
                    NewID = random.Next(min, max);
                    EmployeeIDCheck = Employee.CheckIfExists(NewID);
                }
                while (EmployeeIDCheck == true);

                //cerates new object for employee and adds data
                Employee employee = new Employee();
                employee.EmployeeID = NewID;
                employee.FName = FNameBox.Text;
                employee.SName = SNameBox.Text;
                employee.Email = EmailBox.Text;
                employee.DepartmentID = Convert.ToInt16(DepartmentBox.Text);
                employee.passowrd = NewPass;

                //adds employe to database and clears text boxes
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

            //update page with correct info
            this.employeeTableAdapter.Fill(this.mssql2100902DataSet4.Employee);
            this.departmentTableAdapter.Fill(this.mssql2100902DataSet3.Department);
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView2.Update();
            dataGridView2.Refresh();
            this.Update();
            this.Refresh();


        }


        //edits emplotyee details
        private void EditButton_Click(object sender, EventArgs e)
        {
            //string NewPass = HashPassword(PsswordBox.Text);
            try
            {
                
                if (string.IsNullOrWhiteSpace(PsswordBox.Text))
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
                }
                else
                {
                    string NewPass = HashPassword(PsswordBox.Text);
                    Employee ToUpdate = new Employee();
                    ToUpdate.EmployeeID = Convert.ToInt16(EmployeeIDBox.Text);
                    ToUpdate.FName = FNameBox.Text;
                    ToUpdate.SName = SNameBox.Text;
                    ToUpdate.Email = EmailBox.Text;
                    ToUpdate.passowrd = NewPass;
                    ToUpdate.DepartmentID = Convert.ToInt16(DepartmentBox.Text);

                    if (Employee.CheckIfExists(Convert.ToInt16(EmployeeIDBox.Text)) == false)
                    {
                        MessageBox.Show("this employee does not exist please try again");
                        return;
                    }
                    Employee.UpdateEmployeeWithPass(ToUpdate);
                }
                //cerates new object for employee and adds data
                
                

                //checks if employee exists
                
                
                MessageBox.Show("Employee updated");
            }
            catch
            {
                MessageBox.Show("please make sure all data is enterd correctly (i.e nothing is blank");
            }

            //update page with correct info
            this.employeeTableAdapter.Fill(this.mssql2100902DataSet4.Employee);
            this.departmentTableAdapter.Fill(this.mssql2100902DataSet3.Department);
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView2.Update();
            dataGridView2.Refresh();
            this.Update();
            this.Refresh();
        }

        //deletes user
        private void DelButton_Click(object sender, EventArgs e)
        {
            try
            {

                int ID = Convert.ToInt16(EmployeeIDBox.Text);

                //checks if user wants to do this
                DialogResult dialogResults = MessageBox.Show("are you sure you want to delete the employee: " + ID, "Confirmation ", MessageBoxButtons.YesNo);


                if (dialogResults == DialogResult.Yes)
                {
                    //if yes delete user
                    Employee.DelEmployee(ID);
                    MessageBox.Show("employee deleted");


                }
                else if (dialogResults == DialogResult.Cancel)
                {
                    //if no do nothing
                    return;
                }
            }
            catch
            {
                MessageBox.Show("please make sure an employee is selected");
            }

            //refresh page with correct info
            this.employeeTableAdapter.Fill(this.mssql2100902DataSet4.Employee);
            this.departmentTableAdapter.Fill(this.mssql2100902DataSet3.Department);
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView2.Update();
            dataGridView2.Refresh();
            this.Update();
            this.Refresh();
        }

        //go back to main pag
        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}
