using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xherp016_semestralniProjekt.Forms
{
    public partial class FormDebt : Form
    {
        public FormDebt()
        {
            InitializeComponent();
            dataGridViewMoney.DataSource = Database.CountDebtsForEveryPerson(labelTotalAmount)?.ToArray();
        }
    }
}
