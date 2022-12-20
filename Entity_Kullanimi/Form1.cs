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
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        DbUrunEntities db = new DbUrunEntities();//Global Tannımla
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            // dataGridView1.DataSource = db.TblMusteri.ToList();
            var degerler = from Listele in db.TblMusteri
                           select new
                           {
                               Listele.MusteriId,
                               Listele.Ad,
                               Listele.Soyad,
                               Listele.Bakiye,
                               Listele.Sehir
                           };
            dataGridView1.DataSource = degerler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            /*
            TblMusteri Ekle = new TblMusteri
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Bakiye = decimal.Parse(txtBakiye.Text),
                Sehir = txtSehir.Text
            };
            db.TblMusteri.Add(Ekle);
            db.SaveChanges();
            */

            TblMusteri MusteriEkle = new TblMusteri();
            MusteriEkle.Ad = txtAd.Text;
            MusteriEkle.Soyad = txtSoyad.Text;
            MusteriEkle.Bakiye = decimal.Parse(txtBakiye.Text);
            MusteriEkle.Sehir = txtSehir.Text;
            db.TblMusteri.Add(MusteriEkle);
            db.SaveChanges();

            MessageBox.Show("Ekleme işlemi Başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtId.Text);
            var SilinenId = db.TblMusteri.Find(Id);
            db.TblMusteri.Remove(SilinenId);
            db.SaveChanges();

            MessageBox.Show("Müsteri Sistemden Silindi..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtId.Text);

            var Guncelle = db.TblMusteri.Find(Id);
            Guncelle.Ad = txtAd.Text;
            Guncelle.Soyad = txtSoyad.Text;
            Guncelle.Bakiye = decimal.Parse(txtBakiye.Text);
            db.SaveChanges();

            MessageBox.Show("Güncelleme işlemi Başarılı..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
