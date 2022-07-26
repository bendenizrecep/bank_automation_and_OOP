using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankaotomasyonu
{
    partial class PersonelForm : Form
    {
        public PersonelForm()
        {
            InitializeComponent();
            this.banka = banka;
        }
        
        public PersonelForm(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
        }
        Banka banka;
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        

        private void button_Click(object sender, EventArgs e) //hesap sil
        {
            Db Database = new Db();
            int hesapNo = Convert.ToInt32(txtHesapNo.Text);
            if (txtHesapNo.Text == "")
            {
                MessageBox.Show("Lütfen Geçerli Alanları Boş Bırakamayın");
            }
            else
            {
                MessageBox.Show(Database.HesapSil(hesapNo));
                string rapor = hesapNo + " kullanıcı adına sahip Bireysel Müşterinin " + hesapNo + " numaralı hesabı silindi.";
                DateTime tarih = DateTime.Today;
                Rapor raporekle = new Rapor();
                raporekle.rapor = rapor;
                raporekle.tarih = tarih;
                Db.RaporEkle(raporekle);
            }
        }

        private void buttonMusteriKayit_Click(object sender, EventArgs e)
        {
            if (radioBireysel.Checked == true)
            { //Bireysel Müşteri ekleniyorsa

                bool musteriTipi = true;
                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                string kullaniciAdi = txtNo.Text;
                string sifre = txtSifre.Text;
                DateTime tarih = dateTimeMusteri.Value;

                txtAd.Clear();
                txtSoyad.Clear();
                txtNo.Clear();
                txtSifre.Clear();

                BireyselMusteri BireyselMusteri = new BireyselMusteri();
                BireyselMusteri.Ad = ad;
                BireyselMusteri.Soyad = soyad;
                BireyselMusteri.ID = kullaniciAdi;
                BireyselMusteri.Sifre = sifre;
                BireyselMusteri.Tarih = tarih;
                BireyselMusteri.musteriTipi = "bireysel";
                BireyselMusteri.musteriTuru = true;
                MessageBox.Show(Db.MusteriEkle(BireyselMusteri));


                string rapor = kullaniciAdi + " kullanıcı adına sahip " + ad + " " + soyad + " kişisi Bireysel Müşteri olarak bankaya eklendi.";
                Rapor raporekle = new Rapor();
                raporekle.rapor = rapor;
                raporekle.tarih = tarih;
                Db.RaporEkle(raporekle);
                
            }
            else if (radioTicari.Checked == true) //Ticari Müşteri Ekleniyorsa
            {
                bool musteriTipi = false;
                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                string kullaniciAdi = txtNo.Text;
                string sifre = txtSifre.Text;
                DateTime tarih = dateTimeMusteri.Value;

                TicariMusteri TicariMusteri = new TicariMusteri();
                TicariMusteri.Ad = ad;
                TicariMusteri.Soyad = soyad;
                TicariMusteri.ID = kullaniciAdi;
                TicariMusteri.Sifre = sifre;
                TicariMusteri.Tarih = tarih;
                MessageBox.Show(Db.TicariMusteriEkle(TicariMusteri));


                string rapor = kullaniciAdi + " kullanıcı adına sahip " + ad + " " + soyad + " kişisi Ticari Müşteri olarak bankaya eklendi.";
                Rapor raporekle = new Rapor();
                raporekle.rapor = rapor;
                raporekle.tarih = tarih;
                Db.RaporEkle(raporekle);
            }
            else //Müşteri tipi girilmemişse
            {
                MessageBox.Show("Lütfen müşteri tipini seçiniz.");
            }
        }

        private void buttonHesapAc_Click(object sender, EventArgs e)
        {
            string musteriNo = txtMusteriNo.Text;
            int ekBakiye = Convert.ToInt32(txtEkBakiye.Text);
            List<BireyselMusteri> musterigiris = Db.MusterileriGetir();
            List<TicariMusteri> ticarigiris = Db.TicariMusterileriGetir();
            foreach (BireyselMusteri m in musterigiris)//Müşteri bireysel müşteri mi kontrol ediyoruz
            {
                if (musteriNo == m.ID)
                {

                    Hesap hesapac = new Hesap();
                    hesapac.ekBakiye = ekBakiye;
                    hesapac.No = Convert.ToInt32(musteriNo);
                    MessageBox.Show(Db.HesapAc(hesapac));
                    string rapor = m.ID + " kullanıcı adına sahip Bireysel Müşteri için yeni hesap açıldı";
                    DateTime tarih = DateTime.Today;
                    Rapor raporekle = new Rapor();
                    raporekle.rapor = rapor;
                    raporekle.tarih = tarih;
                    Db.RaporEkle(raporekle);
                }
            }
            foreach (TicariMusteri m in ticarigiris)//Müşteri ticari müşteri mi kontrol ediyoruz
            {
                if (musteriNo == m.ID)
                {
                    Hesap hesapac = new Hesap();
                    hesapac.ekBakiye = ekBakiye;
                    hesapac.No = Convert.ToInt32(musteriNo);
                    Db.HesapAc(hesapac);

                    string rapor = m.ID + " kullanıcı adına sahip Ticari Müşteri için yeni hesap açıldı";
                    DateTime tarih = DateTime.Today;
                    Rapor raporekle = new Rapor();
                    raporekle.rapor = rapor;
                    raporekle.tarih = tarih;
                    Db.RaporEkle(raporekle);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = f1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            GirisForm f3 = new GirisForm(banka);
            f3.TopLevel = false;
            panel1.Controls.Add(f3);
            f3.Show();
            f3.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = f1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            GirisForm f3 = new GirisForm(banka);
            f3.TopLevel = false;
            panel1.Controls.Add(f3);
            f3.Show();
            f3.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = f1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            GirisForm f3 = new GirisForm(banka);
            f3.TopLevel = false;
            panel1.Controls.Add(f3);
            f3.Show();
            f3.Dock = DockStyle.Fill;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMusteriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtEkBakiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = f1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            GirisForm f3 = new GirisForm(banka);
            f3.TopLevel = false;
            panel1.Controls.Add(f3);
            f3.Show();
            f3.Dock = DockStyle.Fill;
        }

        private void hListeleButton_Click(object sender, EventArgs e)
        {
            Db Database = new Db();
            dataGridView1.DataSource = Database.HesapListele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = f1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            GirisForm f3 = new GirisForm(banka);
            f3.TopLevel = false;
            panel1.Controls.Add(f3);
            f3.Show();
            f3.Dock = DockStyle.Fill;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Db Database = new Db();
            dataGridView2.DataSource = Database.MusteriListele();
        }
    }
}
