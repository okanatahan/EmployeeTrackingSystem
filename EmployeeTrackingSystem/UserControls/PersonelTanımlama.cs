using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeTrackingSystem.UserControls
{
    public partial class PersonelTanımlama : UserControl
    {
        public PersonelTanımlama(string id)
        {
            InitializeComponent();
            dob.CustomFormat = "dd/MM/yyyy";
            girisTar.CustomFormat = "dd/MM/yyyy";
            cikisTar.CustomFormat = "dd/MM/yyyy";
        }

        private void PersonelEkleBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dob.Value.Date.ToString());
            string Ad, Soyad, Sicil, Cins, Unvan, Yaka, IsletmeKod, DepartmanKod, DepartmanAltKod, PozisyonKod, LokasyonKod, GecisKod,
                Senkron, SendikaKod, TaseronKod, CalismaSekli, CalismaKonumu, Durum, SicilEk, SGK, MasrafKod;

            Ad = AdInput.Text; Soyad = SoyadInput.Text; Sicil = SicilInput.Text; Unvan = UnvanInput.Text; Yaka = YakaInput.Text;

        }
    }
}
