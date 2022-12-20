using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Kullanimi
{
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
        }

        DbUrunEntities db = new DbUrunEntities();

        void Urunlistesi()
        {
            var urunler = from urun in db.TblUrunler
                          select new
                          {
                              urun.UrunId,
                              urun.UrunAd,
                              urun.Stok,
                              urun.AlisFiyat,
                              urun.SatısFiyat,
                              urun.TblKategori.Ad
                          };
            dataGridView1.DataSource = urunler.ToList();
        }
            

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            Urunlistesi();
            cmbKategori.DataSource = db.TblKategori.ToList();
            cmbKategori.ValueMember = "Id";//Arka
            cmbKategori.DisplayMember = "Ad";//Ön
        }

       
        private void btnListele_Click(object sender, EventArgs e)
        {
            // dataGridView1.DataSource = db.TblUrunler.ToList();
            Urunlistesi();
                       
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblUrunler urun = new TblUrunler();
            urun.UrunAd = txtAd.Text;
            urun.Stok =short.Parse(txtStok.Text);
            urun.AlisFiyat = decimal.Parse(txtA_Fiyat.Text);
            urun.SatısFiyat = decimal.Parse(txtS_Fiyat.Text);
            urun.Kategori =int.Parse(cmbKategori.SelectedValue.ToString());
            db.TblUrunler.Add(urun);
            db.SaveChanges();
            Urunlistesi();

            MessageBox.Show("Ürünler Eklemede Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtId.Text);
            var SilId = db.TblUrunler.Find(Id);
            db.TblUrunler.Remove(SilId);
            db.SaveChanges();
            Urunlistesi();

            MessageBox.Show("Silme İşlemi Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtStok.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtA_Fiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtS_Fiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
           // cmbKategori.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtId.Text);
            var Guncelle = db.TblUrunler.Find(Id);

            Guncelle.UrunAd = txtAd.Text;
            Guncelle.Stok = short.Parse(txtStok.Text);
            Guncelle.AlisFiyat = decimal.Parse(txtA_Fiyat.Text);
            Guncelle.SatısFiyat = decimal.Parse(txtS_Fiyat.Text);
            Guncelle.Kategori = int.Parse(cmbKategori.SelectedValue.ToString());
            db.SaveChanges();
            Urunlistesi();

            MessageBox.Show("Bilgiler Güncellendi..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
