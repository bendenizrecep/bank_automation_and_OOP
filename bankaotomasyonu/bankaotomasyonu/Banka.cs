using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaotomasyonu
{
    class Banka : BankaOzellikleri, RaporOzellikleri
    {
        public List<personel> personeller = new List<personel>();
        public List<BireyselMusteri> BireyselMusteriler = new List<BireyselMusteri>();
        public List<TicariMusteri> TicariMusteriler = new List<TicariMusteri>();
        public List<Rapor> BankaRaporListesi = new List<Rapor>();
        public decimal toplamPara { get; set; }

        personel p;
        BireyselMusteri bireyselMusteri;
        TicariMusteri ticariMusteri;
        Rapor r;
        string rapor;
        DateTime tarih;

        public void MusteriEkle(bool musteriTipi, string ad, string soyad, string ID, string sifre, DateTime tarih)
        {
            if (musteriTipi == true)
            {
                bireyselMusteri = new BireyselMusteri();

                this.bireyselMusteri.Ad = ad;
                this.bireyselMusteri.Soyad = soyad;
                this.bireyselMusteri.ID = ID;
                this.bireyselMusteri.Sifre = sifre;
                this.bireyselMusteri.Tarih = tarih;
                this.bireyselMusteri.musteriTipi = "Bireysel";

                BireyselMusteriler.Add(bireyselMusteri);
                System.Windows.Forms.MessageBox.Show("Bireysel Müşteri Başarıyla Eklendi.");

                rapor = ("'" + ID + "'ID Numaralı Bireysel Müşteri Başarıyla Eklendi");
                tarih = DateTime.Today;
                RaporEkle(rapor, tarih);
            }
            else
            {
                ticariMusteri = new TicariMusteri();

                ticariMusteri.Ad = ad;
                ticariMusteri.Soyad = soyad;
                ticariMusteri.ID = ID;
                ticariMusteri.Sifre = sifre;
                ticariMusteri.Tarih = tarih;
                ticariMusteri.musteriTipi = "Ticari";

                TicariMusteriler.Add(ticariMusteri);
                System.Windows.Forms.MessageBox.Show("Ticari Müşteri Başarıyla Eklendi.");

                rapor = ("'" + ID + "'Id Numaralı Ticari Müşteri Başarıyla Eklemti");
                tarih = DateTime.Today;
                RaporEkle(rapor, tarih);
            }
        }

        public void PersonelEkle(string ad, string soyad, string ID, string sifre)
        {
            p = new personel();

            this.p.Ad = ad;
            this.p.Soyad = soyad;
            this.p.ID = ID;
            this.p.Sifre = sifre;

            personeller.Add(p);
            System.Windows.Forms.MessageBox.Show("Personel Başarıyla Eklendi.");

            rapor = ("'" + ID + "'Personel Başarıyla Eklendi");
            tarih = DateTime.Today;
            RaporEkle(rapor, tarih);
        }

        public void PersonelSil(string kullaniciAdi)
        {
            foreach (personel p in personeller.ToList())
            {
                if (kullaniciAdi == p.ID)
                {
                    personeller.Remove(p);
                    System.Windows.Forms.MessageBox.Show("Personel Silindi.");
                }
            }
            rapor = ("'" + kullaniciAdi + "'Personel Başarıyla Silindi");
            tarih = DateTime.Today;
            RaporEkle(rapor, tarih);
        }

        public void RaporEkle(string rapor, DateTime tarih)
        {
            r = new Rapor();
            r.rapor = rapor;
            r.tarih = tarih;
            BankaRaporListesi.Add(r);
        }


    }
}
