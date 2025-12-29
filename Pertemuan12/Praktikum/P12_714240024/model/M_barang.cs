using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_714240024.model
{
    public class M_barang
    {
        string nama_barang, harga;

        public M_barang()
        {
        }

        public M_barang(string nama_barang, string harga)
        {
            this.NamaBarang = nama_barang;
            this.Harga = harga;
        }

        public string NamaBarang { get => nama_barang; set => nama_barang = value; }
        public string Harga { get => harga; set => harga = value; }
    }
}
