using System;
namespace Uppgift_C_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj en av omvandlings metoderna:");
            Console.WriteLine("1: Omvandla Celsius till Fahrenheit");
            Console.WriteLine("2: Omvandla Fahrenheit till Celsius");
            
            

            int val = int.Parse(Console.ReadLine());

            switch(val)
            {
                case 1:
                    Console.WriteLine("Skriv in grader Celsius du vill omvandla till grader Fahrenheit:");
                    double C = double.Parse(Console.ReadLine());
                    double F = ((32 + C) * 1.8);
                    Console.WriteLine($"{C} grader C = " + CelsiusTillFahrenheit(C,F) + " grader i Fahrenheit");
                    break;

                case 2:
                    Console.WriteLine("Skriv in grader Fahrenheit du vill omvandla till grader Celsius:");
                    double Fahrenheit = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{Fahrenheit} grader F = " + FahrenheitTillCelsius(C,F) + " grader i Fahrenheit");
                    break;

                default:
                    break;
            }


        }
      
        static double CelsiusTillFahrenheit(double C, double F)
        {
            
            double Fahrenheit = ((32+C)*1.8);
            return Fahrenheit;
        }

        static double FahrenheitTillCelsius(double C, double F)
        {
            double Celsius = ((F - 32) / 1.8);
            return Celsius;
        }
    }
}