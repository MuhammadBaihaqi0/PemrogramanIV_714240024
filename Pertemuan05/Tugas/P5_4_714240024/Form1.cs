using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714240024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NamaAPP_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Anda harus memilih Jenis Kelamin", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            bool Kelasterpilih = checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked || checkBox6.Checked || checkBox7.Checked || checkBox8.Checked;
            if (!Kelasterpilih)
            {
                MessageBox.Show(
                  "Harus memilih salah satu dari pilihan kelas", "Warning",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool Jadwalterpilih = radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked;
            if (!Jadwalterpilih)
            {
                MessageBox.Show(
                  "Harus memilih salah satu dari pilihan jadwal", "Warning",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> kelas = new List<string>();
            if (checkBox1.Checked) kelas.Add("Sepak Bola");
            if (checkBox2.Checked) kelas.Add("Renang");
            if (checkBox3.Checked) kelas.Add("Tenis");
            if (checkBox4.Checked) kelas.Add("Yoga");
            if (checkBox5.Checked) kelas.Add("Basket");
            if (checkBox6.Checked) kelas.Add("Bulu Tangkis");
            if (checkBox7.Checked) kelas.Add("Voli");
            if (checkBox8.Checked) kelas.Add("Panahan");

            string jadwal = "";
            if (radioButton1.Checked) jadwal = radioButton1.Text;
            else if (radioButton2.Checked) jadwal = radioButton2.Text;
            else if (radioButton3.Checked) jadwal = radioButton3.Text;
            else if (radioButton4.Checked) jadwal = radioButton4.Text;

            MessageBox.Show(
              "Nama : " + textBox1.Text +
              "\nJenis Kelamin : " + comboBox1.Text +
              "\nTanggal Lahir : " + dateTimePicker1.Text +
              "\nPilihan Kelas : " + string.Join(", ", kelas) +
              "\nPilihan Jadwal : " + jadwal,
              "Informasi Pendaftaran",
              MessageBoxButtons.OK, MessageBoxIcon.Information);

          
        }
           

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
