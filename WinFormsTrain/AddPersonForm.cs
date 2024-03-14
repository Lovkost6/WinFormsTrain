using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTrain
{
    public partial class AddPersonForm : Form
    {
        Form1 context;
        public AddPersonForm(Form1 form)
        {
            InitializeComponent();
            context = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            context.listBox1.Items.Add($"{textBox1.Text} + {textBox2.Text} + {textBox3.Text}");
            Close();
        }
    }
}
