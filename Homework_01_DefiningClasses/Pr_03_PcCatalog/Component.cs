using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_03_PcCatalog
{
    class Component
    {
        private string compName;
        private decimal compPrice;

        public Component (string name, decimal price) 
        {
            this.CompName = name;
            this.CompPrice = price;
        }

        public Component (string name, string details, decimal price) : this(name, price)
        {
            this.CompDetails = details;
        }

        public string CompName
        {
            get { return this.compName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Componet name cannot be null or empty!");
                }
                this.compName = value;
            }
        }

        public string CompDetails { get; set; }

        public decimal CompPrice
        {
            get { return this.compPrice; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }
                this.compPrice = value;
            }
        }
    }
}
