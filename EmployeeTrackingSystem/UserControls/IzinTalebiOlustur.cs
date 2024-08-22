using System;
using System.Collections.Generic;
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
    public partial class IzinTalebiOlustur : UserControl
    {
        string id;
        HttpClient _httpClient;
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
            if (IzinTipleri.Text == "")
            {
                MessageBox.Show("Lütfen Bir İzin Tipi Seçiniz", "HATA!");
                return;
            }
            try
            {
                var PersonelInfo = await _httpClient.GetStringAsync($"Personeller/{id}");
                var PersonelResponse = JsonSerializer.Deserialize<PersonelModel>(PersonelInfo);
                var PersonelAdSoyad = PersonelResponse.AD_SOYAD;
                var IzinTipi = IzinTipleri.SelectedValue;
                var YoneticiID = PersonelResponse.FK_YoneticiID;
                var YoneticiInfo = await _httpClient.GetStringAsync($"Yoneticiler/{id}");
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
                MessageBox.Show("Hata: " + ex, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    public class PersonelModel
    {
        public int PersonelID { get; set; }
        public string SICIL { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public string AD_SOYAD => $"{AD} {SOYAD}";
        public string CINSIYET { get; set; }
        public DateTime? DOGUM_TAR { get; set; }
        public DateTime? GIRIS_TAR { get; set; }
        public DateTime? CIKIS_TAR { get; set; }
        public string UNVAN { get; set; }
        public string YAKA { get; set; }
        public string ISLETME_KOD { get; set; }
        public string DEPARTMAN_KOD { get; set; }
        public string DEPARTMAN_ALT_KOD { get; set; }
        public string POZISYON_KOD { get; set; }
        public string LOKASYON_KOD { get; set; }
        public string GECIS_KOD { get; set; }
        public bool? SENKRON { get; set; }
        public string SENDIKA_KOD { get; set; }
        public string TASERON_KOD { get; set; }
        public string CALISMA_SEKLI { get; set; }
        public string CALISMA_KONUMU { get; set; }
        public string DURUM { get; set; }
        public string SICIL_EK { get; set; }
        public string SGK_NO { get; set; }
        public string MASRAF_KODU { get; set; }
        public int FK_YoneticiID { get; set; }
    }
    public class YoneticiModel
    {
        public int YoneticiID { get; set; }
        public int FK_PersonelID { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public string AD_SOYAD => $"{AD} {SOYAD}";
    }
    public class IzinTalepModel
    {
        public int FK_PersonelID { get; set; }
        public string Ad_Soyad { get; set; }
        public DateTime IzinBaslangicTar { get; set; }
        public DateTime IzinBitisTar { get; set; }
        public string FK_IzinTipi { get; set; }
        public int FK_YoneticiID { get; set; }
        public string Yonetici { get; set; }
        public string OnayDurumu { get; set; }
    }
    public class IzinTipModel
    {
        public int ID { get; set; }
        public string IZIN_TIPI { get; set; }
    }
}
