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

        public double getSumOfMoneyFromBill()
        {
            double moneyOutput = 0;
            //todo make logic
            foreach(Person person in this.PersonList)
            {
                moneyOutput += person.SpentMoney;
            }
            return moneyOutput;
        }

    }
}
