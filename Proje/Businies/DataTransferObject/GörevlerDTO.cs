using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje.Businies.DataTransferObject
{
    public class GörevlerDTO
    {
        public string GörNo { get; set; }
        public string PersonelAdi { get; set; }
        public string Proje_Adi  { get; set; }
        public string GörNitelik  { get; set; }
        public DateTime GörBasTarihi { get; set; }
        public DateTime GörBitTarihi { get; set; }
        public bool GörDurum { get; set; }
    }
}
