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

namespace EmployeeTrackingSystem.UserControls
{
    public partial class YoneticiAtama : UserControl
    {
        private readonly HttpClient _httpClient;
        public YoneticiAtama()
        {
            InitializeComponent();
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:5000/api/")
            };
            DisplayTable();
        }

        public async void DisplayTable()
        {
            try
            {
                var PersonelJson = await _httpClient.GetStringAsync("Personeller");
                var Personeller = JsonSerializer.Deserialize<List<PersonelModel>>(PersonelJson);

                PersonellerDGV.DataSource = Personeller;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}", "Hata");
            }
        }

        private async void YoneticiAtaBtn_Click(object sender, EventArgs e)
        {
            string PersonelID = PersonellerDGV.Rows[PersonellerDGV.CurrentRow.Index].Cells[0].Value.ToString();

            var KullaniciJson = await _httpClient.GetStringAsync($"kullanicilar/{PersonelID}");
            var KullaniciInfo = JsonSerializer.Deserialize<KullaniciModel>(KullaniciJson);
            if (KullaniciInfo.rol == "yonetici")
            {
                MessageBox.Show("Seçili Kişi Zaten Yönetici", "İşlem Başarısız!");
                return;
            }
            try
            {
                string AD = PersonellerDGV.Rows[PersonellerDGV.CurrentRow.Index].Cells[2].Value.ToString();
                string SOYAD = PersonellerDGV.Rows[PersonellerDGV.CurrentRow.Index].Cells[3].Value.ToString();

                var yoneticiModel = new YoneticiModel
                {
                    FK_PersonelID = int.Parse(PersonelID),
                    AD = AD,
                    SOYAD = SOYAD,
                };

                var json = JsonSerializer.Serialize(yoneticiModel);
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("Yoneticiler", content);

                var kullaniciModel = new KullaniciModel
                {
                    FK_PersonelID = KullaniciInfo.FK_PersonelID,
                    kullanıcı_adı = KullaniciInfo.kullanıcı_adı,
                    parola = KullaniciInfo.parola,
                    rol = "yonetici"
                };

                var json2 = JsonSerializer.Serialize(kullaniciModel);
                HttpContent content2 = new StringContent(json2, Encoding.UTF8, "application/json");
                var response2 = await _httpClient.PutAsync($"Kullanicilar/{PersonelID}", content2);

                if (response.IsSuccessStatusCode && response2.IsSuccessStatusCode)
                {
                    DisplayTable();
                    MessageBox.Show(AD + " " + SOYAD + " başarıyla Yöneticiler'e eklendi.", "İşlem Başarılı!");
                }
                else
                {
                    MessageBox.Show($"Hata: {response.StatusCode} - {response.ReasonPhrase}", "İşlem Başarısız!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}", "Hata");
            }
        }

        private async void YoneticiSilBtn_Click(object sender, EventArgs e)
        {
            string PersonelID = PersonellerDGV.Rows[PersonellerDGV.CurrentRow.Index].Cells[0].Value.ToString();

            var KullaniciJson = await _httpClient.GetStringAsync($"kullanicilar/{PersonelID}");
            var KullaniciInfo = JsonSerializer.Deserialize<KullaniciModel>(KullaniciJson);
            if (KullaniciInfo.rol != "yonetici")
            {
                MessageBox.Show("Seçili Kişi Zaten Yönetici Değil", "İşlem Başarısız!");
                return;
            }
            try
            {
                var YoneticilerJson = await _httpClient.GetStringAsync("Yoneticiler");
                var Yoneticiler = JsonSerializer.Deserialize<List<YoneticiModel>>(YoneticilerJson);
                var Yonetici = Yoneticiler.Find(
                    delegate (YoneticiModel ym)
                    {
                        return ym.FK_PersonelID == int.Parse(PersonelID);
                    }
                    );

                var response = await _httpClient.DeleteAsync($"Yoneticiler/{Yonetici.YoneticiID}");

                var kullaniciModel = new KullaniciModel
                {
                    FK_PersonelID = KullaniciInfo.FK_PersonelID,
                    kullanıcı_adı = KullaniciInfo.kullanıcı_adı,
                    parola = KullaniciInfo.parola,
                    rol = "personel"
                };

                var json2 = JsonSerializer.Serialize(kullaniciModel);
                HttpContent content2 = new StringContent(json2, Encoding.UTF8, "application/json");
                var response2 = await _httpClient.PutAsync($"Kullanicilar/{PersonelID}", content2);

                if (response.IsSuccessStatusCode && response2.IsSuccessStatusCode)
                {
                    DisplayTable();
                    string AD = PersonellerDGV.Rows[PersonellerDGV.CurrentRow.Index].Cells[2].Value.ToString();
                    string SOYAD = PersonellerDGV.Rows[PersonellerDGV.CurrentRow.Index].Cells[3].Value.ToString();
                    MessageBox.Show(AD + " " + SOYAD + " başarıyla Yöneticiler'den Silindi.", "İşlem Başarılı!");
                }
                else
                {
                    MessageBox.Show($"Hata: {response.StatusCode} - {response.ReasonPhrase}", "İşlem Başarısız!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}", "Hata");
            }
        }
    }
}
