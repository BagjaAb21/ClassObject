using System;

namespace tugas
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek dari classs mahasiswa
            taxi driver = new taxi();

            // mengeset nilai properties objek saya dan kamu
            driver.nama = "Ramapatuh";
            driver.status = "Yes";
            driver.no_penumpang = "10";

            //pemanggilan method

            driver.Data();
            driver.Status();

            Console.ReadKey();
        }
    }
}
