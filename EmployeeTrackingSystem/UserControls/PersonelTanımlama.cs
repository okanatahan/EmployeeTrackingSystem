using EmployeeTrackingSystem.IsletmelerDataSetTableAdapters;
using EmployeeTrackingSystem.PersonelDataSetTableAdapters;
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
        PersonelTableAdapter dt = new PersonelTableAdapter();
        IsletmelerTableAdapter dt2 = new IsletmelerTableAdapter();
        AltDepartmanlarDataSet dt3 = new AltDepartmanlarDataSet();
        PozisyonlarDataSet dt4 = new PozisyonlarDataSet();
        LokasyonlarDataSet dt5 = new LokasyonlarDataSet();
        string Ad, Soyad, Sicil, Cins, Unvan, Yaka, IsletmeKod, DepartmanKod, DepartmanAltKod, PozisyonKod, LokasyonKod, GecisKod,
                Senkron, SendikaKod, TaseronKod, CalismaSekli, CalismaKonumu, Durum, SicilEk, SGK, MasrafKod;

        public PersonelTanımlama(string id)
        {
            InitializeComponent();
            dob.CustomFormat = "dd/MM/yyyy";
            girisTar.CustomFormat = "dd/MM/yyyy";
            cikisTar.CustomFormat = "dd/MM/yyyy";
            PersonellerDGV.DataSource = dt.GetData();
        }

        private void SetComboBoxes()
        {
            IsletmelerDataSet.IsletmelerDataTable dataTable = dt2.GetData();
            dataTable.Columns.Add(
                "Display",
                typeof(string),
                "IsletmeID + ' - ' + Isletme_Adı"
             );
            Isletmeler.DataSource = dataTable;
            Isletmeler.DisplayMember = "Display";
            Isletmeler.ValueMember = "ID";


        }

        private void PersonelEkleBtn_Click(object sender, EventArgs e)
        {
            Ad = AdInput.Text; Soyad = SoyadInput.Text; Sicil = SicilInput.Text; Unvan = UnvanInput.Text; Yaka = YakaInput.Text;
        }

    }
}
