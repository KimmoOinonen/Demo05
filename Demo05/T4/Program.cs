using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Part part1 = new Part { PartType = "Processor", PartModel = "Intel i5", PartPrice = 200};
            Part part2 = new Part { PartType = "Graphics card", PartModel = "Sapphire R9 290", PartPrice = 300 };
            Part part3 = new Part { PartType = "Motherboard", PartModel = "ASUS Z-97 Pro", PartPrice = 150 };

            Computer compu = new Computer { CaseModel = "Fractal Design Define R5", CaseSize = "ATX", CaseColor = "Black", CasePrice = 100 };
            compu.AddPart(part1);
            compu.AddPart(part2);
            compu.AddPart(part3);

            Console.WriteLine(compu.ToString());

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
