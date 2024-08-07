using EmployeeTrackingSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeTrackingSystem
{
    public partial class UserInterface : System.Windows.Forms.Form
    {
        public UserInterface(UserControl uc)
        {
            InitializeComponent();
            InitializeNavigationControl(uc);
        }
        // navimenüde her bir if'in içine yeni obje aç uygun user control için sonra onu userinterface'e at parametreyle
        // burada onu panele ekle panel1.Controls.Add(obje_adı), dock ayarla, bringtofront yap
        private void InitializeNavigationControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
            uc.BringToFront();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Singleton.GetInstance().Show();
            this.Dispose();
        }
    }
}
