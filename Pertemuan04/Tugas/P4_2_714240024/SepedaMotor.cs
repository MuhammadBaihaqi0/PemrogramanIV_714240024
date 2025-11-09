using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240024
{
    public class SepedaMotor : Kendaraan
    {
        private int _ccMesin;
        public SepedaMotor(string tipe, string warna, int ccMesin)
            : base(tipe, warna) 
        {
            this._ccMesin = ccMesin;
        }
        public int CcMesin
        {
            get { return _ccMesin; }
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Tipe Kendaraan: {Tipe}");
            Console.WriteLine($"Warna Kendaraan: {Warna}");
            Console.WriteLine($"Kapasitas Mesin (cc): {CcMesin}");
            Console.WriteLine("------------------------------------------");
        }
        public override void Bergerak()
        {
            Console.WriteLine($"Sepeda motor {Warna} dengan mesin {CcMesin}cc melaju.");
        }
    }
}