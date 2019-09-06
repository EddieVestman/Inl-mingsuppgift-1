using System;

namespace Inlämingsuppgift
{
    class Program
    {
        static void Main()
        {
            Random generator = new Random();
            int rand = generator.Next(1, 100);
            Console.WriteLine(rand);
            Console.WriteLine("Gissa ett tal mellan 1-100: ");
             int svar = Console.ReadLine();
            if (svar == rand )
            
        }
    }
}
