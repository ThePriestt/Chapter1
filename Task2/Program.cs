using System;

//Да се намери описанието на класа System.Console в стандартната.NET API документация(MSDN Library).

class Program
{
    static void Main(string[] args)
    {       
        //https://docs.microsoft.com/en-us/dotnet/api/system.console?view=netframework-4.7.2
        Console.Write("Hello ");
        Console.WriteLine("World!");
        Console.Write("Enter your name: ");
        String name = Console.ReadLine();
        Console.Write("Good day, ");
        Console.Write(name);
        Console.WriteLine("!");

        int x = 0;
        //
        if ((args.Length == 1) &&
            (Int32.TryParse(args[0], out x) == true) &&
            ((x >= 1) && (x <= 9)))
        {
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine("Beep number {0}.", i);
                Console.Beep();
            }
        }
        else
            Console.WriteLine("Usage: Enter the number of times (between 1 and 9) to beep.");

    }
}

