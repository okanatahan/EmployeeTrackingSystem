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
    public partial class YoneticiAtama : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=OKAN\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
        public YoneticiAtama()
        {
            InitializeComponent();
            DisplayPersonel();
        }

        public void DisplayPersonel()
        {
            try
            {
                conn.Open();
                String DisplayQuery = "SELECT * FROM Personel";

                using (SqlCommand cmd = new SqlCommand(DisplayQuery, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    PersonellerDGV.DataSource = dt;
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

        private void YoneticiAtaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string PersonelID = PersonellerDGV.Rows[PersonellerDGV.CurrentRow.Index].Cells[0].Value.ToString();
                String InsertQuery = "INSERT INTO Yoneticiler (FK_PersonelID, AD, SOYAD) VALUES (@PersonelID, @Ad, @Soyad)";
                String GetAd = "SELECT AD FROM Personel WHERE PersonelID = @PersonelID";
                String GetSoyad = "SELECT SOYAD FROM Personel WHERE PersonelID = @PersonelID";
                String ChangeRole = "UPDATE Kullanıcılar SET rol = @RolAdı WHERE FK_PersonelID = @PersonelID";
                string RolAdı = "yönetici";

                using (SqlCommand cmd = new SqlCommand(GetAd, conn))
                {
                    cmd.Parameters.AddWithValue("@PersonelID", PersonelID);
                    string Ad = cmd.ExecuteScalar().ToString();

                    cmd.Parameters.Clear();
                    cmd.CommandText = GetSoyad;
                    cmd.Parameters.AddWithValue("@PersonelID", PersonelID);
                    string Soyad = cmd.ExecuteScalar().ToString();

                    cmd.Parameters.Clear();
                    cmd.CommandText = InsertQuery;
                    cmd.Parameters.AddWithValue("@PersonelID", PersonelID);
                    cmd.Parameters.AddWithValue("@Ad", Ad);
                    cmd.Parameters.AddWithValue("@Soyad", Soyad);
                    cmd.ExecuteScalar();

                    cmd.Parameters.Clear();
                    cmd.CommandText = ChangeRole;
                    cmd.Parameters.AddWithValue("@RolAdı", RolAdı);
                    cmd.Parameters.AddWithValue("@PersonelID", PersonelID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(Ad + " " + Soyad + " başarıyla Yöneticiler'e eklendi.", "İşlem Başarılı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                DisplayPersonel();
            }
        }
    }
}
