namespace xherp016_semestralniProjekt
{
    public partial class Form1 : Form
    {
        Bill bill = new Bill();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person person = new Person(textBox1.Text, textBox2.Text, textBox3.Text);
            bill.addItemToBill(listBox1, person);
        }
    }
}