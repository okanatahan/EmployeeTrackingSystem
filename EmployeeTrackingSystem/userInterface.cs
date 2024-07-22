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
    public partial class userInterface : System.Windows.Forms.Form
    {
        NavigationControl navigationControl;
        int index;
        public userInterface(int index)
        {
            InitializeComponent();
            InitializeNavigationControl(index);
        }

        private void InitializeNavigationControl(int index)
        {
            List<UserControl> userControls = new List<UserControl>()
            { new PersonelTanımlama(), new YoneticiAtama(), new DepartmanTanımlama(), new IzinTipiTanımlama(), new IzinTalebiOlustur(), new OnayTalepleri() };

            navigationControl = new NavigationControl(userControls, panel1);
            navigationControl.Display(index);

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
