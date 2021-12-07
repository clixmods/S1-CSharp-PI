using System;

namespace Recherche_value
{
    class Program
    {
        /*
            Exo 3 - Recherche value
            Creer une fonction qui retourne
            -  -1 si le tableau ne contient pas la valeur passée en paramètre.
            - l'index de la valeur dans le tableau, si le tableau contient la valeur passée en paramètre.
        */

        static int[] myTable = {1,2,3,5,6,8,09,54,67,61};
        static void Main(string[] args)
        {
            Console.WriteLine(SearchValue(myTable,9809));
        }
        static int SearchValue(int[] table, int value)
        {
            for(int i = 0; i < table.Length; i ++)
            {
                if(table[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
