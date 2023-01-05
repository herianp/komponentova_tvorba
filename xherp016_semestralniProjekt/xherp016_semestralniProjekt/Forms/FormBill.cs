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
            FillComboBox();
        }


        // fill combobo with persons names
        private void FillComboBox()
        {
            foreach (Person person in Database.Persons)
            {
                string fullName = person.Name + " " + person.SureName;
                comboBoxChoosePerson.Items.Add(fullName);
            }

        }

        // add bill to the database 
        private void ButtonAddToBill_Click(object sender, EventArgs e)
        {
            string description = textBoxDescription.Text;
            string amount = textBoxMoney.Text;
            if (comboBoxChoosePerson.SelectedIndex != -1 && !string.IsNullOrEmpty(description) && !string.IsNullOrEmpty(amount))
            {

                // handle if description or surname starts with space
                if (!description.StartsWith(" "))
                {
                    // HANDLE SPACES AFTER INPUT
                    description = Database.DeleteExcessSpacesFromString(description);
                }
                else
                {
                    MessageBox.Show("You have to input letter first");
                    return;
                }

                // amount cant be less than 0
                if (Int32.Parse(amount) > 0)
                {
                    string personName = comboBoxChoosePerson.GetItemText(comboBoxChoosePerson.SelectedItem);
                    Database.CreateNewBill(personName, description, amount);
                }
                else MessageBox.Show("Money have to be positive number!");
            }
            else MessageBox.Show("You have to select and input all values!");
        }


        // delete bill from the database
        private void ButtonDeleteFromBill_Click(object sender, EventArgs e)
        {
            if (dataGridViewBill.Rows.Count != 1)
            {
                Bill bill = (Bill)dataGridViewBill.CurrentRow.DataBoundItem;
                Database.DeleteBill(bill);
                return;
            }
            else MessageBox.Show("No more bills in List");
        }
    }
}
