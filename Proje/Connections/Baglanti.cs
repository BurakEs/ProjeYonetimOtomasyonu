using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace Proje.Connections
{
    public class Baglanti
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DBproject.accdb");
        //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Smog6\source\repos\Proje000\Proje000\bin\Debug\DBproject.accdb

        public OleDbConnection baglantiac() //Bağlantıyı openlamak için yazılan fonks.
        {
            conn.Open();
            return conn;
        }
        public OleDbConnection baglantiKapat() //Bağlantı Kapatmak için yazılan fonks.
        {
            conn.Close();
            return conn;
        }
    }
}
