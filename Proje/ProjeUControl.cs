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
using System.Data.OleDb;

namespace Proje
{
    public partial class ProjeUControl : UserControl
    {
        public int projeid; DataTable table;
        public ProjeUControl()
        {
            InitializeComponent();
        }

        public void projegöster()
        {
            IProjeler proje = new Projeler();
            var projeler = proje.ProjeListesi("Select * from Projeler ORDER BY ProjeID");

            table = new DataTable();

            table.Columns.Add("Proje Id", typeof(string));
            table.Columns.Add("Proje Adı", typeof(string));
            table.Columns.Add("Ayrıntılar", typeof(string));
            table.Columns.Add("xxx", typeof(int));
            foreach (var pro in projeler)
            {
                        table.Rows.Add(pro.ProjeID,pro.Proje_Adi,pro.Ayrintilar, pro.ProNo);
            }
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 239;
            dataGridView1.RowTemplate.Height = 44;
            dataGridView2.RowTemplate.Height = 44;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            projeid = Convert.ToInt32(dataGridView1.Rows[secilialan].Cells[3].Value.ToString());
            string isim = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            lblPerisim.Text = "        " + isim + " Projesindeki Çalışanlar";
            IPersonelProje perproje = new PersonelProje();
            var data = perproje.PersonelListesi(projeid);
            dataGridView2.DataSource = data;
            if (dataGridView2.RowCount == 0)
            {
                dataGridView2.Visible = false;
                BtnProjeEkle.Visible = true;

            }
            else
            {
                dataGridView2.Visible = true;
                BtnProjeEkle.Visible = false;
            }
        }

        private void BtnPEkle_Click(object sender, EventArgs e)
        {
            ProjeEkle projeekle = new ProjeEkle();
            projeekle.ShowDialog();
            projegöster();
        }

        private void BtnDzn_Click(object sender, EventArgs e)
        {
            ProjeEkle projeekle = new ProjeEkle();
            IProjeler proje = new Projeler();
            var data = proje.ProjeListesi("Select * from Projeler where ProNo=" + projeid);
            projeekle.label4.Text = "      Proje Güncelle";
            projeekle.groupBox1.Text = "Proje Güncelle";
            projeekle.seciliprojeid = projeid;

            foreach (var item in data)
            {
                projeekle.txtprono.Text = item.ProjeID;
                projeekle.txtprojead.Text = item.Proje_Adi;
                projeekle.txtAy.Text = item.Ayrintilar;
            }

            projeekle.ShowDialog();
            projegöster();
        }

        private void Btnsl_Click(object sender, EventArgs e)
        {
            DialogResult Onay = DialogResult.OK;
            IProjeler proje = new Projeler();
            var data = proje.ProjeListesi("Select * from Projeler where ProNo=" + projeid);
            foreach (var item in data)
            {
                Onay = MessageBox.Show(item.Proje_Adi + " isimli projeyi silmek istediğinize emin misiniz ? ", "Proje Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (Onay == DialogResult.Yes)
            {
                IProjeler projesil = new Projeler();
                projesil.Sil("Delete From Projeler where ProNo=" + projeid);
                BasarıFormu basarili = new BasarıFormu();
                basarili.ShowDialog();
                projegöster();
            }
            else
            {
                HataFormu hata = new HataFormu();
                hata.htlbl.Text = "Silme İşlemi Başarısız.";
                hata.ShowDialog();
            }
        }

        private void ProjeyePersonelEkle_Click(object sender, EventArgs e)
        {
            ProjeyePersonelekle gönder = new ProjeyePersonelekle();
            gönder.listele(projeid);
            IProjeler proje = new Projeler();
            var data = proje.ProjeListesi("Select * from Projeler where ProNo=" + projeid);
            foreach (var item in data)
            {
                gönder.label4.Text = "      "+ item.Proje_Adi + " Personel Ekle/SİL";
                gönder.txtprojead.Text = item.Proje_Adi;
                gönder.txtAy.Text = item.Ayrintilar;
            }
            gönder.ShowDialog();
            projegöster();
            IPersonelProje perproje = new PersonelProje();
            var veri = perproje.PersonelListesi(projeid);
            dataGridView2.DataSource = veri;
            if (dataGridView2.RowCount == 0)
            {
                dataGridView2.Visible = false;
                BtnProjeEkle.Visible = true;

            }
            else
            {
                dataGridView2.Visible = true;
                BtnProjeEkle.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

                Application.Exit();
        }
    }
}
