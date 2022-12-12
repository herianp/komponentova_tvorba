using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xherp016_semestralniProjekt.Forms
{
    public partial class FormBill : Form
    {
        public FormBill()
        {
            InitializeComponent();
            dataGridViewBill.DataSource = Database.Bills;
            fillComboBox(Database.Persons);
        }

        private void fillComboBox(BindingList<Person> personList)
        {
            foreach(Person person in personList)
            {
                string fullName = person.Name + " " + person.SureName;
                comboBoxChoosePerson.Items.Add(fullName);
            }

        }

        private void buttonAddToBill_Click(object sender, EventArgs e)
        {
            string personName = comboBoxChoosePerson.GetItemText(comboBoxChoosePerson.SelectedItem);
            string description = textBoxDescription.Text;
            string amount = textBoxMoney.Text;
            Database.createNewBill(personName, description, amount);
        }

        private void buttonDeleteFromBill_Click(object sender, EventArgs e)
        {
            Bill bill = (Bill)dataGridViewBill.CurrentRow.DataBoundItem;
            if (!Database.DeleteBill(bill))
            {
                MessageBox.Show("No more bills in List");
            }
        }
    }
}
