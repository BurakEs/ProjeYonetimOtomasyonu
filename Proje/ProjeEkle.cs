using Proje.Businies;
using Proje.Businies.Interface;
using Proje.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proje
{
    public partial class ProjeEkle : Form
    {
        public int seciliprojeid = 0;string ilkad;
        public ProjeEkle()
        {
            InitializeComponent();

        }


        public void temizle()
        {
            txtprojead.Text = "";
            txtprono.Text = "";
            txtAy.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar); //Sadece String Girişi
            if ((int)e.KeyChar == 22 || (int)e.KeyChar == 27)
            {
                e.Handled = true;
            }
        }

        private void txtAy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 22 || (int)e.KeyChar == 27)
            {
                e.Handled = true;
            }
        }

       

        private void btnprjtmz_Click(object sender, EventArgs e)
        {
            txtAy.Text = "";
            txtprojead.Text = "";
        }

        private void btnprjekle_Click(object sender, EventArgs e)
        {
            if (txtprojead.Text!="" && txtAy.Text!="" && txtprono.Text!="")
            {
                if (label4.Text == "      Proje Güncelle")
                {
                    ilkad = txtprono.Text;
                    IProjeler projekontrol = new Projeler();
                    var projevarmı = projekontrol.ProjeListesi("Select * from Projeler Where ProjeID='" + txtprono.Text + "'");
                    if (ilkad == txtprono.Text && projevarmı.Count >= 2)
                    {
                        HataFormu hata = new HataFormu();
                        hata.htlbl.Text = "Proje İD Mevcut.";
                        hata.ShowDialog();
                    }
                    else if (ilkad != txtprono.Text && projevarmı.Count >= 1)
                    {
                        HataFormu hata = new HataFormu();
                        hata.htlbl.Text = "Proje İD Mevcut.";
                        hata.ShowDialog();
                    }
                    else
                     {
                   
                    IProjeler proje = new Projeler();
                    proje.Güncelle("update Projeler set ProjeID = '" + txtprono.Text + "', Proje_Adi = '" + txtprojead.Text + "', Ayrintilar = '" + txtAy.Text + "' where ProNo=" + seciliprojeid);
                    BasarıFormu basarı = new BasarıFormu();
                    basarı.ShowDialog();
                    this.Close();
                     }
                }
                else
                {
                    IProjeler projekontrol = new Projeler();
                    var projevarmı = projekontrol.ProjeListesi("Select * from Projeler Where Proje_Adi='" + txtprojead.Text + "'");
                    if (projevarmı.Count >= 1)
                    {
                        HataFormu hata = new HataFormu();
                        hata.htlbl.Text = "Proje ismi Mevcut.";
                        hata.ShowDialog();
                    }
                    else
                    {
                        IProjeler proje = new Projeler();
                        proje.Ekle("insert into Projeler (ProjeID,Proje_Adi,Ayrintilar) values ('" + txtprono.Text + "','"+ txtprojead.Text + "','" + txtAy.Text + "')");
                        BasarıFormu basarı = new BasarıFormu();
                        basarı.ShowDialog();
                        this.Close();
                    }
                }
            }
            else
            {
                HataFormu hata = new HataFormu();
                hata.htlbl.Text = "Boş Yerleri Doldurun";
                hata.ShowDialog();
            }

                
        }

        private void txtAy_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 34 || (int)e.KeyChar == 39 || (int)e.KeyChar == 44)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btnprjtmz_Click_1(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
