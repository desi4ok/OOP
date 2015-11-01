namespace Pr_01_SquareRoot
{
    using System;

    class SquareRootMain
    {
        static void Main()
        {
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);

                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (number > Int32.MaxValue || number < Int32.MinValue)
                {
                    throw new OverflowException();
                }

                double result = Math.Sqrt((double)number);
                Console.WriteLine(result);
            }

            catch (FormatException fe)
            {
                Console.Error.WriteLine("Invalid number! " + fe.Message);
            }
            catch (ArgumentOutOfRangeException ae)
            {
                Console.Error.WriteLine("Invalid number! " + ae.Message);
            }
            catch (OverflowException oe)
            {
                Console.Error.WriteLine("Invalid number! " + oe.Message);
            }

            finally
            {
                Console.WriteLine("Good bye.");
            }
        }
    }
}
