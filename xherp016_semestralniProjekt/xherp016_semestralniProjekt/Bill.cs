using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xherp016_semestralniProjekt
{
    [Serializable()]
    public class Bill : INotifyPropertyChanged
    {
        public Person? Person { get; set; }

        public string? Description { get; set; }
        public float? Amount { get; set; }

        public Bill(Person? person, string? description, float? amount)
        {
            this.Person = person;
            Description = description;
            Amount = amount;
        }

        public Bill() { }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
