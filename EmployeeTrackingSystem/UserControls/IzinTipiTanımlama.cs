using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using EmployeeTrackingSystem.Models;

namespace EmployeeTrackingSystem.UserControls
{
    public partial class IzinTipiTanımlama : UserControl
    {
        private readonly HttpClient _httpClient;
        public IzinTipiTanımlama()
        {
            InitializeComponent();
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("http://localhost:5000/api/")
            };
            UpdateListAsync();
        }

        private async void UpdateListAsync()
        {
            var response = await _httpClient.GetStringAsync("izintipleri");
            var izintipleri = JsonSerializer.Deserialize<List<IzinTipModel>>(response);
            IzinTipleriDGV.DataSource = izintipleri;
        }

        private async void IzinEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var izinTipModel = new IzinTipModel
                {
                    IZIN_TIPI = IzinAdı.Text
                };

                var json = JsonSerializer.Serialize(izinTipModel);
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("izintipleri", content);

                if (response.IsSuccessStatusCode)
                {
                    //var responseData = await response.Content.ReadAsStringAsync();

                    UpdateListAsync();
                    MessageBox.Show("İzin Tipi Başarıyla Eklendi", "İşlem Başarılı!");
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

        private async void IzinSilBtn_Click(object sender, EventArgs e)
        {
            int id = (int)IzinTipleriDGV.Rows[IzinTipleriDGV.CurrentRow.Index].Cells[0].Value;
            var response = await _httpClient.DeleteAsync($"izintipleri/{id}");

            if (response.IsSuccessStatusCode)
            {
                UpdateListAsync();
                MessageBox.Show("İzin Tipi Başarıyla Silindi", "İşlem Başarılı!");
            }
            else
            {
                MessageBox.Show($"Hata: {response.StatusCode} - {response.ReasonPhrase}", "İşlem Başarısız!");
            }
        }

        private async void IzniDznBtn_Click(object sender, EventArgs e)
        {
            int id = (int)IzinTipleriDGV.Rows[IzinTipleriDGV.CurrentRow.Index].Cells[0].Value;

            var izinTipiModel = new IzinTipModel
            {
                ID = id,
                IZIN_TIPI = YeniİzinAdı.Text
            };

            var json = JsonSerializer.Serialize(izinTipiModel);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"izintipleri/{id}", content);

            if (response.IsSuccessStatusCode)
            {
                UpdateListAsync();
                MessageBox.Show("Seçili İzin Tipi Başarıyla Güncellendi", "İşlem Başarılı");
            }
            else
            {
                MessageBox.Show($"Hata: {response.StatusCode} - {response.ReasonPhrase}", "İşlem Başarısız!");
            }
        }
    }
}
