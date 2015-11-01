﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_02_LaptopShop
{
    class MainClass
    {
        static void Main()
        {
            Laptop laptop = new Laptop("HP 250 G2", 699.00);
            Console.WriteLine(laptop);

            Battery batt = new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5);
            Laptop laptop2 = new Laptop("Lenovo Yoga 2 Pro", "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 8, "Intel HD Graphics 4400", "128GB SSD",
                "13.3\"(33.78 cm) – 3200 x 1800(QHD +), IPS sensor display", batt, 2259.00);
            Console.WriteLine(laptop2);
        }
    }
}
