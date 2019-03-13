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
    public partial class FormEgitmen : Form
    {
        public FormEgitmen()
        {
            InitializeComponent();
        }
        UniversiteContext db = new UniversiteContext();
        int secilenID;

        private void dgvEgitmen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenID = Convert.ToInt32(dgvEgitmen.CurrentRow.Cells[0].Value);
            Egitmen egitmen = db.Egitmenler.Find(secilenID);
            txtEgtAdi.Text = egitmen.EgitmenName;
            txtEgtSoyadi.Text = egitmen.EgitmenSurName;
        }

        private void FormEgitmen_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            var list = db.Egitmenler.Select(x => new
            {
                ID = x.EgitmenId,
                EgitmenAdi = x.EgitmenName,
                EgitmenSoyadi = x.EgitmenSurName
            });
            var n = list.ToList();
            dgvEgitmen.DataSource = n;
            txtEgtAdi.Clear();
            txtEgtSoyadi.Clear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Egitmen egitmen = new Egitmen();
            egitmen.EgitmenName = txtEgtAdi.Text;
            egitmen.EgitmenSurName = txtEgtSoyadi.Text;

            db.Egitmenler.Add(egitmen);
            db.SaveChanges();
            Listele();
        }
    }
}
