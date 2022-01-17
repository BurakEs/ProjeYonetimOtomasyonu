namespace Proje
{
    partial class ProjeEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjeEkle));
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprojead = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnprjtmz = new System.Windows.Forms.Button();
            this.btnprjekle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "      Proje Ekle";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 30);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(388, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 264);
            this.panel2.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtprojead);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtprono);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnprjtmz);
            this.groupBox1.Controls.Add(this.btnprjekle);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 246);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proje Ekle";
            // 
            // txtAy
            // 
            this.txtAy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAy.Location = new System.Drawing.Point(118, 69);
            this.txtAy.Multiline = true;
            this.txtAy.Name = "txtAy";
            this.txtAy.Size = new System.Drawing.Size(256, 95);
            this.txtAy.TabIndex = 2;
            this.txtAy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAy_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Proje Ayrıntıları    :";
            // 
            // txtprojead
            // 
            this.txtprojead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprojead.Location = new System.Drawing.Point(118, 13);
            this.txtprojead.Name = "txtprojead";
            this.txtprojead.Size = new System.Drawing.Size(256, 20);
            this.txtprojead.TabIndex = 0;
            this.txtprojead.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAy_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Proje Adı             :";
            // 
            // txtprono
            // 
            this.txtprono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprono.Location = new System.Drawing.Point(119, 43);
            this.txtprono.Name = "txtprono";
            this.txtprono.Size = new System.Drawing.Size(256, 20);
            this.txtprono.TabIndex = 1;
            this.txtprono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAy_KeyPress_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(14, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Proje No             :";
            // 
            // btnprjtmz
            // 
            this.btnprjtmz.BackColor = System.Drawing.Color.Crimson;
            this.btnprjtmz.FlatAppearance.BorderSize = 0;
            this.btnprjtmz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprjtmz.ForeColor = System.Drawing.Color.Black;
            this.btnprjtmz.Image = ((System.Drawing.Image)(resources.GetObject("btnprjtmz.Image")));
            this.btnprjtmz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprjtmz.Location = new System.Drawing.Point(214, 177);
            this.btnprjtmz.Name = "btnprjtmz";
            this.btnprjtmz.Size = new System.Drawing.Size(150, 38);
            this.btnprjtmz.TabIndex = 4;
            this.btnprjtmz.Text = "Temizle";
            this.btnprjtmz.UseVisualStyleBackColor = false;
            this.btnprjtmz.Click += new System.EventHandler(this.btnprjtmz_Click_1);
            // 
            // btnprjekle
            // 
            this.btnprjekle.BackColor = System.Drawing.Color.GreenYellow;
            this.btnprjekle.FlatAppearance.BorderSize = 0;
            this.btnprjekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprjekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnprjekle.ForeColor = System.Drawing.Color.Black;
            this.btnprjekle.Image = ((System.Drawing.Image)(resources.GetObject("btnprjekle.Image")));
            this.btnprjekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprjekle.Location = new System.Drawing.Point(41, 177);
            this.btnprjekle.Name = "btnprjekle";
            this.btnprjekle.Size = new System.Drawing.Size(150, 38);
            this.btnprjekle.TabIndex = 3;
            this.btnprjekle.Text = "Projeyi Ekle";
            this.btnprjekle.UseVisualStyleBackColor = false;
            this.btnprjekle.Click += new System.EventHandler(this.btnprjekle_Click);
            // 
            // ProjeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 294);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjeEkle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnprjtmz;
        public System.Windows.Forms.Button btnprjekle;
        public System.Windows.Forms.TextBox txtprono;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtprojead;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtAy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}