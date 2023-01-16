namespace H1GPdag1
{
    class program
    {
       

        static void Main(string[] args)
        {
            double fahrenheit;
            double celsius;
            

            Console.WriteLine("Hello! \n\nWhich conversion would you like to use? \n\na: Celsius to Fahrenheit \nb: Fahrenheit to Celsius " +
                "\n\nPress the appropriate key and then press Enter");
            
            string UserChoice = Console.ReadLine();

            if(UserChoice == "a")
            {
                Console.Clear();
                Console.WriteLine("Celsius to Fahrenheit \n\nPlease write the temperatur value for Celsius and press enter");

                
                celsius = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Celsius = " + celsius);
                fahrenheit = (celsius * 9) / 5 + 32;
                Console.WriteLine("Fahrenheit = " + fahrenheit);

            }
            else if(UserChoice == "b")
            {
                Console.Clear();
                Console.WriteLine("Fahrenheit to Celsius");
                Console.WriteLine("Fahrenheit to Celsius \n\nPlease write the temperatur value for Fahrenheit and press enter");

                fahrenheit = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Fahrenheit = " + fahrenheit);
                celsius = (fahrenheit / 32) * 5 / 9;
                Console.WriteLine("Celsius = " + celsius);
            }
            Console.ReadKey();









            /*Console.WriteLine("Celsius " + celsius);

            fahrenheit = (celsius * 9) / 5 + 32;

            Console.WriteLine("Fahrenheit "+fahrenheit);

            Console.ReadLine();*/

            /*Console.WriteLine(("Fahrenheit " + fahrenheit);

            celsius = (fahrenheit/32)*5/9;

            Console.WriteLine("Celsius " + celsius);

            Console.ReadLine();*/

        }
    }
    
}