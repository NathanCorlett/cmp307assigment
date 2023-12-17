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
using System.Net;
using System.CodeDom;
using System.Management.Instrumentation;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Management;


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
            if (string.IsNullOrWhiteSpace(AddAssetTextBox.Text) || string.IsNullOrWhiteSpace(AddAssetEmployeeIDTextBox.Text))
            {
                MessageBox.Show("please make sure all data is enterd correctly (asset name and employee MUST be filled in and date must be enterd correctly");
                return;
            }
            try
            {
                bool HWIDCHECK = false;
                int ID = 0;
                asset NewAsset = new asset();

                if (AddAssetTextBox == null)
                {
                    MessageBox.Show("please enter a name for the asset");
                    return;
                }

                do
                {
                    ID = random.Next();
                    HWIDCHECK = asset.CheckIDNum(ID);
                }
                while (HWIDCHECK == false);

                NewAsset.HardwareID = ID;
                NewAsset.AssetName = AddAssetTextBox.Text;
                NewAsset.EmployeeResponsible = Convert.ToInt32(AddAssetEmployeeIDTextBox.Text);
                NewAsset.model = ModelBox.Text;
                NewAsset.manufacturer = ManufacturerBox.Text;
                NewAsset.type = TypeBox.Text;
                NewAsset.IPadress = IPTextBox.Text;
                NewAsset.DatePurchesed = DateTime.Parse(DateBox.Text);
                NewAsset.SystemName = systemnamebox.Text;
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
            catch
            {
                MessageBox.Show("please make sure all data is enterd correctly (i.e date must be enterd correctly");
            }
        }

        private void AddAssetBackButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();


        }

        private void AddAsset_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2100902DataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.mssql2100902DataSet1.Employee);
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    string IPadress = ip.ToString();
                    IPTextBox.Text = IPadress;
                }
            }

            string mechinename = Environment.MachineName;
            systemnamebox.Text = mechinename;

            System.OperatingSystem OStype = System.Environment.OSVersion;
            TypeBox.Text = OStype.ToString();

            ManagementClass mc = new ManagementClass("Win32_computerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            if (moc.Count != 0)
            {
                foreach (ManagementObject mo in mc.GetInstances())
                {
                    ManufacturerBox.Text = mo["Manufacturer"].ToString();
                    ModelBox.Text = mo["model"].ToString();


                }
            }

            this.employeeTableAdapter.Fill(this.mssql2100902DataSet1.Employee);
            dataGridView1.Update();
            dataGridView1.Refresh();
            this.Update();
            this.Refresh();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex != -1)
            {
                AddAssetEmployeeIDTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void AddAssetTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
