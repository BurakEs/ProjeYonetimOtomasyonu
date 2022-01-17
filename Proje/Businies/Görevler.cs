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
    public class Görevler : IGörevler
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

        public List<GörevlerDTO> GörevListesi(string SorguCümlesi) //Gelen Sorguyu işleme aşaması.
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            OleDbDataReader Okuyucu = Cmd1.ExecuteReader(); //Okumak için datareader dan bir nesne oluşturuyoruz.
            List<GörevlerDTO> kdto = new List<GörevlerDTO>(); //list tipinde bir liste nesnesi.
            while (Okuyucu.Read()) //bitene kadar oku.
            {


                kdto.Add(new GörevlerDTO //Listeye ekleme işlemi.
                {
                    GörNo = Okuyucu["GörNo"].ToString(),
                    PersonelAdi = Okuyucu["PersonelAdi"].ToString(),
                    Proje_Adi = Okuyucu["Proje_Adi"].ToString(),
                    GörNitelik = Okuyucu["GörNitelik"].ToString(),
                    GörBasTarihi = Convert.ToDateTime(Okuyucu["GörBasTarihi"]),
                    GörDurum = Convert.ToBoolean(Okuyucu["GörDurum"]),
                    GörBitTarihi = Convert.ToDateTime(Okuyucu["GörBitTarihi"]),
                });
            }
            bag.baglantiKapat();
            return kdto;

        }
    }
}
