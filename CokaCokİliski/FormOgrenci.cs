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
    public partial class FormOgrenci : Form
    {
        public FormOgrenci()
        {
            InitializeComponent();
        }
        UniversiteContext db = new UniversiteContext();
        int secilenID;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.OgrenciName = txtOgrAdi.Text;
            ogrenci.OgrenciSurName = txtOgrSoyadi.Text;

            db.Ogrenciler.Add(ogrenci);
            db.SaveChanges();
            Listele();
        }

        private void dgvOgrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenID = Convert.ToInt32(dgvOgrenci.CurrentRow.Cells[0].Value);
            Ogrenci ogrenci = db.Ogrenciler.Find(secilenID);
            txtOgrAdi.Text = ogrenci.OgrenciName;
            txtOgrSoyadi.Text = ogrenci.OgrenciSurName;
        }

        private void FormOgrenci_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            var list = db.Ogrenciler.Select(x => new
            {
                ID = x.OgrenciId,
                OgrenciAdi = x.OgrenciName,
                OgrenciSoyadi = x.OgrenciSurName
            });
            var n = list.ToList();
            dgvOgrenci.DataSource = n;
            txtOgrAdi.Clear();
            txtOgrSoyadi.Clear();
        }
    }
}
