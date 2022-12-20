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
    public partial class frmIstatistikler : Form
    {
        public frmIstatistikler()
        {
            InitializeComponent();
        }

        DbUrunEntities db = new DbUrunEntities();

        private void frmIstatistikler_Load(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;

            lblMusteri.Text = db.TblMusteri.Count().ToString();
            lblKategori.Text = db.TblKategori.Count().ToString();
            lblUrun.Text = db.TblUrunler.Count().ToString();
            lblBeyaz.Text = db.TblUrunler.Count(x => x.Kategori == 1).ToString();
            lblToplamS.Text = db.TblUrunler.Sum(x => x.Stok).ToString();
            lblBuGunS_A.Text = db.TblSatislar.Count(x => x.Tarih == bugun).ToString();
            lblBuGunKasaTutar.Text = db.TblSatislar.Sum(x => x.Toplam).ToString() + " ₺";
            lblToplamKasaTutar.Text = db.TblSatislar.Where(y => y.Tarih == bugun).Sum(x => x.Toplam).ToString() + " ₺";
           
            lblEnYuksekFiyat.Text = (from y in db.TblUrunler
                                     orderby y.SatısFiyat descending
                                     select y.UrunAd).FirstOrDefault();
            lblEnDusukFiyatU.Text = (from x in db.TblUrunler
                                     orderby x.SatısFiyat ascending
                                     select x.UrunAd).FirstOrDefault();
            lblEnFazlaStoklu.Text = (from xy in db.TblUrunler
                                     orderby xy.Stok descending
                                     select xy.UrunAd).FirstOrDefault();
            lblEnAzStoklu.Text = (from yx in db.TblUrunler
                                  orderby yx.Stok ascending
                                  select yx.UrunAd).FirstOrDefault();


            



        }
    }
}
