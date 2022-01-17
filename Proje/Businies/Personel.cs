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
    public class Personel : IPersonel
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

        public List<PersonelDTO> PersonelListesi(string SorguCümlesi) //Gelen Sorguyu işleme aşaması.
        {
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            OleDbDataReader Okuyucu = Cmd1.ExecuteReader(); //Okumak için datareader dan bir nesne oluşturuyoruz.
            List<PersonelDTO> kdto = new List<PersonelDTO>(); //list tipinde bir liste nesnesi.
            while (Okuyucu.Read()) //bitene kadar oku.
            {


                kdto.Add(new PersonelDTO //Listeye ekleme işlemi.
                {
                    PerNo = Convert.ToInt32(Okuyucu["PerNo"].ToString()),
                    Adi = Okuyucu["Adi"].ToString(),
                    SoyAdi = Okuyucu["SoyAdi"].ToString(),
                    Alani = Okuyucu["Alani"].ToString(),
                });
            }
            bag.baglantiKapat();
            return kdto;

        }
        
    }
}
