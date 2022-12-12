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
    public partial class FormPeople : Form
    {
        public FormPeople()
        {
            InitializeComponent();
            dataGridViewPeople.DataSource = Database.Persons;
        }

        private void buttonDeletePerson_Click(object sender, EventArgs e)
        {
            Person person = (Person)dataGridViewPeople.CurrentRow.DataBoundItem;
            if (!Database.DeletePerson(person))
            {
                MessageBox.Show("No more persons in List");
            }
        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string sureName = textBoxSureName.Text;
            Database.createNewPerson(name, sureName);
        }
    }
}
