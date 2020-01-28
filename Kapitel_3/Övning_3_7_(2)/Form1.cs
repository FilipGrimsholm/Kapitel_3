using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_3_7__2_
{
    public partial class Form1 : Form
    {
        private List<Match> matcher = new List<Match>();
        int selectedRowIndex = 0;

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
            else if (e.ColumnIndex == 1)
            {
                matcher[i].BortaLag = (string)dgvMatcher.Rows[i].Cells[1].Value;
            }
            else if (e.ColumnIndex == 2)
            {
                matcher[i].MålHemmaLag = int.Parse((string)dgvMatcher.Rows[i].Cells[2].Value);
            }
            else if (e.ColumnIndex == 3)
            {
                matcher[i].MålBortaLag = int.Parse((string)dgvMatcher.Rows[i].Cells[3].Value);
            }
        }

        private void btnMålrikast_Click(object sender, EventArgs e)
        {
            string hemmalag = "";
            int hemmalagMål = 0;
            string bortalag = "";
            int bortalagMål = 0;
            int antalmål = 0;

            for (int i = 0; i < matcher.Count; i++)
            {
                if (matcher[i].MålHemmaLag + matcher[i].MålBortaLag > antalmål)
                {
                    hemmalag = matcher[i].HemmaLag;
                    bortalag = matcher[i].BortaLag;
                    antalmål = matcher[i].MålHemmaLag + matcher[i].MålBortaLag;
                    hemmalagMål = matcher[i].MålHemmaLag;
                    bortalagMål = matcher[i].MålBortaLag;
                }
            }

            tbxMålrikast.Text = hemmalag + ": " + hemmalagMål + ", " + bortalag + ": " + bortalagMål + ", Antal mål: " + antalmål;
        }

        private void dgvMatcher_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int i = e.Row.Index;
            matcher.RemoveAt(i);
        }

        private void btnMålskillnad_Click(object sender, EventArgs e)
        {
            string hemmalag = "";
            int hemmalagMål = 0;
            string bortalag = "";
            int bortalagMål = 0;
            int målskillnad = 0;

            for(int i = 0; i < matcher.Count; i++)
            {
                if (matcher[i].MålHemmaLag > matcher[i].MålBortaLag)
                {
                    if (matcher[i].MålHemmaLag - matcher[i].MålBortaLag > målskillnad)
                    {
                        hemmalag = matcher[i].HemmaLag;
                        bortalag = matcher[i].BortaLag;
                        målskillnad = matcher[i].MålHemmaLag - matcher[i].MålBortaLag;
                        hemmalagMål = matcher[i].MålHemmaLag;
                        bortalagMål = matcher[i].MålBortaLag;
                    }
                }
                else
                {
                    if (matcher[i].MålBortaLag - matcher[i].MålHemmaLag > målskillnad)
                    {
                        hemmalag = matcher[i].HemmaLag;
                        bortalag = matcher[i].BortaLag;
                        målskillnad = matcher[i].MålBortaLag - matcher[i].MålHemmaLag;
                        hemmalagMål = matcher[i].MålHemmaLag;
                        bortalagMål = matcher[i].MålBortaLag;
                    }
                }

                tbxMålskillnad.Text = hemmalag + ": " + hemmalagMål + ", " + bortalag + ": " + bortalagMål + ", " + "Målskillnad: " + målskillnad;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (dgvMatcher.SelectedRows.Count == 1)
            {
                DataGridViewRow rad = dgvMatcher.SelectedRows[0];
                int index = rad.Index;

                //Moving the row up
                if (index == 0) return;

                dgvMatcher.Rows.RemoveAt(index);
                dgvMatcher.Rows.Insert(index - 1, rad);
                rad.Selected = true;

                //Moving the corresponding index to match the moved row
                Match match = matcher[index];
                matcher.RemoveAt(index);
                matcher.Insert(index - 1, match);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (dgvMatcher.SelectedRows.Count == 1)
            {
                DataGridViewRow rad = dgvMatcher.SelectedRows[0];
                int index = rad.Index;

                //Moving the row up
                if (index == dgvMatcher.Rows.Count - 2) return;

                dgvMatcher.Rows.RemoveAt(index);
                dgvMatcher.Rows.Insert(index + 1, rad);
                rad.Selected = true;

                Match match = matcher[index];
                matcher.RemoveAt(index);
                matcher.Insert(index + 1, match);
            }
        }

        private void dgvMatcher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class Match
    {
        public string HemmaLag { get; set; }
        public string BortaLag { get; set; }
        public int MålHemmaLag { get; set; }
        public int MålBortaLag { get; set; }
    }
}
