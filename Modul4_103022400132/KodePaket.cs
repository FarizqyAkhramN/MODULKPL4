using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Modul4_103022400132
{
    public class KodePaket
    {
        private Dictionary<string, String> tabelKode = new Dictionary<string, string>()
        {
            {"Basic", "P201" },
            {"Standart", "P202" },
            {"Premium", "P203" },
            {"Unlimited", "P204" },
            {"Gaming", "P205" },
            {"Streaming", "P206" },
            {"Family", "P207" },
            {"Business", "P208" },
            {"Student", "P209" },
            {"Traveler", "P210" }
        };

        public string getKodePaket(string namaPaket)
        {
            if (tabelKode.ContainsKey(namaPaket))
            {
                return tabelKode[namaPaket];
            }
            else
            {
                return "Kode tidak ditemukan";
            }
        }
    }
}
