using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proje.Businies.Interface;
using Proje.Businies;

namespace Proje
{
    public partial class GörevUControl : UserControl
    {
        public string secid; public int secilialan; public string[] idler;
        public string grup ="PerNo";
        public string durum = "Hepsi";
        public GörevUControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        DataTable table;
        public void listele(string grup,string durum) {

                IGörevler görev = new Görevler();
                var tümgörevler = görev.GörevListesi("SELECT GörNo, Adi +' '+SoyAdi AS PersonelAdi, Proje_Adi, GörNitelik, GörBasTarihi,GörBitTarihi,GörDurum FROM Görevler, Personel, PersonelProje,Projeler  WHERE GörNo = GörevNo and PersonelNo = PerNo and ProjeNo = ProNo Order By "+grup);


                table = new DataTable();
                table.Columns.Add("GörevNo", typeof(string));
                table.Columns.Add("PersonelAdı", typeof(string));
                table.Columns.Add("ProjeAdı", typeof(string));
                table.Columns.Add("GörevNitelik", typeof(string));
                table.Columns.Add("GörevBaşlamaTarihi", typeof(DateTime));
                table.Columns.Add("GörevBitişTarihi", typeof(DateTime));
                table.Columns.Add("GörevDurumu", typeof(bool));
                if (durum == "Tamamlanmadı")
                {
                  foreach (var item in tümgörevler)
                    {

                    if (item.GörDurum == false)
                        {
                            table.Rows.Add(item.GörNo, item.PersonelAdi, item.Proje_Adi, item.GörNitelik, item.GörBasTarihi, item.GörBitTarihi, item.GörDurum);
                        }
                    }
                }
                else if (durum == "Tamamlandı") {
                    foreach (var item in tümgörevler)
                    {
                 
                        if (item.GörDurum == true)
                        {
                            table.Rows.Add(item.GörNo, item.PersonelAdi, item.Proje_Adi, item.GörNitelik, item.GörBasTarihi, item.GörBitTarihi, item.GörDurum);
                        }
                    }
                 }
                else
                {
                foreach (var item in tümgörevler)
                {
                    table.Rows.Add(item.GörNo, item.PersonelAdi, item.Proje_Adi, item.GörNitelik, item.GörBasTarihi, item.GörBitTarihi, item.GörDurum);
                }

                }

                dataGridView1.DataSource = table;

                dataGridView1.Columns[0].Width = 55;
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 120;
                dataGridView1.Columns[3].Width =200;
                dataGridView1.Columns[4].Width = 80;
                dataGridView1.Columns[5].Width = 80;
                dataGridView1.Columns[6].Width = 77;
            dataGridView1.Columns[6].SortMode = DataGridViewColumnSortMode.Automatic;
        }

        private void durumdgs(object sender, EventArgs e)
        {
            if (RdHepsi.Checked)
            {
                durum = "Hepsi";
                listele(grup, durum);
            }
            if (RdTamam.Checked)
            {
                durum = "Tamamlandı";
                listele(grup, durum);
            }
            if (RdDevam.Checked)
            {
                durum = "Tamamlanmadı";
                listele(grup, durum);
            }
        }

        private void grpdgs(object sender, EventArgs e)
        {
            if (RdPerAdi.Checked)
            {
                grup = "PerNo";
                listele(grup, durum);
            }
            if (RdProAdi.Checked)
            {
                grup = "Proje_Adi";
                listele(grup, durum);
            }
            if (RdDrm.Checked)
            {
                grup = "GörDurum";
                listele(grup, durum);
            }
        }

        private void textdegis(object sender, EventArgs e)
        {
            DataView dv = table.DefaultView;
            dv.RowFilter = comboBox1.SelectedItem.ToString()+" LIKE '" + txtara.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtara.Text = "";
        }

        private void BtnTm_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[secilialan].Cells[6].Value.ToString() == "False")
                {

                    dataGridView1.Rows[secilialan].Cells[6].Value = "True";
                    DataView dv = table.DefaultView;
                    dataGridView1.DataSource = dv;
                    IGörevler görev = new Görevler();

                    görev.Güncelle("update Görevler set GörDurum = " + true + " where GörNo='" + secid + "'");

                    BasarıFormu basarı = new BasarıFormu();
                    basarı.ShowDialog();
                    listele(grup, durum);
                    secilialan = dataGridView1.SelectedCells[0].RowIndex;
                }
                else
                {
                    HataFormu hata = new HataFormu();
                    hata.htlbl.Visible = false;
                    hata.ShowDialog();
                }
            }
            catch (ArgumentOutOfRangeException A)
            {
                MessageBox.Show("Hata Bilgisi " + A);
            }

           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilialan = dataGridView1.SelectedCells[0].RowIndex;
            secid = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            idler = secid.Split('x');
        }

        private void Btnsl_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[secilialan].Cells[6].Value.ToString() == "True")
                {

                    IGörevler görev = new Görevler();
                    görev.Sil("Delete from Görevler where GörNo ='" + secid + "'");
                    idler= secid.Split('x');

                    IPersonelProje properekle = new PersonelProje();
                    properekle.Ekle("Delete from PersonelProje where PersonelNo=" + idler[0] + " and ProjeNo=" + idler[1]);
                    BasarıFormu basarı = new BasarıFormu();
                    basarı.ShowDialog();
                    listele(grup, durum);
                    secilialan = dataGridView1.SelectedCells[0].RowIndex;
                }
                else
                {
                    HataFormu hata = new HataFormu();
                    hata.htlbl.Text = "Bitmemiş Görev Silinemez.";
                    hata.htlbl.Left -= 10;
                    hata.ShowDialog();
                }
            }
            catch (ArgumentOutOfRangeException A)
            { 
                MessageBox.Show("Hata Bilgisi " + A);
            }               
        }

        private void GrvDzn_Click(object sender, EventArgs e)
        {
            try
            {
                GrvDznle dznlemek = new GrvDznle(Convert.ToInt32(idler[0]), Convert.ToInt32(idler[1]), secid);
                dznlemek.ShowDialog();
                listele(grup,durum);
            }

            catch (ArgumentOutOfRangeException A)
            {
                MessageBox.Show("Hata Bilgisi " + A);
            }
        }
        
        private void GörevUControl_Load(object sender, EventArgs e)
        {

        }
    }
}
