namespace Proje
{
    partial class GörevUControl
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GörevUControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtara = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RdDrm = new System.Windows.Forms.RadioButton();
            this.RdPerAdi = new System.Windows.Forms.RadioButton();
            this.RdProAdi = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RdHepsi = new System.Windows.Forms.RadioButton();
            this.RdDevam = new System.Windows.Forms.RadioButton();
            this.RdTamam = new System.Windows.Forms.RadioButton();
            this.Btnsl = new System.Windows.Forms.Button();
            this.BtnTm = new System.Windows.Forms.Button();
            this.GrvDzn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.txtara.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 40);
            this.panel1.TabIndex = 9;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl1.Image = ((System.Drawing.Image)(resources.GetObject("lbl1.Image")));
            this.lbl1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl1.Location = new System.Drawing.Point(7, 4);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(166, 23);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "        GÖREVLER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(11, 130);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(763, 365);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtara);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(11, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 65);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ara       :";
            // 
            // txtara
            // 
            this.txtara.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtara.Controls.Add(this.panel2);
            this.txtara.Location = new System.Drawing.Point(72, 40);
            this.txtara.Multiline = true;
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(186, 17);
            this.txtara.TabIndex = 2;
            this.txtara.TextChanged += new System.EventHandler(this.textdegis);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(165, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 17);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arama Yapılacak Alan  :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RdDrm);
            this.groupBox3.Controls.Add(this.RdPerAdi);
            this.groupBox3.Controls.Add(this.RdProAdi);
            this.groupBox3.Location = new System.Drawing.Point(287, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 38);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grupla";
            // 
            // RdDrm
            // 
            this.RdDrm.AutoSize = true;
            this.RdDrm.Location = new System.Drawing.Point(169, 11);
            this.RdDrm.Name = "RdDrm";
            this.RdDrm.Size = new System.Drawing.Size(56, 17);
            this.RdDrm.TabIndex = 5;
            this.RdDrm.Text = "Durum";
            this.RdDrm.UseVisualStyleBackColor = true;
            this.RdDrm.CheckedChanged += new System.EventHandler(this.grpdgs);
            // 
            // RdPerAdi
            // 
            this.RdPerAdi.AutoSize = true;
            this.RdPerAdi.Checked = true;
            this.RdPerAdi.Location = new System.Drawing.Point(11, 11);
            this.RdPerAdi.Name = "RdPerAdi";
            this.RdPerAdi.Size = new System.Drawing.Size(84, 17);
            this.RdPerAdi.TabIndex = 3;
            this.RdPerAdi.TabStop = true;
            this.RdPerAdi.Text = "Personel Adi";
            this.RdPerAdi.UseVisualStyleBackColor = true;
            this.RdPerAdi.CheckedChanged += new System.EventHandler(this.grpdgs);
            // 
            // RdProAdi
            // 
            this.RdProAdi.AutoSize = true;
            this.RdProAdi.Location = new System.Drawing.Point(96, 11);
            this.RdProAdi.Name = "RdProAdi";
            this.RdProAdi.Size = new System.Drawing.Size(67, 17);
            this.RdProAdi.TabIndex = 4;
            this.RdProAdi.Text = "Proje Adi";
            this.RdProAdi.UseVisualStyleBackColor = true;
            this.RdProAdi.CheckedChanged += new System.EventHandler(this.grpdgs);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdHepsi);
            this.groupBox2.Controls.Add(this.RdDevam);
            this.groupBox2.Controls.Add(this.RdTamam);
            this.groupBox2.Location = new System.Drawing.Point(287, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 38);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Durum";
            // 
            // RdHepsi
            // 
            this.RdHepsi.AutoSize = true;
            this.RdHepsi.Checked = true;
            this.RdHepsi.Location = new System.Drawing.Point(11, 14);
            this.RdHepsi.Name = "RdHepsi";
            this.RdHepsi.Size = new System.Drawing.Size(52, 17);
            this.RdHepsi.TabIndex = 6;
            this.RdHepsi.TabStop = true;
            this.RdHepsi.Text = "Hepsi";
            this.RdHepsi.UseVisualStyleBackColor = true;
            this.RdHepsi.CheckedChanged += new System.EventHandler(this.durumdgs);
            // 
            // RdDevam
            // 
            this.RdDevam.AutoSize = true;
            this.RdDevam.Location = new System.Drawing.Point(163, 14);
            this.RdDevam.Name = "RdDevam";
            this.RdDevam.Size = new System.Drawing.Size(101, 17);
            this.RdDevam.TabIndex = 5;
            this.RdDevam.Text = "Devam Etmekte";
            this.RdDevam.UseVisualStyleBackColor = true;
            this.RdDevam.CheckedChanged += new System.EventHandler(this.durumdgs);
            // 
            // RdTamam
            // 
            this.RdTamam.AutoSize = true;
            this.RdTamam.Location = new System.Drawing.Point(75, 14);
            this.RdTamam.Name = "RdTamam";
            this.RdTamam.Size = new System.Drawing.Size(82, 17);
            this.RdTamam.TabIndex = 3;
            this.RdTamam.Text = "Tamamlandı";
            this.RdTamam.UseVisualStyleBackColor = true;
            this.RdTamam.CheckedChanged += new System.EventHandler(this.durumdgs);
            // 
            // Btnsl
            // 
            this.Btnsl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.Btnsl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnsl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Btnsl.Image = ((System.Drawing.Image)(resources.GetObject("Btnsl.Image")));
            this.Btnsl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnsl.Location = new System.Drawing.Point(520, 511);
            this.Btnsl.Name = "Btnsl";
            this.Btnsl.Size = new System.Drawing.Size(245, 72);
            this.Btnsl.TabIndex = 15;
            this.Btnsl.Text = "     Görevi Sil";
            this.Btnsl.UseVisualStyleBackColor = false;
            this.Btnsl.Click += new System.EventHandler(this.Btnsl_Click);
            // 
            // BtnTm
            // 
            this.BtnTm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.BtnTm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTm.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnTm.Image = ((System.Drawing.Image)(resources.GetObject("BtnTm.Image")));
            this.BtnTm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTm.Location = new System.Drawing.Point(17, 511);
            this.BtnTm.Name = "BtnTm";
            this.BtnTm.Size = new System.Drawing.Size(243, 72);
            this.BtnTm.TabIndex = 13;
            this.BtnTm.Text = "         Görev Tamamlandı";
            this.BtnTm.UseVisualStyleBackColor = false;
            this.BtnTm.Click += new System.EventHandler(this.BtnTm_Click);
            // 
            // GrvDzn
            // 
            this.GrvDzn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.GrvDzn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GrvDzn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.GrvDzn.Image = ((System.Drawing.Image)(resources.GetObject("GrvDzn.Image")));
            this.GrvDzn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GrvDzn.Location = new System.Drawing.Point(266, 511);
            this.GrvDzn.Name = "GrvDzn";
            this.GrvDzn.Size = new System.Drawing.Size(248, 72);
            this.GrvDzn.TabIndex = 16;
            this.GrvDzn.Text = "     Görevi Düzenle";
            this.GrvDzn.UseVisualStyleBackColor = false;
            this.GrvDzn.Click += new System.EventHandler(this.GrvDzn_Click);
            // 
            // GörevUControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrvDzn);
            this.Controls.Add(this.Btnsl);
            this.Controls.Add(this.BtnTm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "GörevUControl";
            this.Size = new System.Drawing.Size(788, 596);
            this.Load += new System.EventHandler(this.GörevUControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.txtara.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtara;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.RadioButton RdDrm;
        public System.Windows.Forms.RadioButton RdPerAdi;
        public System.Windows.Forms.RadioButton RdProAdi;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton RdHepsi;
        public System.Windows.Forms.RadioButton RdDevam;
        public System.Windows.Forms.RadioButton RdTamam;
        public System.Windows.Forms.Button Btnsl;
        public System.Windows.Forms.Button BtnTm;
        public System.Windows.Forms.Button GrvDzn;
    }
}
