using System;

namespace Modul4_103022400132
{
    class Program
    {
        static void Main(string[] args)
        {
            //KodePaket kodePaketObj = new KodePaket();
            //Console.Write("Masukkan Nama Paket: ");
            //string inputPaket = Console.ReadLine();
            //string hasilKode = kodePaketObj.getKodePaket(inputPaket);
            //Console.WriteLine("Hasil Kode Paket: " + hasilKode);
            //Console.WriteLine();

            MesinKopi mesin = new MesinKopi();
            bool berjalan = true;
            while (berjalan)
            {
                Console.WriteLine("=== PANEL KONTROL MESIN KOPI ===");
                Console.WriteLine("Status Saat Ini: " + mesin.currentState);
                Console.WriteLine("Opsi Kondisi:");
                Console.WriteLine("1. STANDBY");
                Console.WriteLine("2. START_BREW");
                Console.WriteLine("3. FINISH_BREW");
                Console.WriteLine("4. START_MAINTENANCE");
                Console.WriteLine("5. FINISH_MAINTENANCE");
                Console.WriteLine("6. POWER_OFF");
                Console.WriteLine("7. KELUAR PROGRAM");
                Console.Write("Pilih opsi (1-7): ");
                string pilihan = Console.ReadLine();
                Console.WriteLine();

                switch (pilihan)
                {
                    case "1": mesin.AktivasiKondisi("STANDBY"); break;
                    case "2": mesin.AktivasiKondisi("START_BREW"); break;
                    case "3": mesin.AktivasiKondisi("FINISH_BREW"); break;
                    case "4": mesin.AktivasiKondisi("START_MAINTENANCE"); break;
                    case "5": mesin.AktivasiKondisi("FINISH_MAINTENANCE"); break;
                    case "6": mesin.AktivasiKondisi("POWER_OFF"); break;
                    case "7": berjalan = false; break;
                    default: Console.WriteLine("Opsi tidak ada."); break;
                }
            }
        }
    }
}