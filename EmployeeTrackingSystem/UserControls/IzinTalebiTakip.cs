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
    public partial class IzinTalebiTakip : UserControl
    {
        string id;
        public IzinTalebiTakip(string id)
        {
            this.id = id;
            InitializeComponent();
        }
    }
}
