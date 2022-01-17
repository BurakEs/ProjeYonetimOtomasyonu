namespace Proje
{
    partial class Anamenü
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anamenü));
            this.PnlSolMenü = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGörev = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnProje = new System.Windows.Forms.Button();
            this.BtnAnasayfa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ZdCalisan = new ZedGraph.ZedGraphControl();
            this.görevUControl1 = new Proje.GörevUControl();
            this.personelUControl1 = new Proje.PersonelUControl();
            this.projeUControl1 = new Proje.ProjeUControl();
            this.PnlSolMenü.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSolMenü
            // 
            this.PnlSolMenü.BackColor = System.Drawing.Color.Teal;
            this.PnlSolMenü.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlSolMenü.Controls.Add(this.label2);
            this.PnlSolMenü.Controls.Add(this.label1);
            this.PnlSolMenü.Controls.Add(this.pictureBox1);
            this.PnlSolMenü.Controls.Add(this.pictureBox2);
            this.PnlSolMenü.Controls.Add(this.btnGörev);
            this.PnlSolMenü.Controls.Add(this.btnPersonel);
            this.PnlSolMenü.Controls.Add(this.btnProje);
            this.PnlSolMenü.Controls.Add(this.BtnAnasayfa);
            this.PnlSolMenü.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSolMenü.Location = new System.Drawing.Point(0, 0);
            this.PnlSolMenü.Name = "PnlSolMenü";
            this.PnlSolMenü.Size = new System.Drawing.Size(191, 611);
            this.PnlSolMenü.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 563);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 38);
            this.label2.TabIndex = 32;
            this.label2.Text = "TEMSAN © 2019\r\nTÜM HAKLARI SAKLIDIR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(-3, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 60);
            this.label1.TabIndex = 32;
            this.label1.Text = "PROJE TAKİP \r\nOTOMASYONU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(222, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnGörev
            // 
            this.btnGörev.FlatAppearance.BorderSize = 0;
            this.btnGörev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGörev.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGörev.ForeColor = System.Drawing.Color.White;
            this.btnGörev.Image = ((System.Drawing.Image)(resources.GetObject("btnGörev.Image")));
            this.btnGörev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGörev.Location = new System.Drawing.Point(1, 397);
            this.btnGörev.Name = "btnGörev";
            this.btnGörev.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGörev.Size = new System.Drawing.Size(190, 57);
            this.btnGörev.TabIndex = 5;
            this.btnGörev.Text = "  Görevler";
            this.btnGörev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGörev.UseVisualStyleBackColor = true;
            this.btnGörev.Click += new System.EventHandler(this.btnGörev_Click);
            // 
            // btnPersonel
            // 
            this.btnPersonel.FlatAppearance.BorderSize = 0;
            this.btnPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonel.ForeColor = System.Drawing.Color.White;
            this.btnPersonel.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonel.Image")));
            this.btnPersonel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonel.Location = new System.Drawing.Point(1, 338);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPersonel.Size = new System.Drawing.Size(190, 57);
            this.btnPersonel.TabIndex = 4;
            this.btnPersonel.Text = "  Personeller";
            this.btnPersonel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnProje
            // 
            this.btnProje.FlatAppearance.BorderSize = 0;
            this.btnProje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProje.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProje.ForeColor = System.Drawing.Color.White;
            this.btnProje.Image = ((System.Drawing.Image)(resources.GetObject("btnProje.Image")));
            this.btnProje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProje.Location = new System.Drawing.Point(1, 279);
            this.btnProje.Name = "btnProje";
            this.btnProje.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnProje.Size = new System.Drawing.Size(190, 57);
            this.btnProje.TabIndex = 3;
            this.btnProje.Text = "  Projeler";
            this.btnProje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProje.UseVisualStyleBackColor = true;
            this.btnProje.Click += new System.EventHandler(this.btnProje_Click);
            // 
            // BtnAnasayfa
            // 
            this.BtnAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAnasayfa.FlatAppearance.BorderSize = 0;
            this.BtnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnasayfa.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAnasayfa.ForeColor = System.Drawing.Color.White;
            this.BtnAnasayfa.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnasayfa.Image")));
            this.BtnAnasayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAnasayfa.Location = new System.Drawing.Point(1, 220);
            this.BtnAnasayfa.Name = "BtnAnasayfa";
            this.BtnAnasayfa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAnasayfa.Size = new System.Drawing.Size(190, 57);
            this.BtnAnasayfa.TabIndex = 2;
            this.BtnAnasayfa.Text = "  Anasayfa";
            this.BtnAnasayfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAnasayfa.UseVisualStyleBackColor = true;
            this.BtnAnasayfa.Click += new System.EventHandler(this.BtnAnasayfa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(191, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 16);
            this.panel1.TabIndex = 2;
            // 
            // ZdCalisan
            // 
            this.ZdCalisan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZdCalisan.Location = new System.Drawing.Point(191, 16);
            this.ZdCalisan.Name = "ZdCalisan";
            this.ZdCalisan.ScrollGrace = 0D;
            this.ZdCalisan.ScrollMaxX = 0D;
            this.ZdCalisan.ScrollMaxY = 0D;
            this.ZdCalisan.ScrollMaxY2 = 0D;
            this.ZdCalisan.ScrollMinX = 0D;
            this.ZdCalisan.ScrollMinY = 0D;
            this.ZdCalisan.ScrollMinY2 = 0D;
            this.ZdCalisan.Size = new System.Drawing.Size(773, 595);
            this.ZdCalisan.TabIndex = 28;
            // 
            // görevUControl1
            // 
            this.görevUControl1.Location = new System.Drawing.Point(191, 13);
            this.görevUControl1.Name = "görevUControl1";
            this.görevUControl1.Size = new System.Drawing.Size(789, 638);
            this.görevUControl1.TabIndex = 6;
            // 
            // personelUControl1
            // 
            this.personelUControl1.BackColor = System.Drawing.Color.LightCyan;
            this.personelUControl1.Location = new System.Drawing.Point(191, 13);
            this.personelUControl1.Name = "personelUControl1";
            this.personelUControl1.Size = new System.Drawing.Size(789, 638);
            this.personelUControl1.TabIndex = 5;
            // 
            // projeUControl1
            // 
            this.projeUControl1.BackColor = System.Drawing.Color.LightCyan;
            this.projeUControl1.Location = new System.Drawing.Point(191, 13);
            this.projeUControl1.Name = "projeUControl1";
            this.projeUControl1.Size = new System.Drawing.Size(789, 638);
            this.projeUControl1.TabIndex = 4;
            // 
            // Anamenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(964, 611);
            this.Controls.Add(this.ZdCalisan);
            this.Controls.Add(this.görevUControl1);
            this.Controls.Add(this.personelUControl1);
            this.Controls.Add(this.projeUControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlSolMenü);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(980, 650);
            this.MinimumSize = new System.Drawing.Size(980, 650);
            this.Name = "Anamenü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temsan Ar-Ge";
            this.PnlSolMenü.ResumeLayout(false);
            this.PnlSolMenü.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSolMenü;
        private System.Windows.Forms.Button btnGörev;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnProje;
        private System.Windows.Forms.Button BtnAnasayfa;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private ProjeUControl projeUControl1;
        private PersonelUControl personelUControl1;
        private GörevUControl görevUControl1;
        public ZedGraph.ZedGraphControl ZdCalisan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

