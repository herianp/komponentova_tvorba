namespace xherp016_semestralniProjekt
{
    public partial class Form1 : Form
    {
        Bill bill = new Bill();
        private Button currentButton;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void ActiveButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.Black;
                    currentButton.BackColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control prevBtn in panelMenu.Controls)
            {
                if(prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.ForeColor = Color.Black;
                    prevBtn.BackColor = Color.DarkGray;
                    prevBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
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
            //TODO logic
            textBox4.Text = bill.getSumOfMoneyFromBill().ToString();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
    }
}