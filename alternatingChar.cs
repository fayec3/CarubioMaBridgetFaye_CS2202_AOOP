using System;

class Altchar
{
    static void Main()
    {
        Console.Write("First Character: ");
        char firstChar = Console.ReadKey().KeyChar;
        Console.WriteLine();
        
        Console.Write("Second Character: ");
        char secondChar = Console.ReadKey().KeyChar;
        Console.WriteLine();
        
        Console.Write("Enter size: ");
        int size = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < size; i++)
        {
            Console.Write(new string('-', i));
            Console.WriteLine(i % 2 == 0 ? firstChar : secondChar);
        }
    }
}
