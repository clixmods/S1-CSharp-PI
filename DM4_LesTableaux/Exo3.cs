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
            string preMessage = "";
            for(int i = 0 ; i < listString.Length; i++)
            {
                preMessage += listString[i]+" ";
            }
            Console.WriteLine("Avant triage "+preMessage);


            int[] indexers = new int[listString.Length];
            
            //Pour chaque string on va récupéré la position de la première lettre quon stockera dans indexers
            for(int i = 0 ; i < listString.Length; i++)
            {
                listString[i] = listString[i].ToUpper();
                char[] strChar = listString[i].ToCharArray();
                for(int j = 0; j < HelperTable.Alphabet.Length; j++)
                {   
                    if(strChar[0] == HelperTable.Alphabet[j])
                    {    
                        indexers[i] = j;
                    }    
                }
            }


            // Ensuite on va trier indexers ou chaque index de cette table corresponds à leur string 
            // En triant indexers, on va en meme temps echanger les index de la table string
            bool sort = true;
            int index = 0;
            while(sort) // Le while fera le trie tant qu'il n'a pas fait lordre croissant des indexers
            {
                if(index + 1 < indexers.Length )
                { 
                    if(indexers[index] > indexers[index+1] )
                    {
                        // on fait des copies de indexers[index] et listString[index]
                        // pour ensuite echanger leur place
                        int copyA = indexers[index];
                        
                        indexers[index] = indexers[index+1];
                        indexers[index+1] = copyA;
                        string copyB = listString[index];
                        listString[index] = listString[index+1];
                        listString[index+1] = copyB;

                        index = 0;
                        continue;
                    }
                }
                else
                {
                    sort = false;     
                }
                index++;
            }
            // Le tri est fini, on peut donc afficher le résultat
            string message = "";
            for(int i = 0 ; i < listString.Length; i++)
            {
                message += listString[i]+" ";
            }
            Console.WriteLine("Apres triage "+message);
            return listString;
        }
    }
}