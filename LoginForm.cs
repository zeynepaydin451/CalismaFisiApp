using CalismaFisiApp.Helpers;
using CalismaFisiApp.Repositories;
using System;
using System.Windows.Forms;

namespace CalismaFisiApp
{
    public partial class LoginForm : Form
    {
        private KullaniciRepository _kullaniciRepo = new KullaniciRepository();

        public LoginForm()
        {
            InitializeComponent();
            this.Load += LoginForm_Load;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.BeniHatirla)
            {
                txtEposta.Text = Properties.Settings.Default.HatirlanacakEposta;
                chkBeniHatirla.Checked = true;
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string eposta = txtEposta.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(eposta) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen e-posta adresi ve şifre alanlarını doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var kullanici = _kullaniciRepo.GirisKontrol(eposta, sifre);

                if (kullanici != null)
                {

                    if (chkBeniHatirla.Checked)
                    {
                        Properties.Settings.Default.HatirlanacakEposta = eposta;
                        Properties.Settings.Default.BeniHatirla = true;
                    }
                    else
                    {
                        Properties.Settings.Default.HatirlanacakEposta = string.Empty;
                        Properties.Settings.Default.BeniHatirla = false;
                    }

                    Properties.Settings.Default.Save();
                    
                    Oturum.AktifKullanici = kullanici;

                    MessageBox.Show($"Hoş geldiniz, {kullanici.AdSoyad}!", "Başarılı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    IsKalemleriForm anaForm = new IsKalemleriForm();
                    anaForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("E-posta adresiniz veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanı hatası oluştu: {ex.Message}", "Sistem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}