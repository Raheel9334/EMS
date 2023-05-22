using System;
using System.Collections;
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
    public partial class ListOfEmployeesForm : System.Windows.Forms.Form
    {
        public ListOfEmployeesForm()
        {
            InitializeComponent();
        }
        public void loadData()
        {
         //   GFG gg = new GFG();


            //Basically what i did is i replicated the static List of employes in Data Class in a List of employes  called arr here on this page then
            // i Applied Bubble sort on each index of that list of employes and instead of targeting the entire index i targited.
            // Every indexes ID variable only to find out if the current index ID is greater then the next index ID  and then i swaped it in the end with the help of a temp variable.
            List<Employee> arr = Data.employees;

           // int[] arr = { 78, 55, 45, 98, 13 };
            Employee temp;
            for (int j = 0; j <= arr.Count - 2; j++)
            {
                for (int i = 0; i <= arr.Count - 2; i++)
                {
                    if (arr[i].ID > arr[i + 1].ID)
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            foreach (var item in arr)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = item.ID;
                row.Cells[1].Value = item.Name;
                row.Cells[2].Value = item.Email;
                row.Cells[3].Value = item.Contact;
                /*  */
                row.Cells[4].Value = item.Rank;
                row.Cells[5].Value = item.Date_of_enrolment;
                row.Cells[6].Value = item.Age;
                row.Cells[7].Value = item.DateOfBirth;
                row.Cells[8].Value = item.Hobbies;
                row.Cells[9].Value = item.Salary;
              

                dataGridView1.Rows.Add(row);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loadData();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {

                var einfo = Data.employees.Where(em => em.ID ==Convert.ToInt64( textBox1.Text)).FirstOrDefault();
                if (einfo != null)
                {
                    Data.employees.Remove(einfo);
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    loadData();

                }
                else
                    MessageBox.Show("No Data Found");
            }

            



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addForm f1 = new addForm();
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter ID");
            }
            else
            {
                UpdateForm f1 = new UpdateForm((textBox1.Text));
                f1.ShowDialog();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
