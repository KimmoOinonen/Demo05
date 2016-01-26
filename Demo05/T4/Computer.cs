/*
 * Copyright (C) Kimmo Oinonen
 *
 * This file is part of homework project in Object-Oriented
 * and GUI Programming class in JAMK.
 *
 * Created: 26.1.2016
 * Author: Kimmo Oinonen
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Computer
    {
        public string CaseModel { get; set; }
        public string CaseSize { get; set; }
        public string CaseColor { get; set; }
        public int CasePrice { get; set; }

        public List<Part> Parts { get; }

        public Computer()
        {
            Parts = new List<Part>();
        }


        public void AddPart(Part part)
        {
            Parts.Add(part);
        }


        public override string ToString()
        {
            string sComputer = "Computer case model: " + CaseModel + " Case size: " + CaseSize + " Case color: " + CaseColor + " Case price: " + CasePrice + " euros" + " Parts:\n";
            foreach (Part part in Parts)
            {
                sComputer += part.ToString() + "\n";
            }
            return sComputer;
        }
    }
}
