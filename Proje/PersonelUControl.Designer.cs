namespace Proje
{
    partial class PersonelUControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelUControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnProjeEkle = new System.Windows.Forms.Button();
            this.lblPerisim = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnDzn = new System.Windows.Forms.Button();
            this.Btnsl = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 40);
            this.panel1.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl1.Image = ((System.Drawing.Image)(resources.GetObject("lbl1.Image")));
            this.lbl1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl1.Location = new System.Drawing.Point(7, 7);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(163, 23);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "        PERSONEL";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(11, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 260);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "        Personel Bilgileri";
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(425, 229);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.BtnProjeEkle);
            this.panel3.Controls.Add(this.lblPerisim);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(11, 321);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(733, 281);
            this.panel3.TabIndex = 4;
            // 
            // BtnProjeEkle
            // 
            this.BtnProjeEkle.BackColor = System.Drawing.Color.Transparent;
            this.BtnProjeEkle.FlatAppearance.BorderSize = 0;
            this.BtnProjeEkle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProjeEkle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnProjeEkle.Image = ((System.Drawing.Image)(resources.GetObject("BtnProjeEkle.Image")));
            this.BtnProjeEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProjeEkle.Location = new System.Drawing.Point(0, 31);
            this.BtnProjeEkle.Name = "BtnProjeEkle";
            this.BtnProjeEkle.Size = new System.Drawing.Size(733, 250);
            this.BtnProjeEkle.TabIndex = 4;
            this.BtnProjeEkle.Text = "Personeli Bir Projeye DAHİL ET";
            this.BtnProjeEkle.UseVisualStyleBackColor = false;
            this.BtnProjeEkle.Visible = false;
            // 
            // lblPerisim
            // 
            this.lblPerisim.AutoSize = true;
            this.lblPerisim.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPerisim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPerisim.Image = ((System.Drawing.Image)(resources.GetObject("lblPerisim.Image")));
            this.lblPerisim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPerisim.Location = new System.Drawing.Point(3, 6);
            this.lblPerisim.Margin = new System.Windows.Forms.Padding(0);
            this.lblPerisim.Name = "lblPerisim";
            this.lblPerisim.Size = new System.Drawing.Size(246, 18);
            this.lblPerisim.TabIndex = 2;
            this.lblPerisim.Text = "        Seçili Personel Proje Bilgisi";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeight = 30;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView2.Location = new System.Drawing.Point(0, 31);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 100;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(755, 250);
            this.dataGridView2.TabIndex = 3;
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(0)))));
            this.BtnEkle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkle.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnEkle.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.Image")));
            this.BtnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEkle.Location = new System.Drawing.Point(457, 46);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(287, 79);
            this.BtnEkle.TabIndex = 0;
            this.BtnEkle.Text = "Personel Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnDzn
            // 
            this.BtnDzn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(235)))), ((int)(((byte)(0)))));
            this.BtnDzn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDzn.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnDzn.Image = ((System.Drawing.Image)(resources.GetObject("BtnDzn.Image")));
            this.BtnDzn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDzn.Location = new System.Drawing.Point(457, 131);
            this.BtnDzn.Name = "BtnDzn";
            this.BtnDzn.Size = new System.Drawing.Size(287, 79);
            this.BtnDzn.TabIndex = 1;
            this.BtnDzn.Text = "       Personeli Düzenle";
            this.BtnDzn.UseVisualStyleBackColor = false;
            this.BtnDzn.Click += new System.EventHandler(this.BtnDzn_Click);
            // 
            // Btnsl
            // 
            this.Btnsl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.Btnsl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnsl.ForeColor = System.Drawing.Color.DarkRed;
            this.Btnsl.Image = ((System.Drawing.Image)(resources.GetObject("Btnsl.Image")));
            this.Btnsl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnsl.Location = new System.Drawing.Point(457, 216);
            this.Btnsl.Name = "Btnsl";
            this.Btnsl.Size = new System.Drawing.Size(287, 79);
            this.Btnsl.TabIndex = 2;
            this.Btnsl.Text = "Personeli Sil";
            this.Btnsl.UseVisualStyleBackColor = false;
            this.Btnsl.Click += new System.EventHandler(this.Btnsl_Click);
            // 
            // PersonelUControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.Btnsl);
            this.Controls.Add(this.BtnDzn);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PersonelUControl";
            this.Size = new System.Drawing.Size(807, 622);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label lblPerisim;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.Button BtnEkle;
        public System.Windows.Forms.Button BtnDzn;
        public System.Windows.Forms.Button Btnsl;
        public System.Windows.Forms.Button BtnProjeEkle;
    }
}
