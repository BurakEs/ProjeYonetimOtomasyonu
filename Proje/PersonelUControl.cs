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
    public partial class PersonelUControl : UserControl
    {
        public int secid;
        public DataTable table,personeltable;

        public PersonelUControl()
        {
            InitializeComponent();
        }
        public void personelgöster() {
            IPersonel personel = new Personel();
            var data = personel.PersonelListesi("Select * from Personel ORDER BY PerNO");

            personeltable = new DataTable();

            personeltable.Columns.Add("Adı", typeof(string));
            personeltable.Columns.Add("Soy Adı", typeof(string));
            personeltable.Columns.Add("Alanı", typeof(string));
            personeltable.Columns.Add("PerNo", typeof(int));

            foreach (var pro in data)
            {
                personeltable.Rows.Add(pro.Adi, pro.SoyAdi, pro.Alani, pro.PerNo);
            }
            dataGridView1.DataSource = personeltable;

            dataGridView1.Columns[3].HeaderText = "Personel No";
            dataGridView1.Columns[0].HeaderText = "Adi";
            dataGridView1.Columns[1].HeaderText = "SoyAdi";
            dataGridView1.Columns[2].HeaderText = "Alani";
            dataGridView1.Columns[0].Width = 145;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 75;

        }

        public void projegöster()
        {
            IPersonelProje perproje = new PersonelProje();
            var projeler = perproje.ProjeListesi(secid);
            table = new DataTable();

            table.Columns.Add("ProjeID", typeof(string));
            table.Columns.Add("Proje Adı", typeof(string));
            table.Columns.Add("Ayrıntılar", typeof(string));
            table.Columns.Add("ProNo", typeof(int));
           
            foreach (var pro in projeler)
            {
                table.Rows.Add(pro.ProjeID, pro.Proje_Adi, pro.Ayrintilar, pro.ProNo);
            }
            dataGridView2.DataSource = table;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            secid = Convert.ToInt32(dataGridView1.Rows[secilialan].Cells[3].Value.ToString());
            string isim = dataGridView1.Rows[secilialan].Cells[0].Value.ToString() +" "+ dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            lblPerisim.Text = "        "+isim+" - Dahil Olduğu Projeler";
            projegöster();
            
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
            dataGridView2.Columns[0].HeaderText = "Proje ID";
            dataGridView2.Columns[1].HeaderText = "Proje Adi";
            dataGridView2.Columns[2].HeaderText = "Proje Açıklaması";
            dataGridView2.Columns[0].Width = 100;
            dataGridView2.Columns[1].Width = 300;
            dataGridView2.Columns[2].Width = 375;
            dataGridView2.RowTemplate.Height = 60;
        }


        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Anamenü ana = new Anamenü();
            PersonelEkleGncle ekle = new PersonelEkleGncle();
            ekle.MdiParent = ana.ParentForm;
            ekle.ShowDialog();
            personelgöster();
        }

        private void BtnDzn_Click(object sender, EventArgs e)
        {
            Anamenü ana = new Anamenü();
            PersonelEkleGncle ekle = new PersonelEkleGncle();
            IPersonel personel = new Personel();
            var data = personel.PersonelListesi("Select * from Personel where PerNo=" + secid);
            ekle.güncelleid = secid;
            foreach (var item in data)
            {
                ekle.txtad.Text = item.Adi;
                ekle.txtalan.Text = item.Alani;
                ekle.txtsoy.Text = item.SoyAdi;
            }
            ekle.MdiParent = ana.ParentForm;
            ekle.label4.Text = "Personel Güncelle";
            ekle.groupBox1.Text = "Personel Güncelle";
            ekle.BtnEkle.Text = "     Güncelle";
            ekle.ShowDialog();
            personelgöster();
        }

        private void Btnsl_Click(object sender, EventArgs e)
        {
            DialogResult Onay=DialogResult.OK;
            Personel personel = new Personel();
            var data = personel.PersonelListesi("Select * from Personel where PerNo=" + secid);
            foreach (var item in data)
            {
                Onay = MessageBox.Show(item.Adi.ToUpper() +" "+ item.SoyAdi.ToUpper() + " isimli personeli silmek istediğinize Eminmisiniz ? ", "Personel Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (Onay == DialogResult.Yes)
            {
                Personel personelsil = new Personel();
                personelsil.Sil("Delete From Personel where PerNo=" + secid);
                BasarıFormu basarili = new BasarıFormu();
                basarili.ShowDialog();
                personelgöster();
            }
            else
            {
                HataFormu hata = new HataFormu();
                hata.htlbl.Text = "Silme İşlemi Başarısız.";
                hata.ShowDialog();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
