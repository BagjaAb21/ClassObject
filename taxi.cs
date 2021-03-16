using System;
using System.Collections.Generic;
using System.Text;

namespace tugas
{
    public class taxi
    {
        //properties
        public string nama { get; set; }
        public string status { get; set; }
        public string no_penumpang { get; set; }

        //Method
        public void Data()
        {
            Console.WriteLine("Nama Driver: {0}", nama);
            Console.WriteLine("On Duty: {0}", status);
            Console.WriteLine("Number Of Passenger: {0}", no_penumpang);
            Console.WriteLine("\n{0} sedang menjemput penumpang", nama);
        }
        public void Status()
        {
            Console.WriteLine("{0} Selesai Mengantar Penumpang", nama);
            Console.WriteLine();
        }
    }
}
