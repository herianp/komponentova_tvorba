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
            // Person person_petr = new Person("Petr", "Herian");
            // Persons.Add(person_petr);

            // Bill bill = new Bill(person_petr, "Nakup v Lidlu", 500);
            // Bills.Add(bill);
            Database.Deserialisation();
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

        public static void createNewBill(string fullName, string description, string amount)
        {
            string personName = "--";
            string personSureName = "--";
            foreach (Person per in Database.Persons)
            {
                string personFullName = per.Name + " " + per.SureName;
                if (personFullName == fullName)
                {
                    personName = per.Name;
                    personSureName = per.SureName;
                }
            }
            Person person = new Person(personName, personSureName);

            if (Single.TryParse(amount, out float amountValue))
            {
                Bill bill = new Bill(person, description, amountValue);
                Database.Bills.Add(bill);
            }

        }

        public static bool DeleteBill(Bill bill)
        {
            if (Database.Bills.Count > 0)
            {
                Database.Bills.Remove(bill);
                return true;
            }
            return false;
        }

        public static void createNewPerson(string name, string sureName)
        {
            Person person = new Person(name, sureName);
            Database.Persons.Add(person);
        }

        public static bool DeletePerson(Person person)
        {
            if (Database.Persons.Count > 0)
            {
                Database.Persons.Remove(person);
                return true;
            }
            return false;
        }
    }
}
