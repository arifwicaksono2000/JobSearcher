using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobSearcher
{
    public partial class Form1 : Form
    {
        DataJK dataJK = new DataJK();

        public Form1()
        {
            InitializeComponent();
        }

        private void comboClick_jurusan(object sender, EventArgs e)
        {
            List<string> combo_jurusan = dataJK.impor_jurusan();
            comboBox2.DataSource = combo_jurusan;
        }

        private void comboClick_kota(object sender, EventArgs e)
        {
            List<string> combo_kota = dataJK.impor_kota();
            comboBox1.DataSource = combo_kota;
        }

        private void btnClick_cari(object sender, EventArgs e)
        {
            DataDP dataDana = new DataDP(comboBox1.Text, comboBox2.Text);
            List<string> list_pekerjaan = dataDana.impor_pekerjaan_lagi();

            listBox1.DataSource = list_pekerjaan;
            label6.Text = dataDana.dana_didapatkan;

            label7.Text = comboBox1.Text;
        }

        private void btnClose(object sender, EventArgs e)
        {
            Close();
        }
    }

}
