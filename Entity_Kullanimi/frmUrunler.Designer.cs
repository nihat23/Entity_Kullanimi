namespace Entity_Kullanimi
{
    partial class frmUrunler
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtS_Fiyat = new System.Windows.Forms.TextBox();
            this.txtA_Fiyat = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(805, 335);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(187, 29);
            this.btnGuncelle.TabIndex = 29;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(805, 300);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(187, 29);
            this.btnEkle.TabIndex = 28;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(805, 370);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(187, 29);
            this.btnSil.TabIndex = 27;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtS_Fiyat
            // 
            this.txtS_Fiyat.Location = new System.Drawing.Point(821, 152);
            this.txtS_Fiyat.Name = "txtS_Fiyat";
            this.txtS_Fiyat.Size = new System.Drawing.Size(171, 26);
            this.txtS_Fiyat.TabIndex = 26;
            // 
            // txtA_Fiyat
            // 
            this.txtA_Fiyat.Location = new System.Drawing.Point(821, 119);
            this.txtA_Fiyat.Name = "txtA_Fiyat";
            this.txtA_Fiyat.Size = new System.Drawing.Size(171, 26);
            this.txtA_Fiyat.TabIndex = 25;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(821, 86);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(171, 26);
            this.txtStok.TabIndex = 24;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(821, 53);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(171, 26);
            this.txtAd.TabIndex = 23;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(805, 265);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(187, 29);
            this.btnListele.TabIndex = 22;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(821, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(171, 26);
            this.txtId.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(716, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Satış Fiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(728, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Alış Fiyat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(764, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Stok:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(731, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Urun Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(785, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 372);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(728, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Kategori:";
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(821, 185);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(171, 28);
            this.cmbKategori.TabIndex = 31;
            // 
            // frmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1009, 409);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtS_Fiyat);
            this.Controls.Add(this.txtA_Fiyat);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "frmUrunler";
            this.Text = "Ürünler Sayfası";
            this.Load += new System.EventHandler(this.frmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtS_Fiyat;
        private System.Windows.Forms.TextBox txtA_Fiyat;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbKategori;
    }
}