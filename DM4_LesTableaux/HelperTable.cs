using System;

namespace DM4_LesTableaux
{
    /*
    Exo 1 - Display Tab
    Creer une fonction qui parcourt un tableau et qui affiche chacune de ses valeurs.
    */
    class HelperTable
    {
         /*
            Tableau charWithAccents généré depuis DisplayAllCharacter. L'objectif est de changé tout les accents par leur lettre "source"
            le tableau charSource va donner la lettre sans accent grace à l'index de charWithAccents qui correspondra à celle ci. 
            static void DisplayAllCharacter(int number)
            {
                for(int i = 33 ; i < number+33;i++)
                {
                    Console.WriteLine(Convert.ToChar(i) );
                }    
            }
        */
        static char[] charWithAccents = {'À','Á','Â','Ã','Ä','Å','Æ','Ç','È','É','Ê','Ë','Ì','Í','Î','Ï','Ð','Ñ','Ò','Ó','Ô','Õ','Ö','×','Ù','Ú','Û','Ü','Ý','Þ','ß','à','á','â','ã','ä','å','æ','ç','è','é','ê','ë','ì','í','î','ï','ð','ñ','ò','ó','ô','õ','ö','ù','ú','û','ü','ý','ÿ'};
        static char[] charSource = {'A','A','A','A','A','A','A','C','E','E','E','E','I','I','I','I','D','N','O','O','O','O','O','X','U','U','U','U','Y','P','B','A','A','A','A','A','A','A','C','E','E','E','E','I','I','I','I','O','N','O','O','O','O','O','U','U','U','U','Y','Y'};
       
        public static char[] Alphabet = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M','N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};


        public static int[] SortMyIntTable(int[] myTable)
        {
            bool sort = true;
            int index = 0;
            while(sort)
            {
                if(index + 1 < myTable.Length )
                { 
                    if(myTable[index] > myTable[index+1] )
                    {
                        int oofff = myTable[index];
                        myTable[index] = myTable[index+1];
                        myTable[index+1] = oofff;
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
            return myTable;
        }

        // La function CharTableRemoveAccents va remplacer tout les charWithAccents par ceux de charSource
        public static char[] CharTableRemoveAccents(char[] text)
        {
            for(int i = 0; i < text.Length; i++)
            {
                for(int j = 0; j < charWithAccents.Length; j++)
                {
                    if(text[i] == charWithAccents[j])
                        text[i] = charSource[j];
                }
            } 
            return text;
        }

        static void DisplayTab(int[] tab)
        {
            string message = "{\"";
            for(int i = 0; i < tab.Length ; i++)
            {
                if(i != tab.Length - 1)
                    message += tab[i]+"\",\"";
                else
                    message += tab[i]+"\"";
            }    
            message += "}";
            Console.WriteLine(message);
        }
        public static void DisplayTabGeneric<T>(T[] tab) // On peut envoyer tout type de table c'est lourd
        {
            string message = "{\"";
            for(int i = 0; i < tab.Length ; i++)
            {
                if(i != tab.Length - 1)
                    message += tab[i]+"\",\"";
                else
                    message += tab[i]+"\"";
            }    
            message += "}";
            Console.WriteLine(message);
        }
    }
}
