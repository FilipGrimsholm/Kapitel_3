using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3_2
{
    public partial class Form1 : Form
    {
        int change = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void väljFärgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgColor.ShowDialog();
            if (r == DialogResult.OK)
            {
                väljFärgToolStripMenuItem.BackColor = dlgColor.Color;
                väljTeckensnittToolStripMenuItem.BackColor = dlgColor.Color;
                väljMappToolStripMenuItem.BackColor = dlgColor.Color;
                väljFärgToolStripMenuItem.BackColor = dlgColor.Color;
                lblTruth.BackColor = dlgColor.Color;
                mnsChoose.BackColor = dlgColor.Color;
                revealTheTruthToolStripMenuItem.BackColor = dlgColor.Color;
            }
        }

        private void väljMappToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgBrowser.ShowDialog();
            if (r == DialogResult.OK)
            {
                väljMappToolStripMenuItem.Text = dlgBrowser.SelectedPath;
            }
        }

        private void väljTeckensnittToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgFont.ShowDialog();
            if (r == DialogResult.OK)
            {
                väljTeckensnittToolStripMenuItem.Font = dlgFont.Font;
                väljMappToolStripMenuItem.Font = dlgFont.Font;
                väljFärgToolStripMenuItem.Font = dlgFont.Font;
                lblTruth.Font = dlgFont.Font;
                mnsChoose.Font = dlgFont.Font;
                revealTheTruthToolStripMenuItem.Font = dlgFont.Font;
            }
        }

        private void revealTheTruthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (change == 0)
            {
                lblTruth.Visible = true;
                revealTheTruthToolStripMenuItem.Text = "Hide the truth";
                change = 1;
            }
            else
            {
                lblTruth.Visible = false;
                revealTheTruthToolStripMenuItem.Text = "Reveal the truth";
                change = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                //this.Controls.Remove((Button)sender);
                Button b = (Button)sender;
                Button bb = sender as Button;
            }          
            
            Contextmenustrip1.SourceControl.Visible = false;
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void Contextmenustrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
