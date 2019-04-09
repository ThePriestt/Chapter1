using System;


// Напишете програма, която извежда първите 100 члена на редицата 2,  -3, 4, -5, 6, -7, 8.
class Program
{
    static void Main()
    {
        for (int i = 2; i < 101; i++)
        {
            
            if (i % 2 == 1)
            {
                Console.WriteLine(-i);
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}

