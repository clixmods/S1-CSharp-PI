/*
using System;

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
    
    class Product
    {
        public string Name;
        public float Price;
        public int Count;
    }
    class Program
    {
        // TVA Variables
        static int tva = 20;
        static int tvaPrimary = 5;
        //
        static void Main(string[] args)
        {
            string UserFuncChoice = Console.ReadLine();
            
            //bool isValide;
            if(int.TryParse(UserFuncChoice,out int intChoice))
            {
                switch(intChoice)
                {
                    case 0: // TVA
                        string UserProductName = Console.ReadLine();
                        string UserProductPrice = Console.ReadLine();  
                        string UserProductCount = Console.ReadLine();
                        string UserTVA = Console.ReadLine();
                        if(float.TryParse(UserProductPrice,out float productPrice) 
                            && float.TryParse(UserTVA,out float TVA)  
                            && int.TryParse(UserProductCount,out int productCount)  )
                        {
                            string result = CalculTVA(UserProductName,productPrice,productCount,TVA);
                            Console.WriteLine(result);
                        }
                        else
                        {
                            Console.WriteLine("Error dans les données envoyés par l'utilisateur, réessayer");
                        }                   
                    break;
                    case 1:  // KeyChar
                        DetermineKeyChar();
                    break;
                    case 2: // Couleur
                        DetermineCouleur();
                    break;
                    case 3: // Saison
                        DetermineSaison();
                    break;
                    case 4: 
                    break;
                    case 5: 
                    break;
                }
            }
            
        }
        static string CalculTVA(string name, float price, int count, float tva)
        {   
            float tvafloat = ((float)tva/100)+1;
            float productPriceTTdC = price * tvafloat;
            return count+" quantity of "+name+" cost "+price*count+" in total \n "+count+" quantity of "+name+" cost together "+productPriceTTdC*count+" with for each a TVA  = "+tva+"% \n La taxe ajoute au total "+(productPriceTTdC-price)*count;  
                        
        }
        static void DetermineKeyChar()
        {
            while(true)
            {
                Console.WriteLine("Appuyer sur une ECHAP pour quitter \nAppuyer sur une touche :");
                ConsoleKeyInfo Hello = Console.ReadKey(true);
                if((byte)Hello.KeyChar == 27)
                    break;

                Console.WriteLine("\nVous avez appuyé sur la touche "+Hello.Key+" sa valeur numérique est de "+((byte)Hello.Key)+".");
            }
            
        }
        
        static int life;
        static void DetermineCouleur()
        {
            while(true)
            {
                Console.WriteLine("Indiquez la vie que vous souhaitez, tapez autre chose qu'un nombre pour éteindre le programme");
                string userLife = Console.ReadLine();
                if(int.TryParse(userLife, out life))
                {
                    if(life <= 0) Console.WriteLine("NOIR");
                    else if(life >= 1 && life <= 20 ) Console.WriteLine("ROUGE");
                    else if(life >= 21 && life <= 40 ) Console.WriteLine("ORANGE");
                    else if(life >= 41 && life <= 60 ) Console.WriteLine("JAUNE");
                    else if(life >= 61 ) Console.WriteLine("VERT");
                }
                else 
                {
                    Console.WriteLine("Good bye world!");
                    break;
                }

            }
            
        }
        static void DetermineSaison()
        {
            Console.WriteLine("ECRIT UN MOIS EN ANGLAIS OU FRANCAIS ET LA SAISON SERA DONNNEEEERRR ( pas daccent svp ) ");
            // Fr ou anglais, normalement c'est langlais qui est privilégié mais du coup j'ai mi les deux.
            string aMonth = Console.ReadLine().ToUpper(); // Comme ca on évite de faire trop de case inutile

            switch(aMonth)
            {
                case "DECEMBRE":
                case "JANVIER":
                case "FEVRIER":
                case "DECEMBER":
                case "JANUARY":
                case "FEBRUARY":
                Console.WriteLine("On est au mois "+aMonth+" à la saison d'hiver ");
                break;
                case "MARS":
                case "AVRIL":
                case "MAI":
                case "MARCH":
                case "APRIL":
                case "MAY":
                Console.WriteLine("On est au mois "+aMonth+" à la saison du printemps");
                break;
                case "JUIN":
                case "JUILLET":
                case "AOUT":
                case "JUNE":
                case "JULY":
                case "AUGUST":
                Console.WriteLine("On est au mois "+aMonth+" à la saison d'été");
                break;
                case "SEPTEMBRE":
                case "OCTOBRE":
                case "NOVEMBRE":
                case "SEPTEMBER":
                case "OCTOBER":
                case "NOVEMBER":
                Console.WriteLine("On est au mois "+aMonth+" à la saison d'automne ");
                break;
                default:
                    Console.WriteLine("Le mois saisi est incorrect, attention il doit être inscrit sans accent");
                break;

            }
        }
    }
}

*/