using System;
using System.Collections.Generic;
using System.Text;

namespace tugas
{
    public class taxi : taxiBase
    {
        //properties
        public string nama { get; set; }
        public Boolean OnDuty { get; set; }
        public string no_penumpang { get; set; }

        //Method
        public void Info()
        {
            Console.WriteLine("Nama Driver: {0}", nama);
            Console.WriteLine("On Duty: {0}", true);
            Console.WriteLine("Number Of Passenger: {0}", no_penumpang);
        }
        public void PickUp()
        {
            Console.WriteLine("\n{0} sedang menjemput penumpang", nama);
        }
        public void DropOff()
        {
            Console.WriteLine("{0} Selesai Mengantar Penumpang", nama);
            Console.WriteLine();
        }
    }
}

