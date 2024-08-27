using EmployeeTrackingSystem.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace EmployeeTrackingSystem.UserControls
{
    public partial class PersonelTanımlama : UserControl
    {
        private readonly HttpClient _httpClient;
        public PersonelTanımlama(string id)
        {
            InitializeComponent();
            dob.CustomFormat = "dd/MM/yyyy";
            girisTar.CustomFormat = "dd/MM/yyyy";
            cikisTar.CustomFormat = "dd/MM/yyyy";
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("http://localhost:5000/api/")
            };
            UpdateList();
            SetComboBoxes();
        }

        private async void UpdateList()
        {
            var json = await _httpClient.GetStringAsync("Personeller");
            var personeller = JsonSerializer.Deserialize<List<PersonelModel>>(json);
            PersonellerDGV.DataSource = personeller;
        }

        private async void SetComboBoxes()
        {
            var IsletmeJson = await _httpClient.GetStringAsync("Isletmeler");
            Isletmeler.DataSource = JsonSerializer.Deserialize<List<IsletmeModel>>(IsletmeJson);
            Isletmeler.DisplayMember = "Isletme_Adı";
            Isletmeler.ValueMember = "IsletmeID";

            var DepartmanJson = await _httpClient.GetStringAsync("Departmanlar");
            Departmanlar.DataSource = JsonSerializer.Deserialize<List<DepartmanModel>>(DepartmanJson);
            Departmanlar.DisplayMember = "DEPARTMAN_ADI";
            Departmanlar.ValueMember = "DepartmanID";

            var AltDepartmanJson = await _httpClient.GetStringAsync("AltDepartmanlar");
            AltDepartmanlar.DataSource = JsonSerializer.Deserialize<List<AltDepartmanModel>>(AltDepartmanJson);
            AltDepartmanlar.DisplayMember = "Alt_Departman_Adı";
            AltDepartmanlar.ValueMember = "AltDepartmanID";

            var PozisyonJson = await _httpClient.GetStringAsync("Pozisyonlar");
            Pozisyonlar.DataSource = JsonSerializer.Deserialize<List<PozisyonModel>>(PozisyonJson);
            Pozisyonlar.DisplayMember = "Pozisyon_Adı";
            Pozisyonlar.ValueMember = "PozisyonID";

            var LokasyonJson = await _httpClient.GetStringAsync("Lokasyonlar");
            Lokasyonlar.DataSource = JsonSerializer.Deserialize<List<LokasyonModel>>(LokasyonJson);
            Lokasyonlar.DisplayMember = "Lokasyon_Adı";
            Lokasyonlar.ValueMember = "LokasyonID";

            var YoneticiJson = await _httpClient.GetStringAsync("Yoneticiler");
            Yoneticiler.DataSource = JsonSerializer.Deserialize<List<YoneticiModel>>(YoneticiJson);
            Yoneticiler.DisplayMember = "AD_SOYAD";
            Yoneticiler.ValueMember = "YoneticiID";

            var GecisJson = await _httpClient.GetStringAsync("Gecisler");
            Gecisler.DataSource = JsonSerializer.Deserialize<List<GecisModel>>(GecisJson);
            Gecisler.DisplayMember = "Gecis_Bilgisi";
            Gecisler.ValueMember = "GecisID";

            var SendikaJson = await _httpClient.GetStringAsync("Sendikalar");
            Sendikalar.DataSource = JsonSerializer.Deserialize<List<SendikaModel>>(SendikaJson);
            Sendikalar.DisplayMember = "Sendika_Bilgisi";
            Sendikalar.ValueMember = "SendikaID";

            var TaseronJson = await _httpClient.GetStringAsync("Taseronlar");
            Taseronlar.DataSource = JsonSerializer.Deserialize<List<TaseronModel>>(TaseronJson);
            Taseronlar.DisplayMember = "Taseron_Bilgisi";
            Taseronlar.ValueMember = "TaseronID";

            var MasrafJson = await _httpClient.GetStringAsync("Masraflar");
            Masraflar.DataSource = JsonSerializer.Deserialize<List<MasrafModel>>(MasrafJson);
            Masraflar.DisplayMember = "Masraf_Bilgisi";
            Masraflar.ValueMember = "MasrafID";
        }

        private async void PersonelEkleBtn_Click(object sender, EventArgs e)
        {
            if (AdInput.Text == "" || SoyadInput.Text == "" || SicilInput.Text == "" || (erkek.Checked == kadın.Checked)
                || UnvanInput.Text == "" || YakaInput.Text == "" || Isletmeler.Text == "" || Departmanlar.Text == ""
                || AltDepartmanlar.Text == "" || Pozisyonlar.Text == "" || Lokasyonlar.Text == "" || Gecisler.Text == "" 
                || (SenkronEvet.Checked == SenkronHayir.Checked) || Sendikalar.Text == "" || Taseronlar.Text == "" 
                || CalismaSekliInput.Text == "" || CalismaKonumuInput.Text == "" || DurumInput.Text == "" || SicilEkInput.Text == ""
                || SgkInput.Text == "" || Masraflar.Text == "")
            {
                MessageBox.Show("Lütfen Bütün Boşlukları Düzgün Bir Şekilde Doldurun.", "HATA");
                return;
            }
            try
            {
                string Cins = erkek.Checked ? "Erkek" : "Kadın";
                string Senkron = SenkronEvet.Checked ? "Evet": "Hayır";

                var personelModel = new PersonelModel
                {
                    SICIL = SicilInput.Text,
                    AD = AdInput.Text,
                    SOYAD = SoyadInput.Text,
                    CINSIYET = Cins,
                    DOGUM_TAR = dob.Value.Date,
                    GIRIS_TAR = girisTar.Value.Date,
                    CIKIS_TAR = cikisTar.Value.Date,
                    UNVAN = UnvanInput.Text,
                    YAKA = YakaInput.Text,
                    ISLETME_KOD = Isletmeler.SelectedValue.ToString(),
                    DEPARTMAN_KOD = Departmanlar.SelectedValue.ToString(),
                    DEPARTMAN_ALT_KOD = AltDepartmanlar.SelectedValue.ToString(),
                    POZISYON_KOD = Pozisyonlar.SelectedValue.ToString(),
                    LOKASYON_KOD = Lokasyonlar.SelectedValue.ToString(),
                    GECIS_KOD = Gecisler.SelectedValue.ToString(),
                    SENKRON = Senkron,
                    SENDIKA_KOD = Sendikalar.SelectedValue.ToString(),
                    TASERON_KOD = Taseronlar.SelectedValue.ToString(),
                    CALISMA_SEKLI = CalismaSekliInput.Text,
                    CALISMA_KONUMU = CalismaKonumuInput.Text,
                    DURUM = DurumInput.Text,
                    SICIL_EK = SicilEkInput.Text,
                    SGK_NO = SgkInput.Text,
                    MASRAF_KODU = Masraflar.SelectedValue.ToString(),
                    FK_YoneticiID = (int)Yoneticiler.SelectedValue
                };

                var json = JsonSerializer.Serialize(personelModel);
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("Personeller", content);

                if (response.IsSuccessStatusCode)
                {
                    UpdateList();
                    MessageBox.Show("Personel Başarıyla Eklendi", "İşlem Başarılı");
                }
                else
                {
                    MessageBox.Show($"Hata: {response.StatusCode} - {response.ReasonPhrase}", "İşlem Başarısız!");
                }

                AdInput.Text = ""; SoyadInput.Text = ""; SicilInput.Text = ""; erkek.Checked = false; kadın.Checked = false;
                UnvanInput.Text = ""; YakaInput.Text = ""; SenkronEvet.Checked = false; SenkronHayir.Checked = false;
                CalismaSekliInput.Text = ""; CalismaKonumuInput.Text = ""; DurumInput.Text = ""; SicilEkInput.Text = "";
                SgkInput.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}", "Hata");
            }
        }

        private async void PersonelSilBtn_Click(object sender, EventArgs e)
        {
            int id = (int)PersonellerDGV.Rows[PersonellerDGV.CurrentRow.Index].Cells[0].Value;

            var talepJson = await _httpClient.GetStringAsync("Yoneticiler");
            var talepler = JsonSerializer.Deserialize<List<YoneticiModel>>(talepJson);
            var talep = talepler.Find(ym => ym.FK_PersonelID == id);

            try
            {
                if (talep != null)
                {
                    var response = await _httpClient.DeleteAsync($"Yoneticiler/{talep.YoneticiID}");

                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Hata: {response.StatusCode} - {response.ReasonPhrase}", "İşlem Başarısız!");
                        return;
                    }
                }

                var response2 = await _httpClient.DeleteAsync($"Personeller/{id}");

                if (response2.IsSuccessStatusCode)
                {
                    UpdateList();
                    MessageBox.Show("Personel Başarıyla Silindi", "İşlem Başarılı");
                }
                else
                {
                    MessageBox.Show($"Hata: {response2.StatusCode} - {response2.ReasonPhrase}", "İşlem Başarısız!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}", "Hata");
            }
        }

        private async void PersonelGncBtn_Click(object sender, EventArgs e)
        {
            if (AdInput.Text == "" || SoyadInput.Text == "" || SicilInput.Text == "" || (erkek.Checked == kadın.Checked)
                || UnvanInput.Text == "" || YakaInput.Text == "" || Isletmeler.Text == "" || Departmanlar.Text == ""
                || AltDepartmanlar.Text == "" || Pozisyonlar.Text == "" || Lokasyonlar.Text == "" || Gecisler.Text == ""
                || (SenkronEvet.Checked == SenkronHayir.Checked) || Sendikalar.Text == "" || Taseronlar.Text == ""
                || CalismaSekliInput.Text == "" || CalismaKonumuInput.Text == "" || DurumInput.Text == "" || SicilEkInput.Text == ""
                || SgkInput.Text == "" || Masraflar.Text == "")
            {
                MessageBox.Show("Lütfen Bütün Boşlukları Düzgün Bir Şekilde Doldurun.", "HATA");
                return;
            }
            try
            {
                int id = (int)PersonellerDGV.Rows[PersonellerDGV.CurrentRow.Index].Cells[0].Value;
                string Cins = erkek.Checked ? "Erkek" : "Kadın";
                string Senkron = SenkronEvet.Checked ? "Evet" : "Hayır";

                var personelModel = new PersonelModel
                {
                    PersonelID = id,
                    SICIL = SicilInput.Text,
                    AD = AdInput.Text,
                    SOYAD = SoyadInput.Text,
                    CINSIYET = Cins,
                    DOGUM_TAR = dob.Value.Date,
                    GIRIS_TAR = girisTar.Value.Date,
                    CIKIS_TAR = cikisTar.Value.Date,
                    UNVAN = UnvanInput.Text,
                    YAKA = YakaInput.Text,
                    ISLETME_KOD = Isletmeler.SelectedValue.ToString(),
                    DEPARTMAN_KOD = Departmanlar.SelectedValue.ToString(),
                    DEPARTMAN_ALT_KOD = AltDepartmanlar.SelectedValue.ToString(),
                    POZISYON_KOD = Pozisyonlar.SelectedValue.ToString(),
                    LOKASYON_KOD = Lokasyonlar.SelectedValue.ToString(),
                    GECIS_KOD = Gecisler.SelectedValue.ToString(),
                    SENKRON = Senkron,
                    SENDIKA_KOD = Sendikalar.SelectedValue.ToString(),
                    TASERON_KOD = Taseronlar.SelectedValue.ToString(),
                    CALISMA_SEKLI = CalismaSekliInput.Text,
                    CALISMA_KONUMU = CalismaKonumuInput.Text,
                    DURUM = DurumInput.Text,
                    SICIL_EK = SicilEkInput.Text,
                    SGK_NO = SgkInput.Text,
                    MASRAF_KODU = Masraflar.SelectedValue.ToString(),
                    FK_YoneticiID = (int)Yoneticiler.SelectedValue
                };

                var json = JsonSerializer.Serialize(personelModel);
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PutAsync($"Personeller/{id}", content);

                if (response.IsSuccessStatusCode)
                {
                    UpdateList();
                    MessageBox.Show("Personel Bilgileri Başarıyla Güncellendi", "İşlem Başarılı");
                }
                else
                {
                    MessageBox.Show($"Hata: {response.StatusCode} - {response.ReasonPhrase}", "İşlem Başarısız!");
                }

                AdInput.Text = ""; SoyadInput.Text = ""; SicilInput.Text = ""; erkek.Checked = false; kadın.Checked = false;
                UnvanInput.Text = ""; YakaInput.Text = ""; SenkronEvet.Checked = false; SenkronHayir.Checked = false;
                CalismaSekliInput.Text = ""; CalismaKonumuInput.Text = ""; DurumInput.Text = ""; SicilEkInput.Text = "";
                SgkInput.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}", "Hata");
            }
        }

        private void PersonellerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = PersonellerDGV.Rows[e.RowIndex];
                SicilInput.Text = row.Cells[1].Value.ToString();
                AdInput.Text = row.Cells[2].Value.ToString();
                SoyadInput.Text = row.Cells[3].Value.ToString();

                if (row.Cells[5].Value.ToString() == "Erkek")
                {
                    kadın.Checked = false;
                    erkek.Checked = true;
                }
                else
                {
                    erkek.Checked = false;
                    kadın.Checked = true;
                }

                dob.Text = row.Cells[6].Value.ToString();
                girisTar.Text = row.Cells[7].Value.ToString();
                cikisTar.Text = row.Cells[8].Value.ToString();
                UnvanInput.Text = row.Cells[9].Value.ToString();
                YakaInput.Text = row.Cells[10].Value.ToString();
                Isletmeler.SelectedValue = row.Cells[11].Value;
                Departmanlar.SelectedValue = row.Cells[12].Value;
                AltDepartmanlar.SelectedValue = row.Cells[13].Value;
                Pozisyonlar.SelectedValue = row.Cells[14].Value;
                Lokasyonlar.SelectedValue = row.Cells[15].Value;
                Gecisler.SelectedValue = row.Cells[16].Value;

                if (row.Cells[17].Value.ToString() == "Hayır")
                {
                    SenkronEvet.Checked = false;
                    SenkronHayir.Checked = true;
                }
                else
                {
                    SenkronHayir.Checked = false;
                    SenkronEvet.Checked = true;
                }

                Sendikalar.SelectedValue = row.Cells[18].Value;
                Taseronlar.SelectedValue = row.Cells[19].Value;
                CalismaSekliInput.Text = row.Cells[20].Value.ToString();
                CalismaKonumuInput.Text = row.Cells[21].Value.ToString();
                DurumInput.Text = row.Cells[22].Value.ToString();
                SicilEkInput.Text = row.Cells[23].Value.ToString();
                SgkInput.Text = row.Cells[24].Value.ToString();
                Masraflar.SelectedValue = row.Cells[25].Value;
                Yoneticiler.SelectedValue = row.Cells[26].Value; // Null Object Error!
            }
        }
    }
}
