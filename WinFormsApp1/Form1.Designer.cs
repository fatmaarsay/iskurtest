namespace WinFormsApp1
{
    partial class Form1
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
            label1 = new Label();
            panel1 = new Panel();
            lb_menu = new ListBox();
            panel2 = new Panel();
            dataGridView = new DataGridView();
            btn_kaydet = new Button();
            tb_ara = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(534, 9);
            label1.Name = "label1";
            label1.Size = new Size(400, 20);
            label1.TabIndex = 5;
            label1.Text = "BURSA ULUDAĞ ÜNİVERSİTESİ İŞKUR GENÇLİK PROGRAMI ";
            // 
            // panel1
            // 
            panel1.Controls.Add(lb_menu);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 744);
            panel1.TabIndex = 6;
            // 
            // lb_menu
            // 
            lb_menu.FormattingEnabled = true;
            lb_menu.Items.AddRange(new object[] { "Puantaj", "Bordro", "Muhtasar Sgk Raporu", "Banka Listesi", "Katılımcı İşlemleri", "Kullanıcı Ayarları" });
            lb_menu.Location = new Point(3, 34);
            lb_menu.Name = "lb_menu";
            lb_menu.Size = new Size(244, 584);
            lb_menu.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView);
            panel2.Location = new Point(268, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(968, 510);
            panel2.TabIndex = 7;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(968, 510);
            dataGridView.TabIndex = 0;
            // 
            // btn_kaydet
            // 
            btn_kaydet.Location = new Point(1075, 65);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(132, 29);
            btn_kaydet.TabIndex = 8;
            btn_kaydet.Text = "Kaydet";
            btn_kaydet.UseVisualStyleBackColor = true;
            // 
            // tb_ara
            // 
            tb_ara.Location = new Point(311, 67);
            tb_ara.Name = "tb_ara";
            tb_ara.Size = new Size(235, 27);
            tb_ara.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 70);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 9;
            label2.Text = "Ara";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 744);
            Controls.Add(tb_ara);
            Controls.Add(label2);
            Controls.Add(btn_kaydet);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private ListBox lb_menu;
        private Panel panel2;
        private DataGridView dataGridView;
        private Button btn_kaydet;
        private TextBox tb_ara;
        private Label label2;
    }
}