﻿using EmployeeTrackingSystem.UserControls;
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
        NavigationControl navigationControl;
        int index;
        string id;
        public UserInterface(int index, string id)
        {
            InitializeComponent();
            this.index = index;
            this.id = id;
            InitializeNavigationControl(index, id);
        }

        private void InitializeNavigationControl(int index, string id)
        {
            List<UserControl> userControls = new List<UserControl>()
            { new PersonelTanımlama(id), new YoneticiAtama(), new DepartmanTanımlama(), new IzinTipiTanımlama(), new IzinTalebiOlustur(id), new IzinTalebiTakip(id), new OnayTalepleri(id) };

            navigationControl = new NavigationControl(userControls, panel1);
            navigationControl.Display(index);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Singleton.GetInstance().Show();
            this.Dispose();
        }
    }
}
