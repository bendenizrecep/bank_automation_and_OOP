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
    partial class MusteriForm : Form
    {
        //konstrakçır
        public MusteriForm(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;

        }
        public MusteriForm(Banka banka, BireyselMusteri bireyselMusteri)
        {
            InitializeComponent();
            this.banka = banka;
            this.bireyselMusteri =bireyselMusteri ;
            musteri = true;
        }
        public MusteriForm(Banka banka, TicariMusteri ticariMusteri)
        {
            InitializeComponent();
            this.banka = banka;
            this.ticariMusteri = ticariMusteri ;
            musteri = false;
        }
        Banka banka;
        BireyselMusteri bireyselMusteri;
        TicariMusteri ticariMusteri;
        bool musteri;
        private void button1_Click(object sender, EventArgs e) //havale
        {
            Db Database = new Db();
            int musterino;
            Rapor rapor = new Rapor();
            int kaynakNo = Convert.ToInt32(txtHavaleKaynak.Text);
            int hedefNo = Convert.ToInt32(txtHavaleHedef.Text);
            int miktar = Convert.ToInt32(txtHavaleMiktar.Text);
            int Kaynakbakiye = Database.HesapBakiyeGetir(kaynakNo);
            int hedefbakiye = Database.HesapBakiyeGetir(hedefNo);
            decimal kaynakgerikalan = Kaynakbakiye - miktar;
            decimal hedeftotal = hedefbakiye + miktar;
            if (kaynakgerikalan < 0)
            {
                MessageBox.Show("Hesap Bakiyeniz Bu İşlem İçin Yetersiz");
            }
            else
            {
                if (ticariMusteri == null)
                {
                    musterino = Convert.ToInt32(bireyselMusteri.ID);
                }
                else
                {
                    musterino = Convert.ToInt32(ticariMusteri.ID);
                }
                rapor.Musterino = musterino;
                rapor.rapor = "'"+musterino+"' Numaralı Hesap,"+hedefNo+" Numaralı Hesaba "+miktar+" Tl gönderdi";
                rapor.tarih = DateTime.Today;
                MessageBox.Show(Database.HesapBakiyeYatir(kaynakNo, kaynakgerikalan));
                MessageBox.Show(Database.HesapBakiyeYatir(hedefNo, hedeftotal));
                MessageBox.Show(Database.ParaRaporEkle(rapor));
            }
            

        }

        private void button2_Click(object sender, EventArgs e) //hesap listeleme
        {
            Db Database = new Db();
            if (musteri == true) //Giriş yapan bireysel müşteri ise
                dataGridHesaplar.DataSource = Database.MusteriHesapListele(bireyselMusteri.ID);
            else
                dataGridHesaplar.DataSource = Database.MusteriHesapListele(ticariMusteri.ID);
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
            Form1 f1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = f1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();
            GirisForm f3 = new GirisForm(banka);
            f3.TopLevel = false;
            panel1.Controls.Add(f3);
            f3.Show();
            f3.Dock = DockStyle.Fill;
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
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

        private void buttonParaCek_Click(object sender, EventArgs e)
        {
            Db Database = new Db();
            Rapor rapor = new Rapor();
            int musterino;
            int hesapNo = Convert.ToInt32(txHesapNo.Text);
            decimal miktar = Convert.ToDecimal(txCekmeMiktari.Text);
            int hesapbakiye = Database.HesapBakiyeGetir(hesapNo);
            decimal total = hesapbakiye - miktar;
            if (ticariMusteri == null)
            {
                musterino = Convert.ToInt32(bireyselMusteri.ID);
            }
            else
            {
                musterino = Convert.ToInt32(ticariMusteri.ID);
            }
            rapor.Musterino = musterino;
            rapor.rapor = ("'" + hesapbakiye + "' TL bakiyeden, '" + miktar + "' Tl Ek Bakiyeden çekilmiştir.");
            rapor.tarih = DateTime.Today;
            if (total < 0)
            {
                MessageBox.Show("Bakiye Limiti Yetersiz");
            }
            else
            {
                MessageBox.Show(Database.HesapBakiyeYatir(hesapNo, total));
                MessageBox.Show(Database.ParaRaporEkle(rapor));
            }
        }

        private void buttonParaYatir_Click(object sender, EventArgs e)
        {
            Db Database = new Db();
            Rapor rapor = new Rapor();
            int musterino;
            int hesapNo = Convert.ToInt32(txYatirHesapNo.Text);
            decimal miktar = Convert.ToDecimal(txYatirMiktar.Text);
            int hesapbakiye = Database.HesapBakiyeGetir(hesapNo);
            decimal total = miktar + hesapbakiye;
            if (ticariMusteri == null)
            {
                musterino = Convert.ToInt32(bireyselMusteri.ID);
            }
            else
            {
                musterino = Convert.ToInt32(ticariMusteri.ID);
            }
            rapor.Musterino = musterino;
            rapor.rapor = "'" + miktar + "' TL yatırıldı.";
            rapor.tarih = DateTime.Today;
            MessageBox.Show(Database.HesapBakiyeYatir(hesapNo,total));
            MessageBox.Show(Database.ParaRaporEkle(rapor));

        }


        private void txHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txCekmeMiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txYatirHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txYatirMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtHavaleKaynak_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtHavaleHedef_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtHavaleMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txOzetHesapNo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txOzetHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtHavaleHedef_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e) //hesap özeti
        {
            int musterino;
            if (ticariMusteri == null)
            {
                musterino = Convert.ToInt32(bireyselMusteri.ID);
            }
            else
            {
                musterino = Convert.ToInt32(ticariMusteri.ID);
            }
            Db Database = new Db();
            dataGridHesapOzeti.DataSource = Database.ParaRaporMusteri(musterino);
        }
    }
}
