using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ManagementSystem
{
    public partial class UpdateForm : System.Windows.Forms.Form
    {
        string Eid = "";

        public UpdateForm(string id)
        {
            InitializeComponent();
            Eid = id;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.ID =  Convert.ToInt32(txtID.Text);
            emp.Name = txtName.Text;
            emp.Email = txtEmail.Text;
            emp.Contact = txtContact.Text;
            emp.Rank = textRank.Text;
            emp.Date_of_enrolment = DateTime.Parse(textDOE.Text);
            emp.Age = int.Parse(textAge.Text);
            emp.DateOfBirth = DateTime.Parse(textDOB.Text);
            emp.Hobbies = textHobbies.Text;
            emp.Salary = int.Parse(textSalary.Text);
            if (txtID.Text != "" )
            {

                    var einfo = Data.employees.Where(em => em.ID ==  Convert.ToInt64(txtID.Text)).FirstOrDefault();
                    if (einfo!=null)
                    {
                        Data.employees.Where(em => em.ID == Convert.ToInt64(txtID.Text)).FirstOrDefault().Name = txtName.Text;
                        Data.employees.Where(em => em.ID == Convert.ToInt64(txtID.Text)).FirstOrDefault().Email = txtEmail.Text;
                        Data.employees.Where(em => em.ID == Convert.ToInt64(txtID.Text)).FirstOrDefault().Contact = txtContact.Text;
                        Data.employees.Where(em => em.ID == Convert.ToInt64(txtID.Text)).FirstOrDefault().Rank = textRank.Text;
                        Data.employees.Where(em => em.ID == Convert.ToInt64(txtID.Text)).FirstOrDefault().Date_of_enrolment = DateTime.Parse(textDOE.Text);
                        Data.employees.Where(em => em.ID == Convert.ToInt64(txtID.Text)).FirstOrDefault().Age = int.Parse(textAge.Text);
                        Data.employees.Where(em => em.ID == Convert.ToInt64(txtID.Text)).FirstOrDefault().DateOfBirth = DateTime.Parse(textDOB.Text);
                        Data.employees.Where(em => em.ID == Convert.ToInt64(txtID.Text)).FirstOrDefault().Hobbies = textHobbies.Text;
                        Data.employees.Where(em => em.ID == Convert.ToInt64(txtID.Text)).FirstOrDefault().Salary = int.Parse(textSalary.Text);

                    MessageBox.Show("Employee Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Employee Not Found");
                    }
                


                
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void textHobbies_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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

        private void textDOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textDOE_TextChanged(object sender, EventArgs e)
        {

        }

        private void textRank_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            txtID.Text = Eid.ToString();


            var einfo = Data.employees.Where(em => em.ID == Convert.ToInt64(txtID.Text)).FirstOrDefault();
            if (einfo != null)
            {
              txtName.Text =   Data.employees.Where(em => em.ID == Convert.ToInt64(txtID.Text)).FirstOrDefault().Name;
                txtEmail.Text = Data.employees.Where(em => em.ID == Convert.ToInt64(txtID.Text)).FirstOrDefault().Email;
                txtContact.Text = Data.employees.Where(em => em.ID == Convert.ToInt64(txtID.Text)).FirstOrDefault().Contact ;
                textRank.Text = Data.employees.Where(em => em.ID == Convert.ToInt64(txtID.Text)).FirstOrDefault().Rank ;
              textDOE.Text = Data.employees.Where(em => em.ID == Convert.ToInt64(txtID.Text)).FirstOrDefault().Date_of_enrolment.ToString();
              textAge.Text = Data.employees.Where(em => em.ID == Convert.ToInt64(txtID.Text)).FirstOrDefault().Age.ToString() ;
              textDOB.Text = Data.employees.Where(em => em.ID == Convert.ToInt64(txtID.Text)).FirstOrDefault().DateOfBirth.ToString();
              textHobbies.Text = Data.employees.Where(em => em.ID == Convert.ToInt64(txtID.Text)).FirstOrDefault().Hobbies;
                textSalary.Text= Data.employees.Where(em => em.ID == Convert.ToInt64(txtID.Text)).FirstOrDefault().Salary.ToString();

            }
            else
            {
                MessageBox.Show("Employee Not Found");
                this.Close();
            } 


        }
    }
}
