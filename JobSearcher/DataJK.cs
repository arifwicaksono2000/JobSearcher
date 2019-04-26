using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearcher
{
    public class DataJK //Class Pilihan User
    {
        List<string> combo_jurusan = new List<string>();
        List<string> combo_kota = new List<string>();

        public List<string> impor_jurusan()
        {
            return combo_jurusan;
        }

        public List<string> impor_kota()
        {
            return combo_kota;
        }

        public DataJK()
        {

            combo_kota.Add("Jakarta");
            combo_kota.Add("Semarang");
            combo_kota.Add("Jogja");

            combo_jurusan.Add("Teknik Nuklir");
            combo_jurusan.Add("Teknik Elektro");
            combo_jurusan.Add("Teknologi Informasi");

        }

    }
}
