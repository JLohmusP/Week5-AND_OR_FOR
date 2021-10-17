using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //küsida sisestada kasutajatunnus ja salasõna;
            //kui tunnus "admin" ja salasõna "admin69420";
            //kuvada "Tere tulemast";
            //muudel juhtudel kuva "Valed sisselogimisandmed. Proovi uuesti.";

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            if(userName == "admin" && userPassword == "admin69420")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Valed sisselogimisandmed. Proovi uuesti.");
            }
        }
    }
}
