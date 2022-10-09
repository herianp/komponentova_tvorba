using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xherp016_semestralniProjekt
{
    internal class Bill
    {
        public ArrayList PersonList { get; set; }

        public Bill()
        {
            this.PersonList = new ArrayList();
        }
        public void addItemToBill(ListBox listBox, Person person)
        {
            this.PersonList.Add(person);
            listBox.Items.Add($"{person.Name}, {person.Description}, {person.SpentMoney}");
        }

        public static double getSumOfMoneyFromBill()
        {
            //todo make logic
            return 2;
        }

    }
}
