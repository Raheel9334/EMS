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
    public partial class HomeForm : System.Windows.Forms.Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PayrollForm f1 = new PayrollForm();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListOfEmployeesForm f1 = new ListOfEmployeesForm();
            f1.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          /*  Data.employees.Add(new Employee { Name = "cpt Umair", ID =1, Contact = "123", Email = "umair@gmail.com",Rank="Captain",Date_of_enrolment=DateTime.Parse("12-24-2004"),Age=23,DateOfBirth= DateTime.Parse("12-30-1998"),Hobbies="Acting",Salary=150000});
            Data.employees.Add(new Employee { Name = "LT Saleem", ID = 2, Contact = "123", Email = "saleem@gmail.com", Rank = "LT.", Date_of_enrolment = DateTime.Parse("8-24-2023"), Age = 23, DateOfBirth = DateTime.Parse("12-5-1997"), Hobbies = "Reading", Salary = 70000 });
            Data.employees.Add(new Employee { Name = "LT Wahab", ID = 3, Contact = "123", Email = "wahab@gmail.com", Rank = "LT.", Date_of_enrolment = DateTime.Parse("8-24-2023"), Age = 23, DateOfBirth = DateTime.Parse("12-5-1997"), Hobbies = "Reading", Salary = 70000 });
            Data.employees.Add(new Employee { Name = "Cdr. Moiz", ID = 4, Contact = "123", Email = "moiz@gmail.com", Rank = "CDR", Date_of_enrolment = DateTime.Parse("8-24-2023"), Age = 23, DateOfBirth = DateTime.Parse("12-5-1997"), Hobbies = "Reading", Salary = 70000 });
            Data.employees.Add(new Employee { Name = "M. Hammad", ID = 5, Contact = "123", Email = "hammadkhan@gmail.com", Rank = "JCO", Date_of_enrolment = DateTime.Parse("8-24-2023"), Age = 23, DateOfBirth = DateTime.Parse("12-5-1997"), Hobbies = "Reading", Salary = 70000 });
            //'''''''''''''''''''''''''payroll'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            PayrolData.payrolls.Add(new Payroll { Name = "LT Umair", ID = 0, Vacations = "123", Salary =50000});*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
