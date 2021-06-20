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
            //UC:-4 Extended the max method to take more than three Parameter
            Console.WriteLine("=============================");
            int[] intArray = { 525, 625, 462, 890, 900 };
            FindMaximum<int> find1 = new FindMaximum<int>(intArray);

            float[] floatArray = { 30.2f, 38.5f, 42.4f, 59.5f, 69.8f };
            FindMaximum<float> find2 = new FindMaximum<float>(floatArray);

            double[] doubleArray = { 50.23, 89.26, 38.98, 99.99 };
            FindMaximum<double> find3 = new FindMaximum<double>(doubleArray);

            string[] stringArray = { "Banana", "Guava", "Papaya", "Pomegranate", "Strawbeery" };
            FindMaximum<string> find4 = new FindMaximum<string>(stringArray);

            Console.WriteLine("Maximum Integer Value is: "+find1.FindMaxValue());
            Console.WriteLine("Maximun Float Value is: "+find2.FindMaxValue());
            Console.WriteLine("Maximun double Value is: " + find3.FindMaxValue());
            Console.WriteLine("Maximum String Value is: "+find4.FindMaxValue());











        }
    }
}
