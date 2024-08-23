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
    public partial class OnayTalepleri : UserControl
    {
        private readonly HttpClient _httpClient;
        string id;
        public OnayTalepleri(string id)
        {
            InitializeComponent();
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:5000/api/")
            };
            this.id = id;
            DisplayTable();
        }

        private async void DisplayTable()
        {
            try
            {
                var json = await _httpClient.GetStringAsync("izintalepleri");
                var izintalepleri = JsonSerializer.Deserialize<List<IzinTalepModel>>(json);

                var YoneticilerInfo = await _httpClient.GetStringAsync("yoneticiler");
                var YoneticilerResponse = JsonSerializer.Deserialize<List<YoneticiModel>>(YoneticilerInfo);

                var yonetici = YoneticilerResponse.Find(
                    delegate (YoneticiModel ym)
                    {
                        return ym.FK_PersonelID == int.Parse(id);
                    }
                    );

                var results = izintalepleri.FindAll(
                    delegate (IzinTalepModel it)
                    {
                        return it.FK_YoneticiID == yonetici.YoneticiID;
                    }
                    );
                OnayTalepleriDGV.DataSource = results;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}", "Hata");
            }
        }

        private async void OnayBtn_Click(object sender, EventArgs e)
        {
            int TalepID = (int)OnayTalepleriDGV.Rows[OnayTalepleriDGV.CurrentRow.Index].Cells[0].Value;

            var PersonelJson = await _httpClient.GetStringAsync($"izintalepleri/{TalepID}");
            var PersonelResponse= JsonSerializer.Deserialize<IzinTalepModel>(PersonelJson);

            var izinTalepModel = new IzinTalepModel
            {
                TalepID = TalepID,
                FK_PersonelID = PersonelResponse.FK_PersonelID,
                Ad_Soyad = PersonelResponse.Ad_Soyad,
                IzinBaslangicTar = PersonelResponse.IzinBaslangicTar,
                IzinBitisTar = PersonelResponse.IzinBitisTar,
                FK_IzinTipi = PersonelResponse.FK_IzinTipi,
                FK_YoneticiID = PersonelResponse.FK_YoneticiID,
                Yonetici = PersonelResponse.Yonetici,
                OnayDurumu = "ONAYLANDI"
            };

            var json = JsonSerializer.Serialize(izinTalepModel);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"izintalepleri/{TalepID}", content);

            if (response.IsSuccessStatusCode)
            {
                DisplayTable();
                MessageBox.Show("Seçili İzin Talebi Başarıyla Onaylandı", "İşlem Başarılı!");
            }
            else
            {
                MessageBox.Show($"Hata: {response.StatusCode} - {response.ReasonPhrase}", "İşlem Başarısız!");
            }
        }

        private async void RedBtn_Click(object sender, EventArgs e)
        {
            int TalepID = (int)OnayTalepleriDGV.Rows[OnayTalepleriDGV.CurrentRow.Index].Cells[0].Value;

            var PersonelJson = await _httpClient.GetStringAsync($"izintalepleri/{TalepID}");
            var PersonelResponse = JsonSerializer.Deserialize<IzinTalepModel>(PersonelJson);

            var izinTalepModel = new IzinTalepModel
            {
                TalepID = TalepID,
                FK_PersonelID = PersonelResponse.FK_PersonelID,
                Ad_Soyad = PersonelResponse.Ad_Soyad,
                IzinBaslangicTar = PersonelResponse.IzinBaslangicTar,
                IzinBitisTar = PersonelResponse.IzinBitisTar,
                FK_IzinTipi = PersonelResponse.FK_IzinTipi,
                FK_YoneticiID = PersonelResponse.FK_YoneticiID,
                Yonetici = PersonelResponse.Yonetici,
                OnayDurumu = "REDDEDİLDİ"
            };

            var json = JsonSerializer.Serialize(izinTalepModel);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"izintalepleri/{TalepID}", content);

            if (response.IsSuccessStatusCode)
            {
                DisplayTable();
                MessageBox.Show("Seçili İzin Talebi Reddedildi", "İşlem Başarılı!");
            }
            else
            {
                MessageBox.Show($"Hata: {response.StatusCode} - {response.ReasonPhrase}", "İşlem Başarısız!");
            }
        }
    }
}
