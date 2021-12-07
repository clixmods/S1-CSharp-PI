using System;

namespace DM4_LesTableaux
{
    /*
       ================== Exo 2 ================== - Random alphabet tab et tri, Nom projet : TriAlphabetique
        - Creer une fonction qui créer un tableau avec tous les caractères de l'alphabet en désordre.
        - Creer une fonction qui prend un tableau de char en entrée et qui le tri par ordre alphabetique.
        - Utiliser cette fonction avec le tableau contenant l'alphabet et afficher le resultat trié.
    */
    class Exo2
    {
        

        public static char[] AlphabetRandomizer()
        {
            // on copie tout les lettres de l'alphabet dans une nouvelle table de même taille
            // Ensuite pour chaque index, nous utiliserons un bool[] pour savoir si celle ci 
            // a deja été utilisé.
            char[] alphabetRandom = new char[HelperTable.Alphabet.Length]; 
            bool[] valueUsed = new bool[HelperTable.Alphabet.Length];
            Random randomFunc = new Random();  
            for(int i = 0; i < HelperTable.Alphabet.Length; i++)
            {
                // Pour autant de lettre dans l'alphabet, nous allons généré un nombre aléatoire
                // qui indiquera une position dans l'alphabet
                int randomValue = randomFunc.Next(0,HelperTable.Alphabet.Length);
                while(true)
                {
                    // Cette boucle permet de vérifier si la position n'est pas déja utilisé, sinon elle va regénérer
                    // une position jusqua que ce soit bon
                    if(!valueUsed[randomValue])
                    {
                        valueUsed[randomValue] = true;
                        alphabetRandom[i] = HelperTable.Alphabet[randomValue];
                        break;
                    }
                    else
                        randomValue = randomFunc.Next(0,HelperTable.Alphabet.Length);
                }
                
            }
            return alphabetRandom;
        }


        public static char[] SortAlphabetTable(char[] tableChar)
        {
            /*
                return HelperTable.Alphabet; JOKE
            */
            // On nettoie la table de tout accents et on la passe également en majuscule
            tableChar = HelperTable.CharTableRemoveAccents(tableChar);
            string oof = new string(tableChar);
            oof = oof.ToUpper();
            tableChar = oof.ToCharArray();

            // On va récupéré les position de chaque lettre dans l'alphabet
            int[] indexers = new int[tableChar.Length];
            for(int i = 0 ; i < indexers.Length; i++)
            {
                for(int j = 0 ; j < HelperTable.Alphabet.Length; j++)
                {
                    if(tableChar[i] == HelperTable.Alphabet[j])
                        indexers[i] = j;
                }
            }
            // On tri les positions par ordre croissant.
            indexers = HelperTable.SortMyIntTable(indexers);
            
            // On attribue dans tableReturn les lettres qui corresponde aux positions quon a trier precedemment
            char[] tableReturn = new char[indexers.Length];
            for(int i = 0 ; i < indexers.Length; i++)
            {
                tableReturn[i] = HelperTable.Alphabet[indexers[i]];
            }
            return tableReturn;
        }

    }
}