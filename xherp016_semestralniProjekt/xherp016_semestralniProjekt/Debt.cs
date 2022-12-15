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
    public class Debt
    {
        public string PersonName { get; set; }
        public string PersonSureName { get; set; }
        public float Amount { get; set; }

        public Debt(string personName, string personSureName, float amount)
        {
            PersonName = personName;
            PersonSureName = personSureName;
            Amount = amount;
        }
    }
}
