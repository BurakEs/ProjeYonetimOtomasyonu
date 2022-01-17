using Proje.Businies;
using Proje.Businies.Interface;
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
    public partial class GrvDznle : Form
    {
        public Boolean durum;
        public DateTime baslangıctarihi;
        public string görno;
        public GrvDznle(int projeid,int personelid, string görevno)
        {
            InitializeComponent();
            görno = görevno;
            IGörevler görev = new Görevler();
            var tümgörevler = görev.GörevListesi("SELECT GörNo, Adi +' '+SoyAdi AS PersonelAdi, Proje_Adi, GörNitelik, GörBasTarihi,GörBitTarihi,GörDurum FROM Görevler, Personel, PersonelProje,Projeler  WHERE GörNo = GörevNo and PersonelNo = PerNo and ProjeNo = ProNo and GörevNo='"+ görevno+"'");
            foreach (var item in tümgörevler)
            {
                txtgrno.Text = görevno;
                txtperadı.Text = item.PersonelAdi;
                txtProadı.Text = item.Proje_Adi;
                TxtGrvNt.Text = item.GörNitelik;
                durum = item.GörDurum;
                DtBas.Value = item.GörBasTarihi;
                baslangıctarihi = item.GörBasTarihi;
                DtBit.Value = item.GörBitTarihi;

            }
            if (durum)
            {
                BtnDrm.ForeColor = Color.White;
                BtnDrm.Text = "Görev Tamamlanmış";
                BtnDrm.BackColor = Color.Green;
            }
            else
            {
                BtnDrm.ForeColor = Color.White;
                BtnDrm.Text = "Görev Tamamlanmamış";
                BtnDrm.BackColor = Color.DarkRed;
            }

            if (DtBit.Value <= DateTime.Now)
            {
                lblSonBas.Visible = true;
                lblSonBas.Text = "Görev Bitiş Tarihi Geçmiş.";
                lblSonBas.ForeColor = Color.Red;
               
            }
            else
            {
                TimeSpan tarih = DtBit.Value - DtBas.Value;
                lblSonBas.Visible = true;
                lblSonBas.Text = "Görev için " + tarih.Days + " gün süre verilmiştir.";
                lblSonBas.ForeColor = Color.Green;
            }


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GrvDznle_Load(object sender, EventArgs e)
        {

        }

        private void BtnDrm_Click(object sender, EventArgs e)
        {
            if (durum)
            {
                BtnDrm.ForeColor = Color.White;
                BtnDrm.Text = "Görev Tamamlanmamış";
                BtnDrm.BackColor = Color.DarkRed;
                durum = false;
            }
            else
            {
                BtnDrm.ForeColor = Color.White;
                BtnDrm.Text = "Görev Tamamlanmış";
                BtnDrm.BackColor = Color.Green;
                durum = true;
            }

        }

        private void DtBit_ValueChanged(object sender, EventArgs e)
        {
            if (DtBit.Value <= DateTime.Now)
            {
                lblSonBas.Visible = true;
                lblSonBas.Text = "Görev Bitiş Tarihi Geçmiş.";
                lblSonBas.ForeColor = Color.Red;
            }
            else
            {
                TimeSpan tarih = DtBit.Value - DtBas.Value;
                lblSonBas.Visible = true;
                lblSonBas.Text = "Görev için " + tarih.Days + " gün süre verilmiştir.";
                lblSonBas.ForeColor = Color.Green;
            }
        }

        private void DtBas_ValueChanged(object sender, EventArgs e)
        {
            if (DtBas.Value >= DtBit.Value)
            {
                MessageBox.Show("Başlangıç Tarihi Bitiş Tarihinden ileri bir Tarih veya aynı Tarih olamaz.!!!");
                DtBas.Value = baslangıctarihi;
            }

        }

        private void BtnDznle_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtGrvNt.Text != "")
                {
                    IGörevler görev = new Görevler();
                    görev.Güncelle("update Görevler set  GörNitelik = '" + TxtGrvNt.Text + "', GörBasTarihi = '" + DtBas.Value.ToString("d") + "', GörBitTarihi = '" + DtBit.Value.ToString("d") + "', GörDurum = " + durum + " where GörNo='" + görno+"'");
                    BasarıFormu basarili = new BasarıFormu();
                    basarili.ShowDialog();
                    this.Close();
                }
                else
                {
                    HataFormu hata = new HataFormu();
                    hata.ShowDialog();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnTmz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtGrvNt_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
