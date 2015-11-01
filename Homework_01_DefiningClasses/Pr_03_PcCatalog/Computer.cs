using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_03_PcCatalog
{
    class Computer
    {
        private string name;
        private List<Component> components;

        public Computer (string currentName, List<Component> currentComponents)
        {
            this.Name = currentName;
            this.Components = currentComponents;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                this.name = value;
            }
        }

        public List<Component> Components
        {
            get { return this.components; }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentNullException("Computer must have at least two components");
                }
                this.components = value;
            }
        }

        public decimal Price
        {
            get
            {
                return CalculatePrice(this);
            }
        }

        private decimal CalculatePrice(Computer comp)
        {
            decimal finalPrice = 0.0m;
            List<Component> components = comp.Components;
            foreach (var component in components)
            {
                finalPrice += component.CompPrice;
            }
            return finalPrice;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Computer name: {0}", this.Name));
            foreach (var component in components)
            {
                result.AppendLine(string.Format("{0}{2} {1:c2}", component.CompName, component.CompPrice, string.IsNullOrWhiteSpace(component.CompDetails) ? ":" : "(" + component.CompDetails + "):"));
            }
            result.AppendLine(string.Format("Total price: {0:c2}", this.Price));
            return result.ToString();
        }
    }
}
