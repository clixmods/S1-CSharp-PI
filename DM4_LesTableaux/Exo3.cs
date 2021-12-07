using System;

namespace DM4_LesTableaux
{
    /*
       ================== Exo 3 ================== - Tri tableau de string, Nom projet : TriAlphabetiqueString
    - Creer une fonction qui prend en entrée un tableau de string.
    - Après être passé par la fonction le tableau doit contenir les strings triées par ordre alphabetique.
    - Utiliser cette fonction avec differents tableaux de string pour demontrer que ça fonctionne.
    */
    class Exo3
    {
        public static string[] TriAlphabetiqueString(string[] listString)
        {
            int[] indexers = new int[listString.Length];
            
            for(int i = 0 ; i < listString.Length; i++)
            {
                listString[i] = listString[i].ToUpper();
                char[] strChar = listString[i].ToCharArray();
                for(int j = 0; j < HelperTable.Alphabet.Length; j++)
                {   
                    if(strChar[0] == HelperTable.Alphabet[j])
                    {    
                        indexers[i] = (int)HelperTable.Alphabet[j];
                    }
                        
                }
            }
                

            for(int i = 0 ; i < listString.Length; i++)
            {
                Console.WriteLine(listString[i] + " / "+ indexers[i]);
            }

            return listString;
        }
    }
}