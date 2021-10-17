using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //kaks mängijat - arvuti ja kasutaja;
            //kontrolli, kumb viskas rohkem;
            //kes viskab rohkem, võidab;
            //täringuid visatakse kolm korda;

            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i++) {
                Random rnd = new Random();
                int cpuRandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);
                

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja võitis. Palju õnne!");
                    userScore++;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti võitis.");
                    cpuScore++;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }
                
            }
            Console.WriteLine($"Mänguseis - Arvuti: {cpuScore} vs Kasutaja: {userScore}");

        }
    }
}
