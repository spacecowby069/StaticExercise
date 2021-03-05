using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string userOption = null;
            do
            {
                Console.WriteLine("What conversion would you like to perform? FtoC or CtoF?");
                userOption = Console.ReadLine().ToLower();

                if (userOption == "ftoc")
                {
                    Console.WriteLine("What is the Fahrenheit that you want to convert to Celsius?");
                    double fahTemp = Convert.ToDouble(Console.ReadLine());

                    TempConverter.FahrenheitToCelsius(fahTemp);

                    double convertToCel = TempConverter.FahrenheitToCelsius(fahTemp);

                    Console.WriteLine();
                    Console.WriteLine($"{fahTemp} is {convertToCel} degrees Celsius.");
                }
                else if (userOption == "ctof")
                {
                    Console.WriteLine("What temperature in Celsius do you want to convert to Fahrenheit?");
                    double celTemp = Convert.ToDouble(Console.ReadLine());

                    double convertToFah = TempConverter.CelsiusToFarenheit(celTemp);

                    Console.WriteLine();
                    Console.WriteLine($"{celTemp} is {convertToFah} degrees Fahrenheit.");
                }
                else
                {
                    Console.WriteLine("Did not recognize that command. please try again");
                }

                Console.WriteLine("If you would like to quit, type exit. ");
                userOption = Console.ReadLine();

                
                

                

                
            } while (userOption != "exit");
        }
    }
}
