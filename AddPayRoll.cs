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
    public partial class AddPayRoll : Form
    {
        public AddPayRoll()
        {
            InitializeComponent();
        }

        private void AddPayRoll_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Payroll emp = new Payroll();
            emp.ID = Convert.ToInt32(txtID.Text);
            emp.Name = txtName.Text;
            emp.Vacations = txtVacations.Text;
            emp.Salary = Convert.ToInt32(txtSalary.Text);

            if (txtID.Text != "" && txtName.Text != "" && txtVacations.Text != "" && txtSalary.Text != "")
            {




                PayrolData.payrolls.Add(emp);
                MessageBox.Show("Employee Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);




            }
            else
            {
                MessageBox.Show("Invalid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
