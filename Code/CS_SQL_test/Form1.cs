namespace CS_SQL_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.SavePerson(button1GetData());
            listBox1Show();
            button1SetView();

        }
    }
}