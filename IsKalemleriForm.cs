using CalismaFisiApp.Helpers;
using CalismaFisiApp.Models;
using CalismaFisiApp.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CalismaFisiApp
{
    public partial class IsKalemleriForm : Form
    {
        private readonly IsKalemiRepository _repo = new IsKalemiRepository();

        private int _aktifSayfa = 1;
        private int _sayfaBoyutu = 5;
        private int _toplamKayit = 0;
        private int _toplamSayfa = 1;
        private int _aktifKullaniciId = 0;
        private string _aramaMetni = "";

        public IsKalemleriForm()
        {
            InitializeComponent();

            // Form Görünümü
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Event Bağlantıları
            txtArama.TextChanged += txtArama_TextChanged;
            cmbKayitSayisi.SelectedIndexChanged += cmbKayitSayisi_SelectedIndexChanged;

            // Sayfa Numarası Butonları
            button3.Click += SayfaButton_Click;
            button4.Click += SayfaButton_Click;
            button5.Click += SayfaButton_Click;
            button6.Click += SayfaButton_Click;
            button7.Click += SayfaButton_Click;
        }

        private void IsKalemleriForm_Load(object sender, EventArgs e)
        {
            if (Oturum.AktifKullanici == null)
            {
                MessageBox.Show("Oturum bilgisi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            _aktifKullaniciId = Oturum.AktifKullanici.Id;

            KayitSayisiniDoldur();
            SetupDataGridViewColumns();
            VeriYukle();
        }

        private void KayitSayisiniDoldur()
        {
            cmbKayitSayisi.Items.Clear();
            cmbKayitSayisi.Items.AddRange(new object[] { 5, 10, 20, 50 });
            cmbKayitSayisi.SelectedIndex = 0;
            _sayfaBoyutu = 5;
        }

        private void SetupDataGridViewColumns()
        {
            dgvIsKalemleri.AutoGenerateColumns = false;
            dgvIsKalemleri.Columns.Clear();

            // Grid Tasarım ve Stil Ayarları
            dgvIsKalemleri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIsKalemleri.RowTemplate.Height = 42;
            dgvIsKalemleri.EnableHeadersVisualStyles = false;
            dgvIsKalemleri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIsKalemleri.AllowUserToAddRows = false;
            dgvIsKalemleri.AllowUserToDeleteRows = false;
            dgvIsKalemleri.ReadOnly = true;

            dgvIsKalemleri.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvIsKalemleri.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgvIsKalemleri.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvIsKalemleri.DefaultCellStyle.Font = new Font("Segoe UI", 9f);
            dgvIsKalemleri.DefaultCellStyle.Padding = new Padding(6, 4, 6, 4);
            dgvIsKalemleri.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);

            // Kolon Eşleşmeleri
            dgvIsKalemleri.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colProje",
                HeaderText = "Proje",
                DataPropertyName = "ProjeAdi",
                FillWeight = 25
            });

            dgvIsKalemleri.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCalismaTuru",
                HeaderText = "Çalışma Türü",
                DataPropertyName = "CalismaTuruAdi",
                FillWeight = 25
            });

            dgvIsKalemleri.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAciklama",
                HeaderText = "Açıklama",
                DataPropertyName = "Aciklama",
                FillWeight = 40
            });

            // İşlem Butonları (Düzenle / Sil)
            dgvIsKalemleri.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "btnDuzenle",
                HeaderText = "İşlem",
                Text = "✎",
                UseColumnTextForButtonValue = true,
                FillWeight = 5,
                FlatStyle = FlatStyle.Flat
            });

            dgvIsKalemleri.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "btnSil",
                HeaderText = "",
                Text = "🗑",
                UseColumnTextForButtonValue = true,
                FillWeight = 5,
                FlatStyle = FlatStyle.Flat
            });
        }

        private void VeriYukle()
        {
            try
            {
                _toplamKayit = _repo.IsKalemleriToplamSayisiGetir(_aktifKullaniciId, _aramaMetni);
                _toplamSayfa = Math.Max(1, (int)Math.Ceiling((double)_toplamKayit / _sayfaBoyutu));

                if (_aktifSayfa < 1) _aktifSayfa = 1;
                if (_aktifSayfa > _toplamSayfa) _aktifSayfa = _toplamSayfa;

                int skip = (_aktifSayfa - 1) * _sayfaBoyutu;
                List<IsKalemi> liste = _repo.IsKalemleriGetirSayfali(_aktifKullaniciId, _aramaMetni, skip, _sayfaBoyutu) ?? new List<IsKalemi>();

                dgvIsKalemleri.DataSource = null;
                dgvIsKalemleri.DataSource = liste;
                dgvIsKalemleri.ClearSelection();

                SayfaButonlariniGuncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SayfaButonlariniGuncelle()
        {
            int startPage = ((_aktifSayfa - 1) / 5) * 5 + 1;

            button1.Enabled = _aktifSayfa > 1;
            button2.Enabled = startPage > 1;
            button8.Enabled = (startPage + 5) <= _toplamSayfa;
            button9.Enabled = _aktifSayfa < _toplamSayfa;

            Button[] sayfaButonlari = { button3, button4, button5, button6, button7 };

            for (int i = 0; i < sayfaButonlari.Length; i++)
            {
                int pageNo = startPage + i;
                Button btn = sayfaButonlari[i];

                if (pageNo <= _toplamSayfa)
                {
                    btn.Visible = true;
                    btn.Text = pageNo.ToString();
                    btn.Tag = pageNo;
                    btn.Enabled = true;

                    bool secili = (_aktifSayfa == pageNo);
                    btn.BackColor = secili ? Color.FromArgb(55, 74, 94) : Color.White;
                    btn.ForeColor = secili ? Color.White : Color.FromArgb(80, 80, 80);
                    btn.FlatAppearance.BorderSize = 0;
                }
                else
                {
                    btn.Visible = false;
                }
            }
        }

        // --- SAYFALAMA BUTON EKLENTİLERİ (CS1061 Hatalarını Çözer) ---
        private void button1_Click(object sender, EventArgs e)
        {
            if (_aktifSayfa > 1) { _aktifSayfa--; VeriYukle(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _aktifSayfa = Math.Max(1, _aktifSayfa - 5);
            VeriYukle();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _aktifSayfa = Math.Min(_toplamSayfa, _aktifSayfa + 5);
            VeriYukle();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_aktifSayfa < _toplamSayfa) { _aktifSayfa++; VeriYukle(); }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            _aramaMetni = txtArama.Text.Trim();
            _aktifSayfa = 1;
            VeriYukle();
        }

        private void cmbKayitSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKayitSayisi.SelectedItem == null) return;

            _sayfaBoyutu = Convert.ToInt32(cmbKayitSayisi.SelectedItem);
            _aktifSayfa = 1;
            VeriYukle();
        }

        private void SayfaButton_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is int page)
            {
                _aktifSayfa = page;
                VeriYukle();
            }
        }

        private void btnYeniIsKalemi_Click(object sender, EventArgs e)
        {
            using (var frm = new IsKalemiDuzenleForm(_aktifKullaniciId))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    VeriYukle();
                }
            }
        }

        private void dgvIsKalemleri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var satir = dgvIsKalemleri.Rows[e.RowIndex].DataBoundItem as IsKalemi;
            if (satir == null) return;

            string kolonAdi = dgvIsKalemleri.Columns[e.ColumnIndex].Name;

            if (kolonAdi == "btnDuzenle")
            {
                using (var frm = new IsKalemiDuzenleForm(_aktifKullaniciId, satir.Id))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        VeriYukle();
                    }
                }
            }
            else if (kolonAdi == "btnSil")
            {
                if (MessageBox.Show("Bu iş kalemini silmek istediğinize emin misiniz?", "Silme Onayı",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (_repo.IsKalemiSil(satir.Id))
                    {
                        MessageBox.Show("Kayıt silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        VeriYukle();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
