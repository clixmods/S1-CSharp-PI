using System;
using System.Threading.Tasks;

namespace Exercice_1
{
    /*
    Exo 1 transformer les exos précédents en fonction. Créer un projet "PreviousFunctions".
    Créer les fonctions dans le même projet et les utilisées dans la fonction Main du projet.

    - Calcule TVA en fonction d'une prix de produit + une quantité et affiche le nom du produit, le prix de base, le prix TTC.
    L'utiliser avec au moins deux produits.

    - Creer une fonction qui prend en parametre un caractère, affiche le caractère et sa valeur numérique.
    L'utiliser avec au moins deux caractères.

    - Creer une fonction qui affiche une couleur en fonction d'une valeur entre 0 et 100.
    L'utiliser avec au moins deux valeurs.

    - Creer une fonction qui affiche une saison en fonction d'un mois.
    L'utiliser avec au moins deux mois.

    - Creer une fonction qui affiche le signe chinois en fonction d'une année.
    L'utiliser avec au moins deux années.
    */
    class Program
    {
        static void Main(string[] args)
        {
            // Task WatchToExit= new Task(() => // cause un etrange bug, il enleve le first character des Console.readline 
            //   {
                    // Console.WriteLine("Tap Echap to exit the program");
                    // while(true)
                    // {    
                        // ConsoleKeyInfo Hello = Console.ReadKey();
                        // if((byte)Hello.KeyChar == 27)
                        // {
                            // Environment.Exit(0);
                            // Console.WriteLine("\n Program closed");          
                        // }
                    // }
            //   });
            // WatchToExit.Start();

            Console.WriteLine("Bienvenue, veuilliez taper le nombre correspondant aux function pour le lancer: \n 0 : TVA \n 1 : DetermineKeyChar \n 2 : DetermineCouleur \n 3 : DetermineSaison");
            string UserFuncChoice = Console.ReadLine();
            string result = "Undefined";
            //bool isValide;
            if(int.TryParse(UserFuncChoice,out int intChoice))
            {
                switch(intChoice)
                {
                    case 0: // TVA
                        Console.WriteLine("Tapez le nom du produit");
                        string UserProductName = Console.ReadLine();
                        Console.WriteLine("Tapez le prix du produit");
                        string UserProductPrice = Console.ReadLine();  
                        Console.WriteLine("Tapez le nombre de produit");
                        string UserProductCount = Console.ReadLine();
                        Console.WriteLine("Tapez la TVA en % de produit");
                        string UserTVA = Console.ReadLine();
                        result = CompatibilityUtility.CalculTVA(UserProductName,UserProductPrice,UserProductCount,UserTVA);
                    break;
                    case 1:  // KeyChar
                        result = DetermineKeyChar.Exec();
                    break;
                    case 2: // Couleur
                       result = DetermineCouleur.Exec();
                    break;
                    case 3: // Saison
                        result = DetermineSaison.Exec();
                    break;
                    case 4: 
                        result = DetermineChinoisSign.Exec();
                    break;
                    case 5: 
                        result = DetermineChinoisSign.Exec();
                    break;
                }
                Console.WriteLine(result);
            }
            
        }
       
      
        

    }
}
