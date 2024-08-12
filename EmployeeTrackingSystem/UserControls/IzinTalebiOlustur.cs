using EmployeeTrackingSystem.DataSets;
using EmployeeTrackingSystem.DataSets.IzinTipleriDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeTrackingSystem.UserControls
{
    public partial class IzinTalebiOlustur : UserControl
    {
        string id;
        string YoneticiID;
        IzinTipleriTableAdapter ta = new IzinTipleriTableAdapter();
        SqlConnection conn = new SqlConnection(@"Data Source=OKAN\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
        public IzinTalebiOlustur(string id)
        {
            InitializeComponent();
            SetComboBox();
            IzinBaslangicTar.MinDate = DateTime.Now;
            IzinBitisTar.MinDate = DateTime.Now;
            this.id = id;
        }

        private void SetComboBox()
        {
            IzinTipleriDataSet.IzinTipleriDataTable dt = ta.GetData();
            IzinTipleri.DataSource = dt;
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

        private void IzinTalepBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String GetYoneticiID = "SELECT FK_YoneticiID FROM Personel WHERE PersonelID = @id";
                String InsertQuery = "INSERT INTO IzinTalepleri (FK_PersonelID, Ad_Soyad, IzinBaslangicTar, IzinBitisTar, FK_IzinTipi, FK_YoneticiID, Yonetici) VALUES (@PersonelID, @Ad_Soyad, @IzinBasTar, @IzinBitTar, @IzinTipi, @YoneticiID, @Yonetici)";
                
                using (SqlCommand cmd = new SqlCommand(GetYoneticiID, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    object result = cmd.ExecuteScalar();
                    this.YoneticiID = result.ToString();

                    String GetYonetici = "SELECT AD_SOYAD FROM Yoneticiler WHERE YoneticiID = @YoneticiID";
                    cmd.Parameters.Clear();
                    cmd.CommandText = GetYonetici;
                    cmd.Parameters.AddWithValue("@YoneticiID", YoneticiID);
                    string YoneticiAD_SOYAD = cmd.ExecuteScalar().ToString();

                    String GetAd_Soyad = "SELECT AD_SOYAD FROM Personel WHERE PersonelID = @id";
                    cmd.Parameters.Clear();
                    cmd.CommandText = GetAd_Soyad;
                    cmd.Parameters.AddWithValue("@id", id);
                    string PersonelAd_Soyad = cmd.ExecuteScalar().ToString();

                    cmd.Parameters.Clear();
                    cmd.CommandText = InsertQuery;
                    cmd.Parameters.AddWithValue("@PersonelID", id);
                    cmd.Parameters.AddWithValue("@Ad_Soyad", PersonelAd_Soyad);
                    cmd.Parameters.AddWithValue("@IzinBasTar", IzinBaslangicTar.Value.Date);
                    cmd.Parameters.AddWithValue("@IzinBitTar", IzinBitisTar.Value.Date);
                    cmd.Parameters.AddWithValue("@IzinTipi", IzinTipleri.SelectedValue);
                    cmd.Parameters.AddWithValue("@YoneticiID", YoneticiID);
                    cmd.Parameters.AddWithValue("@Yonetici", YoneticiAD_SOYAD);

                    cmd.ExecuteScalar();

                    MessageBox.Show("Talebiniz Başarıyla Oluşturuldu.", "Talep Başarılı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
