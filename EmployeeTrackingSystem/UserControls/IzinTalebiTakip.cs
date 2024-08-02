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
    public partial class IzinTalebiTakip : UserControl
    {
        string id;
        SqlConnection conn = new SqlConnection(@"Data Source=OKAN\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
        public IzinTalebiTakip(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void DisplayTable()
        {
            try
            {
                conn.Open();
                String GetIzinTalepleri = "SELECT * FROM IzinTalepleri WHERE FK_PersonelID = @id";

                using (SqlCommand cmd = new SqlCommand(GetIzinTalepleri, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
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

        private void tlp_grntl_btn_Click(object sender, EventArgs e)
        {
            DisplayTable();
        }
    }
}
