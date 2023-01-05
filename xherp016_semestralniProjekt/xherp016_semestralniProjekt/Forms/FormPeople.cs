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
    public partial class FormPeople : Form
    {
        public FormPeople()
        {
            InitializeComponent();
            dataGridViewPeople.DataSource = Database.Persons;
        }

        // Delete person from database
        private void ButtonDeletePerson_Click(object sender, EventArgs e)
        {
            if (dataGridViewPeople.Rows.Count != 1)
            {
                Person person = (Person)dataGridViewPeople.CurrentRow.DataBoundItem;
                Database.DeletePerson(person);
                return;
            }
            else MessageBox.Show("No more persons in List");
        }

        // Add person to database
        private void ButtonAddPerson_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxSureName.Text != "")
            {
                // handle if name or surname starts with space
                if(!textBoxName.Text.StartsWith(" ") && !textBoxSureName.Text.StartsWith(" ")){
                    string name = textBoxName.Text;
                    string sureName = textBoxSureName.Text;

                    // HANDLE SPACES AFTER INPUT
                    name = Database.DeleteExcessSpacesFromString(name);
                    sureName = Database.DeleteExcessSpacesFromString(sureName);

                    Database.CreateNewPerson(name, sureName);
                } 
                else MessageBox.Show("You have to input letter first");
            }
            else MessageBox.Show("You have to input Name and Surename!");
        }
    }
}
