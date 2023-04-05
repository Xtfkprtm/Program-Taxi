using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugasClassTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            //objek taxi
            Taxi taxi = new tugasClassTaxi.Taxi();

            //pengesetan nilai proterties
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}