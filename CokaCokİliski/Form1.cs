using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CokaCokİliski
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void öğrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOgrenci ogrenci = new FormOgrenci();
            ogrenci.Show();
        }

        private void eğitmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEgitmen egitmen = new FormEgitmen();
            egitmen.Show();
        }

        private void ögrenciEğitmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fomİliski formiliski = new Fomİliski();
            formiliski.Show();
        }
    }
}
