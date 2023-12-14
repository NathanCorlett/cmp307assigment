using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace cmp307
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private static string HashPass(string s)
        {
            var Pass = System.Text.ASCIIEncoding.ASCII.GetBytes(s);
            Pass = System.Security.Cryptography.MD5.Create().ComputeHash(Pass);
            return Convert.ToBase64String(Pass);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string password = PassBox.Text;
            string email = EmailBox.Text;

            password = HashPass(password);

            bool CorrectPass = false;
            bool CorrectEmail = false;

            CorrectPass = Employee.CheckPass(password);
            CorrectEmail = Employee.CheckEmail(email);

            if (CorrectPass == true && CorrectEmail == true)
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("incorrect Password or email please try again");
                PassBox.Clear();
            }

        }
    }
}
