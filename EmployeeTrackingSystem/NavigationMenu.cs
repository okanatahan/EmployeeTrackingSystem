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
    public partial class NavigationMenu : Form
    {
        string rol;
        string id;
        int index;
        userInterface userInterface;
        public NavigationMenu(string rol, string id)
        {
            InitializeComponent();
            this.rol = rol;
            this.id = id;

            if (rol == "ik")
            {
                izin_talebi_btn.Enabled = false;
                izin_talebi2_btn.Enabled = false;
                onay_talebi_btn.Enabled = false;
            }
            else if (rol == "personel")
            {
                personel_tanımlama_btn.Enabled = false;
                yonetici_atama_btn.Enabled = false;
                departman_btn.Enabled = false;
                izin_tipi_btn.Enabled = false;
                onay_talebi_btn.Enabled = false;
            }
            else
            {
                personel_tanımlama_btn.Enabled = false;
                yonetici_atama_btn.Enabled = false;
                departman_btn.Enabled = false;
                izin_tipi_btn.Enabled = false;
                izin_talebi_btn.Enabled = false;
                izin_talebi2_btn.Enabled = false;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void personel_tanımlama_btn_Click(object sender, EventArgs e)
        {
            this.index = 0;
            userInterface = new userInterface(index, id);
            userInterface.ShowDialog();
        }

        private void yonetici_atama_btn_Click(object sender, EventArgs e)
        {
            this.index = 1;
            userInterface = new userInterface(index, id);
            userInterface.ShowDialog();
        }

        private void departman_btn_Click(object sender, EventArgs e)
        {
            this.index = 2;
            userInterface = new userInterface(index, id);
            userInterface.ShowDialog();
        }

        private void izin_tipi_btn_Click(object sender, EventArgs e)
        {
            this.index = 3;
            userInterface = new userInterface(index, id);
            userInterface.ShowDialog();
        }

        private void izin_talebi_btn_Click(object sender, EventArgs e)
        {
            this.index = 4;
            userInterface = new userInterface(index, id);
            userInterface.ShowDialog();
        }

        private void onay_talebi_btn_Click(object sender, EventArgs e)
        {
            this.index = 5;
            userInterface = new userInterface(index, id);
            userInterface.ShowDialog();
        }
    }
}
