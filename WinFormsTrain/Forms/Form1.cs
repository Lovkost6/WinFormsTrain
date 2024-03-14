using WinFormsTrain.Controllers;
using WinFormsTrain.Models;

namespace WinFormsTrain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form dlg1 = new AddPersonForm(this);
            
            dlg1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void AddPersonForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            var employees = Employees.GetAllEmployees();
            foreach (var employee in employees)
            {
                listBox1.Items.Add($"{employee.LastName} {employee.FirstName} {employee.SurName}");
            }
        }
    }
}
