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
            double money = 0;
            try
            {
                money = double.Parse(textBox3.Text);
                string name = textBox1.Text;
                string description = textBox2.Text;
                if(name.Length == 0 || description.Length == 0) { 
                    throw new Exception();
                }
                Person person = new Person(name, description, money);
                bill.addItemToBill(listBox1, person);
            }
            catch { MessageBox.Show("Text have to Money have to be number!"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO
            textBox4.Text = bill.getSumOfMoneyFromBill().ToString();
        }
    }
}