using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(System.Object sender, System.EventArgs e)
        {
            ServiceReference1.Service1Client client = new
                ServiceReference1.Service1Client();
            string returnString;

            returnString = client.GetData(textBox1.Text);
            label1.Text = returnString;
        }
    }
}
