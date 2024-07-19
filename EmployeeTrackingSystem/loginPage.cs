using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeTrackingSystem
{
    public partial class loginPage : System.Windows.Forms.Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=OKAN\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        public loginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void show_password_btn_CheckedChanged(object sender, EventArgs e)
        {
            password_input.PasswordChar = show_password_btn.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (username_input.Text == "" || password_input.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }

            userInterface userInterfaceObj = new userInterface();
            userInterfaceObj.Show();
            this.Hide();
        }
    }
}
