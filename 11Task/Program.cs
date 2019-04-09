using System;

// Направете програма, която прочита от конзолата вашата възраст и изписва (също на конзолата) каква ще бъде вашата възраст след 10 години.

class Program
{
    static void Main()
    {
        int temp;
        string input = Console.ReadLine();
        temp = int.Parse(input);
        int temp2;
        temp2 = temp + 10;
        Console.WriteLine(temp2);

        //Console.WriteLine(int.Parse(Console.ReadLine()) + 10);
    }
}

