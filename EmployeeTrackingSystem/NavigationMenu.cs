using EmployeeTrackingSystem.UserControls;
using System;
using System.Windows.Forms;

namespace EmployeeTrackingSystem
{
    public partial class NavigationMenu : Form
    {
        string rol;
        string id;
        UserInterface userInterface;
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
            UserControl per = new PersonelTanımlama(id);
            userInterface = new UserInterface(per);
            this.Hide();
            userInterface.ShowDialog();
        }

        private void yonetici_atama_btn_Click(object sender, EventArgs e)
        {
            UserControl yon = new YoneticiAtama();
            userInterface = new UserInterface(yon);
            this.Hide();
            userInterface.ShowDialog();
        }

        private void departman_btn_Click(object sender, EventArgs e)
        {
            UserControl dep = new DepartmanTanımlama();
            userInterface = new UserInterface(dep);
            this.Hide();
            userInterface.ShowDialog();
        }

        private void izin_tipi_btn_Click(object sender, EventArgs e)
        {
            UserControl izin = new IzinTipiTanımlama();
            userInterface = new UserInterface(izin);
            this.Hide();
            userInterface.ShowDialog();
        }

        private void izin_talebi_btn_Click(object sender, EventArgs e)
        {
            UserControl izin2 = new IzinTalebiOlustur(id);
            userInterface = new UserInterface(izin2);
            this.Hide();
            userInterface.ShowDialog();
        }
        private void izin_talebi2_btn_Click(object sender, EventArgs e)
        {
            UserControl izin3 = new IzinTalebiTakip(id);
            userInterface = new UserInterface(izin3);
            this.Hide();
            userInterface.ShowDialog();
        }

        private void onay_talebi_btn_Click(object sender, EventArgs e)
        {
            UserControl onay = new OnayTalepleri(id);
            userInterface = new UserInterface(onay);
            this.Hide();
            userInterface.ShowDialog();
        }
    }
}
