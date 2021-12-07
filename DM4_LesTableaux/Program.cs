using System;

namespace DM4_LesTableaux
{
    // Note du code : bledard/20
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string message = "Veuillez choisir le programme à lancer : \n";
            message += "[A] pour lancer isPalindrome()\n";
            message += "[Z] pour lancer RandomizeAlphabet\n";
            message += "[E] pour lancer TriAlphabetique\n";
            message += "[R] pour lancer le jeu du Pendu\n";
            message += "[ECHAP] pour quitter le programme\n";
            bool canRun = true;
            while(canRun)
            {
                Console.WriteLine(message);
                ConsoleKey input = Console.ReadKey(false).Key;
                Console.Clear();
                switch(input)
                {
                    case ConsoleKey.A :
                        Exo1.IsPalindrome("elle");
                        Exo1.IsPalindrome("Tu l'as trop écrasé César ce Port-Salut");
                        Exo1.IsPalindrome("Dogma I am God");
                        Exo1.IsPalindrome("KayAk");
                        Exo1.IsPalindrome("Vive L'argent");
                        Exo1.IsPalindrome("Vérifié si cé 1 palindrome avek dé axe100 c po trait gantil");
                    break;
                    case ConsoleKey.Z :
                        char[] randomizedTable = Exo2.AlphabetRandomizer();
                        Console.WriteLine(Exo2.SortAlphabetTable(randomizedTable));
                        char[] pogTable = {'p','o','g','c','h','a','m','p','s'};
                        Console.WriteLine(Exo2.SortAlphabetTable(pogTable));
                    break;
                    case ConsoleKey.E :
                        string[] fdp =  {"aaaaaaaaaaaaaaa","AR", "abc", "abcd", "abdce", "abcdef"};
                        Exo3.TriAlphabetiqueString(fdp);
                    break;
                    case ConsoleKey.R :
                       Exo4.Init();

                    break;
                    case ConsoleKey.Escape :
                        canRun = false;
                    break;

                }
            }
         
        }
    }
}
