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
    public partial class ProjeyePersonelekle : Form
    {
        int projeid;int secid;int secilialan;
        DataTable table;
        public ProjeyePersonelekle()
        {
            InitializeComponent();

        }
        public void listele(int gelenprojeid) {

            IPersonel personel = new Personel();
            var tümpersonel = personel.PersonelListesi("Select * from Personel ORDER BY PerNO");
            IPersonelProje persoproje = new PersonelProje();
            var projedecalisanlar = persoproje.PersonelListesi(gelenprojeid);

            table = new DataTable();

            table.Columns.Add("Personel No", typeof(int));
            table.Columns.Add("Adı", typeof(string));
            table.Columns.Add("Soyadı", typeof(string));
            table.Columns.Add("Alanı    ", typeof(string));
            table.Columns.Add("Dahil Edildi   ", typeof(Boolean));
            foreach (var perso in tümpersonel)
            {
                int i = 0;

                foreach (var karsılastir in projedecalisanlar)
                {
                    if (perso.PerNo == karsılastir.PerNo && i == 0)
                    {
                        table.Rows.Add(karsılastir.PerNo, karsılastir.Adi, karsılastir.SoyAdi, karsılastir.Alani, "True");
                        i = 1;
                    }

                }
                if (i == 0)
                {
                    table.Rows.Add(perso.PerNo, perso.Adi, perso.SoyAdi, perso.Alani, "False");
                }

            }
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Width = 73;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 63;
            dataGridView1.Columns[4].SortMode = DataGridViewColumnSortMode.Automatic;
            projeid = gelenprojeid;
            try
            {
                secid = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value.ToString());
            }
            catch (ArgumentOutOfRangeException Hata)
            {

                MessageBox.Show("Lütfen Proje Seçmeden İşlem Yapmayınız.\n" + Hata);
            }
            
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtperadi_TextChanged(object sender, EventArgs e)
        {
            DataView dv = table.DefaultView;
            dv.RowFilter = "Adı LIKE '" + txtperadi.Text + "%'";
            dataGridView1.DataSource = dv;
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
        
               
                if (dataGridView1.Rows[secilialan].Cells[4].Value.ToString() == "False")
                {
                if (txtgr.Text!="" && txtgrsr.Text!="" )
                {
                    dataGridView1.Rows[secilialan].Cells[4].Value = "True";
                    DataView dv = table.DefaultView;
                    dataGridView1.DataSource = dv;
                    IGörevler görev = new Görevler();
                    DateTime bitis = DateTime.Now.AddDays(Convert.ToInt32(txtgrsr.Text));
                    görev.Ekle("insert into Görevler (GörNo,GörNitelik,GörBasTarihi,GörBitTarihi,GörDurum) values ('" + secid+"x"+ projeid + "','" + txtgr.Text + "','"+DateTime.Now.ToString("d")+ "','"+ bitis.ToShortDateString() + "',"+false+")");
                    IPersonelProje properekle = new PersonelProje();
                    properekle.Ekle("insert into PersonelProje (PersonelNo,ProjeNo,GörevNo) values (" + secid + "," +
                                    projeid + ",'" + secid + "x" + projeid + "')");
                    BasarıFormu basarı = new BasarıFormu();
                    basarı.ShowDialog();
                }
                else
                {
                    HataFormu hata = new HataFormu();
                    hata.htlbl.Text = "Görev Bilgisini Giriniz.";
                    hata.ShowDialog();
                }
                }
                else
                {
                    HataFormu hata = new HataFormu();
                    hata.htlbl.Visible = false;
                    hata.ShowDialog();
                }
            


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
                int secilialan = dataGridView1.SelectedCells[0].RowIndex;
                if (dataGridView1.Rows[secilialan].Cells[4].Value.ToString() == "True")
                {
                    dataGridView1.Rows[secilialan].Cells[4].Value = "False";
                    DataView dv = table.DefaultView;
                    dataGridView1.DataSource = dv;

                IGörevler görev = new Görevler();
                görev.Sil("Delete from Görevler where GörNo ='" + secid + "x" + projeid + "'");
                IPersonelProje properekle = new PersonelProje();
                properekle.Ekle("Delete from PersonelProje where PersonelNo="+secid+" and ProjeNo=" + projeid);
                BasarıFormu basarı = new BasarıFormu();
                basarı.ShowDialog();
                }
                else
                {
                    HataFormu hata = new HataFormu();
                    hata.htlbl.Visible = false;
                    hata.ShowDialog();
                }
            


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilialan = dataGridView1.SelectedCells[0].RowIndex;
            secid = Convert.ToInt32(dataGridView1.Rows[secilialan].Cells[0].Value.ToString());
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // Sadece sayı girişi
        }

        private void txtgrsr_Click(object sender, EventArgs e)
        {
            txtgrsr.Text = "";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
