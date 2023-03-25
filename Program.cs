using System;

namespace CounterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 0; counter <= 10; counter++)
            {
                if(counter%2==0)
                {
                    Console.WriteLine($"The counter is in number {counter}, an Even Number");    
                }
                else 
                {
                    Console.WriteLine($"The counter is in number {counter}, an Odd Number");
                }
            }
        }
    }
}