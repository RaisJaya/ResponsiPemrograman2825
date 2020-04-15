using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2825
{
    class Karyawan
    {
        public string No { get; set; }
        public string NIK { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        public Karyawan(string no, string nik, string nama, int gajibulanan)
        {
            No = no;
            NIK = nik;
            Nama = nama;
            if (gajibulanan < 0)
            {
                GajiBulanan = 0;
            }
            else
            {
                GajiBulanan = gajibulanan;
            }
        }

        public void DataKaryawan()
        {
            Console.WriteLine("{0} {1} {2} {3}", No.PadRight(2), NIK.PadRight(11), Nama.PadRight(10), GajiBulanan);
        }
        public void NaikGaji()
        {
            Console.WriteLine("{0} {1} {2} {3}", No.PadRight(2), NIK.PadRight(11), Nama.PadRight(10), (GajiBulanan * 110 / 100));
        }
    }
}
