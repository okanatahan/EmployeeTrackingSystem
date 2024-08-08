using EmployeeTrackingSystem.DataSets.DepartmanlarDataSetTableAdapters;
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
    public partial class DepartmanTanımlama : UserControl
    {
        DepartmanlarTableAdapter ta = new DepartmanlarTableAdapter();
        
        public DepartmanTanımlama()
        {
            InitializeComponent();
            UpdateList();
        }

        private void UpdateList()
        {
            DepartmanlarDGV.DataSource = ta.GetData();
        }

        private void DepartmanEkleBtn_Click(object sender, EventArgs e)
        {
            string d = DepartmanAdı.Text;
            ta.InsertQuery(d);
            UpdateList();
            MessageBox.Show("Departman Başarıyla Eklendi", "İşlem Başarılı!");
        }
    }
}
