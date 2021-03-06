using Proje.Businies.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje.Businies.Interface
{
    public interface IPersonelProje
    {
        void Ekle(string SorguCümlesi);
        void Sil(string SorguCümlesi);
        void Güncelle(string SorguCümlesi);
        List<ProjelerDTO> ProjeListesi(int perid);
        List<PersonelDTO> PersonelListesi(int proid);
        List<PersonelProjeDTO> GRAPH(string SorguCümlesi);
    }
}
