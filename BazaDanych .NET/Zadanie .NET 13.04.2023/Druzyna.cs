using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadanie.NET_13._04._2023.PilkaNoznaDataSetTableAdapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zadanie.NET_13._04._2023
{
    public partial class Druzyna : Form
    {
        public Druzyna()
        {
            InitializeComponent();
        }

        private void Druzyna_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'pilkaNoznaDataSet.druzyna' . Możesz go przenieść lub usunąć.
            this.druzynaTableAdapter.Fill(this.pilkaNoznaDataSet.druzyna);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            druzynaTableAdapter.Update(pilkaNoznaDataSet.druzyna);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
            druzynaTableAdapter.Update(pilkaNoznaDataSet.druzyna);

        }
    }
}
