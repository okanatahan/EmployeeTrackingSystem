using System;
using System.Text.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeTrackingSystem.Models;

namespace EmployeeTrackingSystem.UserControls
{
    public partial class DepartmanTanımlama : UserControl
    {
        private readonly HttpClient _httpClient;
        public DepartmanTanımlama()
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
            var response = await _httpClient.GetStringAsync("Departmanlar");
            var departman = JsonSerializer.Deserialize<List<DepartmanModel>>(response);
            DepartmanlarDGV.DataSource = departman;
        }

        private async void DepartmanEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var departmanModel = new DepartmanModel
                {
                    DEPARTMAN_ADI = DepartmanAdı.Text
                };

                var json = JsonSerializer.Serialize(departmanModel);
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("Departmanlar", content);

                if (response.IsSuccessStatusCode)
                {
                    //var responseData = await response.Content.ReadAsStringAsync();

                    UpdateListAsync();
                    MessageBox.Show("Departman Başarıyla Eklendi", "İşlem Başarılı!");
                    DepartmanAdı.Text = "";
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

        private async void DepartmanSilBtn_Click(object sender, EventArgs e)
        {
            int id = (int)DepartmanlarDGV.Rows[DepartmanlarDGV.CurrentRow.Index].Cells[0].Value;
            var response = await _httpClient.DeleteAsync($"Departmanlar/{id}");

            if (response.IsSuccessStatusCode)
            {
                UpdateListAsync();
                MessageBox.Show("Departman Başarıyla Silindi", "İşlem Başarılı!");
            }
            else
            {
                MessageBox.Show($"Hata: {response.StatusCode} - {response.ReasonPhrase}", "İşlem Başarısız!");
            }
        }

        private async void DepartmanDznBtn_Click(object sender, EventArgs e)
        {
            int id = (int)DepartmanlarDGV.Rows[DepartmanlarDGV.CurrentRow.Index].Cells[0].Value;

            var departmanModel = new DepartmanModel
            {
                ID = id,
                DEPARTMAN_ADI = YeniDepartmanAd.Text
            };

            var json = JsonSerializer.Serialize(departmanModel);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"Departmanlar/{id}", content);

            if (response.IsSuccessStatusCode)
            {
                UpdateListAsync();
                MessageBox.Show("Seçili Departman Başarıyla Güncellendi", "İşlem Başarılı");
                YeniDepartmanAd.Text = "";
            }
            else
            {
                MessageBox.Show($"Hata: {response.StatusCode} - {response.ReasonPhrase}", "İşlem Başarısız!");
            }
        }

        private void DepartmanlarDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DepartmanAdı.Text = DepartmanlarDGV.Rows[DepartmanlarDGV.CurrentRow.Index].Cells[2].Value.ToString();
        }
    }
}
