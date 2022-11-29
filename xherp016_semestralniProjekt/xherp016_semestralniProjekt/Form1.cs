namespace xherp016_semestralniProjekt
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Form activeForm;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void ActiveButton(object btnSender, Color color)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.Black;
                    currentButton.BackColor = color;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    panelTitleBar.BackColor= color;
                    panelLogo.BackColor = ControlPaint.Dark(color);
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

        private void openChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender, Color.Aqua);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelBill.Controls.Add(childForm);
            this.panelBill.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.DarkGreen);
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, Color.HotPink);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActiveButton(sender,Color.Gold);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //delete this
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //DELETE
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DELETE
        }
    }
}