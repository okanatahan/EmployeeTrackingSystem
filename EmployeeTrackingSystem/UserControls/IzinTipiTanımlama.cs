using EmployeeTrackingSystem.DataSets.IzinTipleriDataSetTableAdapters;
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
    public partial class IzinTipiTanımlama : UserControl
    {
        IzinTipleriTableAdapter ta = new IzinTipleriTableAdapter();
        public IzinTipiTanımlama()
        {
            InitializeComponent();
            UpdateList();
        }

        private void UpdateList()
        {
            IzinTipleriDGV.DataSource = ta.GetData();
        }

        private void IzinEkleBtn_Click(object sender, EventArgs e)
        {
            string i = IzinAdı.Text;
            ta.InsertQuery(i);
            UpdateList();
            IzinAdı.Text = "";
            MessageBox.Show("İzin Tipi Başarıyla Eklendi", "İşlem Başarılı!");
        }

        private void IzinSilBtn_Click(object sender, EventArgs e)
        {
            int id = (int) IzinTipleriDGV.Rows[IzinTipleriDGV.CurrentRow.Index].Cells[0].Value;
            ta.DeleteQuery(id);
            UpdateList();
            MessageBox.Show("İzin Tipi Başarıyla Silindi", "İşlem Başarılı!");
        }

        private void IzniGuncelleBtn_Click(object sender, EventArgs e)
        {
            string n = YeniİzinAdı.Text;
            int id = (int) IzinTipleriDGV.Rows[IzinTipleriDGV.CurrentRow.Index].Cells[0].Value;
            ta.UpdateQuery(n, id);
            UpdateList();
            YeniİzinAdı.Text = "";
            MessageBox.Show("İzin Tipi Başarıyla Güncellendi", "İşlem Başarılı!");
        }
    }
}
