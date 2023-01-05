using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace xherp016_semestralniProjekt
{
    internal class Database
    {
        public Database() { }

        public static BindingList<Bill> Bills { get; set; } = new BindingList<Bill>();
        public static BindingList<Person> Persons { get; set; } = new BindingList<Person>();

        public static void Init()
        {
            Database.Deserialisation();
            CreateBondsBetweenPersonsAndBills();
        }

        // this function restores the bounds between the Person and the Bills, than we can delete bills
        //      using Person.PersonBills.Remove(bill);
        public static void CreateBondsBetweenPersonsAndBills()
        {
            foreach (Person person in Database.Persons)
            {
                person.PersonBills.Clear();
                foreach (Bill bill in Database.Bills)
                {
                    string person_fullName = person.Name + " " + person.SureName;
                    if (bill.PersonName == person_fullName)
                    {
                        person.PersonBills.Add(bill);
                    }
                }
            }
        }
        public static void Serialisation<T>(BindingList<T> list, string soubor)
        {
            using (Stream s = File.Open(soubor, FileMode.Create))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(BindingList<T>));
                xmlSerializer.Serialize(s, list);
            }
        }

        public static void Serialisation()
        {
            Database.Serialisation(Bills, "bills.bin");
            Database.Serialisation(Persons, "persons.bin");
        }


        public static BindingList<T> Deserialisation<T>(string soubor)
        {
            using (Stream s = File.Open(soubor, FileMode.Open))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(BindingList<T>));
                return (BindingList<T>)xmlSerializer.Deserialize(s);

            }
        }

        public static void Deserialisation()
        {
            Database.Bills = Database.Deserialisation<Bill>("bills.bin");
            Database.Persons = Database.Deserialisation<Person>("persons.bin");
        }

        // create new Bill for Person
        public static void CreateNewBill(string fullName, string description, string amount)
        {
            foreach (Person per in Database.Persons)
            {
                string personFullName = per.Name + " " + per.SureName;
                if (personFullName == fullName)
                {
                    if (Single.TryParse(amount, out float amountValue))
                    {
                        Bill bill = new Bill(fullName, description, amountValue);
                        Database.Bills.Add(bill);
                        per.PersonBills.Add(bill);
                        return;
                    }
                    else MessageBox.Show("Input money, have to be number!");
                }
            }

        }

        // delete Bill
        public static void DeleteBill(Bill bill)
        {
            if (Database.Bills.Count > 0)
            {
                foreach (Person p in Persons)
                {
                    if (bill.PersonName.Equals(p.ToString()))
                    {
                        p.PersonBills.Remove(bill);
                        break;
                    }
                }
                Database.Bills.Remove(bill);
            }
        }

        // create new Person
        public static void CreateNewPerson(string name, string sureName)
        {
            Person person = new Person(name, sureName);
            Database.Persons.Add(person);
        }

        // delete Person
        public static void DeletePerson(Person person)
        {
            if (Database.Persons.Count > 0)
            {
                foreach (Bill bill in person.PersonBills)
                {
                    Database.Bills.Remove(bill);
                }
                Database.Persons.Remove(person);
            }
        }

        // modify name to better format
        public static string DeleteExcessSpacesFromString(string text)
        {
            text = Regex.Replace(text, @" +", " ");
            if (text[text.Length - 1].Equals(' '))
            {
                text = text.Remove(text.Length - 1);
                Debug.WriteLine("AFTER_IF: " + text);
            }
            return Regex.Replace(text, @" +", " ");
        }


        // find person in Database by fullname
        public static Person? FindPersonByFullName(string username)
        {
            foreach (Person per in Database.Persons)
            {
                string personFullName = per.Name + " " + per.SureName;
                if (personFullName == username)
                {
                    return per;
                }
            }
            return null;
        }

        // find bills by person and description
        public static BindingList<Bill>? FindBillsByPersonAndDescription(Person? person, string description)
        {
            BindingList<Bill> bills = new BindingList<Bill>();

            foreach (Bill bill in person.PersonBills)
            {
                if (bill.Description == description)
                {
                    bills.Add(bill);
                }
            }
            return bills;
        }

        // find bills by description
        public static BindingList<Bill>? FindBillsByDescription(string description)
        {
            BindingList<Bill> bills = new BindingList<Bill>();

            foreach (Bill bill in Database.Bills)
            {
                if (bill.Description == description)
                {
                    bills.Add(bill);
                }
            }
            return bills;
        }


        // final counter of debts for each person
        public static Dictionary<string, float>? CountDebtsForEveryPerson(Label label)
        {
            float sumOfDebtsAmount = 0;
            Dictionary<string, float> debtsOutput = new Dictionary<string, float>();
            foreach (Person person in Database.Persons)
            {
                float debtAmount = 0;
                foreach (Bill bill in person.PersonBills)
                {
                    debtAmount += bill.Amount;
                    sumOfDebtsAmount += bill.Amount;
                }
                debtsOutput.Add(person.ToString(), debtAmount);
            }
            foreach (string key in debtsOutput.Keys)
            {
                debtsOutput[key] -= (sumOfDebtsAmount / Database.Persons.Count);
            }
            // set total amount label
            label.Text = sumOfDebtsAmount.ToString();
            return debtsOutput;
        }
    }
}
