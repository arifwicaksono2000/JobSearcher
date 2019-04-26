using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearcher
{
    class DataDP //Class Database
    {
        public string dana_didapatkan { get; set; }
        List<string> pekerjaan_tersedia = new List<string>();


        public List<string> impor_pekerjaan_lagi()
        {
            return pekerjaan_tersedia;
        }

        public DataDP(string kota, string jurusan)
        {
            if (kota == "Jakarta")
            {
                if (jurusan == "Teknik Elektro")
                {
                    pekerjaan_tersedia.Add("PT Elektro Jaya");
                    pekerjaan_tersedia.Add("PT Merdeka Listrik");

                    dana_didapatkan = "10.000.000";
                }

                if (jurusan == "Teknologi Informasi")
                {
                    pekerjaan_tersedia.Add("PT Infocom Nusantara");
                    pekerjaan_tersedia.Add("PT Google United");

                    dana_didapatkan = "45.000.000";
                }

                if (jurusan == "Teknik Nuklir")
                {
                    pekerjaan_tersedia.Add("CV Uranium Permata");
                    pekerjaan_tersedia.Add("PT Hantara");

                    dana_didapatkan = "16.400.000";
                }

            }

            if (kota == "Jogja")
            {
                if (jurusan == "Teknik Elektro")
                {
                    pekerjaan_tersedia.Add("PT Interjaya");
                    pekerjaan_tersedia.Add("PT Sukses Elektrika");

                    dana_didapatkan = "18.000.000";
                }

                if (jurusan == "Teknologi Informasi")
                {
                    pekerjaan_tersedia.Add("PT C. Pertama");
                    pekerjaan_tersedia.Add("PT Facebook Indonesia");
                    pekerjaan_tersedia.Add("PT GamaTIf");

                    dana_didapatkan = "30.000.000";
                }

                if (jurusan == "Teknik Nuklir")
                {
                    pekerjaan_tersedia.Add("PT V2 Energi");
                    pekerjaan_tersedia.Add("PT Komatora Hanas");

                    dana_didapatkan = "44.000.000";
                }

            }

            if (kota == "Semarang")
            {
                if (jurusan == "Teknik Elektro")
                {
                    pekerjaan_tersedia.Add("PT Petir Kabel");
                    pekerjaan_tersedia.Add("PT Robotika Neutron");

                    dana_didapatkan = "13.440.000";
                }

                if (jurusan == "Teknologi Informasi")
                {
                    pekerjaan_tersedia.Add("PT Go-jek");
                    pekerjaan_tersedia.Add("PT Bukalapak");

                    dana_didapatkan = "67.000.000";
                }

                if (jurusan == "Teknik Nuklir")
                {
                    pekerjaan_tersedia.Add("PT Atom Plack");
                    pekerjaan_tersedia.Add("PT Uratek");
                    pekerjaan_tersedia.Add("PT. I-Nuclue");

                    dana_didapatkan = "51.000.000";
                }
                //83 line
            }
        }
    }
}
