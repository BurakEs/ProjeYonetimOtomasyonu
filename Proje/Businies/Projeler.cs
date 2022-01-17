using Proje.Businies.DataTransferObject;
using Proje.Businies.Interface;
using Proje.Connections;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace Proje.Businies
{
    public class Projeler : IProjeler
    {

        Baglanti bag = new Baglanti();
        Command cmd = new Command();

        public void Ekle(string SorguCümlesi) //Gelen Sorguyu işleme aşaması.
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            Cmd1.ExecuteNonQuery();
            bag.baglantiKapat();

        }

        public void Sil(string SorguCümlesi) //Gelen Sorguyu işleme aşaması.
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            Cmd1.ExecuteNonQuery();
            bag.baglantiKapat();

        }

        public void Güncelle(string SorguCümlesi) //Gelen Sorguyu işleme aşaması.
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            Cmd1.ExecuteNonQuery();
            bag.baglantiKapat();

        }

        public List<ProjelerDTO> ProjeListesi(string SorguCümlesi) //Gelen Sorguyu işleme aşaması.
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            OleDbDataReader Okuyucu = Cmd1.ExecuteReader(); //Okumak için datareader dan bir nesne oluşturuyoruz.
            List<ProjelerDTO> kdto = new List<ProjelerDTO>(); //list tipinde bir liste nesnesi.
            while (Okuyucu.Read()) //bitene kadar oku.
            {


                kdto.Add(new ProjelerDTO //Listeye ekleme işlemi.
                {
                    ProNo = Convert.ToInt32(Okuyucu["ProNo"].ToString()),
                    ProjeID = Okuyucu["ProjeID"].ToString(),
                    Proje_Adi = Okuyucu["Proje_Adi"].ToString(),
                    Ayrintilar = Okuyucu["Ayrintilar"].ToString(),
                });
            }
            bag.baglantiKapat();
            return kdto;

        }

        public List<ProjelerDTO> ProjeAdi(string Projeadi) //Gelen Sorguyu işleme aşaması.
        {
            string SorguCümlesi = "Select * from Projeler where Proje_Adi='"+ Projeadi+"'";
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            OleDbDataReader Okuyucu = Cmd1.ExecuteReader(); //Okumak için datareader dan bir nesne oluşturuyoruz.
            List<ProjelerDTO> kdto = new List<ProjelerDTO>(); //list tipinde bir liste nesnesi.
            while (Okuyucu.Read()) //bitene kadar oku.
            {


                kdto.Add(new ProjelerDTO //Listeye ekleme işlemi.
                {
                    ProNo = Convert.ToInt32(Okuyucu["ProNo"].ToString()),
                });
            }
            bag.baglantiKapat();
            return kdto;

        }
    }
}
