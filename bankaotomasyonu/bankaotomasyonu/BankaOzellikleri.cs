using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaotomasyonu
{
    public interface BankaOzellikleri
    {
        void MusteriEkle(bool musteriTipi, string ad, string soyad, string ID, string sifre, DateTime tarih);
        void PersonelEkle(string ad, string soyad, string ID, string sifre);
        void PersonelSil(string kullaniciAdi);
    }
}
