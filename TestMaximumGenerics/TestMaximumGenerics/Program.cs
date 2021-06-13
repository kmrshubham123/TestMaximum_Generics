using System;

namespace TestMaximumGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Welcome to the Test Maximum****");
            //UC1:-Maximum number using Interger
            MaximumNumber maximumInteger = new MaximumNumber();
            Console.WriteLine("Maximum Interger is:-"+maximumInteger.FindMaximumNumber(10, 20, 30));


        }
    }
}
