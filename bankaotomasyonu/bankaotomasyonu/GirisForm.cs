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
    partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        public GirisForm(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
        }
        Banka banka;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Form1 f1 = Application.OpenForms["Form1"] as Form1;
            Panel panel1 = f1.Controls["panel1"] as Panel;
            panel1.Controls.Clear();

            YoneticiForm formYonetici = new YoneticiForm(banka);
            formYonetici.TopLevel = false;
            panel1.Controls.Add(formYonetici);
            formYonetici.Show();
            formYonetici.Dock = DockStyle.Fill;
        }

        private void buttonPersonel_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            List<personel> personellist =  Db.PersonelleriGetir();

            foreach (personel p in personellist)
            {
                if (kullaniciAdi == p.ID && sifre == p.Sifre)
                {
                    Form1 f1 = Application.OpenForms["Form1"] as Form1;
                    Panel panel1 = f1.Controls["panel1"] as Panel;
                    panel1.Controls.Clear();

                    PersonelForm formPersonel = new PersonelForm();
                    formPersonel.TopLevel = false;
                    panel1.Controls.Add(formPersonel);
                    formPersonel.Show();
                    formPersonel.Dock = DockStyle.Fill;
                    MessageBox.Show("Hoşgeldiniz. Sayın " + p.Ad + " " + p.Soyad);
                }
            }
        }

        private void buttonMusteri_Click(object sender, EventArgs e)
        {
            List<BireyselMusteri> musterigiris = Db.MusterileriGetir();
            List<TicariMusteri> Tmusterigiris = Db.TicariMusterileriGetir();
            string musteriNo = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            foreach (BireyselMusteri m in musterigiris)
            {
                if (musteriNo == m.ID && sifre == m.Sifre)
                {
                    Form1 f1 = Application.OpenForms["Form1"] as Form1;
                    Panel panel1 = f1.Controls["panel1"] as Panel;
                    panel1.Controls.Clear();
                    MusteriForm formMusteri = new MusteriForm(banka, m);
                    formMusteri.TopLevel = false;
                    panel1.Controls.Add(formMusteri);
                    formMusteri.Show();
                    formMusteri.Dock = DockStyle.Fill;

                    MessageBox.Show("Hoşgeldiniz Sayın " + m.Ad + " " + m.Soyad);
                }
            }
            foreach (TicariMusteri m in Tmusterigiris)
            {
                if (musteriNo == m.ID && sifre == m.Sifre)
                {
                    Form1 f1 = Application.OpenForms["Form1"] as Form1;
                    Panel panel1 = f1.Controls["panel1"] as Panel;
                    panel1.Controls.Clear();
                    MusteriForm formMusteri = new MusteriForm(banka, m);
                    formMusteri.TopLevel = false;
                    panel1.Controls.Add(formMusteri);
                    formMusteri.Show();
                    formMusteri.Dock = DockStyle.Fill;

                    MessageBox.Show("Hoşgeldiniz Sayın " + m.Ad + " " + m.Soyad);
                }
            }
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {

        }
    }
}
