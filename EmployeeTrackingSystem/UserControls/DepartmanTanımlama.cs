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
            var response = await _httpClient.GetStringAsync($"Departman");
            var personel = JsonSerializer.Deserialize<List<DepartmanModel>>(response);
            DepartmanlarDGV.DataSource = personel;
            //DepartmanlarDGV.DataSource = ta.GetData();
        }

        private void DepartmanEkleBtn_Click(object sender, EventArgs e)
        {
            string d = DepartmanAdı.Text;
            ta.InsertQuery(d);
            UpdateListAsync();
            MessageBox.Show("Departman Başarıyla Eklendi", "İşlem Başarılı!");
        }
    }

    public class DepartmanModel
    {
        public int ID { get; set; }
        public string DepartmanID => $"DEP{ID}";
        public string DEPARTMAN_ADI { get; set; }
    }
}
