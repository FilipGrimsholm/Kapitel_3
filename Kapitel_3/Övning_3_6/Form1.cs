using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTeckensnitt_Click(object sender, EventArgs e)
        {
            try
            {
                string markeradText = rtbxText.SelectedText;

                if (markeradText == "")
                {
                    MessageBox.Show("Du har inte markerat någon text som ska ändras");
                }
                else
                {
                    DialogResult r = fontdlgTeckensnitt.ShowDialog();
                    if (r == DialogResult.OK)
                    {
                        rtbxText.SelectionFont = fontdlgTeckensnitt.Font;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void RadbtnLeft_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string markeradText = rtbxText.SelectedText;

                if (markeradText == "")
                {
                    MessageBox.Show("Du har inte markerat någon text som ska ändras");
                }
                else
                {
                    rtbxText.SelectionAlignment = HorizontalAlignment.Left;
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void RadbtnCenter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string markeradText = rtbxText.SelectedText;

                if (markeradText == "")
                {
                    MessageBox.Show("Du har inte markerat någon text som ska ändras");
                }
                else
                {
                    rtbxText.SelectionAlignment = HorizontalAlignment.Center;
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void RadbtnRight_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string markeradText = rtbxText.SelectedText;

                if (markeradText == "")
                {
                    MessageBox.Show("Du har inte markerat någon text som ska ändras");
                }
                else
                {
                    rtbxText.SelectionAlignment = HorizontalAlignment.Right;
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult r = colordlgText.ShowDialog();
            if(r == DialogResult.OK)
            {
                pictureBox1.BackColor = colordlgText.Color;
                rtbxText.SelectionColor = colordlgText.Color;
            }
        }
    }
}
