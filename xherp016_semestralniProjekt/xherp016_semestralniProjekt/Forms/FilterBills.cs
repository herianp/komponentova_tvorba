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
    public partial class FilterBills : Form
    {
        public FilterBills()
        {
            InitializeComponent();
            fillComboBoxes();
        }

        private void buttonFilterDebts_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("START");
            Person? person = null;
            string fullName = comboBoxFilterByUser.GetItemText(comboBoxFilterByUser.SelectedItem);
            string description = textBoxByDescription.Text;
            if (comboBoxFilterByUser.SelectedIndex != -1 || !string.IsNullOrEmpty(description))
            {
                Debug.WriteLine("herer");
                if (comboBoxFilterByUser.SelectedIndex != -1 && !string.IsNullOrEmpty(textBoxByDescription.Text))
                {
                    Debug.WriteLine("1");
                    person = Database.FindPersonByFullName(fullName);
                    dataGridViewFiltredDebts.DataSource = Database.FindBillsByPersonAndDescription(person, description);
                    return;
                } else if(comboBoxFilterByUser.SelectedIndex != -1)
                {
                    Debug.WriteLine("2");
                    person = Database.FindPersonByFullName(fullName);
                    dataGridViewFiltredDebts.DataSource = person?.PersonBills;
                    return;
                } else if (!string.IsNullOrEmpty(textBoxByDescription.Text))
                {
                    Debug.WriteLine("3");
                    dataGridViewFiltredDebts.DataSource = Database.FindBillsByDescription(description);
                    return;
                }
            } else MessageBox.Show("You have to input at least one filter");
            Debug.WriteLine("END");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxFilterByUser.SelectedIndex = -1;
            textBoxByDescription.Clear();
        }

        private void fillComboBoxes()
        {
            foreach (Person person in Database.Persons)
            {
                string fullName = person.Name + " " + person.SureName;
                comboBoxFilterByUser.Items.Add(fullName);
            }
        }
    }
}
