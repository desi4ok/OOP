namespace Pr_02_EnterNumbers
{
    using System;
    using System.Linq;

    class Numbers
    {
        static void Main()
        {
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                int start = Math.Max(1, numbers.Max());
                int end = 91 + i;
                numbers[i] = ReadNumber(start, end);
            }

            Console.WriteLine("\nThe numbers are:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Number[{0}]: {1}", i + 1, numbers[i]);
            }
        }

        public static int ReadNumber(int start, int end)
        {
            try
            {
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    throw new ArgumentNullException();
                }

                int number = int.Parse(input);

                if (number <= start || number >= end)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return number;
            }
            catch (FormatException fe)
            {
                Console.Error.WriteLine("Invalid number " + fe.Message);

                return ReadNumber(start, end);
            }
            catch (ArgumentOutOfRangeException ae)
            {
                Console.WriteLine("Invalid number " + ae.Message);

                return ReadNumber(start, end);
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("Invalid number " + oe.Message);

                return ReadNumber(start, end);
            }
        }
    }
}
