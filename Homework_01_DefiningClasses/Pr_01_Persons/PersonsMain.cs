using System;
using Persons;

namespace Pr_01_Persons
{
    class PersonsMain
    {
        static void Main()
        {
            Person pesho = new Person("Pesho", 18);
            Console.WriteLine(pesho);

            //Person gosho = new Person("Gosho", 20, "email");
            //Console.WriteLine(gosho);

            Person didi = new Person("Didi", 20, "@email");
            Console.WriteLine(didi);
        }
    }
}
