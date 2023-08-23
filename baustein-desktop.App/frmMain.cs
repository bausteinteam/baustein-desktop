using baustein_desktop.Data;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void vakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVak frmVak = new frmVak();
            frmVak.ShowDialog();
        }

    }
}
