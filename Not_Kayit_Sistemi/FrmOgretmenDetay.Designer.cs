namespace Not_Kayit_Sistemi
{
    partial class FrmOgretmenDetay
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            txtSoyad = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtAd = new TextBox();
            mskNumara = new MaskedTextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtSinav3 = new TextBox();
            label4 = new Label();
            label6 = new Label();
            button2 = new Button();
            txtSinav2 = new TextBox();
            label5 = new Label();
            txtSinav1 = new TextBox();
            groupBox3 = new GroupBox();
            lblKalanSayisi = new Label();
            lblGecenSayisi = new Label();
            lblOrtalama = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(mskNumara);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 192);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Ekle";
            // 
            // button1
            // 
            button1.Location = new Point(30, 141);
            button1.Name = "button1";
            button1.Size = new Size(172, 35);
            button1.TabIndex = 6;
            button1.Text = "Öğrenci Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(93, 99);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(109, 27);
            txtSoyad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 102);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 4;
            label3.Text = "Soyad: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 69);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 3;
            label2.Text = "Ad: ";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(93, 66);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(109, 27);
            txtAd.TabIndex = 2;
            // 
            // mskNumara
            // 
            mskNumara.Location = new Point(93, 33);
            mskNumara.Mask = "0000";
            mskNumara.Name = "mskNumara";
            mskNumara.Size = new Size(109, 27);
            mskNumara.TabIndex = 1;
            mskNumara.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 36);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Numara: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSinav3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(txtSinav2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtSinav1);
            groupBox2.Location = new Point(238, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(220, 192);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sınav Notları";
            // 
            // txtSinav3
            // 
            txtSinav3.Location = new Point(93, 99);
            txtSinav3.Name = "txtSinav3";
            txtSinav3.Size = new Size(109, 27);
            txtSinav3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 102);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 8;
            label4.Text = "Sınav3: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 69);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 7;
            label6.Text = "Sınav2: ";
            // 
            // button2
            // 
            button2.Location = new Point(28, 141);
            button2.Name = "button2";
            button2.Size = new Size(172, 35);
            button2.TabIndex = 6;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtSinav2
            // 
            txtSinav2.Location = new Point(93, 66);
            txtSinav2.Name = "txtSinav2";
            txtSinav2.Size = new Size(109, 27);
            txtSinav2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 36);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 3;
            label5.Text = "Sınav1: ";
            // 
            // txtSinav1
            // 
            txtSinav1.Location = new Point(93, 33);
            txtSinav1.Name = "txtSinav1";
            txtSinav1.Size = new Size(109, 27);
            txtSinav1.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(lblKalanSayisi);
            groupBox3.Controls.Add(lblGecenSayisi);
            groupBox3.Controls.Add(lblOrtalama);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(464, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(178, 192);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sınıf Ortalaması";
            // 
            // lblKalanSayisi
            // 
            lblKalanSayisi.AutoSize = true;
            lblKalanSayisi.Location = new Point(126, 123);
            lblKalanSayisi.Name = "lblKalanSayisi";
            lblKalanSayisi.Size = new Size(25, 20);
            lblKalanSayisi.TabIndex = 11;
            lblKalanSayisi.Text = "00";
            // 
            // lblGecenSayisi
            // 
            lblGecenSayisi.AutoSize = true;
            lblGecenSayisi.Location = new Point(126, 90);
            lblGecenSayisi.Name = "lblGecenSayisi";
            lblGecenSayisi.Size = new Size(25, 20);
            lblGecenSayisi.TabIndex = 10;
            lblGecenSayisi.Text = "00";
            // 
            // lblOrtalama
            // 
            lblOrtalama.AutoSize = true;
            lblOrtalama.Location = new Point(126, 57);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(25, 20);
            lblOrtalama.TabIndex = 9;
            lblOrtalama.Text = "00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 123);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 8;
            label7.Text = "Kalan Sayısı: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 90);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 7;
            label8.Text = "Geçen Sayısı: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 57);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 3;
            label9.Text = "Ortalama: ";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(12, 210);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(630, 204);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Öğrenci Ekle";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(624, 178);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FrmOgretmenDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(654, 426);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmOgretmenDetay";
            Text = "Öğrenci Not Kayıt Sistemi";
            FormClosed += FrmOgretmenDetay_FormClosed;
            Load += FrmOgretmenDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtAd;
        private MaskedTextBox mskNumara;
        private Label label1;
        private Button button1;
        private TextBox txtSoyad;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox txtSinav3;
        private Label label4;
        private Label label6;
        private Button button2;
        private TextBox txtSinav2;
        private Label label5;
        private TextBox txtSinav1;
        private GroupBox groupBox3;
        private Label lblOrtalama;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblKalanSayisi;
        private Label lblGecenSayisi;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
    }
}