using EmployeeTrackingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeTrackingSystem.UserControls
{
    public partial class IzinTalebiTakip : UserControl
    {
        HttpClient _httpClient;
        public IzinTalebiTakip(string id)
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
                var results = izintalepleri.FindAll(
                    delegate (IzinTalepModel it)
                    {
                        return it.FK_PersonelID == int.Parse(id);
                    }
                    );
                IzinTalepleriDGV.DataSource = results;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
