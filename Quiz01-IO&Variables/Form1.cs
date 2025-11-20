namespace Quiz01_IO_Variables
{
    public partial class Form1 : Form
    {
        string userName;
        int numItems = 0;
        double itemPrice = 2.25;
        double taxAmount = 0;
        double taxRate = 0.13;
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

        private void q03Button_Click(object sender, EventArgs e)
        {

        }

        private void noItemsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void q04Button_Click(object sender, EventArgs e)
        {
            numItems = Convert.ToInt16(noItemsBox.Text);
            taxAmount = taxRate * itemPrice;
            q4OutputLabel.Text = itemPrice + taxAmount;
            q4OutputLabel.Text = taxAmount.ToString("C");
            q4OutputLabel.Text = itemPrice.ToString("C");

        }
    }
}
