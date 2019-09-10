using System;

namespace Inlämingsuppgift
{
    class Program
    {
        static void Main()
        {
            Random generator = new Random();
            int rand = generator.Next(1, 100), gissningar = 0;
            Console.WriteLine("Gissa ett tal mellan 1-100: ");
            int tal = Convert.ToInt32(Console.ReadLine());
            while(tal != rand)
            {
                if (tal < rand)
                {
                    Console.WriteLine("Du gissade för lågt!");

                }
                else if (tal > rand)
                {
                    Console.WriteLine("Du gissade för högt!");
                }
                tal = Convert.ToInt32(Console.ReadLine());
                gissningar++;
            }
            Console.WriteLine("Du gissade rätt!");
            Console.WriteLine("Du gissade " + gissningar + " gånger");
            


        }
    }
}
