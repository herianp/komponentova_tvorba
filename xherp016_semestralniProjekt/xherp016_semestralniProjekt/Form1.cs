using System.Windows.Forms;
using xherp016_semestralniProjekt.Forms;

namespace xherp016_semestralniProjekt
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            Database.Init();
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

        private void openChildForm(Form childForm, object btnSender, Color color)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender, color);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormBill(), sender, Color.DarkGreen);
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormPeople(), sender, Color.HotPink);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormDebt(), sender, Color.Gold);
        }

        private void form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database.Serialisation();
        }

        private void buttonFilterBills_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FilterBills(), sender, Color.DarkKhaki);
        }
    }
}