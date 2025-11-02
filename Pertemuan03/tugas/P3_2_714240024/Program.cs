using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714240024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char repeat = 'Y';

            do
            {
                Console.Clear(); 
                Console.WriteLine("=== MENU PERSEGI PANJANG ===");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu (1-3): ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    choice = -1; 
                }
                double panjang, lebar;
                switch (choice)
                {
                    case 1:
                        Console.Write("Masukkan panjang: ");
                        panjang = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan lebar: ");
                        lebar = Convert.ToDouble(Console.ReadLine());
                       
                        double luas = panjang * lebar;
                        Console.WriteLine("Luas Persegi Panjang: " + luas);
                        break;

                    case 2:
                        Console.Write("Masukkan panjang: ");
                        panjang = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan lebar: ");
                        lebar = Convert.ToDouble(Console.ReadLine());

                        double keliling = 2 * (panjang + lebar);
                        Console.WriteLine("Keliling Persegi Panjang: " + keliling);
                        break;

                    case 3:
                        Console.WriteLine("Program selesai.");
                        repeat = 'T'; 
                        break;

                    default:
                        Console.WriteLine("Menu tidak tersedia. Silakan pilih menu yang valid.");
                        break;
                }

                if (choice != 3)
                {
                    Console.Write("Ingin mengulang kembali (Y/T)? ");
                    repeat = Convert.ToChar(Console.ReadLine());
                }
            } while (repeat == 'Y' || repeat == 'y');

            Console.WriteLine("Terima kasih!");
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();

        }
    }
}
