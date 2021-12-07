using System;
namespace DM4_LesTableaux
{
    /*
    ================== Exo 4 ================== - Le pendu, Nom projet : LePendu
Principe du pendu : 
A chaque partie, un mot random est choisi. Le joueur doit trouver le mot en proposant des lettres.
Le joueur a un nombre de porpositions limités.
Difficulté : la dificulté dépend de la longeur du mot et du nombre de coups disponibles.

Déroulé d'une partie :
Afficher un menu qui propose au joueur au minimum deux difficultés : Normale, Difficile
Normale : mot entre 4 et 6 lettres, 15 coups
Difficile : mot entre 8 et 10 lettres et 12 coups
Après le choix de la difficulté le programme choisi un mot aléatoirement parmis un lot de mots (tableau de string).
Ensuite on affiche à chaque tour:
- l'etat du pendu en fonction des coups
- le nombre de coups restant
- l'etat du mot à trouver 

Déroulé d'un tour :
A chaque tour, le joueur peut entrer une lettre ou un mot entier.
Lorsqu'on joue au pendu, il est possible de proposer le mot entier plutôt qu'une seule lettre.
Gérer la possibilité d'entrer un mot entier pour le joueur.
A chaque tour, le programme affiche le mot en cachant les lettres non trouvées : 
Exemple avec le mot "bonjour", le joueur a trouvé n et u :
**n**u*

Lorsque le joueur a entré sa lettre ou son mot il appuie sur entrer,
le programme decremente le nombre de coups et valide si la lettre est dans le mot (ou si le mot proposé est le bon).
- si oui on ajoute la lettre dans l'affichage
- sinon on ajoute un element à l'affichage du pendu

Fin de partie :
A chaque tour il faut gérer :
si le joueur peut continuer
si le joueur a perdu
si le joueur a gagné => afficher le mot trouvé et le nombre de coups utilisés pour le trouver.

Inventer un affichage original pour le pendu.
Idée d'affichage pendu pour une partie à 12 coups (Difficile).

_ _0_ _
   |
   |
   |
  / \
 /   \
 
 ou 
   _ _
 |   |
    _O_
 |   |
    / \
 |
    */
    class Exo4
    {
        public enum Difficulty 
        {
            normal,
            difficile,
        }
        static string[] penduStateNormal = {
            "  \n    \n     \n    \n     \n ",
            "  \n    \n     \n    \n     \n ",
            "  \n    \n     \n    \n     \n ",
            "  \n    \n     \n    \n     \n ",
            "  \n    \n     \n    \n     \n |",
            "  \n    \n     \n |   \n     \n |",
            "  \n |   \n     \n |   \n     \n |",
            " _ \n |   \n     \n |   \n     \n |",
            " _ _\n |   \n     \n |   \n     \n |",
            " _ _\n |   |\n     \n |   \n     \n |",
            " _ _\n |   |\n     O\n |   \n     \n |",
            " _ _\n |   |\n     O\n |   |\n     \n |",
            " _ _\n |   |\n    _O\n |   |\n     \n |",
            " _ _\n |   |\n    _O_\n |   |\n     \n |",
            " _ _\n |   |\n    _O_\n |   |\n    / \n |",
            " _ _\n |   |\n    _O_\n |   |\n    / \\\n |"
        };

        static string[] penduStateDifficile = {
            "  \n    \n     \n    \n     \n ",
            "  \n    \n     \n    \n     \n |",
            "  \n    \n     \n |   \n     \n |",
            "  \n |   \n     \n |   \n     \n |",
            " _ \n |   \n     \n |   \n     \n |",
            " _ _\n |   \n     \n |   \n     \n |",
            " _ _\n |   |\n     \n |   \n     \n |",
            " _ _\n |   |\n     O\n |   \n     \n |",
            " _ _\n |   |\n     O\n |   |\n     \n |",
            " _ _\n |   |\n    _O\n |   |\n     \n |",
            " _ _\n |   |\n    _O_\n |   |\n     \n |",
            " _ _\n |   |\n    _O_\n |   |\n    / \n |",
            " _ _\n |   |\n    _O_\n |   |\n    / \\\n |"
        };


        //Normale : mot entre 4 et 6 lettres, 15 coups
        static string[] wordListNormal = {
            "boule",
            "idiot",
            "biere",
            "chat",
            "puant",
            "souris",
            "tomate",
            "doigt",
            "fuir",
            "Garage"
        };

        //Difficile : mot entre 8 et 10 lettres et 12 coups
        static string[] wordListDifficile = {
            "monstrueux",
            "toilette",
            "automobile",
            "Domination",
            "Soumission",
            "difficile",
            "adorable",
            "cosmique"
        };
        // Cette fonction permet d'update le mot caché par la lettre trouvé
        public static char[] UpdateCharHidden(char[] wordCharHidden , char[] wordChar, char Letter )
        {
            for(int i = 0 ; i < wordCharHidden.Length;i++)
            {
                if(wordChar[i] == Letter)
                    wordCharHidden[i] = wordChar[i];
            }
            return wordCharHidden;
        }
        public static void Init()
        {
            string message = "Choissisez un mode de difficulté :\n";
            message += "[n] pour normal (mot entre 4 et 6 lettres, 15 coups) \n";
            message += "[d] pour difficile (mot entre 8 et 10 lettres et 12 coups)";
            Console.WriteLine(message);
             ConsoleKey input = Console.ReadKey().Key;
                switch(input)
                {
                    case ConsoleKey.N :
                        PenduStart(Difficulty.normal);
                    break;
                    case ConsoleKey.D :
                        PenduStart(Difficulty.difficile);
                    break;
                    default : 
                        PenduStart(Difficulty.normal);
                    break;

                }
        }
        public static void PenduStart(Difficulty difficulty)
        {
            // On initie les variables utiles pour notre pendu
            int tentativeRestante = 15;
            string[] penduState = penduStateNormal;
            Random rand = new Random();
            string word = "default";
            int randomValue = 0;
            // Le switch va permettre de configurer les variables suivant la difficulté
            switch(difficulty)
            {
                case Difficulty.normal :
                    Console.WriteLine("La difficulté choisie est : Normal");
                    randomValue =  rand.Next(0, wordListNormal.Length);
                    word = wordListNormal[randomValue];
                    penduState = penduStateNormal;
                    tentativeRestante = 15;
                break;
                case Difficulty.difficile :
                    Console.WriteLine("La difficulté choisie est : Difficile");
                    randomValue =  rand.Next(0, wordListNormal.Length);
                    word = wordListNormal[randomValue];
                    penduState = penduStateDifficile;
                    tentativeRestante = 12;
                break;
                default : 
                    Console.WriteLine("La difficulté choisie est : Normal");
                    randomValue =  rand.Next(0, wordListNormal.Length);
                    word = wordListNormal[randomValue];
                    penduState = penduStateNormal;
                    tentativeRestante = 15;
                break;
            }
            // on clean le mot à trouver en le passant en majuscules et en enlevant les accents     
            word = word.ToUpper(); 
            char[] wordChar = word.ToCharArray();
            wordChar = HelperTable.CharTableRemoveAccents(wordChar);
            // On prépare le string caché qui va etre afficher 
            char[] wordCharHidden = new char[wordChar.Length];
            for(int i = 0 ; i < wordCharHidden.Length;i++)
            {
                wordCharHidden[i] = '*';
            }
            bool isWin = false;
            // Le pendu commence avec le while()
            while(tentativeRestante >= 0)
            {
                Console.Clear();
                if(new string(wordChar) == new string(wordCharHidden)) // On check si le mot est trouvé
                {
                    Console.WriteLine("Vous avez réussi en "+(penduState.Length - tentativeRestante)+ " essaies \n Le mot était "+new string(wordChar));
                    isWin = true;
                    break;
                }
                // On construit l'affichage du jeu    
                Console.WriteLine(penduState[penduState.Length-1 - tentativeRestante] +"\nTentativeRestante : "+tentativeRestante+ " \n "+new string(wordCharHidden) );
                
                bool isPassed = false;  // isPassed permettra de savoir si le joueur à trouver une lettre,
                // On lit ce que le joueur a envoyé,
                // et on nettoie accents etc pour harmoniser
                string input = Console.ReadLine();
                input = input.ToUpper();
                char[] inputs = input.ToCharArray();
                inputs = HelperTable.CharTableRemoveAccents(inputs);
                // Vue que l'input contient plusieurs char, on check si il correspond au mot. 
                // Sinon, c'est un seul character, on check chaque char du mot à trouver 
                if(inputs.Length > 1)
                {
                    // Si on rentre dans le if c'est que le mot proposer est juste, sinon rip 
                    if(new string(wordChar) == new string(inputs))
                    {
                        wordCharHidden = inputs;
                        isPassed = true;
                    }
                }
                else
                {
                    for(int i = 0; i < wordChar.Length;i++)
                    {
                        for(int j = 0; j < inputs.Length;j++)
                        {
                            // pour chaque lettre du mot à trouver, on regarde si l'un des lettre envoyé par le joueur correspond
                            if(inputs[j] == wordChar[i])
                            {   
                                // On update le var avec les lettres trouvée
                                wordCharHidden = UpdateCharHidden(wordCharHidden , wordChar, inputs[j] );
                                isPassed = true; // C'est good, il n'a pas perdu de tentative
                            }
                        }
                    }
                }
                
                if(isPassed) // Si isPassed est à true, cela veut dire que le joueur à trouver une lettre, on peut donc revenir au debut sans enlever une tentative
                    continue;

                tentativeRestante--;
            }
            if(!isWin)
            {
                Console.WriteLine("Vous avez perdu, le mot était "+new string(wordChar));
            }
        }
        
    }
}