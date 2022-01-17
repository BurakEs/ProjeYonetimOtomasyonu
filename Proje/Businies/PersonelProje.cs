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
    public class PersonelProje : IPersonelProje
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

        public List<ProjelerDTO> ProjeListesi(int perid) //Gelen Sorguyu işleme aşaması.
        {
            string SorguCümlesi = "Select ProjeID,Proje_Adi,Ayrintilar,ProNo from PersonelProje,Projeler,Personel where Projeler.ProNo=PersonelProje.ProjeNo AND Personel.PerNo=PersonelProje.PersonelNo And Personel.PerNo=" + perid+"";
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            OleDbDataReader Okuyucu = Cmd1.ExecuteReader(); //Okumak için datareader dan bir nesne oluşturuyoruz.
            List<ProjelerDTO> kdto = new List<ProjelerDTO>(); //list tipinde bir liste nesnesi.
            while (Okuyucu.Read()) //bitene kadar oku.
            {


                kdto.Add(new ProjelerDTO //Listeye ekleme işlemi.
                {
                    
                    ProjeID = Okuyucu["ProjeID"].ToString(),
                    Proje_Adi = Okuyucu["Proje_Adi"].ToString(),
                    Ayrintilar = Okuyucu["Ayrintilar"].ToString(),
                    ProNo = Convert.ToInt32(Okuyucu["ProNo"].ToString()),
                });
            }
            bag.baglantiKapat();
            return kdto;

        }

        public List<PersonelDTO> PersonelListesi(int proid) //Gelen Sorguyu işleme aşaması.
        {
            string SorguCümlesi = "Select PerNo,Adi,SoyAdi,ALani from PersonelProje,Projeler,Personel where Projeler.ProNo=PersonelProje.ProjeNo AND Personel.PerNo=PersonelProje.PersonelNo And Projeler.ProNo=" + proid + " ORDER BY PerNO";
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
        public List<PersonelProjeDTO> GRAPH(string SorguCümlesi) //Gelen Sorguyu işleme aşaması.
        {
            
            OleDbCommand Cmd1 = cmd.command(SorguCümlesi);
            OleDbDataReader Okuyucu = Cmd1.ExecuteReader(); //Okumak için datareader dan bir nesne oluşturuyoruz.
            List<PersonelProjeDTO> kdto = new List<PersonelProjeDTO>(); //list tipinde bir liste nesnesi.
            while (Okuyucu.Read()) //bitene kadar oku.
            {


                kdto.Add(new PersonelProjeDTO //Listeye ekleme işlemi.
                {
                    PersonelNo = Convert.ToInt32(Okuyucu["PersonelNo"].ToString()),
                });
            }
            bag.baglantiKapat();
            return kdto;

        }

    }
}
