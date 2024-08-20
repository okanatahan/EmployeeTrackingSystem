using EmployeeTrackingSystem.DataSets.DepartmanlarDataSetTableAdapters;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeTrackingSystem.UserControls
{
    public partial class DepartmanTanımlama : UserControl
    {
        DepartmanlarTableAdapter ta = new DepartmanlarTableAdapter();
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
            var response = await _httpClient.GetStringAsync("Departman");
            var personel = JsonSerializer.Deserialize<List<DepartmanModel>>(response);
            DepartmanlarDGV.DataSource = personel;
            //DepartmanlarDGV.DataSource = ta.GetData();
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

                var response = await _httpClient.PostAsync("Departman", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseData = await response.Content.ReadAsStringAsync();

                    UpdateListAsync();
                    MessageBox.Show("Departman Başarıyla Eklendi", "İşlem Başarılı!");
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}", "İşlem Başarısız!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}", "Error");
            }
            //ta.InsertQuery(d);
        }

        private async void DepartmanSilBtn_Click(object sender, EventArgs e)
        {
            int id = (int)DepartmanlarDGV.Rows[DepartmanlarDGV.CurrentRow.Index].Cells[0].Value;
            await _httpClient.DeleteAsync($"Departman/{id}");
            UpdateListAsync();
            MessageBox.Show("Departman Başarıyla Silindi", "İşlem Başarılı!");
        }

        private void DepartmanDznBtn_Click(object sender, EventArgs e)
        {

        }
    }

    public class DepartmanModel
    {
        public int ID { get; set; }
        public string DepartmanID => $"DEP{ID}";
        public string DEPARTMAN_ADI { get; set; }
    }
}
