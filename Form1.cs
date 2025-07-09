namespace PROG6221
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form4 f4 = new Form4();
            f4.Show();
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show(); //this allows the button to take you to a new form/page
            Visible = false;  //This hides the current page
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form3 f3 = new Form3();
            f3.Show();
            Visible = false;
        }
    }
}
