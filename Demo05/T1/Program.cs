using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tyre tyre = new Tyre { Name = "Nokia", Model = "Hakkapeliitta", TyreSize = "205R16" };

            Vehicle car = new Vehicle { Name = "Datsun", Model = "100A" };
            car.AddTyre(tyre);
            car.AddTyre(tyre);
            car.AddTyre(tyre);
            car.AddTyre(tyre);

            Console.WriteLine(car.ToString());

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
