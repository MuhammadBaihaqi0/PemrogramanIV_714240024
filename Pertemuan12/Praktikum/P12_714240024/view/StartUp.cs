using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714240024.view
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //meanmbah nilai progress sebesar 5 setiap tick, progress bar berfungsi sebagai indikator loading
            progressBar1.Value += 5;

            //mengecek apakah progress bar sudah mencapai nilai maksimum 100
            if (progressBar1.Value == 100)
            {
                //menghentikan dan membersihkan Timer agar tidak terus berjalan
                timer1.Dispose();

                //menutup form startup
                Close();
            }
        }
    }
}
