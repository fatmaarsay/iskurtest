namespace IskurTakipSistemi
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            lb_menu = new ListBox();
            pnl_datagrid = new Panel();
            dataGridView = new DataGridView();
            btn_ekle = new Button();
            btn_sil = new Button();
            btn_guncelle = new Button();
            label2 = new Label();
            tb_ara = new TextBox();
            tb_tc = new TextBox();
            label3 = new Label();
            tb_adsoyad = new TextBox();
            label4 = new Label();
            tb_iban = new TextBox();
            label5 = new Label();
            tb_gorevyeri = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dtp_ise_giris = new DateTimePicker();
            dtp_isten_cikis = new DateTimePicker();
            btn_coklu_giris = new Button();
            txt_id = new TextBox();
            label9 = new Label();
            panel1.SuspendLayout();
            pnl_datagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(459, 9);
            label1.Name = "label1";
            label1.Size = new Size(400, 20);
            label1.TabIndex = 0;
            label1.Text = "BURSA ULUDAĞ ÜNİVERSİTESİ İŞKUR GENÇLİK PROGRAMI ";
            // 
            // panel1
            // 
            panel1.Controls.Add(lb_menu);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 624);
            panel1.TabIndex = 1;
            // 
            // lb_menu
            // 
            lb_menu.FormattingEnabled = true;
            lb_menu.Items.AddRange(new object[] { "Puantaj", "Bordro", "Muhtasar Sgk Raporu", "Banka Listesi", "Katılımcı İşlemleri", "Kullanıcı Ayarları" });
            lb_menu.Location = new Point(3, 34);
            lb_menu.Name = "lb_menu";
            lb_menu.Size = new Size(244, 564);
            lb_menu.TabIndex = 0;
            lb_menu.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pnl_datagrid
            // 
            pnl_datagrid.Controls.Add(dataGridView);
            pnl_datagrid.Location = new Point(253, 65);
            pnl_datagrid.Name = "pnl_datagrid";
            pnl_datagrid.Size = new Size(977, 329);
            pnl_datagrid.TabIndex = 2;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(974, 366);
            dataGridView.TabIndex = 0;
            // 
            // btn_ekle
            // 
            btn_ekle.Location = new Point(962, 503);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(133, 29);
            btn_ekle.TabIndex = 3;
            btn_ekle.Text = "Ekle";
            btn_ekle.UseVisualStyleBackColor = true;
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(962, 468);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(133, 29);
            btn_sil.TabIndex = 4;
            btn_sil.Text = "Sil";
            btn_sil.UseVisualStyleBackColor = true;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(962, 433);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(133, 29);
            btn_guncelle.TabIndex = 5;
            btn_guncelle.Text = "Güncelle";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 35);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 6;
            label2.Text = "Ara";
            // 
            // tb_ara
            // 
            tb_ara.Location = new Point(299, 32);
            tb_ara.Name = "tb_ara";
            tb_ara.Size = new Size(235, 27);
            tb_ara.TabIndex = 7;
            // 
            // tb_tc
            // 
            tb_tc.Location = new Point(388, 434);
            tb_tc.Name = "tb_tc";
            tb_tc.Size = new Size(235, 27);
            tb_tc.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 437);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 8;
            label3.Text = "Tc Kimlik";
            label3.Click += label3_Click;
            // 
            // tb_adsoyad
            // 
            tb_adsoyad.Location = new Point(388, 467);
            tb_adsoyad.Name = "tb_adsoyad";
            tb_adsoyad.Size = new Size(235, 27);
            tb_adsoyad.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 470);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 10;
            label4.Text = "Ad Soyad";
            label4.Click += label4_Click;
            // 
            // tb_iban
            // 
            tb_iban.Location = new Point(388, 500);
            tb_iban.Name = "tb_iban";
            tb_iban.Size = new Size(235, 27);
            tb_iban.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 503);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 12;
            label5.Text = "İban Numarası";
            // 
            // tb_gorevyeri
            // 
            tb_gorevyeri.Location = new Point(388, 533);
            tb_gorevyeri.Name = "tb_gorevyeri";
            tb_gorevyeri.Size = new Size(235, 27);
            tb_gorevyeri.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(269, 536);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 14;
            label6.Text = "Görev Yeri";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(269, 568);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 16;
            label7.Text = "İşe Giriş Tarihi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(269, 601);
            label8.Name = "label8";
            label8.Size = new Size(113, 20);
            label8.TabIndex = 18;
            label8.Text = "İşten Çıkış Tarihi";
            // 
            // dtp_ise_giris
            // 
            dtp_ise_giris.Location = new Point(388, 566);
            dtp_ise_giris.Name = "dtp_ise_giris";
            dtp_ise_giris.Size = new Size(250, 27);
            dtp_ise_giris.TabIndex = 20;
            // 
            // dtp_isten_cikis
            // 
            dtp_isten_cikis.Location = new Point(388, 599);
            dtp_isten_cikis.Name = "dtp_isten_cikis";
            dtp_isten_cikis.Size = new Size(250, 27);
            dtp_isten_cikis.TabIndex = 21;
            // 
            // btn_coklu_giris
            // 
            btn_coklu_giris.Location = new Point(868, 616);
            btn_coklu_giris.Name = "btn_coklu_giris";
            btn_coklu_giris.Size = new Size(227, 29);
            btn_coklu_giris.TabIndex = 22;
            btn_coklu_giris.Text = "Çoklu Giriş (Excel)";
            btn_coklu_giris.UseVisualStyleBackColor = true;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(388, 401);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(235, 27);
            txt_id.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(269, 404);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 23;
            label9.Text = "Tc Kimlik";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 687);
            Controls.Add(txt_id);
            Controls.Add(label9);
            Controls.Add(btn_coklu_giris);
            Controls.Add(dtp_isten_cikis);
            Controls.Add(dtp_ise_giris);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(tb_gorevyeri);
            Controls.Add(label6);
            Controls.Add(tb_iban);
            Controls.Add(label5);
            Controls.Add(tb_adsoyad);
            Controls.Add(label4);
            Controls.Add(tb_tc);
            Controls.Add(label3);
            Controls.Add(tb_ara);
            Controls.Add(label2);
            Controls.Add(btn_guncelle);
            Controls.Add(btn_sil);
            Controls.Add(btn_ekle);
            Controls.Add(pnl_datagrid);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form1";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            pnl_datagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ListBox lb_menu;
        private Panel pnl_datagrid;
        private DataGridView dataGridView;
        private Button btn_ekle;
        private Button btn_sil;
        private Button btn_guncelle;
        private Label label2;
        private TextBox tb_ara;
        private TextBox tb_tc;
        private Label label3;
        private TextBox tb_adsoyad;
        private Label label4;
        private TextBox tb_iban;
        private Label label5;
        private TextBox tb_gorevyeri;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dtp_ise_giris;
        private DateTimePicker dtp_isten_cikis;
        private Button btn_coklu_giris;
        private TextBox txt_id;
        private Label label9;
    }
}
