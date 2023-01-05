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
            FillComboBox();
        }

        // Filter bills from database by user and description
        private void ButtonFilterDebts_Click(object sender, EventArgs e)
        {
            Person? person = null;
            string fullName = comboBoxFilterByUser.GetItemText(comboBoxFilterByUser.SelectedItem);
            string description = textBoxByDescription.Text;
            if (comboBoxFilterByUser.SelectedIndex != -1 || !string.IsNullOrEmpty(description))
            {
                if (comboBoxFilterByUser.SelectedIndex != -1 && !string.IsNullOrEmpty(textBoxByDescription.Text))
                {
                    person = Database.FindPersonByFullName(fullName);
                    dataGridViewFiltredDebts.DataSource = Database.FindBillsByPersonAndDescription(person, description);
                    return;
                } else if(comboBoxFilterByUser.SelectedIndex != -1)
                {
                    person = Database.FindPersonByFullName(fullName);
                    dataGridViewFiltredDebts.DataSource = person?.PersonBills;
                    return;
                } else if (!string.IsNullOrEmpty(textBoxByDescription.Text))
                {
                    dataGridViewFiltredDebts.DataSource = Database.FindBillsByDescription(description);
                    return;
                }
            } else MessageBox.Show("You have to input at least one filter");
        }


        // set all inputs in form to null
        private void RefreshFilters_Click(object sender, EventArgs e)
        {
            comboBoxFilterByUser.SelectedIndex = -1;
            textBoxByDescription.Clear();
        }

        // Fill combobo with person names
        private void FillComboBox()
        {
            foreach (Person person in Database.Persons)
            {
                string fullName = person.Name + " " + person.SureName;
                comboBoxFilterByUser.Items.Add(fullName);
            }
        }
    }
}
