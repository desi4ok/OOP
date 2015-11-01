using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_03_PcCatalog
{
    class Catalog
    {
        static void Main()
        {
            List<Computer> catalog = new List<Computer>();

            List<Component> components = new List<Component>();
            components.Add(new Component("HDD", 250.32m));
            components.Add(new Component("CPU", 560.45m));
            components.Add(new Component("RAM", 103.50m));
            Computer lenovo = new Computer("Lenovo", components);
            catalog.Add(lenovo);

            List<Component> components1 = new List<Component>();
            components1.Add(new Component("CPU", 231));
            components1.Add(new Component("Motheboard", 351));
            components1.Add(new Component("Graphics card", 351));
            Computer mac = new Computer("Mac", components1);
            catalog.Add(mac);

            List<Component> components2 = new List<Component>();
            components2.Add(new Component("CPU", 134));
            components2.Add(new Component("RAM", "4GB", 123.65m));
            Computer sony = new Computer("Sony", components2);
            catalog.Add(sony);

            var sortedCatalog = catalog.OrderBy(computer => computer.Price);

            foreach (var computer in sortedCatalog)
            {
                Console.WriteLine(computer);
            }
        }
    }
}
