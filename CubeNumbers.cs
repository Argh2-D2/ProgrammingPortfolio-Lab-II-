using System;

namespace L2._1_Cubenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number you would like to be cubed.");
            int input = int.Parse(Console.ReadLine());
            int cubeNumber = input * input * input;
            int x = cubeNumber;
            Console.WriteLine(input + " cubed is " + x);
        }
    }
}
