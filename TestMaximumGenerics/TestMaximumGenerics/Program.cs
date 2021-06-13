using System;

namespace TestMaximumGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Welcome to the Test Maximum****");
            //UC1:-Maximum number using Interger
            MaximumNumber maximum = new MaximumNumber();
            Console.WriteLine("Maximum Interger Number is:-"+maximum.FindMaximumNumber(10, 20, 30));
            //UC2:-Maximum number using Double
            Console.WriteLine("Maximum Float Number is:-"+maximum.FindMaximumFloatNumber(10.5,20.5,30.5));

        }
    }
}
