using System;

namespace L2._3_TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much was the bill?");
            int number = int.Parse(Console.ReadLine());
        
            double TotalTip = number;
            double x = number * 0.1 + number;
            double y = number * 0.2 + number;

            Console.WriteLine("For a tip of 10%, pay " + "£" + x.ToString("F1") + " \nFor a 20% tip, pay " + "£" + y.ToString("F1"));
            
        }
    }
}
