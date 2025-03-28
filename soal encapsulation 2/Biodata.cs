using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal_encapsulation_2
{
    internal class Biodata
    {
        public string nama, prodi;
        private int _nim;

        public Biodata(string nama, string prodi)
        {
            this.nama = nama;
            this.prodi = prodi;
        }
        public int Nim
        {

            get { return _nim; }
            set
            {
                prodi = prodi.ToLower();
                if (prodi == "sistem informasi")
                {
                    if (value >= 1000 && value <= 1100)
                    {
                        Console.WriteLine("Tambah Nim Berhasil Bang");
                        _nim = value;
                    }
                    else
                    {
                        Console.WriteLine("Nim Ga sesuai Prodi Bang");
                    }
               
                }
                else if (prodi == "teknologi informasi")
                {
                    if (value >= 2000 && value <= 2100)
                    {
                        Console.WriteLine("Tambah Nim Berhasil Bang");
                        _nim = value;
                    }
                    else
                    {
                        Console.WriteLine("Nim Ga sesuai Prodi Bang");
                    }
               
                }
                else if (prodi == "informatika")
                {
                    if (value >= 3000 && value <= 3100)
                    {
                        Console.WriteLine("Tambah Nim Berhasil Bang");
                        _nim = value;
                    }
                    else
                    {
                        Console.WriteLine("Nim Ga sesuai Prodi Bang");
                    }
                  
                }
            }
        }
        public void tampilkanBiodata()
        {
            Console.WriteLine($"NAMA : {nama}");
            Console.WriteLine($"NIM : {_nim}");
            Console.WriteLine($"Prodi : {prodi}");


        }
    }
}
