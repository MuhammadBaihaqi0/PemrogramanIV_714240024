using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240024
{
    public abstract class Kendaraan
    {
        private string _tipe;
        private string _warna;
        public Kendaraan(string tipe, string warna)
        {
            _tipe = tipe;
            _warna = warna;
        }
        public string Tipe
        {
            get { return _tipe; }
            set { _tipe = value; }
        }
        public string Warna
        {
            get { return _warna; }
            set { _warna = value; } 
        }
        public abstract void DisplayInfo();
        public virtual void Bergerak()
        {
            Console.WriteLine("Kendaraan mulai bergerak...");
        }
    }
}