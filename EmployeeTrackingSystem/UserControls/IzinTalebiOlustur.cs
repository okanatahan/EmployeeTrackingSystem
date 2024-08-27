﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using EmployeeTrackingSystem.Models;

namespace EmployeeTrackingSystem.UserControls
{
    public partial class IzinTalebiOlustur : UserControl
    {
        string id;
        private readonly HttpClient _httpClient;
        public IzinTalebiOlustur(string id)
        {
            InitializeComponent();
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:5000/api/")
            };
            this.id = id;
            SetComboBox();
            IzinBaslangicTar.MinDate = DateTime.Now;
            IzinBitisTar.MinDate = DateTime.Now;
        }

        private async void SetComboBox()
        {
            var json = await _httpClient.GetStringAsync("IzinTipleri");
            var response = JsonSerializer.Deserialize<List<IzinTipModel>>(json);
            var Sorted = response.OrderBy(d => d.ID).ToList();

            IzinTipleri.DataSource = Sorted;
            IzinTipleri.DisplayMember = "IZIN_TIPI";
            IzinTipleri.ValueMember = "IZIN_TIPI";
        }

        private void IzinBaslangicTar_ValueChanged(object sender, EventArgs e)
        {
            // Could be added the years of working value to the "Personel" table and according to that value, change the value
            // for IzinBitisTar.MaxDate
            // An Example: int c; string years; # Get the years from the database using PersonelID.
            // if (years >= 1 || years < 5) { c = 13 } else if (years >= 5 || years < 15) { c = 19 } else if (years >= 15) { c = 25 }
            // else { "Cannot request an annual leave" }
            // IzinBitisTar.MaxDate = IzinBaslangicTar.Value.AddDays(c);
            IzinBitisTar.MaxDate = IzinBaslangicTar.Value.AddDays(13);
            IzinBitisTar.MinDate = IzinBaslangicTar.Value;
        }

        private async void IzinTalepBtn_Click(object sender, EventArgs e)
        {
            // check the izintalepleri table by personelid where OnayDurumu is null, and if the count of rows is > 0,
            // then return; so that the user cannot create another annual leave request
            // then make FK_PersonelID in izintalepleri table Key again and add get by id method back to its controller
            // but change it so that it only retrieves data where onaydurumu is null. so, there will be 1 row.
            // then make changes to related user controls
            if (IzinTipleri.Text == "")
            {
                MessageBox.Show("Lütfen Bir İzin Tipi Seçiniz", "HATA!");
                return;
            }
            var talepJson = await _httpClient.GetStringAsync("izintalepleri");
            var talepResponse = JsonSerializer.Deserialize<List<IzinTalepModel>>(talepJson);
            var talepler = talepResponse.FindAll(
                delegate (IzinTalepModel it)
                {
                    return (it.FK_PersonelID == int.Parse(id)) && (it.OnayDurumu == null);
                }
                );
            if (talepler.Count > 0)
            {
                MessageBox.Show("Zaten Onay Bekleyen 1 İzin Talebiniz Var!", "HATA!");
                return;
            }
            try
            {
                var PersonelInfo = await _httpClient.GetStringAsync($"Personeller/{id}");
                var PersonelResponse = JsonSerializer.Deserialize<PersonelModel>(PersonelInfo);
                var PersonelAdSoyad = PersonelResponse.AD_SOYAD;
                var IzinTipi = IzinTipleri.SelectedValue;
                var YoneticiID = PersonelResponse.FK_YoneticiID;
                var YoneticiInfo = await _httpClient.GetStringAsync($"Yoneticiler/{YoneticiID}");
                var YoneticiResponse = JsonSerializer.Deserialize<YoneticiModel>(YoneticiInfo);
                var YoneticiAdSoyad = YoneticiResponse.AD_SOYAD;

                var izinTalep = new IzinTalepModel
                {
                    FK_PersonelID = int.Parse(id),
                    Ad_Soyad = PersonelAdSoyad,
                    IzinBaslangicTar = IzinBaslangicTar.Value,
                    IzinBitisTar = IzinBitisTar.Value,
                    FK_IzinTipi = IzinTipleri.SelectedValue.ToString(),
                    FK_YoneticiID = YoneticiID,
                    Yonetici = YoneticiAdSoyad
                };

                var json = JsonSerializer.Serialize(izinTalep);
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("izintalepleri", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("İzin Talebiniz Başarıyla Oluşturuldu", "Talep Başarılı!");
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
