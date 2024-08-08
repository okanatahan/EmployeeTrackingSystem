﻿using EmployeeTrackingSystem.DataSets.PersonelDataSetTableAdapters;
using EmployeeTrackingSystem.DataSets.DepartmanlarDataSetTableAdapters;
using EmployeeTrackingSystem.DataSets.IsletmelerDataSetTableAdapters;
using EmployeeTrackingSystem.DataSets.AltDepartmanlarDataSetTableAdapters;
using EmployeeTrackingSystem.DataSets.PozisyonlarDataSetTableAdapters;
using EmployeeTrackingSystem.DataSets.LokasyonlarDataSetTableAdapters;
using EmployeeTrackingSystem.DataSets.YoneticilerDataSetTableAdapters;
using EmployeeTrackingSystem.DataSets.GecislerDataSetTableAdapters;
using EmployeeTrackingSystem.DataSets.SendikalarDataSetTableAdapters;
using EmployeeTrackingSystem.DataSets.TaseronlarDataSetTableAdapters;
using EmployeeTrackingSystem.DataSets.MasraflarDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeTrackingSystem.DataSets;

namespace EmployeeTrackingSystem.UserControls
{
    public partial class PersonelTanımlama : UserControl
    {
        PersonelTableAdapter dt = new PersonelTableAdapter();
        IsletmelerTableAdapter i = new IsletmelerTableAdapter();
        DepartmanlarTableAdapter d = new DepartmanlarTableAdapter();
        AltDepartmanlarTableAdapter ad = new AltDepartmanlarTableAdapter();
        PozisyonlarTableAdapter p = new PozisyonlarTableAdapter();
        LokasyonlarTableAdapter l = new LokasyonlarTableAdapter();
        YoneticilerTableAdapter y = new YoneticilerTableAdapter();
        GecislerTableAdapter g = new GecislerTableAdapter();
        SendikalarTableAdapter s = new SendikalarTableAdapter();
        TaseronlarTableAdapter t = new TaseronlarTableAdapter();
        MasraflarTableAdapter m = new MasraflarTableAdapter();

        public PersonelTanımlama(string id)
        {
            InitializeComponent();
            dob.CustomFormat = "dd/MM/yyyy";
            girisTar.CustomFormat = "dd/MM/yyyy";
            cikisTar.CustomFormat = "dd/MM/yyyy";
            SetComboBoxes();
        }

        private void UpdateList()
        {
            PersonellerDGV.DataSource = dt.GetData();
        }

        private void SetComboBoxes()
        {
            UpdateList();

            IsletmelerDataSet.IsletmelerDataTable dataTable = i.GetData();
            dataTable.Columns.Add(
                "Display",
                typeof(string),
                "IsletmeID + ' - ' + Isletme_Adı"
             );
            Isletmeler.DataSource = dataTable;
            Isletmeler.DisplayMember = "Display";
            Isletmeler.ValueMember = "IsletmeID";

            DepartmanlarDataSet.DepartmanlarDataTable dataTable2 = d.GetData();
            dataTable2.Columns.Add(
                "Display",
                typeof(string),
                "DepartmanID + ' - ' + Departman_Adı"
             );
            Departmanlar.DataSource = dataTable2;
            Departmanlar.DisplayMember = "Display";
            Departmanlar.ValueMember = "DepartmanID";

            AltDepartmanlarDataSet.AltDepartmanlarDataTable dataTable3 = ad.GetData();
            dataTable3.Columns.Add(
                "Display",
                typeof(string),
                "AltDepartmanID + ' - ' + Alt_Departman_Adı"
             );
            AltDepartmanlar.DataSource = dataTable3;
            AltDepartmanlar.DisplayMember = "Display";
            AltDepartmanlar.ValueMember = "AltDepartmanID";

            PozisyonlarDataSet.PozisyonlarDataTable dataTable4 = p.GetData();
            dataTable4.Columns.Add(
                "Display",
                typeof(string),
                "PozisyonID + ' - ' + Pozisyon_Adı"
             );
            Pozisyonlar.DataSource = dataTable4;
            Pozisyonlar.DisplayMember = "Display";
            Pozisyonlar.ValueMember = "PozisyonID";

            LokasyonlarDataSet.LokasyonlarDataTable dataTable5 = l.GetData();
            dataTable5.Columns.Add(
                "Display",
                typeof(string),
                "LokasyonID + ' - ' + Lokasyon_Adı"
             );
            Lokasyonlar.DataSource = dataTable5;
            Lokasyonlar.DisplayMember = "Display";
            Lokasyonlar.ValueMember = "LokasyonID";

            YoneticilerDataSet.YoneticilerDataTable dataTable6 = y.GetData();
            dataTable6.Columns.Add(
                "Display",
                typeof(string),
                "FK_PersonelID + ' - ' + AD_SOYAD"
             );
            Yoneticiler.DataSource = dataTable6;
            Yoneticiler.DisplayMember = "Display";
            Yoneticiler.ValueMember = "YoneticiID";

            GecislerDataSet.GecislerDataTable dataTable7 = g.GetData();
            dataTable7.Columns.Add(
                "Display",
                typeof(string),
                "GecisID + ' - ' + Gecis_Bilgisi"
             );
            Gecisler.DataSource = dataTable7;
            Gecisler.DisplayMember = "Display";
            Gecisler.ValueMember = "GecisID";

            SendikalarDataSet.SendikalarDataTable dataTable8 = s.GetData();
            dataTable8.Columns.Add(
                "Display",
                typeof(string),
                "SendikaID + ' - ' + Sendika_Bilgisi"
             );
            Sendikalar.DataSource = dataTable8;
            Sendikalar.DisplayMember = "Display";
            Sendikalar.ValueMember = "SendikaID";

            TaseronlarDataSet.TaseronlarDataTable dataTable9 = t.GetData();
            dataTable9.Columns.Add(
                "Display",
                typeof(string),
                "TaseronID + ' - ' + Taseron_Bilgisi"
             );
            Taseronlar.DataSource = dataTable9;
            Taseronlar.DisplayMember = "Display";
            Taseronlar.ValueMember = "TaseronID";

            MasraflarDataSet.MasraflarDataTable dataTable10 = m.GetData();
            dataTable10.Columns.Add(
                "Display",
                typeof(string),
                "MasrafID + ' - ' + Masraf_Bilgisi"
             );
            Masraflar.DataSource = dataTable10;
            Masraflar.DisplayMember = "Display";
            Masraflar.ValueMember = "MasrafID";
        }

        private void PersonelEkleBtn_Click(object sender, EventArgs e)
        {
            if (AdInput.Text == "" || SoyadInput.Text == "" || SicilInput.Text == "" || (erkek.Checked == kadın.Checked)
                || UnvanInput.Text == "" || YakaInput.Text == "" || Isletmeler.Text == "" || Departmanlar.Text == ""
                || AltDepartmanlar.Text == "" || Pozisyonlar.Text == "" || Lokasyonlar.Text == "" || Gecisler.Text == "" 
                || (SenkronEvet.Checked == SenkronHayir.Checked) || Sendikalar.Text == "" || Taseronlar.Text == "" 
                || CalismaSekliInput.Text == "" || CalismaKonumuInput.Text == "" || DurumInput.Text == "" || SicilEkInput.Text == ""
                || SgkInput.Text == "" || Masraflar.Text == "")
            {
                MessageBox.Show("Lütfen Bütün Boşlukları Düzgün Bir Şekilde Doldurun.", "HATA");
            }
            else
            {
                string Cins = erkek.Checked ? "Erkek" : "Kadın";
                bool Senkron = SenkronEvet.Checked ? true : false;
                dt.PersonelInsert(SicilInput.Text, AdInput.Text, SoyadInput.Text, Cins, dob.Value.Date.ToString(),
                    girisTar.Value.Date.ToString(), cikisTar.Value.Date.ToString(), UnvanInput.Text, YakaInput.Text,
                    Isletmeler.SelectedValue.ToString(), Departmanlar.SelectedValue.ToString(), AltDepartmanlar.SelectedValue.ToString(),
                    Pozisyonlar.SelectedValue.ToString(), Lokasyonlar.SelectedValue.ToString(), Gecisler.SelectedValue.ToString(),
                    Senkron, Sendikalar.SelectedValue.ToString(), Taseronlar.SelectedValue.ToString(), CalismaSekliInput.Text,
                    CalismaKonumuInput.Text, DurumInput.Text, SicilEkInput.Text, SgkInput.Text, Masraflar.SelectedValue.ToString(),
                    (int)Yoneticiler.SelectedValue);

                AdInput.Text = "";  SoyadInput.Text = "";  SicilInput.Text = ""; erkek.Checked = false;  kadın.Checked = false;
                UnvanInput.Text = "";  YakaInput.Text = "";  Isletmeler.Text = "";  Departmanlar.Text = "";
                AltDepartmanlar.Text = "";  Pozisyonlar.Text = "";  Lokasyonlar.Text = "";  Gecisler.Text = "";
                SenkronEvet.Checked = false; SenkronHayir.Checked = false;  Sendikalar.Text = ""; Taseronlar.Text = "";
                CalismaSekliInput.Text = ""; CalismaKonumuInput.Text = ""; DurumInput.Text = ""; SicilEkInput.Text = "";
                SgkInput.Text = "";  Masraflar.Text = ""; Yoneticiler.Text = "";

                UpdateList();
                MessageBox.Show("Personel Başarıyla Eklendi", "İşlem Başarılı");
            }
        }

        private void PersonelCikartBtn_Click(object sender, EventArgs e)
        {
            int id = (int)PersonellerDGV.Rows[PersonellerDGV.CurrentRow.Index].Cells[0].Value;
            dt.DeleteQuery(id);
            UpdateList();
            MessageBox.Show("Personel Başarıyla Silindi", "İşlem Başarılı");
        }

        private void PersonelGncBtn_Click(object sender, EventArgs e)
        {
            int id = (int)PersonellerDGV.Rows[PersonellerDGV.CurrentRow.Index].Cells[0].Value;
            
        }
    }
}
