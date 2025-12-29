using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P9_714240024.controller;

namespace P9_714240024.view
{
    public partial class FormLogin : Form
    {
        CekLogin Login = new CekLogin();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //mengecek apakah textbox username dan password masih kosong
            if (string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show(
                    "Username dan Password tidak boleh kosong!"
                    , "Peringatan", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
                return;
            }

            string username = tbUsername.Text;
            string password = tbPassword.Text;

            bool status = Login.cek_login(username, password);

            //Mengecek hasil login
            if (status)
            {
                MessageBox.Show(
                    "Login Berhasil!"
                    , "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                ParentForm pform = new ParentForm(); //membuat objek parentform
                Hide(); //menyembunyikan form login
                pform.Show(); //menampilkan parentform
            }

            else
            {
                MessageBox.Show(
                    "Username atau Password salah"
                    , "Gagal Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
            }
        }
    }
}
