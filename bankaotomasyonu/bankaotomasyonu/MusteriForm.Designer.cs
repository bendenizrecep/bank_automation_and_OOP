
namespace bankaotomasyonu
{
    partial class MusteriForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonParaCek = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txCekmeMiktari = new System.Windows.Forms.TextBox();
            this.txHesapNo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonParaYatir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txYatirMiktar = new System.Windows.Forms.TextBox();
            this.txYatirHesapNo = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHavaleHedef = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHavaleMiktar = new System.Windows.Forms.TextBox();
            this.txtHavaleKaynak = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridHesapOzeti = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridHesaplar = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHesapOzeti)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHesaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 366);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(592, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Para Çekme";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 5);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Geri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonParaCek);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txCekmeMiktari);
            this.groupBox2.Controls.Add(this.txHesapNo);
            this.groupBox2.Location = new System.Drawing.Point(134, 92);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(323, 175);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hesap Bilgileri";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hesap Numarası:";
            // 
            // buttonParaCek
            // 
            this.buttonParaCek.Location = new System.Drawing.Point(130, 127);
            this.buttonParaCek.Margin = new System.Windows.Forms.Padding(2);
            this.buttonParaCek.Name = "buttonParaCek";
            this.buttonParaCek.Size = new System.Drawing.Size(81, 30);
            this.buttonParaCek.TabIndex = 4;
            this.buttonParaCek.Text = "Para Çek";
            this.buttonParaCek.UseVisualStyleBackColor = true;
            this.buttonParaCek.Click += new System.EventHandler(this.buttonParaCek_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Miktar:";
            // 
            // txCekmeMiktari
            // 
            this.txCekmeMiktari.Location = new System.Drawing.Point(152, 92);
            this.txCekmeMiktari.Margin = new System.Windows.Forms.Padding(2);
            this.txCekmeMiktari.Name = "txCekmeMiktari";
            this.txCekmeMiktari.Size = new System.Drawing.Size(111, 20);
            this.txCekmeMiktari.TabIndex = 3;
            this.txCekmeMiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txCekmeMiktari_KeyPress);
            // 
            // txHesapNo
            // 
            this.txHesapNo.Location = new System.Drawing.Point(152, 61);
            this.txHesapNo.Margin = new System.Windows.Forms.Padding(2);
            this.txHesapNo.Name = "txHesapNo";
            this.txHesapNo.Size = new System.Drawing.Size(111, 20);
            this.txHesapNo.TabIndex = 2;
            this.txHesapNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txHesapNo_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(592, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Para Yatırma";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 5);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 24);
            this.button4.TabIndex = 14;
            this.button4.Text = "Geri";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.buttonParaYatir);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txYatirMiktar);
            this.groupBox3.Controls.Add(this.txYatirHesapNo);
            this.groupBox3.Location = new System.Drawing.Point(134, 82);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(323, 158);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hesap Bilgileri";
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hesap Numarası:";
            // 
            // buttonParaYatir
            // 
            this.buttonParaYatir.Location = new System.Drawing.Point(152, 112);
            this.buttonParaYatir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonParaYatir.Name = "buttonParaYatir";
            this.buttonParaYatir.Size = new System.Drawing.Size(111, 26);
            this.buttonParaYatir.TabIndex = 4;
            this.buttonParaYatir.Text = "Para Yatır";
            this.buttonParaYatir.UseVisualStyleBackColor = true;
            this.buttonParaYatir.Click += new System.EventHandler(this.buttonParaYatir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Miktar:";
            // 
            // txYatirMiktar
            // 
            this.txYatirMiktar.Location = new System.Drawing.Point(152, 72);
            this.txYatirMiktar.Margin = new System.Windows.Forms.Padding(2);
            this.txYatirMiktar.Name = "txYatirMiktar";
            this.txYatirMiktar.Size = new System.Drawing.Size(111, 20);
            this.txYatirMiktar.TabIndex = 3;
            this.txYatirMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txYatirMiktar_KeyPress);
            // 
            // txYatirHesapNo
            // 
            this.txYatirHesapNo.Location = new System.Drawing.Point(152, 41);
            this.txYatirHesapNo.Margin = new System.Windows.Forms.Padding(2);
            this.txYatirHesapNo.Name = "txYatirHesapNo";
            this.txYatirHesapNo.Size = new System.Drawing.Size(111, 20);
            this.txYatirHesapNo.TabIndex = 2;
            this.txYatirHesapNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txYatirHesapNo_KeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(592, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Havale / EFT";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 5);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Geri";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtHavaleHedef);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtHavaleMiktar);
            this.groupBox5.Controls.Add(this.txtHavaleKaynak);
            this.groupBox5.Location = new System.Drawing.Point(73, 76);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(446, 187);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Para Gönder";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 47);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Para Gönderilecek Hesap Numarası:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Havale Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 110);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Gönderilecek Tutar:";
            // 
            // txtHavaleHedef
            // 
            this.txtHavaleHedef.Location = new System.Drawing.Point(270, 44);
            this.txtHavaleHedef.Margin = new System.Windows.Forms.Padding(2);
            this.txtHavaleHedef.Name = "txtHavaleHedef";
            this.txtHavaleHedef.Size = new System.Drawing.Size(127, 20);
            this.txtHavaleHedef.TabIndex = 5;
            this.txtHavaleHedef.TextChanged += new System.EventHandler(this.txtHavaleHedef_TextChanged);
            this.txtHavaleHedef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHavaleHedef_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 78);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(209, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Paranın Çekileceği Hesap Numarası:";
            // 
            // txtHavaleMiktar
            // 
            this.txtHavaleMiktar.Location = new System.Drawing.Point(270, 106);
            this.txtHavaleMiktar.Margin = new System.Windows.Forms.Padding(2);
            this.txtHavaleMiktar.Name = "txtHavaleMiktar";
            this.txtHavaleMiktar.Size = new System.Drawing.Size(127, 20);
            this.txtHavaleMiktar.TabIndex = 4;
            this.txtHavaleMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHavaleMiktar_KeyPress);
            // 
            // txtHavaleKaynak
            // 
            this.txtHavaleKaynak.Location = new System.Drawing.Point(270, 78);
            this.txtHavaleKaynak.Margin = new System.Windows.Forms.Padding(2);
            this.txtHavaleKaynak.Name = "txtHavaleKaynak";
            this.txtHavaleKaynak.Size = new System.Drawing.Size(127, 20);
            this.txtHavaleKaynak.TabIndex = 3;
            this.txtHavaleKaynak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHavaleKaynak_KeyPress);
            // 
            // tabPage4
            // 
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage4.Controls.Add(this.button8);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.dataGridHesapOzeti);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(592, 340);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Hesap Özeti";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(116, 7);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 32);
            this.button8.TabIndex = 15;
            this.button8.Text = "Listele";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(4, 13);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 21);
            this.button6.TabIndex = 14;
            this.button6.Text = "Geri";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridHesapOzeti
            // 
            this.dataGridHesapOzeti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridHesapOzeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHesapOzeti.Location = new System.Drawing.Point(4, 47);
            this.dataGridHesapOzeti.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridHesapOzeti.Name = "dataGridHesapOzeti";
            this.dataGridHesapOzeti.RowHeadersWidth = 49;
            this.dataGridHesapOzeti.RowTemplate.Height = 24;
            this.dataGridHesapOzeti.Size = new System.Drawing.Size(588, 289);
            this.dataGridHesapOzeti.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage5.Controls.Add(this.button7);
            this.tabPage5.Controls.Add(this.dataGridHesaplar);
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(592, 340);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Hesaplarım";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(4, 15);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 27);
            this.button7.TabIndex = 14;
            this.button7.Text = "Geri";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridHesaplar
            // 
            this.dataGridHesaplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridHesaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHesaplar.Location = new System.Drawing.Point(4, 46);
            this.dataGridHesaplar.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridHesaplar.Name = "dataGridHesaplar";
            this.dataGridHesaplar.RowHeadersWidth = 49;
            this.dataGridHesaplar.RowTemplate.Height = 24;
            this.dataGridHesaplar.Size = new System.Drawing.Size(586, 294);
            this.dataGridHesaplar.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "Listele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MusteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MusteriForm";
            this.Text = "MusteriForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHesapOzeti)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHesaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonParaCek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txCekmeMiktari;
        private System.Windows.Forms.TextBox txHesapNo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonParaYatir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txYatirMiktar;
        private System.Windows.Forms.TextBox txYatirHesapNo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHavaleHedef;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtHavaleMiktar;
        private System.Windows.Forms.TextBox txtHavaleKaynak;
        private System.Windows.Forms.DataGridView dataGridHesapOzeti;
        private System.Windows.Forms.DataGridView dataGridHesaplar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}