using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3_7
{
    public partial class Form1 : Form
    {
        private List<Match> matcher = new List<Match>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void dgvMatcher_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            Match nyMatch = new Match();
            matcher.Add(nyMatch);
        }

        private void dgvMatcher_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex; //Index för den rad som redigerats

            if (e.ColumnIndex == 0)
            {
                matcher[i].HemmaLag = (string)dgvMatcher.Rows[i].Cells[0].Value;
            }
            else if(e.ColumnIndex == 1)
            {
                matcher[i].BortaLag = (string)dgvMatcher.Rows[i].Cells[1].Value;
            }
            else if(e.ColumnIndex == 2)
            {
                matcher[i].MålBortaLag = 
            }
        }

        private void btnMålrikast_Click(object sender, EventArgs e)
        {

        }
    }

    public class Match
    {
        public string HemmaLag { get; set; }
        public string BortaLag { get; set; }
        public int MålHemma { get; set; }
        public int MålBortaLag { get; set; }
    }
}
