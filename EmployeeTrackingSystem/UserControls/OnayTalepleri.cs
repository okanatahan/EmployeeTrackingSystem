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
    public partial class OnayTalepleri : UserControl
    {
        string id;
        string YoneticiID;
        SqlConnection conn = new SqlConnection(@"Data Source=OKAN\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
        public OnayTalepleri(string id)
        {
            InitializeComponent();
            this.id = id;
            GetYoneticiID(id);
            DisplayTable(YoneticiID);
        }

        private void GetYoneticiID(string id)
        {
            try
            {
                conn.Open();
                String GetYoneticiID = "SELECT YoneticiID FROM Yoneticiler WHERE FK_PersonelID = @id";

                using (SqlCommand cmd = new SqlCommand(GetYoneticiID, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    this.YoneticiID = cmd.ExecuteScalar().ToString();
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

        private void DisplayTable(string YoneticiID)
        {
            try
            {
                conn.Open();
                String GetIzinTalepleri = "SELECT * FROM IzinTalepleri WHERE FK_YoneticiID = @YoneticiID";

                using (SqlCommand cmd = new SqlCommand(GetIzinTalepleri, conn))
                {
                    cmd.Parameters.AddWithValue("@YoneticiID", YoneticiID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv.DataSource = dt;
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

        private void OnayBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String UpdateQuery = "UPDATE IzinTalepleri SET OnayDurumu = @Onay WHERE FK_PersonelID = @id";
                string onay = "Onaylandı";

                using (SqlCommand cmd = new SqlCommand(UpdateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Onay", onay);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            { 
                conn.Close();
                DisplayTable(YoneticiID);
            }
        }

        private void RedBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String UpdateQuery = "UPDATE IzinTalepleri SET OnayDurumu = @Onay WHERE FK_PersonelID = @id";
                string onay = "Reddedildi";

                using (SqlCommand cmd = new SqlCommand(UpdateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Onay", onay);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                DisplayTable(YoneticiID);
            }
        }
    }
}
