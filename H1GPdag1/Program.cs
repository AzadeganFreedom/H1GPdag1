namespace H1GPdag1
{
    class program
    {
       

        static void Main(string[] args)
        {
            double fahrenheit;
            double celsius;
            

            Console.WriteLine("Hello! \n\nWhich conversion would you like to use? \n\na: Celsius to Fahrenheit \nb: Fahrenheit to Celsius " +
                "\nAny key: Quit \n\nPress the appropriate key and then press Enter");
            
            string UserChoice = Console.ReadLine();

                
            if(UserChoice == "a")
            {
                Console.Clear();
                Console.WriteLine("Celsius to Fahrenheit \n\nPlease write the temperatur value for Celsius and press enter");

                
                celsius = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n\nCelsius = " + celsius);
                fahrenheit = (celsius * 9) / 5 + 32;
                Console.WriteLine("\nFormula: (Celsius * 9) / 5 + 32");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nFahrenheit = " + fahrenheit);

            }
            else if(UserChoice == "b")
            {
                Console.Clear();
                Console.WriteLine("Fahrenheit to Celsius \n\nPlease write the temperatur value for Fahrenheit and press enter");

                fahrenheit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n\nFahrenheit = " + fahrenheit);
                celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine("\nFormula: (Fahrenheit - 32) * 5 / 9");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nCelsius = " + celsius);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Press enter twice to quit");
            }

            Console.ReadKey();

        }
    }
    
}