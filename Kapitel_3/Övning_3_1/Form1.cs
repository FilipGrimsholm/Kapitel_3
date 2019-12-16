using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVäljFärg_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgColor.ShowDialog();
            if (r == DialogResult.OK)
            {
                btnVäljFärg.BackColor = dlgColor.Color;
            }
        }

        private void btnBrowserDialog_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgBrowser.ShowDialog();
            if (r == DialogResult.OK)
            {
                btnBrowserDialog.Text = dlgBrowser.SelectedPath;
            }
        }

        private void btnVäljTeckensnitt_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgFont.ShowDialog();
            if (r == DialogResult.OK)
            {
                btnVäljTeckensnitt.Font = dlgFont.Font;
            }
        }
    }
}
