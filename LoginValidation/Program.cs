using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i = 0;

            while (i < 3) {

                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPassword = Console.ReadLine();

                if (userName == "admin" && userPassword == "admin69420")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine("Valed sisselogimisandmed. Proovi uuesti.");
                    Console.WriteLine($"Teil on jäänud {3 - i} katset.");
                }
            }
        }
    }
}
