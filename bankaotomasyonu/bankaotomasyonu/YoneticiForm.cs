using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;


namespace bankaotomasyonu
{
    partial class YoneticiForm : Form
    {
        public YoneticiForm(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
            
        }
        Banka banka;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Ad = txtPersonelAd.Text; 
            string Soyad = txtPersonelSoyad.Text;
            string ID = txtPersonelID.Text;
            string Sifre = txtPersonelSifre.Text;

            txtPersonelAd.Clear(); //Personel eklendikten sonra textBoxları temizliyoruz.
            txtPersonelSoyad.Clear();
            txtPersonelID.Clear();
            txtPersonelSifre.Clear();

            //banka.PersonelEkle(Ad, Soyad, ID, Sifre);   

            string rapor = ID + " kullanıcı adına sahip kişi bankaya personel olarak eklendi.";
            DateTime tarih = DateTime.Today;
            Rapor raporekle = new Rapor();
            raporekle.rapor = rapor;
            raporekle.tarih = tarih;
            Db.RaporEkle(raporekle);

            personel p = new personel();
            p.Ad = Ad;
            p.Soyad = Soyad;
            p.ID = ID;
            p.Sifre = Sifre;
            Db.PersonelEkle(p);
            List<personel> personellist = Db.PersonelleriGetir();



            //this.gridPersonelListele.DataSource = banka.personeller; //ram'de çalışan liste
            this.gridPersonelListele.DataSource = personellist; //db'den çekilen liste

        }

        private void labelTopPara_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void buttonGeri_Click(object sender, EventArgs e)
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

        private void buttonPersonelSil_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtIDSil.Text;
            txtIDSil.Clear();
            string rapor = kullaniciAdi + " kullanıcı adına sahip personel silindi.";
            DateTime tarih = DateTime.Today;
            Rapor raporekle = new Rapor();
            raporekle.rapor = rapor;
            raporekle.tarih = tarih;
            Db.RaporEkle(raporekle);

            //db
            Db.PersoneliSil(kullaniciAdi);
            List<personel> personellist = Db.PersonelleriGetir();
            this.gridPersonelListele.DataSource = personellist;


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBankaIslemList_Click(object sender, EventArgs e)
        {
            Db Database = new Db();
            dataGridBankaIslemListele.DataSource = Database.RaporListele();
            dataGridView1.DataSource = Database.ParaRaporListele();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtPersonelAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtPersonelSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void gridPersonelListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridBankaIslemListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //personel lsitele
        {
            Db Database = new Db();
            gridPersonelListele.DataSource = Database.PersonelListele();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e) //musteri listelem
        {
            Db Database = new Db();
            dataGridView2.DataSource = Database.MusteriListele();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
