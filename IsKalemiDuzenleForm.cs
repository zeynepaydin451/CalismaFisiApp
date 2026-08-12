using CalismaFisiApp.Helpers;
using CalismaFisiApp.Models;
using CalismaFisiApp.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalismaFisiApp
{
    public partial class IsKalemiDuzenleForm : Form
    {
        private readonly IsKalemiRepository _isKalemiRepo = new IsKalemiRepository();
        private readonly ProjeRepository _projeRepo = new ProjeRepository();
        private readonly CalismaTuruRepository _calismaTuruRepo = new CalismaTuruRepository();
        
        private int _aktifKullaniciId = 0;
        private int? _duzenlenecekIsKalemiId = null;
        private IsKalemi _mevcutIsKalemi = null;

        public IsKalemiDuzenleForm(int kullaniciId, int? isKalemiId = null)
        {
            InitializeComponent();
            _aktifKullaniciId = kullaniciId;
            _duzenlenecekIsKalemiId = isKalemiId;

            this.Load += IsKalemiDuzenleForm_Load;
        }

        private void IsKalemiDuzenleForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Proje ve Çalışma Türü ComboBox'larını doldur
                ProjeleriYukle();
                CalismaTurleriniYukle();

                // Eğer düzenleme ise mevcut verileri yükle
                if (_duzenlenecekIsKalemiId.HasValue)
                {
                    MevcutVerileriYukle();
                    this.lblFormTitle.Text = "✎ İş Kalemi Düzenle";
                }
                else
                {
                    this.lblFormTitle.Text = "➕ Yeni İş Kalemi Ekle";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Form yüklenirken hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProjeleriYukle()
        {
            try
            {
                cmbProje.Items.Clear();
                List<Proje> projeler = _projeRepo.TumProjeleriGetir() ?? new List<Proje>();

                foreach (var proje in projeler)
                {
                    cmbProje.Items.Add(new { Text = proje.Ad, Value = proje.Id });
                }

                cmbProje.DisplayMember = "Text";
                cmbProje.ValueMember = "Value";

                if (cmbProje.Items.Count > 0)
                    cmbProje.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Projeler yüklenirken hata:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalismaTurleriniYukle()
        {
            try
            {
                cmbCalismaTuru.Items.Clear();
                List<CalismaTuru> turler = _calismaTuruRepo.TumCalismaTurleriGetir() ?? new List<CalismaTuru>();

                foreach (var tur in turler)
                {
                    cmbCalismaTuru.Items.Add(new { Text = tur.Ad, Value = tur.Id });
                }

                cmbCalismaTuru.DisplayMember = "Text";
                cmbCalismaTuru.ValueMember = "Value";

                if (cmbCalismaTuru.Items.Count > 0)
                    cmbCalismaTuru.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Çalışma türleri yüklenirken hata:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MevcutVerileriYukle()
        {
            try
            {
                _mevcutIsKalemi = _isKalemiRepo.IsKalemiGetir(_duzenlenecekIsKalemiId.Value);

                if (_mevcutIsKalemi != null)
                {
                    // ComboBox'larda değerleri seç
                    foreach (dynamic item in cmbProje.Items)
                    {
                        if (item.Value == _mevcutIsKalemi.ProjeId)
                        {
                            cmbProje.SelectedItem = item;
                            break;
                        }
                    }

                    foreach (dynamic item in cmbCalismaTuru.Items)
                    {
                        if (item.Value == _mevcutIsKalemi.CalismaTuruId)
                        {
                            cmbCalismaTuru.SelectedItem = item;
                            break;
                        }
                    }

                    txtAciklama.Text = _mevcutIsKalemi.Aciklama ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mevcut veriler yüklenirken hata:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasyon
                if (cmbProje.SelectedIndex < 0)
                {
                    MessageBox.Show("Lütfen bir proje seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbCalismaTuru.SelectedIndex < 0)
                {
                    MessageBox.Show("Lütfen bir çalışma türü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAciklama.Text))
                {
                    MessageBox.Show("Lütfen bir açıklama giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Seçilen değerleri al
                int projeId = ((dynamic)cmbProje.SelectedItem).Value;
                int calismaTuruId = ((dynamic)cmbCalismaTuru.SelectedItem).Value;
                string aciklama = txtAciklama.Text.Trim();

                // Yeni İş Kalemi oluştur veya güncelle
                if (_duzenlenecekIsKalemiId.HasValue)
                {
                    // Güncelleme
                    _mevcutIsKalemi.ProjeId = projeId;
                    _mevcutIsKalemi.CalismaTuruId = calismaTuruId;
                    _mevcutIsKalemi.Aciklama = aciklama;

                    if (_isKalemiRepo.IsKalemiGuncelle(_mevcutIsKalemi))
                    {
                        MessageBox.Show("İş kalemi başarıyla güncellendi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("İş kalemi güncellenirken hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Yeni kayıt
                    var yeniIsKalemi = new IsKalemi
                    {
                        KullaniciId = _aktifKullaniciId,
                        ProjeId = projeId,
                        CalismaTuruId = calismaTuruId,
                        Aciklama = aciklama,
                        OlusturmaTarihi = DateTime.Now
                    };

                    if (_isKalemiRepo.IsKalemiEkle(yeniIsKalemi))
                    {
                        MessageBox.Show("İş kalemi başarıyla eklendi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("İş kalemi eklenirken hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıt sırasında hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
