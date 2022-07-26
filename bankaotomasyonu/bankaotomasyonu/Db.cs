using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace bankaotomasyonu
{
    public class Db
    {
      
        private static string connStr = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=bankaDB)));User Id=SYSTEM;Password=bankadmin; Provider=oraoledb.oracle";

        //VERİTABANINDAN VERİLERİ OKUYORUZ
        public static BireyselMusteri DataReaderToMusteri(OleDbDataReader dr)
        {
            var musteri = new BireyselMusteri();
            musteri.ID = dr["ID"].ToString();
            musteri.Ad = dr["Ad"].ToString();
            musteri.Soyad = dr["Soyad"].ToString();
            musteri.Sifre = dr["Sifre"].ToString();
            musteri.Tarih = Convert.ToDateTime(dr["Tarih"].ToString());
            musteri.musteriTipi = dr["musteriTipi"].ToString();

            return musteri;
        }   
        public static TicariMusteri DataReaderToTicariMusteri(OleDbDataReader dr)
        {
            var musteri = new TicariMusteri();
            musteri.ID = dr["ID"].ToString();
            musteri.Ad = dr["Ad"].ToString();
            musteri.Soyad = dr["Soyad"].ToString();
            musteri.Sifre = dr["Sifre"].ToString();
            musteri.Tarih = Convert.ToDateTime(dr["Tarih"].ToString());
            musteri.musteriTipi = dr["musteriTipi"].ToString();

            return musteri;
        }
        public static personel DataReaderToPersonel(OleDbDataReader dr)
        {
            var personel = new personel();
            personel.ID = dr["ID"].ToString();
            personel.Ad = dr["Ad"].ToString();
            personel.Soyad = dr["Soyad"].ToString();
            personel.Sifre = dr["Sifre"].ToString();


            return personel;
        }
        //LERİ HEPSİNİ GETİR BİR TANE
        public static List<BireyselMusteri> MusterileriGetir()
        {
            var list = new List<BireyselMusteri>();

            OleDbConnection conn = new OleDbConnection(connStr);
            string commandText = "select * from Musteri where MUSTERITIPI = 'Bireysel'";
            OleDbCommand cmd = new OleDbCommand(commandText, conn);

            cmd.Connection.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    var musteri = DataReaderToMusteri(dr);

                    list.Add(musteri);
                }
            }

            return list;
        }
        public static BireyselMusteri MusteriGetir(string id)
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            string commandText = "select * from Musteri where ID=(:M_ID)";
            OleDbCommand cmd = new OleDbCommand(commandText, conn);
            cmd.Parameters.Add(new OleDbParameter("M_ID", id));
            var musteri = new BireyselMusteri();

            cmd.Connection.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    musteri = DataReaderToMusteri(dr);
                }
            }

            return musteri;
        }

        public static personel PersonelGetir(string id)
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            string commandText = "select * from personel where ID=(:P_ID)";
            OleDbCommand cmd = new OleDbCommand(commandText, conn);
            cmd.Parameters.Add(new OleDbParameter("P_ID", id));
            var personel = new personel();

            cmd.Connection.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    personel = DataReaderToPersonel(dr);
                }
            }

            return personel;
        }
        

        public static string MusteriEkle(BireyselMusteri musteri)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(connStr);
                string commandText = "insert into Musteri (ID,AD,SOYAD,SIFRE,TARIH,MUSTERITIPI) values(:M_ID, :M_AD, :M_SOYAD, :M_SIFRE, :M_TARIH, :M_MUSTERITIPI)";

                OleDbCommand cmd = new OleDbCommand(commandText, conn);

                cmd.Parameters.AddWithValue("M_ID", musteri.ID);
                cmd.Parameters.AddWithValue("M_AD", musteri.Ad);
                cmd.Parameters.AddWithValue("M_SOYAD", musteri.Soyad);
                cmd.Parameters.AddWithValue("M_SIFRE", musteri.Sifre);
                cmd.Parameters.AddWithValue("M_TARIH", musteri.Tarih);
                cmd.Parameters.AddWithValue("M_MUSTERITIPI", "Bireysel");



                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return "Başarılı";
            }
            catch 
            {

                return "Bir Kullanıcı adi ile sadece 1 Kez Hesap Açabilirsiniz";
            }
        }
        public static string TicariMusteriEkle(TicariMusteri musteri)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(connStr);
                string commandText = "insert into Musteri (ID,Ad,Soyad,Sifre,Tarih,musteriTipi) values(:M_ID, :M_AD, :M_SOYAD, :M_SIFRE, :M_TARIH, :M_MUSTERITIPI)";
                OleDbCommand cmd = new OleDbCommand(commandText, conn);

                cmd.Parameters.AddWithValue("M_ID", musteri.ID);
                cmd.Parameters.AddWithValue("M_AD", musteri.Ad);
                cmd.Parameters.AddWithValue("M_SOYAD", musteri.Soyad);
                cmd.Parameters.AddWithValue("M_SIFRE", musteri.Sifre);
                cmd.Parameters.AddWithValue("M_TARIH", musteri.Tarih);
                cmd.Parameters.AddWithValue("M_MUSTERITIPI", "Ticari");

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return "Başarılı";
            }
            catch 
            {

                return "Bir Kullanıcı adi ile sadece 1 Kez Hesap Açabilirsiniz";
            }
            
        }
        public static List<TicariMusteri> TicariMusterileriGetir()
        {
            var list = new List<TicariMusteri>();

            OleDbConnection conn = new OleDbConnection(connStr);
            string commandText = "select * from Musteri where MUSTERITIPI = 'Ticari'";
            OleDbCommand cmd = new OleDbCommand(commandText, conn);

            cmd.Connection.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    var musteri = DataReaderToTicariMusteri(dr);

                    list.Add(musteri);
                }
            }

            return list;
        }


        public static void MusteriGuncelle(BireyselMusteri musteri)
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            string commandText = "update Musteri set Ad=(:M_AD), Soyad=(:M_SOYAD), Sifre=(:M_SIFRE), Tarih=(:M_TARIH), musteriTipi=(:M_MUSTERITIPI) where ID=(:M_ID)";
            OleDbCommand cmd = new OleDbCommand(commandText, conn);

            cmd.Parameters.AddWithValue("M_ID", musteri.ID);
            cmd.Parameters.AddWithValue("M_AD", musteri.Ad);
            cmd.Parameters.AddWithValue("M_SOYAD", musteri.Soyad);
            cmd.Parameters.AddWithValue("M_SIFRE", musteri.Sifre);
            cmd.Parameters.AddWithValue("M_TARIH", musteri.Tarih);
            cmd.Parameters.AddWithValue("M_MUSTERITIPI", musteri.musteriTipi);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static void MusteriSil(string id)
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            string commandText = "delete from Musteri  where ID=(:M_ID)";
            OleDbCommand cmd = new OleDbCommand(commandText, conn);

            cmd.Parameters.AddWithValue("M_ID", id);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static List<personel> PersonelleriGetir()
        {
            var list = new List<personel>();

            OleDbConnection conn = new OleDbConnection(connStr);
            //OleDbConnection con = new OleDbConnection(connStr);
            string commandText = "select * from Personel";

            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(commandText, conn);
            //OleDbCommand cmd = new OleDbCommand(commandText, con);

            cmd.Connection.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    var personel = DataReaderToPersonel(dr);

                    list.Add(personel);
                }
            }

            return list;
        }
        public static void PersonelEkle(personel p)
        {
            OleDbConnection conn = new OleDbConnection(connStr);


            string commandText = "insert into Personel (Id,Ad,Soyad,Sifre) values(:P_ID, :P_AD, :P_SOYAD, :P_SIFRE)";

            OleDbCommand cmd = new OleDbCommand(commandText, conn);

            cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("P_ID", p.ID));
            cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("P_AD", p.Ad));
            cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("P_SOYAD", p.Soyad));
            cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("P_SIFRE", p.Sifre));

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static void PersoneliSil(string id)
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            string commandText = "delete from personel  where ID=(:P_ID)";
            OleDbCommand cmd = new OleDbCommand(commandText, conn);

            cmd.Parameters.Add(new OleDbParameter("P_ID", id));

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public static string HesapAc(Hesap hesap)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(connStr);
                string commandText = "insert into Hesap (MUSTERİNO,EKBAKİYE) values(:H_NO, :H_EKBAKİYE)";

                OleDbCommand cmd = new OleDbCommand(commandText, conn);

                cmd.Parameters.AddWithValue("H_ID", hesap.No);
                cmd.Parameters.AddWithValue("H_EKBAKİYE", hesap.ekBakiye);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return "Başarılı";
            }
            catch
            {
                return "Sadece 1 Kez Hesap Açabilirsiniz";
            }
            
        }
        public string HesapSil(int id)
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            string commandText = "delete from HESAP  where NO=(:M_ID)";
            OleDbCommand cmd = new OleDbCommand(commandText, conn);

            cmd.Parameters.AddWithValue("M_ID", id);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return "Silme İşlemi Başarılı";
        }
        public static void RaporEkle(Rapor rapor)
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            string commandText = "insert into Rapor (RAPOR,TARIH) values(:R_RAPOR, :R_TARIH)";

            OleDbCommand cmd = new OleDbCommand(commandText, conn);

            cmd.Parameters.AddWithValue("R_RAPOR", rapor.rapor);
            cmd.Parameters.AddWithValue("R_TARIH", rapor.tarih);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public DataTable RaporListele()
        {
            
            OleDbConnection conn = new OleDbConnection(connStr);
            string commandText = "select * from RAPOR";
            OleDbCommand cmd = new OleDbCommand(commandText, conn);
            cmd.Connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Connection.Close();
            return dt;
        }
        public DataTable HesapListele()
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            string commandText = "select * from HESAP";
            OleDbCommand cmd = new OleDbCommand(commandText, conn);
            cmd.Connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Connection.Close();
            return dt;
        }
        int Bakiye;
        public int HesapBakiyeGetir(int id)
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            string commandText = "select EKBAKİYE from HESAP where NO=(:M_ID)";
            OleDbCommand cmd = new OleDbCommand(commandText, conn);
            cmd.Parameters.Add(new OleDbParameter("M_ID", id));
            cmd.Connection.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Bakiye = Convert.ToInt32(dr["EKBAKİYE"]);
            }
            cmd.Connection.Close();
            return Bakiye;
        }

        public string HesapBakiyeYatir(int id, decimal bakiye)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(connStr);
                string commandText = "update HESAP set EKBAKİYE=(:M_BAKİYE) where NO=(:M_ID)";
                OleDbCommand cmd = new OleDbCommand(commandText, conn);

                cmd.Parameters.AddWithValue("M_BAKİYE", bakiye);
                cmd.Parameters.AddWithValue("M_ID", id);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return "Başarılı";
            }
            catch (Exception hata)
            {

                return hata.ToString();
            }
        }

        public string ParaRaporEkle(Rapor rapor)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(connStr);
                string commandText = "insert into PARARAPOR (RAPOR,TARIH,MUSTERİNO) values(:R_RAPOR, :R_TARIH, :R_Musterino)";

                OleDbCommand cmd = new OleDbCommand(commandText, conn);

                cmd.Parameters.AddWithValue("R_RAPOR", rapor.rapor);
                cmd.Parameters.AddWithValue("R_TARIH", rapor.tarih);
                cmd.Parameters.AddWithValue("R_Musterino", rapor.Musterino);


                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return "Rapor Eklendi";
            }
            catch (Exception hata)
            {
                return hata.ToString();
            }
            
            
        }
        public DataTable ParaRaporListele()
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            string commandText = "select * from PARARAPOR";
            OleDbCommand cmd = new OleDbCommand(commandText, conn);
            cmd.Connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Connection.Close();
            return dt;
        }

        public DataTable ParaRaporMusteri(int id)
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            string commandText = "select * from PARARAPOR where MUSTERİNO=" + id;
            OleDbCommand cmd = new OleDbCommand(commandText, conn);
            cmd.Connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Connection.Close();
            return dt;
        }

        public DataTable MusteriListele()
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            string commandText = "select * from MUSTERI";
            OleDbCommand cmd = new OleDbCommand(commandText, conn);
            cmd.Connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Connection.Close();
            return dt;

        }
         
        public DataTable MusteriHesapListele(string id)
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            string commandText = "select * from HESAP where MUSTERİNO="+id;
            OleDbCommand cmd = new OleDbCommand(commandText, conn);
            cmd.Connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Connection.Close();
            return dt;
        }

        public DataTable PersonelListele()
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            string commandText = "select * from PERSONEL";
            OleDbCommand cmd = new OleDbCommand(commandText, conn);
            cmd.Connection.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Connection.Close();
            return dt;
        }
        

    }
}