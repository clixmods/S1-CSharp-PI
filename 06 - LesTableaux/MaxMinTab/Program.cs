using System;

namespace MaxMinTab
{
    class Program
    {
        /*
        Exo 5 - Max et Min valeur dans un tab
        1 - Creer une fonction qui retourne le min des valeurs d'un tableau
        2 - Creer une fonction qui retourne le max des valeurs d'un tableau
        */
        static int[] myTable = {1,2,3,5,6,8,4,9,8,5,0,2,6,-560,6,4,64,8};
        static void Main(string[] args)
        {
            Console.WriteLine(ReturnMinTab(myTable));
            Console.WriteLine(ReturnMaxTab(myTable));
        }

        static int ReturnMinTab(int[] table)
        {
            int minValue = table[0];
            for(int i = 0; i < table.Length;i++)
            {
                if( minValue > table[i])
                    minValue = table[i];
            } 
            return minValue;
        }
        static int ReturnMaxTab(int[] table)
        {
            int maxValue = table[0];
            for(int i = 0; i < table.Length;i++)
            {
                if( maxValue < table[i])
                    maxValue = table[i];
            } 
            return maxValue;
        }
    }
}
