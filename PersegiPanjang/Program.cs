using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersegiPanjang
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remarks> class PersegiPanjang1 dapat memuat operasi Masukkan Data, Menghitung luas, dan menampilkan data </remarks>
    class PersegiPanjang1
    {
        /// <summary>
        /// variabel panjang dan lebar
        /// </summary>
        double panjang, lebar;

        /// <summary>
        /// operasi masukkan data
        /// <param name="panjang"> angka dari panjang sebuah persegi panjang </param>
        /// <param name="lebar"> angka dari lebar sebuah persegi panjang </param>
        /// </summary>
        public void MasukkanData()
        {
            Console.Write("masukan panjang = ");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("masukan lebar = ");
            lebar = Convert.ToDouble(Console.ReadLine());

        }
        /// <summary>
        /// operasi hitung luas
        /// </summary>
        /// <returns> hasil dari penjumlahan panjang dan lebar sebuah persegi panjang </returns>
        public double HitungLuas()
        {

            return panjang * lebar;
        }

        /// <summary>
        /// Operasi menampilkan hasil data penjumlahan 
        /// </summary>
        public void TampilData()
        {
            Console.Write("Luas persegi panjang = {0}", HitungLuas());
            Console.ReadKey();

        }

    }
    /// <summary>
    /// sub class program
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            PersegiPanjang1 fud = new PersegiPanjang1();
            fud.MasukkanData();
            fud.TampilData();
        }
    }
}