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
    public partial class PayrollForm : Form
    {
        public PayrollForm()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            //   GFG gg = new GFG();


            //Basically what i did is i replicated the static List of employes in Data Class in a List of employes  called arr here on this page then
            // i Applied Bubble sort on each index of that list of employes and instead of targeting the entire index i targited.
            // Every indexes ID variable only to find out if the current index ID is greater then the next index ID  and then i swaped it in the end with the help of a temp variable.
            List<Payroll> arr = PayrolData.payrolls;

            // int[] arr = { 78, 55, 45, 98, 13 };
            Payroll temp;
            for (int j = 0; j <= arr.Count - 2; j++)
            {
                for (int i = 0; i <= arr.Count - 2; i++)
                {
                    if (arr[i].Salary > arr[i + 1].Salary)
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
                row.Cells[2].Value = item.Vacations;
                row.Cells[3].Value = item.Salary;
                dataGridView1.Rows.Add(row);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loadData();

            //BindingList<Employee> x = new BindingList<Employee>();
            //var bindingList = new BindingList<Employee>(Data.employees);
            //foreach (var item in Data.employees)
            //{
            //    x.Add(item);
            //}
            //dataGridView1.DataSource = x;
            //dataGridView1.Update();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPayRoll f1 = new AddPayRoll();
            f1.ShowDialog();
        }

        private void PayrollForm_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
