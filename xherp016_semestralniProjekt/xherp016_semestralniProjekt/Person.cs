using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xherp016_semestralniProjekt
{
    [Serializable()]
    public class Person
    {
        public string Name { get; set; }
        public string SureName { get; set; }
        public BindingList<Bill> PersonBills { get; set; } = new BindingList<Bill>();

        public Person() { }

        public Person(string name, string sureName)
        {
            this.Name = name;
            SureName = sureName;
        }

        public override string ToString()
        {
            return Name.ToString() + " " + SureName.ToString();
        }
    }
}
