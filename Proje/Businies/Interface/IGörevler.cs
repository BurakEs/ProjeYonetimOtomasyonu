﻿using Proje.Businies.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje.Businies.Interface
{
    public interface IGörevler
    {
        void Ekle(string SorguCümlesi);
        void Sil(string SorguCümlesi);
        void Güncelle(string SorguCümlesi);
        List<GörevlerDTO> GörevListesi(string SorguCümlesi);
    }
}
