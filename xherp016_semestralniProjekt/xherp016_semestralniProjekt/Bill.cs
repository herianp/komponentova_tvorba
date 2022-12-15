using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace xherp016_semestralniProjekt
{
    [Serializable()]
    public class Bill : INotifyPropertyChanged
    {
        public string PersonName { get; set; }

        public string Description { get; set; }
        public float Amount { get; set; }

        public Bill(string personName, string description, float amount)
        {
            this.PersonName = personName;
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
