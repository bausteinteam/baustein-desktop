using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baustein_desktop.App
{
    public partial class frmNewVak : Form
    {
        public frmNewVak()
        {
            InitializeComponent();
        }

        private void frmNewVak_Load(object sender, EventArgs e)
        {
            crnBudgetKosten.FormatString = "C";
            crnBudgetKosten.FormatProvider = new System.Globalization.CultureInfo("de-DE");
            crnBudgetschätzung.FormatString = "C";
            crnBudgetschätzung.FormatProvider = new System.Globalization.CultureInfo("de-DE");
            dtmLeistungsBeginn.FormatString = "C";
            dtmLeistungsBeginn.FormatProvider = new System.Globalization.CultureInfo("de-DE");
            dtmVertragAbschluss.FormatString = "C";
            dtmVertragAbschluss.FormatProvider = new System.Globalization.CultureInfo("de-DE");
        }
    }
}
