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
        int id;
        String yonetici;
        SqlConnection conn = new SqlConnection(@"Data Source=OKAN\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
        public IzinTalebiOlustur(int id)
        {
            InitializeComponent();
            IzinBaslangicTar.MinDate = DateTime.Now;
            this.id = id;
        }

        private void IzinBaslangicTar_ValueChanged(object sender, EventArgs e)
        {
            IzinBitisTar.MaxDate = IzinBaslangicTar.Value.AddDays(13);
            IzinBitisTar.MinDate = IzinBaslangicTar.Value;
        }

        private void IzinTalepBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string InsertQuery = "INSERT INTO IzinTalepleri (FK_PersonelID, IzinBaslangicTar, IzinBitisTar, Yonetici) VALUES (@PersonelID, @IzinBasTar, @IzinBitTar, @Yonetici)";
                string query = "SELECT yonetici FROM Personel WHERE PersonelID = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@id", id);
                    this.yonetici = cmd.ExecuteScalar().ToString();
                }
                
                using (SqlCommand cmd = new SqlCommand(InsertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@PersonelID", id);
                    cmd.Parameters.AddWithValue("@IzinBasTar", IzinBaslangicTar.Value.Date);
                    cmd.Parameters.AddWithValue("@IzinBitTar", IzinBitisTar.Value.Date);
                    cmd.Parameters.AddWithValue("@Yonetici", yonetici);

                    cmd.ExecuteScalar();
                }
            }
            catch
            {

            }
        }
    }
}
