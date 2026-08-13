namespace CalismaFisiApp
{
    partial class CalismaFisiForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalismaFisiForm));
            
            // Panel Üst (Header)
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();

            // Panel Sol (Navigation)
            this.pnlSol = new System.Windows.Forms.Panel();
            this.btnIsKalemiManager = new System.Windows.Forms.Button();
            this.btnCalismaFisi = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();

            // Ana İçerik Paneli
            this.pnlIcerik = new System.Windows.Forms.Panel();

            // DataGridView - Çalışma Kaydı
            this.dgvCalismaKaydi = new System.Windows.Forms.DataGridView();
            this.pnlKontroller = new System.Windows.Forms.Panel();

            // Kontrol Butonları
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.lblSaatlik = new System.Windows.Forms.Label();
            this.txtSaatlik = new System.Windows.Forms.TextBox();

            // Status Bar
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();

            // Timer
            this.timerCalisma = new System.Windows.Forms.Timer();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(55, 74, 94);
            this.pnlHeader.Controls.Add(this.lblBaslik);
            this.pnlHeader.Controls.Add(this.btnMenu);
            this.pnlHeader.Controls.Add(this.btnCikis);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 60;

            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = false;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Text = "📊 Çalışma Fişi";
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 14f, System.Drawing.FontStyle.Bold);
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);

            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Text = "☰";
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 16f);
            this.btnMenu.Size = new System.Drawing.Size(50, 60);
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);

            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Text = "✕";
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 14f);
            this.btnCikis.Size = new System.Drawing.Size(50, 60);
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);

            // 
            // pnlSol
            // 
            this.pnlSol.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlSol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSol.Controls.Add(this.lblKullaniciAdi);
            this.pnlSol.Controls.Add(this.btnAyarlar);
            this.pnlSol.Controls.Add(this.btnRaporlar);
            this.pnlSol.Controls.Add(this.btnCalismaFisi);
            this.pnlSol.Controls.Add(this.btnIsKalemiManager);
            this.pnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSol.Width = 220;
            this.pnlSol.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);

            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = false;
            this.lblKullaniciAdi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblKullaniciAdi.Text = "👤 Kullanıcı";
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.lblKullaniciAdi.Height = 35;
            this.lblKullaniciAdi.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.lblKullaniciAdi.TextAlign = System.Drawing.ContentAlignment.TopLeft;

            // 
            // btnIsKalemiManager
            // 
            this.btnIsKalemiManager.BackColor = System.Drawing.Color.Transparent;
            this.btnIsKalemiManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIsKalemiManager.FlatAppearance.BorderSize = 0;
            this.btnIsKalemiManager.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnIsKalemiManager.Text = "📋 İş Kalemlerim";
            this.btnIsKalemiManager.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.btnIsKalemiManager.Height = 45;
            this.btnIsKalemiManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIsKalemiManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIsKalemiManager.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnIsKalemiManager.Click += new System.EventHandler(this.btnIsKalemiManager_Click);

            // 
            // btnCalismaFisi
            // 
            this.btnCalismaFisi.BackColor = System.Drawing.Color.FromArgb(55, 74, 94);
            this.btnCalismaFisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalismaFisi.FlatAppearance.BorderSize = 0;
            this.btnCalismaFisi.ForeColor = System.Drawing.Color.White;
            this.btnCalismaFisi.Text = "📊 Çalışma Fişi";
            this.btnCalismaFisi.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnCalismaFisi.Height = 45;
            this.btnCalismaFisi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalismaFisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalismaFisi.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);

            // 
            // btnRaporlar
            // 
            this.btnRaporlar.BackColor = System.Drawing.Color.Transparent;
            this.btnRaporlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaporlar.FlatAppearance.BorderSize = 0;
            this.btnRaporlar.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnRaporlar.Text = "📈 Raporlar";
            this.btnRaporlar.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.btnRaporlar.Height = 45;
            this.btnRaporlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRaporlar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRaporlar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);

            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.Color.Transparent;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.FlatAppearance.BorderSize = 0;
            this.btnAyarlar.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.btnAyarlar.Text = "⚙️ Ayarlar";
            this.btnAyarlar.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.btnAyarlar.Height = 45;
            this.btnAyarlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyarlar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyarlar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);

            // 
            // pnlIcerik
            // 
            this.pnlIcerik.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.pnlIcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIcerik.Controls.Add(this.dgvCalismaKaydi);
            this.pnlIcerik.Controls.Add(this.pnlKontroller);

            // 
            // dgvCalismaKaydi
            // 
            this.dgvCalismaKaydi.AutoGenerateColumns = false;
            this.dgvCalismaKaydi.BackgroundColor = System.Drawing.Color.White;
            this.dgvCalismaKaydi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalismaKaydi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCalismaKaydi.Location = new System.Drawing.Point(0, 0);
            this.dgvCalismaKaydi.Name = "dgvCalismaKaydi";
            this.dgvCalismaKaydi.ReadOnly = true;
            this.dgvCalismaKaydi.RowTemplate.Height = 25;
            this.dgvCalismaKaydi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalismaKaydi.AllowUserToAddRows = false;
            this.dgvCalismaKaydi.AllowUserToDeleteRows = false;
            this.dgvCalismaKaydi.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // Grid Stil
            this.dgvCalismaKaydi.EnableHeadersVisualStyles = false;
            this.dgvCalismaKaydi.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.dgvCalismaKaydi.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.dgvCalismaKaydi.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.dgvCalismaKaydi.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.dgvCalismaKaydi.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvCalismaKaydi.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.dgvCalismaKaydi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            // 
            // pnlKontroller
            // 
            this.pnlKontroller.BackColor = System.Drawing.Color.White;
            this.pnlKontroller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKontroller.Controls.Add(this.txtSaatlik);
            this.pnlKontroller.Controls.Add(this.lblSaatlik);
            this.pnlKontroller.Controls.Add(this.btnTamamla);
            this.pnlKontroller.Controls.Add(this.btnDurdur);
            this.pnlKontroller.Controls.Add(this.btnBasla);
            this.pnlKontroller.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlKontroller.Height = 80;
            this.pnlKontroller.Padding = new System.Windows.Forms.Padding(10);

            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnBasla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasla.FlatAppearance.BorderSize = 0;
            this.btnBasla.ForeColor = System.Drawing.Color.White;
            this.btnBasla.Text = "▶ Başla";
            this.btnBasla.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnBasla.Size = new System.Drawing.Size(100, 40);
            this.btnBasla.Location = new System.Drawing.Point(10, 20);
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);

            // 
            // btnDurdur
            // 
            this.btnDurdur.BackColor = System.Drawing.Color.FromArgb(255, 152, 0);
            this.btnDurdur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurdur.FlatAppearance.BorderSize = 0;
            this.btnDurdur.ForeColor = System.Drawing.Color.White;
            this.btnDurdur.Text = "⏸ Durdur";
            this.btnDurdur.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnDurdur.Size = new System.Drawing.Size(100, 40);
            this.btnDurdur.Location = new System.Drawing.Point(120, 20);
            this.btnDurdur.Enabled = false;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);

            // 
            // btnTamamla
            // 
            this.btnTamamla.BackColor = System.Drawing.Color.FromArgb(244, 67, 54);
            this.btnTamamla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamamla.FlatAppearance.BorderSize = 0;
            this.btnTamamla.ForeColor = System.Drawing.Color.White;
            this.btnTamamla.Text = "✓ Tamamla";
            this.btnTamamla.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnTamamla.Size = new System.Drawing.Size(100, 40);
            this.btnTamamla.Location = new System.Drawing.Point(230, 20);
            this.btnTamamla.Enabled = false;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);

            // 
            // lblSaatlik
            // 
            this.lblSaatlik.AutoSize = true;
            this.lblSaatlik.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblSaatlik.Text = "Saatlik Ücret:";
            this.lblSaatlik.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblSaatlik.Location = new System.Drawing.Point(360, 25);

            // 
            // txtSaatlik
            // 
            this.txtSaatlik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaatlik.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.txtSaatlik.Location = new System.Drawing.Point(460, 22);
            this.txtSaatlik.Size = new System.Drawing.Size(80, 25);
            this.txtSaatlik.ReadOnly = true;

            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlAlt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAlt.Controls.Add(this.lblTarih);
            this.pnlAlt.Controls.Add(this.lblDurum);
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Height = 35;

            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = false;
            this.lblDurum.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDurum.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblDurum.Text = "✓ Hazır";
            this.lblDurum.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblDurum.Width = 200;
            this.lblDurum.Padding = new System.Windows.Forms.Padding(10, 8, 0, 0);

            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = false;
            this.lblTarih.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTarih.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblTarih.Text = System.DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            this.lblTarih.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblTarih.Width = 180;
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTarih.Padding = new System.Windows.Forms.Padding(0, 8, 10, 0);

            // 
            // timerCalisma
            // 
            this.timerCalisma.Interval = 1000;
            this.timerCalisma.Tick += new System.EventHandler(this.timerCalisma_Tick);

            // 
            // CalismaFisiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlIcerik);
            this.Controls.Add(this.pnlSol);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlAlt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalismaFisiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışma Fişi Yönetim Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CalismaFisiForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalismaFisiForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalismaKaydi)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnCikis;

        private System.Windows.Forms.Panel pnlSol;
        private System.Windows.Forms.Button btnIsKalemiManager;
        private System.Windows.Forms.Button btnCalismaFisi;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Label lblKullaniciAdi;

        private System.Windows.Forms.Panel pnlIcerik;
        private System.Windows.Forms.DataGridView dgvCalismaKaydi;
        private System.Windows.Forms.Panel pnlKontroller;

        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.Label lblSaatlik;
        private System.Windows.Forms.TextBox txtSaatlik;

        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblTarih;

        private System.Windows.Forms.Timer timerCalisma;
    }
}
