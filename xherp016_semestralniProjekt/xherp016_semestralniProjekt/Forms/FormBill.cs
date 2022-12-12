using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            fillComboBox();
        }

        private void fillComboBox()
        {
            foreach (Person person in Database.Persons)
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
            if (dataGridViewBill.Rows.Count != 1)
            {
                Bill bill = (Bill)dataGridViewBill.CurrentRow.DataBoundItem;
                Database.DeleteBill(bill);
                return;
            } else MessageBox.Show("No more bills in List");
        }
    }
}
