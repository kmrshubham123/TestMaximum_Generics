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
            Console.WriteLine("Maximum Interger Number is:- "+maximum.FindMaximumNumber(10, 20, 30));
            //UC2:-Maximum number using Double
            Console.WriteLine("Maximum Float Number is:- "+maximum.FindMaximumFloatNumber(10.5,20.5,30.5));
            //UC3:-Longest Word using string
            Console.WriteLine("Longest Word:- "+maximum.FindLongestString("Apple","Banana","Pomegranate"));
            //Refactor 1:- 3 to one Generic Method 
            Console.WriteLine("===========Generics============");
            int maximumint = MaximumNumber.MaxValue<int>(10, 20, 30);
            Console.WriteLine("Maximum Integer Value: " +maximumint);
            float maximumfloat = MaximumNumber.MaxValue<float>(10.5f, 20.5f, 30.5f);
            Console.WriteLine("Maximum Float Value: " + maximumfloat);
            string maximumstring = MaximumNumber.MaxValue<string>("Apple","Banana","Pomegranate");
            Console.WriteLine("Maximum String Value: " + maximumstring);
            //Refactor 2:-Create a Generic Class
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine("****Welcome to the Generic and Find Maximum****");
            int genericInt = GenericMaximum<int>.MaxValue(20,40,50);
            Console.WriteLine("Maximum Interger Value: "+genericInt);
            float genericFloat = GenericMaximum<float>.MaxValue(20.99f, 40.39f, 50.99f);
            Console.WriteLine("Maximum Float Value: " + genericFloat);
            string genericString = GenericMaximum<string>.MaxValue("Apple", "Banana", "Pomegranate");
            Console.WriteLine("Maximum String Value: " + genericString);








        }
    }
}
