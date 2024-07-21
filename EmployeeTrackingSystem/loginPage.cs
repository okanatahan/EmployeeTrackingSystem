﻿using System;
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
        SqlConnection conn = new SqlConnection(@"Data Source=OKAN\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

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
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();

                        String selectUser = "SELECT * FROM kullanıcılar WHERE kullanıcı_adı = @username AND parola = @password";

                        using (SqlCommand cmd = new SqlCommand(selectUser, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", username_input.Text);
                            cmd.Parameters.AddWithValue("@password", password_input.Text);

                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.HasRows)
                            {
                                this.Hide();
                                userInterface userInterfaceObj = new userInterface(); // Find and add the role of the user as a parameter inside userInterface();
                                userInterfaceObj.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex, "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void password_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_btn_Click(sender, e);
            }
        }

        private void username_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password_input.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}