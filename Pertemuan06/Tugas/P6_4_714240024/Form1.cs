using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_4_714240024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void  SetErrorMessages(TextBox textBox, string warningMessage, string wrongMessage, string correctMessage)
        {
            epWarning.SetError(textBox, warningMessage);
            epWrong.SetError(textBox, wrongMessage);
            epCorrect.SetError(textBox, correctMessage);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if (txtNPM.Text == "")
            {
                SetErrorMessages(txtNPM, "Textbox NPM tidak boleh kosong!", "", "");
            }
            else if (txtNPM.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtNPM, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtNPM, "", "Inputan hanya boleh angka!", "");
            }    
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            if (txtNama.Text == "")
            {
                SetErrorMessages(txtNama, "Textbox Nama tidak boleh kosong!", "", "");
            }
            else if (txtNama.Text.All(Char.IsLetter))
            {
                SetErrorMessages(txtNama, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtNama, "", "Inputan hanya boleh Huruf!", "");
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                SetErrorMessages(txtUser, "Textbox Username tidak boleh kosong!", "", "");
            }
            else if (txtUser.Text.All(Char.IsLetter))
            {
                SetErrorMessages(txtUser, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtUser, "", "Inputan hanya boleh Huruf!", "");
            }
        }

        private void txtRequired_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                SetErrorMessages(txtEmail, "Textbox Email tidak boleh kosong!", "", "");
            }
            else if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                SetErrorMessages(txtEmail, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtEmail, "", "Format Email salah \nContoh: user@gmail.com!", "");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                SetErrorMessages(txtPassword, "Textbox Password tidak boleh kosong!", "", "");
            }
            else if (txtPassword.Text.All(Char.IsLetter))
            {
                SetErrorMessages(txtPassword, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtPassword, "", "Inputan hanya boleh angka!", "");
            }
        }

        private void txtAlasan_TextChanged(object sender, EventArgs e)
        {
            int minLength = 5;
            int maxLength = 15;
            int currentLength = txtAlasan.Text.Length;

            if (txtAlasan.Text == "")
            {
                SetErrorMessages(txtAlasan, "Textbox Alasan tidak boleh kosong!", "", "");
            }
            else if (currentLength >= minLength && currentLength <= maxLength)
            {
                txtAlasan.SelectionStart = txtAlasan.Text.Length; 
                SetErrorMessages(txtAlasan, "", "", "Panjang & Format OK!");
            }
            else
            {
                SetErrorMessages(txtAlasan, "", $"Panjang harus antara {minLength} dan {maxLength} karakter.", "");
            }
        }

        private void txtPanggilan_TextChanged(object sender, EventArgs e)
        {

            if (txtPanggilan.Text == "")
            {
                SetErrorMessages(txtPanggilan, "Textbox panggilan tidak boleh kosong!", "", "");
            }
            else
            {
                txtPanggilan.Text = txtPanggilan.Text.ToUpper();
                SetErrorMessages(txtPanggilan, "", "", "Format OK!");
            }
        }

        private void txtSms_TextChanged(object sender, EventArgs e)
        {
            if (txtSms.Text == "")
            {
                SetErrorMessages(txtSms, "Textbox Tingkat Semester tidak boleh kosong!", "", "");
            }
            else
            {
                txtSms.Text = txtSms.Text.ToLower();
                SetErrorMessages(txtSms, "", "", "Format OK!");
            }
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "NPM : " + txtNPM.Text +
        "\nNama Lengkap : " + txtNama.Text +
        "\nUsername : " + txtUser.Text +
        "\nEmail : " + txtEmail.Text +
        "\nPassword : " + txtPassword.Text +
        "\nNama Panggilan : " + txtAlasan.Text +
        "\nAlasan Gabung : " + txtPanggilan.Text +
        "\nTingkat Semester : " + txtSms.Text,
        "Informasi Pendaftaran",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
