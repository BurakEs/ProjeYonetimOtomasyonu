using Proje.Businies;
using Proje.Businies.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Proje
{
    public partial class PersonelEkleGncle : Form
    {

        BasarıFormu basarı; HataFormu hata; IPersonel personel;public int güncelleid;

        public PersonelEkleGncle()
        {
            InitializeComponent();

          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        public void temizle()
        {
            txtad.Text = "";
            txtalan.Text = "";
            txtsoy.Text = "";
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (label4.Text== "Personel Güncelle")
            {
                if (string.IsNullOrEmpty(txtad.Text) || string.IsNullOrEmpty(txtsoy.Text) || string.IsNullOrEmpty(txtalan.Text))
                {

                    hata = new HataFormu();
                    hata.htlbl.Text = "Tüm Alanları Doldurun";
                    hata.ShowDialog();
                }
                else
                {
                    personel = new Personel();
                    basarı = new BasarıFormu();
                    personel.Güncelle("update Personel set Adi = '" + txtad.Text + "', Soyadi = '" + txtsoy.Text + "', Alani = '" + txtalan.Text + "' where PerNo="+güncelleid);
                    basarı.ShowDialog();
                    this.Close();
                    temizle();
                }
            }
            else
            {
            if (string.IsNullOrEmpty(txtad.Text) || string.IsNullOrEmpty(txtsoy.Text) || string.IsNullOrEmpty(txtalan.Text))
            {
          
               hata = new HataFormu();
               hata.htlbl.Text = "Tüm Alanları Doldurun";
               hata.ShowDialog();
            }
            else
            {
                personel = new Personel();
                personel.Ekle("insert into Personel (Adi,SoyAdi,Alani) values ('" + txtad.Text + "','" + txtsoy.Text + "','" + txtalan.Text + "')");
                basarı = new BasarıFormu();
                basarı.ShowDialog();
                this.Close();
                temizle();
            }
            }
        }

        private void BtnTmz_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void OnlyString_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar); //Sadece String Girişi
            if ((int)e.KeyChar ==22 || (int)e.KeyChar == 27)
            {
                e.Handled = true;
            }
        }
    }
}
