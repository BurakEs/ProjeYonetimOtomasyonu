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
using ZedGraph;

namespace Proje
{
    public partial class Anamenü : Form
    {

        

        public Anamenü()
        {
            InitializeComponent();
           CalisanGrafik(ZdCalisan);

        }


        private void BtnAnasayfa_Click(object sender, EventArgs e)
        {
            CalisanGrafik(ZdCalisan);
            ZdCalisan.BringToFront();
        }

        private void btnProje_Click(object sender, EventArgs e)
        {

            projeUControl1.BringToFront();
            projeUControl1.projegöster();
            projeUControl1.projegöster();
            try
            {
                projeUControl1.projeid = Convert.ToInt32(projeUControl1.dataGridView1.Rows[0].Cells[3].Value.ToString());
                string isim = projeUControl1.dataGridView1.Rows[0].Cells[1].Value.ToString();
                projeUControl1.lblPerisim.Text = "        " + isim + " Projesindeki Çalışanlar";
            }
            catch (ArgumentOutOfRangeException Hata)
            {

                MessageBox.Show("Kayıtlı Proje Yok." + Hata);
            }



            IPersonelProje perproje = new PersonelProje();
            var data = perproje.PersonelListesi(projeUControl1.projeid);
            projeUControl1.dataGridView2.DataSource = data;
            if (projeUControl1.dataGridView2.RowCount == 0)
            {
                projeUControl1.dataGridView2.Visible = false;
                projeUControl1.BtnProjeEkle.Visible = true;

            }
            else
            {
                projeUControl1.dataGridView2.Visible = true;
                projeUControl1.BtnProjeEkle.Visible = false;
            }
            projeUControl1.dataGridView2.Columns[0].HeaderText = "Personel No";
            projeUControl1.dataGridView2.Columns[1].HeaderText = "Adı";
            projeUControl1.dataGridView2.Columns[2].HeaderText = "Soy Adı";
            projeUControl1.dataGridView2.Columns[3].HeaderText = "Alanı";
            projeUControl1.dataGridView2.Columns[0].Width = 94;
            projeUControl1.dataGridView2.Columns[1].Width = 130;
            projeUControl1.dataGridView2.Columns[2].Width = 130;
            projeUControl1.dataGridView2.Columns[3].Width = 140;
            projeUControl1.dataGridView2.RowTemplate.Height = 44;
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            
            personelUControl1.BringToFront();
            /*ZdCalisan.Visible = false;*/
            personelUControl1.personelgöster();
            try
            {
                personelUControl1.secid = Convert.ToInt32(personelUControl1.dataGridView1.Rows[0].Cells[3].Value.ToString());
                string isim = personelUControl1.dataGridView1.Rows[0].Cells[0].Value.ToString() + " " + personelUControl1.dataGridView1.Rows[0].Cells[1].Value.ToString() + " -- Dahil Olduğu Projeler";
                personelUControl1.lblPerisim.Text = "        " + isim;
            }
            catch (ArgumentOutOfRangeException Hata)
            {

                MessageBox.Show("Kayıtlı Personel Yok." + Hata);
            }


            personelUControl1.projegöster();

            personelUControl1.dataGridView2.Columns[0].HeaderText = "Proje ID";
            personelUControl1.dataGridView2.Columns[1].HeaderText = "Proje Adi";
            personelUControl1.dataGridView2.Columns[2].HeaderText = "Proje Açıklaması";
            personelUControl1.dataGridView2.Columns[0].Width = 100;
            personelUControl1.dataGridView2.Columns[1].Width = 300;
            personelUControl1.dataGridView2.Columns[2].Width = 375;
            personelUControl1.dataGridView2.RowTemplate.Height = 60;
            if (personelUControl1.dataGridView2.RowCount == 0)
            {
                personelUControl1.dataGridView2.Visible = false;
                personelUControl1.BtnProjeEkle.Visible = true;



            }
            else
            {
                personelUControl1.dataGridView2.Visible = true;
                personelUControl1.BtnProjeEkle.Visible = false;
            }
        }

        private void btnGörev_Click(object sender, EventArgs e)
        {
            görevUControl1.BringToFront();

            /*ZdCalisan.Visible = false;*/
            görevUControl1.listele(görevUControl1.grup, görevUControl1.durum);

            görevUControl1.comboBox1.Items.Add("PersonelAdı");
            görevUControl1.comboBox1.Items.Add("GörevNo");
            görevUControl1.comboBox1.Items.Add("ProjeAdı");
            görevUControl1.comboBox1.Items.Add("GörevNitelik");
            görevUControl1.comboBox1.SelectedItem = görevUControl1.comboBox1.Items[0];
            try
            {
                görevUControl1.secid = görevUControl1.dataGridView1.Rows[0].Cells[0].Value.ToString();
                görevUControl1.secilialan = görevUControl1.dataGridView1.SelectedCells[0].RowIndex;
                görevUControl1.idler = görevUControl1.secid.Split('x');
            }
            catch (ArgumentOutOfRangeException hata1)
            {
                MessageBox.Show("Kayıtı hiçbir personel Görevi Yok." + hata1);
            }
        }

        public void CalisanGrafik(ZedGraphControl zg1)
        {

            GraphPane DurumGrafik = zg1.GraphPane;
            zg1.GraphPane.CurveList.Clear();
            zg1.GraphPane.GraphObjList.Clear();
            zg1.Visible = true;
            // Set the pane title
            DurumGrafik.Title.Text = "Personel İş Durumu";
            PictureBox Yeni = new PictureBox();
            Yeni.Text = "Yeni Buton";
            Yeni.Height = 35;  //Yüksekliği
            Yeni.Width = 35; //Eni
            /*ZdCalisan.Controls.Add(Yeni); //Butonu Forma Ekleme*/
            Yeni.BackColor = Color.LightCyan;
            Yeni.Location = new Point(749, 2);
            Yeni.Size = new Size(35, 35);
            Yeni.ImageLocation = (Application.StartupPath + "\\image\\cancel (1).png");
            Yeni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Yeni.Cursor = Cursors.Hand;
            Yeni.Click += new EventHandler(kapat);
            // Enter some data values

            Double[] DurumlarınSayisi = new Double[2]; // Durum True ve false olduğu için 2 değerin toplam sayisi
            int i = 0;
            IPersonel personel = new Personel();
            var data = personel.PersonelListesi("Select * from Personel ORDER BY PerNO");
            foreach (var item in data)
            {
                i++;
            }
            int A = 0;
            IPersonelProje projeper = new PersonelProje();
            var veri = projeper.GRAPH("Select PersonelNo From PersonelProje Group by PersonelNo");
            foreach (var item in veri)
            {
                A++;
            }
            DurumlarınSayisi[0] = A;
            DurumlarınSayisi[1] = i - A;
            Color[] colors = { Color.Red, Color.Blue };
            string[] DilimTextleri = { "Projeye Atanmış Personel", "Projeye Atanmamış Personel" };
            // ??
            DurumGrafik.Fill = new Fill(Color.LightCyan);
            DurumGrafik.Chart.Fill = new Fill(Color.LightCyan);
            DurumGrafik.Legend.Position = LegendPos.TopCenter;



            // dilimlere gerekli verileri işleme
            PieItem[] dilim = new PieItem[2];
            dilim = DurumGrafik.AddPieSlices(DurumlarınSayisi, DilimTextleri);

            // İSİM TİPLERİNİ % BARINDIRICAK ŞEKİLDE AYARLADIK
            ((PieItem)dilim[0]).LabelType = PieLabelType.Name_Value;
            ((PieItem)dilim[1]).LabelType = PieLabelType.Name_Value;




            CurveList DilimDegerTPL = DurumGrafik.CurveList;
            double total = 0;
            for (int x = 0; x < DilimDegerTPL.Count; x++)  // TOPLAM KİTAP SAYISI HESABI.
                total += ((PieItem)DilimDegerTPL[x]).Value;

            // TEXT İŞLEMİ
            TextObj text = new TextObj("Sistemde Toplam " + total.ToString() + " çalışan mevcut.      .", 0.82F, 1F, CoordType.PaneFraction);
            text.Location.AlignH = AlignH.Center;
            text.Location.AlignV = AlignV.Bottom;
            text.FontSpec.Border.IsVisible = false;
            text.FontSpec.Fill = new Fill(Color.White, Color.Teal, 45F);
            text.FontSpec.StringAlignment = StringAlignment.Center;
            DurumGrafik.GraphObjList.Add(text);

    
           

            zg1.AxisChange();
        }

        private void kapat(object sender, EventArgs e)
        {
            this.Close();
        }


        public void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
