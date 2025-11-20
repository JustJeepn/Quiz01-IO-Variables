namespace Quiz01_IO_Variables
{
    public partial class Form1 : Form
    {
        string userName;
        public Form1()
        {
            InitializeComponent();
        }

        private void q2SExampleButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Go Jays!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("6");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("To output two decimal places use F2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4 items at 2.25 each with tax will be $10.17");
        }

        private void q01Button_Click(object sender, EventArgs e)
        {
            q1OutputLabel.Text = "Go Bears!";
        }

        private void q02Button_Click(object sender, EventArgs e)
        {
            userName = q2TextBox.Text;
            q2OutputLabel.Text = "Go, " + userName + "!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
