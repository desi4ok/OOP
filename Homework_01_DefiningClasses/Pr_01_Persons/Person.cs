using System;
using System.Linq;

namespace Persons
{
    public class Person
    {
        private string name;
        private string email;
        private byte age;

        public Person (string currentName, byte currentAge)
        {
            this.Name = currentName;
            this.Age = currentAge;
            
        }

        public Person (string currentName, byte currentAge, string currentEmail) : this (currentName, currentAge)
        {
            this.Email = currentEmail;
        }
        
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty!");
                }
                this.name = value;
            }
        }

        public byte Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 0 and 100");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("E-mail cannot be null or empty!");
                }
                else if (!value.Contains('@'))
                {
                    throw new ArgumentException("E-mail must contain '@'!");
                }
                this.email = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, E-mail: {2}", this.Name, this.Age, this.Email ?? "None");
        }
    }
}
