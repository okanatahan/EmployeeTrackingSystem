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
        public OnayTalepleri(string id)
        {
            InitializeComponent();
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:5000/api/")
            };
            DisplayTable(id);
        }

        private async void DisplayTable(string id)
        {
            try
            {
                var json = await _httpClient.GetStringAsync("izintalepleri");
                var izintalepleri = JsonSerializer.Deserialize<List<IzinTalepModel>>(json);

                var YoneticilerInfo = await _httpClient.GetStringAsync("yoneticiler");
                var YoneticilerResponse = JsonSerializer.Deserialize<List<YoneticiModel>>(json);

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

        private void OnayBtn_Click(object sender, EventArgs e)
        {
            int TempId = (int)OnayTalepleriDGV.Rows[OnayTalepleriDGV.CurrentRow.Index].Cells[0].Value;

            var izinTalepModel = new IzinTalepModel
            {
                OnayDurumu = "ONAYLANDI"
            };
        }

        private void RedBtn_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }
    }
}
