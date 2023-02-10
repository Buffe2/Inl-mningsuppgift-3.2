using System;
namespace Uppgift_3._2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int intNr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Har du gått ut ur gymnasiet, svara med J för ja och N för nej.");
            string strNr2 = Console.ReadLine();

            if (intNr1 < 22 && strNr2 == "J")
                Console.WriteLine("Vi vill anställa dig");

            else
                Console.WriteLine("Vi söker tyvärr någon annan.");
        }
    }
}