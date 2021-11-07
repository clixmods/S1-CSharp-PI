using System;

namespace Exos_Boucles_Project
{
    /*
    Dans chaque exo, il faut utiliser des boucles !

    Pour cette serie d'exercices, faire un seul projet et appeler les differentes fonctions dans Main.

    Pour chaque exercice, vous devez demander à l'utilisateur de rentrer une valeur et ensuite passer la valeur saisie dans la fonction.
    Utiliser le HelperRead (créé en cours) qui permet de demander à l'utilisateur un int de manière sécurisé.
    => Copiez le fichier HelperRead.cs dans votre projet.

    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string message = "Write the id function to start it, 0 to stop the program \n";
            message += "1 : DisplayAllNumber \n";
            message += "2 : DisplayAllCharacter \n";
            message += "3 : DisplayAllPairNumber \n";
            message += "4 : DisplayTriangle \n";
            message += "5 : DisplayDiamond \n";
            bool run = true;
            while(run)
            {
                switch(HelperRead.ReadIntBetween(0,5,message))
                {
                    case 0:
                        run = false;
                    break;
                    case 1:
                        DisplayAllNumber(HelperRead.ReadInt("Veuillez tapez un INT pour la function DisplayAllNumber"));
                    break;
                    case 2:
                        DisplayAllCharacter(HelperRead.ReadIntBetween(1,94,"Veuillez tapez un INT pour la function DisplayAllCharacter, entre "));
                    break;
                    case 3:
                        DisplayAllPairNumber(HelperRead.ReadInt("Veuillez tapez un INT pour la function DisplayAllPairNumber"));
                    break;
                    case 4:
                        DisplayTriangle(HelperRead.ReadInt("Veuillez tapez un INT pour la function DisplayTriangle"));
                    break;
                    case 5:
                        DisplayDiamond(HelperRead.ReadInt("Veuillez tapez un INT pour la function DisplayDiamond"));
                    break;
                }
            }
            Console.WriteLine("Good Bye World!");


        }
        /*
        Exo 1
        Creer une fonction 'DisplayAllNumber' qui prend en paramètre un int.
        La fonction doit afficher tous les nombres de 0 à la valeur du paramètre sans aller à la ligne.
        Ex : 4 est passé en paramètre. Le programme affiche : 
        01234
        */
        static void DisplayAllNumber(int number)
        {
            string message = "";
            for(int i = 0 ; i <= number; i++)
                message += i;
                
            Console.WriteLine(message);

        }
        /*  
        Exo 2
        Creer une fonction 'DisplayAllCharacter' qui prend en paramètre un int.
        La fonction doit afficher les caractères de valeur 33 à la valeur numerique + 33 du paramètre.
        (33 étant le premier caractère affichable dans la table ASCII, '!')
        Ex : 3 est passé en paramètre. le programme affiche :
        !
        "
        #
        */
        static void DisplayAllCharacter(int number)
        {
            for(int i = 33 ; i < number+33;i++)
            {
                Console.WriteLine(Convert.ToChar(i) );
            }    
        }
        /*
        Exo 3
        Creer une fonction 'DisplayAllPairNumber' qui prend en paramètre un int.
        La fonction doit afficher tous les nombres de 0 à la valeur du paramètre et si les nombres sont multiple de 2 et sans aller à la ligne.
        Ex : 11 est passé en paramètre. Le programme affiche : 
        0246810
        */

        static void DisplayAllPairNumber(int number)
        {
            string message = "";
            for(int i = 0 ; i <= number; i+=2)
            {
                message += i;
            }
            Console.WriteLine(message);
        }
        /*
            Exo 4
            Creer une fonction 'DisplayTriangle' qui prend en paramètre un int et qui affiche un figure comme suit :
            Exemple le programme prend en paramètre 4 et affiche :

            *
            **
            ***
            ****        
        */
        static void DisplayTriangle(int number)
        {
            string message = "";
            for(int i = 0; i< number ;i++)
            {
                message += "*";
                Console.WriteLine(message);
            }
        }
        /*
        Exo 5
        Creer une fonction 'DisplayDiamond' qui prend en paramètre un int
        */
        static void DisplayDiamond(int number)
        {
            String[] array = new String[number];
            // Genere la partie du haut du diamant.
            for(int i = 0; i< number ;i++)
            {
                string message = "";
                // On rajoute le nombre d'espace au message
                for(int j = 1; j < number-i ; j++ )
                    message += " ";
                // après les espaces il a toujours une *
                message += "*";
                // A chaque i, rajoute deux * en plus, du coup on refait un for
                for(int k = 0; k < i; k++ )
                    message += "**";
                // Pour la dernière ligne, vue que je ne veux pas la réecrire pour dessiner la partie du bas, 
                // je rajoute le message à larray jusqua l'avant derniere itération afin de pas rajouter la derniere 
                if( i+1 < number)
                    array[i] = message;
                
                Console.WriteLine(message);
            }
            // Genere la partie bas du diamant
            // Vue que j'ai stocker tout mes précedents messages dans mon array string[], j'ai juste à les réafficher dans l'ordre décroissant par le for
            for(int i = array.Length-2; i >= 0 ;i--)
                Console.WriteLine(array[i]);
        }
    }
}
