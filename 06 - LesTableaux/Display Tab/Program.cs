using System;

namespace Display_Tab
{
    /*
    Exo 1 - Display Tab
    Creer une fonction qui parcourt un tableau et qui affiche chacune de ses valeurs.
    */
    class Program
    {
        static int[] myTable = { 1,5,6,8,7,46,4,1,3897,4,13};
        static string[] myTableDaron = { "ton","père","le","chauve"};
        static void Main(string[] args)
        {
            DisplayTabGeneric(myTableDaron);
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
        static void DisplayTabGeneric<T>(T[] tab) // On peut envoyer tout type de table c'est lourd
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
