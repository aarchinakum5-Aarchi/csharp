using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit4_prog21
{
    internal class car:Vehicle

    {
        string model_type, company_name;
        public void get_car()
    {
        Console.WriteLine("enter model_type");
        model_type = Console.ReadLine();

        Console.WriteLine("enter company name ");
        company_name = Console.ReadLine();

    }
     void show_car()
    {
        Console.WriteLine("model Type " + model_type);
        Console.WriteLine("company name " + company_name);

    }



    }
}
