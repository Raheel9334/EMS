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
    public partial class addForm : System.Windows.Forms.Form
    {
        public addForm()
        {
            InitializeComponent();
        }

        private void add_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.ID = Convert.ToInt32(txtID.Text);
            emp.Name = txtName.Text;
            emp.Email = txtEmail.Text;
            emp.Contact = txtContact.Text;
            emp.Rank = textRank.Text;
            emp.Date_of_enrolment = DateTime.Parse( textDOE.Text);
            emp.Age = Convert.ToInt32( textAge.Text);
            emp.DateOfBirth = DateTime.Parse( textDOB.Text);
            emp.Hobbies = textHobbies.Text;
            emp.Salary = Convert.ToInt32(textSalary.Text);

            if (txtID.Text != "" && txtName.Text != "" && txtEmail.Text != "" && txtContact.Text != "" && textRank.Text != "" && textDOE.Text != ""
                && textAge.Text != "" && textDOB.Text != "" && textHobbies.Text != "" && textSalary.Text != "")
            {            

                    Data.employees.Add(emp);
                    MessageBox.Show("Employee Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.ID = Convert.ToInt32(txtID.Text);
                emp.Name = txtName.Text;
                emp.Email = txtEmail.Text;
                emp.Contact = txtContact.Text;
                emp.Rank = textRank.Text;
                emp.Date_of_enrolment = DateTime.Parse(textDOE.Text);
                emp.Age = int.Parse(textAge.Text);
                emp.DateOfBirth = DateTime.Parse(textDOB.Text);
                emp.Hobbies = textHobbies.Text;
                emp.Salary = int.Parse(textSalary.Text);

                if (txtID.Text != "" && txtName.Text != "" && txtEmail.Text != "" && txtContact.Text != "")
                {
                    Data.employees.Add(emp);
                    MessageBox.Show("Employee Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            }
          


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
