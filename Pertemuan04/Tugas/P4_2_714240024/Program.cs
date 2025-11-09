using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240024
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Input Data Sepeda Motor ===");
 
            Console.Write("Masukkan Tipe Motor (misal: Matic, Sport,Dll): ");
            string tipeInput = Console.ReadLine();
            Console.Write("Masukkan Warna Motor: ");
            string warnaInput = Console.ReadLine();
            Console.Write("Masukkan Kapasitas Mesin (cc): ");
            // Mengubah input string menjadi integer
            if (!int.TryParse(Console.ReadLine(), out int ccInput))
            {
                ccInput = 150; 
                Console.WriteLine("Input CC tidak valid, menggunakan default 150cc.");
            }
            Console.WriteLine("=== Pembuatan Objek & Implementasi OOP ===");
            SepedaMotor motorSaya = new SepedaMotor(tipeInput, warnaInput, ccInput);
            Console.WriteLine($"Data berhasil dibuat untuk motor {motorSaya.Tipe}.");
            Console.WriteLine("Informasi Produk:");
            motorSaya.DisplayInfo();
            Console.Write("Aksi: ");
            motorSaya.Bergerak();
            motorSaya.Warna = "PINK";
            Console.WriteLine($"\nWarna diperbarui menjadi: {motorSaya.Warna}");
            Console.WriteLine("\nProgram Selesai. Tekan tombol apa saja untuk keluar...");
            Console.ReadKey();
        }
    }
}
