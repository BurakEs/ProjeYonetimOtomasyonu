using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace Proje.Connections
{
    public class Command
    {
        Baglanti baglanti = new Baglanti();
        public OleDbCommand command(string SorguCümlesi) //Sorgu cümleleri için bağlantı açma ve işleme.
        {
            OleDbCommand cmd = new OleDbCommand(SorguCümlesi,baglanti.baglantiac());
            return cmd;
        }
    }
}
