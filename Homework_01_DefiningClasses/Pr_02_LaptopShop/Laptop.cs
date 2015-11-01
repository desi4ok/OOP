using System;

namespace Pr_02_LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private double price;
        private Battery batt;

        public Laptop (string currentModel, double currentPrice)
        {
            this.Model = currentModel;
            this.Price = currentPrice;
        }

        public Laptop (string currentModel, string currentManufacturer, string currentProcessor, int currentRam,
            string currentGraphicsCard, string currentHdd, string currentScreen, Battery 
            battery, double currentPrice) : this (currentModel, currentPrice)
        {
            this.Manufacturer = currentManufacturer;
            this.Processor = currentProcessor;
            this.Ram = currentRam;
            this.GraphicsCard = currentGraphicsCard;
            this.Hdd = currentHdd;
            this.Screen = currentScreen;
            this.batt = battery;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The model of the laptop is mandatory!");
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public string Processor
        {
            get { return this.processor; }
            set { this.processor = value; }
        }

        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Ram must be > 0");
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set { this.graphicsCard = value; }
        }

        public string Hdd
        {
            get { return this.hdd; }
            set { this.hdd = value; }
        }

        public string Screen
        {
            get { return this.screen; }
            set { this.screen = value; }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("The price must be set and > 0");
                this.price = value;
            }
        }

        public override string ToString()
        {
            string output = "model: " + this.Model + "\n";
            if (!String.IsNullOrEmpty(this.Manufacturer))
            {
                output += "manufacturer: " + this.Manufacturer + "\n";
            }
            if (!String.IsNullOrEmpty(this.Processor))
            {
                output += "processor: " + this.Processor + "\n";
            }
            if (this.Ram != 0)
            {
                output += "RAM: " + this.Ram + " GB\n";
            }
            if (!String.IsNullOrEmpty(this.GraphicsCard))
            {
                output += "graphics card: " + this.GraphicsCard + "\n";
            }
            if (!String.IsNullOrEmpty(this.Hdd))
            {
                output += "HDD: " + this.Hdd + "\n";
            }
            if (!String.IsNullOrEmpty(this.Screen))
            {
                output += "screen: " + this.Screen + "\n";
            }

            output += batt;
            output += "price: " + this.Price + " lv.";
            return output;
        }

    }
}
