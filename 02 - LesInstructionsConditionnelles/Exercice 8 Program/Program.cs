using System;
using System.Threading.Tasks;
namespace Exercice_8_Program
{
    /*
                    Exo 8 L’échelle de Richter
            L’échelle de Richter permet de décrire la magnitude des tremblements de terre :
            1 Micro tremblement de terre, non ressenti
            2 Très mineur. non ressenti mais détecté
            3 Mineur. causant rarement des dommages
            4 Léger. Secousses notables d’objets à l’intérieur des maisons
            5 Modéré. Légers dommages aux édifices bien construits
            6 Fort. Destructeur dans des zones allant jusqu’à 180 kilomètres à la ronde si elles sont peuplées
            7 Majeur. Dommages modérés à sévères dans des zones plus vastes.
            8 Important. Dommages sérieux dans des zones à des centaines de kilomètres à la ronde
            9 Dévastateur.Dévaste des zones sur des milliers de kilomètres à la ronde

            Si le nombre n’est pas compris entre 1 et 9 c’est qu’il y a erreur de saisie (si inférieur à 1) ou que c’est l’appocalypse (si
            supérieur à 9).

            Vous écrirez un programme permettant à l’utilisateur de saisir une valeur d’échelle et qui en réponse affichera à l’écran la
            description associée à ce nombre. Vous n’oublierez pas de gérer le cas où le nombre tapé par l’utilisateur est ”hors-échelle”.
    */
    class Program
    {
        static string[] RichterTable = {
            "Micro tremblement de terre, non ressenti",
            "Très mineur. non ressenti mais détecté",
            "Mineur. causant rarement des dommages",
            "Léger. Secousses notables d’objets à l’intérieur des maisons",
            "Modéré. Légers dommages aux édifices bien construits",
            "Fort. Destructeur dans des zones allant jusqu’à 180 kilomètres à la ronde si elles sont peuplées",
            "Majeur. Dommages modérés à sévères dans des zones plus vastes.",
            "Important. Dommages sérieux dans des zones à des centaines de kilomètres à la ronde",
            "Dévastateur.Dévaste des zones sur des milliers de kilomètres à la ronde"
        };

        static void Main(string[] args)
        {
            Task WatchToExit= new Task(() =>
              {
                    Console.WriteLine("Tap Echap to exit the program");
                    while(true)
                    {    
                        ConsoleKeyInfo Hello = Console.ReadKey(true);
                        if((byte)Hello.KeyChar == 27)
                        {
                            Environment.Exit(0);
                            Console.WriteLine("\n Program closed");          
                        }
                    }
              });
            WatchToExit.Start();
            ExecTheApplication();
        }

            static void ExecTheApplication()
            {
                while(true)
                {
                    Console.WriteLine("Entre un nombre de 1 à "+RichterTable.Length);
                    string aProposition = Console.ReadLine();
                    if(int.TryParse(aProposition, out int cool))
                    {
                        int index = int.Parse(aProposition);
                        if( index >= 1 && index <= RichterTable.Length)
                        {
                            Console.WriteLine(RichterTable[index-1]);
                            break;
                        }
                        else continue;

                        
                    }
                    else continue;
                   
                }
                
            }
    }
}
