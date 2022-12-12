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
    public partial class FilterBills : Form
    {
        public FilterBills()
        {
            InitializeComponent();
            fillComboBoxes();
        }

        private void buttonFilterDebts_Click(object sender, EventArgs e)
        {
            string fullName = comboBoxFilterByUser.GetItemText(comboBoxFilterByUser.SelectedItem);
            foreach (Person per in Database.Persons)
            {
                string personFullName = per.Name + " " + per.SureName;
                if (personFullName == fullName)
                {
                    dataGridViewFiltredDebts.DataSource = per.PersonBills;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxFilterByUser.SelectedIndex = -1;
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
