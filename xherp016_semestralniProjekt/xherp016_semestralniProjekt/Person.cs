using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xherp016_semestralniProjekt
{
    internal class Person
    {
        // Easier way to create setters and getters than do private string _name; and than create methods for geter and setter. 
        public string Name { get; set; }
        public string Description { get; set; }
        public double SpentMoney { get; set; }

        public Person(string name, string description, double spentMoney)
        {
            this.Name = name;
            this.Description = description;
            this.SpentMoney = spentMoney;
        }
    }
}
