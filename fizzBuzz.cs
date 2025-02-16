using System;

class Fizzbuzz
{
    static void Main(string[] args)
    {
        int upperBound = 15;
        
        for (int num = 1; num <= upperBound; num++)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(num);
            }
        }
    }
}
