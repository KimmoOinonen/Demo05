using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Part
    {
        public int PartPrice { get; set; }
        public string PartType { get; set; }
        public string PartModel { get; set; }

        public override string ToString()
        {
            return "Part type: " + PartType + " Part model: " + PartModel + " Part price: " + PartPrice + " euros";
        }
    }
}
