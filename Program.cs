using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolyDanCol
{
    class Program
    {
        static void Main(string[] args)
        {
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "987-987-987";
            karyawanTetap.Nama = "Roberto Bilwas";
            karyawanTetap.GajiBulanan = 9100000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "897-897-897";
            karyawanHarian.Nama = "Michael Wanabun";
            karyawanHarian.JumlahJamKerja = 20;
            karyawanHarian.UpahPerJam = 6600;

            Sales sales = new Sales();
            sales.Nik = "789-789-789";
            sales.Nama = "Khsnul Khotimah";
            sales.JumlahPenjualan = 15;
            sales.Komisi = 3300;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}",
                noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());

                noUrut++;
            }

            Console.ReadKey();
        }
    }
}
