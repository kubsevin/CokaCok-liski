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
    public partial class Fomİliski : Form
    {
        private UniversiteContext _db=new UniversiteContext();
        private List<Ogrenci> ogrenci;
        private Egitmen egitmen;
        public Fomİliski()
        {
            InitializeComponent();
            _db = new UniversiteContext();
            egitmen = null;
            ogrenci = new List<Ogrenci>();
        }
       

        private void dgvİliski_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Fomİliski_Load(object sender, EventArgs e)
        {
            EgitmenDoldur();
            OgrenciDoldur();
        
        }

        private void lstİliski_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cbEgitmen_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbEgitmen.SelectedIndex == -1)
                return;
            egitmen = (Egitmen)cbEgitmen.SelectedItem;
            dgvİliski.DataSource = egitmen.Ogrenciler.ToList();
            OgrenciDoldur();
        }
        private void EgitmenDoldur()
        {
            //var list = _db.Egitmenler.Select(x => new
            //{
            //    x.EgitmenId,
            //    x.EgitmenName,
            //    x.EgitmenSurName

            //}).OrderBy(x => x.EgitmenId).ToList();
            //cbEgitmen.DisplayMember = "EgitmenName";
            //cbEgitmen.ValueMember = "EgitmenId";
            //cbEgitmen.DataSource = list;

            cbEgitmen.DisplayMember = "EgitmenName";
            cbEgitmen.ValueMember = "EgitmenId";
            cbEgitmen.DataSource = _db.Egitmenler.ToList();
        }
        private void OgrenciDoldur()
        {
            lstİliski.Items.Clear();
            ogrenci = _db.Ogrenciler.ToList();
            ogrenci.ForEach(o => lstİliski.Items.Add(o.ToString()));
        }


        private void DgvIliskiDoldur()
        {
            dgvİliski.DataSource = egitmen.Ogrenciler.ToList();
        }

        //
        private void btnİliskilendir_Click(object sender, EventArgs e)
        {
            foreach (int index in lstİliski.SelectedIndices)
            {
                egitmen.Ogrenciler.Add(ogrenci[index]);
            }

            _db.SaveChanges();
            OgrenciDoldur();
            EgitmenDoldur();
            DgvIliskiDoldur();
        }
    }
}
