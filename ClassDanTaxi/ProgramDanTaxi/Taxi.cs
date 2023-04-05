using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugasClassTaxi
{
    class Taxi
    {
        //prop
        public int NumPassenger { get; set; }
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }


        // methode
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("On Duty: {0}", OnDuty);
            Console.WriteLine("Number of Passenger: {0}", NumPassenger);
        }

        public void PickUpPassenger()
        {
            if (NumPassenger >= 1 && OnDuty == true)
            {
                Console.WriteLine("Jono sedang menjemput penumpang");
            }
        }

        public void DropOffPassenger()
        {
            if (NumPassenger == 0 && OnDuty == false)
            {
                Console.WriteLine("Jono selesai menjemput penumpang");
            }
            else { }
        }
    }
}
