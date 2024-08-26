using EmployeeTrackingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeTrackingSystem
{
    public partial class LoginPage : System.Windows.Forms.Form
    {
        private readonly HttpClient _httpClient;
        public LoginPage()
        {
            InitializeComponent();
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("http://localhost:5000/api/")
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void show_password_btn_CheckedChanged(object sender, EventArgs e)
        {
            password_input.PasswordChar = show_password_btn.Checked ? '\0' : '*';
        }

        private async void login_btn_Click(object sender, EventArgs e)
        {
            if (username_input.Text == "" || password_input.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var json = await _httpClient.GetStringAsync("kullanicilar");
                var kullanicilar = JsonSerializer.Deserialize<List<KullaniciModel>>(json);

                var kullanici = kullanicilar.Find(k => k.kullanıcı_adı == username_input.Text && k.parola == password_input.Text);
                if (kullanici != null)
                {
                    Singleton.SetInstance(kullanici.rol, kullanici.FK_PersonelID.ToString());
                    NavigationMenu NaviObj = Singleton.GetInstance();
                    this.Hide();
                    NaviObj.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}", "Hata");
            }
        }

        private void password_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                login_btn_Click(sender, e);
            }
        }

        private void username_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password_input.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}