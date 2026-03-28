using System;

namespace Modul4_103022400132
{
    class Program
    {
        static void Main(string[] args)
        {
            KodePaket kodePaketObj = new KodePaket();

            Console.Write("Masukkan Nama Paket: ");
            string input = Console.ReadLine();

            string hasil = kodePaketObj.getKodePaket(input);
            Console.WriteLine("Kode Paket: " + hasil);

            Console.WriteLine("\nTekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}