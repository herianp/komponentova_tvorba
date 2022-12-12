using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace xherp016_semestralniProjekt
{
    internal class Database
    {
        public Database() { }

        public static BindingList<Bill> Bills { get; set; } = new BindingList<Bill>();
        public static BindingList<Person> Persons { get; set; } = new BindingList<Person>();

        public static void Init()
        {
            /*Person person_petr = new Person("Petr", "Herian");
            Persons.Add(person_petr);

            string fullName = person_petr.Name + " " + person_petr.SureName;
            Bill bill = new Bill(fullName, "Nakup v Lidlu", 500);
            Bills.Add(bill);
            person_petr.PersonBills.Add(bill);*/

            Database.Deserialisation();
            CreateBondsBetweenPersonsAndBills();
        }

        // this function restores the bounds between the Person and the Bills, than we can delete bills
        //      using Person.PersonBills.Remove(bill);
        public static void CreateBondsBetweenPersonsAndBills()
        {
            foreach(Bill bill in Database.Bills)
            {
                foreach(Person person in Database.Persons)
                {
                    string person_fullName = person.Name + " " + person.SureName;
                    if (bill.PersonName == person_fullName)
                    {
                        person.PersonBills.Remove(bill);
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

        // creating new Bill for Person
        public static void createNewBill(string fullName, string description, string amount)
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
                    }
                }
            }

        }

        public static void DeleteBill(Bill bill)
        {
            if (Database.Bills.Count > 0)
            {
                Database.Bills.Remove(bill);
            }
        }

        public static void createNewPerson(string name, string sureName)
        {
            Person person = new Person(name, sureName);
            Database.Persons.Add(person);
        }

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
    }
}
