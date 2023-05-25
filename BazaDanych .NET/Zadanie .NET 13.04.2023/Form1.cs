using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie.NET_13._04._2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void graczeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gracz gracz = new Gracz();
            gracz.Show();
        }

        private void drużynyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Druzyna druzyna = new Druzyna();
            druzyna.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
