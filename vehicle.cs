using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit4_prog21
{
    internal class Vehicle
    {
        string vehicle_type;

        public void get_data()
        {
            Console.WriteLine("enter vehicle type");
            vehicle_type = Console.ReadLine();


        }
        public void show_vehicle()
        {
            Console.WriteLine("WriteLine type " + vehicle_type);
        }

    }
}
