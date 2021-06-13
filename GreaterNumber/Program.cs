using System;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, third;
            Console.WriteLine("Enter First Number: ");
            first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second number : ");
            second = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Third number : ");
            third = int.Parse(Console.ReadLine());

            if(first> second)
            {
                if (first > third)
                {
                    Console.WriteLine("largest number : " + first);
                }
                else
                {
                    Console.WriteLine("largest number : " + third);
                }
            }
            else
            {
                if(second> third)
                {
                    Console.WriteLine("Largest number : " + second);
                }
                else
                {
                    Console.WriteLine("largest number : " + third);
                }
            }
        }
    }
}
