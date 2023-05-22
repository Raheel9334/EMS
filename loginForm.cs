using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class loginForm : System.Windows.Forms.Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String username, password;
            username = textUser.Text;
            password = textPass.Text;
            if( username=="Admin"&& password == "1234")
            {
                HomeForm f1 = new HomeForm();
                f1.ShowDialog();
            }
            else
            {
                MessageBox.Show("invalid");
            }

        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
