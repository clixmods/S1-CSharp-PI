using System;

namespace DM4_LesTableaux
{
    /*
        ================== Exo 1 ================== - Nom projet : Palindromes
        - Creer une fonction qui prend en entrée une string et dit si la string est un palindrome. (Indice : utiliser la fonction ToCharArray des string)
        Palindrome : un texte ou un mot dont l'ordre des lettres reste le même qu'on le lise de gauche à droite ou de droite à gauche.
        Exemple de palindrome : "elle", "Tu l'as trop écrasé César ce Port-Salut", "Dogma I am God"
        -  Demontrer le fonctionnement de votre fonction avec plusieurs mots ou phrase (palindrome et non palindrome).
    */
    class Exo1
    { 
        public static bool IsPalindrome(string text)
        {
            // Etape 1 : On passe en majuscule tout le string pour harmoniser
            // On decompose le texte en char
            // On remplace les accents par la lettre source 
            text = text.ToUpper(); 
            char[] CharText = text.ToCharArray();
            CharText = HelperTable.CharTableRemoveAccents(CharText);

            // On créer un tableau temporaire dans lequel on va stocker les lettre seulement
            char[] tempTable = new char[CharText.Length];
            int sizeOfTable = 0;  // Ce int permettra de savoir le nombre exact de lettre dont la taille de nos futures tableaux;
            for(int i = 0 ; i < CharText.Length; i++)
            {
                if(Char.IsLetter(CharText[i]))
                {
                    tempTable[sizeOfTable] = CharText[i];
                    sizeOfTable++;
                }    
            }
            // tempTable contient toutes nos lettres, mais vue que cette taille dépend du tableau passé en parametre,
            // il faut le recomposer afin d'avoir une taille correct
            char[] cleanAndDecomposedText = new char[sizeOfTable];
            for(int i = 0; i < sizeOfTable; i++)
            {
                cleanAndDecomposedText[i] = tempTable[i];
            }
            
            // Maintenant que l'on possède une table avec seulement les lettres, nous allons l'inverser.
            char[] inversedDecomposedText = new char[sizeOfTable];
            for(int i = 0 ; i < sizeOfTable; i++)
            {
                inversedDecomposedText[i] = cleanAndDecomposedText[sizeOfTable-i-1];
            }         
  
            // Maintenant que lon a nos deux tables, une dans lordre et lautre inverser, on va comparer si les strings généré sont identiques.
            string stringA = new string(inversedDecomposedText);
            string stringB = new string(cleanAndDecomposedText);

                if(stringA == stringB)
                {
                    Console.WriteLine("Le texte "+text+" est palindrome.");
                    return true;
                }  
                else
                {
                    Console.WriteLine("Le texte "+text+" n'est pas un palindrome.");
                    return false;
                }      
        }
    }
}