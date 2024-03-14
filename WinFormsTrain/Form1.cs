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
    }
}
