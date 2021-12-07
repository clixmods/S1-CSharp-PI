using System;

namespace InsertVal
{
    /*
    
    Exo 6 - Insert Tab
    Creer une fonction qui prend deux tableaux en entrée et un index
    La fonction insert les valeurs du deuxième dans le premier à partir de l'index passé en paramètre.

    */
    class Program
    {
        static void Main(string[] args)
        {
            int[] myTable = {9,9,9,9};
            int[] myTableToImplnt = {10,10,10};

            int[] myNewTable = InsertValueInTable(myTable,  2);
            for(int i = 0 ; i < myNewTable.Length; i++)
                Console.WriteLine(myNewTable[i]);

            Console.WriteLine("-----------------------------------------------------");

            int[] myNewTableB = InsertValuesInMyTable(myTable, myTableToImplnt,  2);
            for(int i = 0 ; i < myNewTableB.Length; i++)
                Console.WriteLine(myNewTableB[i]);
        }
         
        static int[] InsertValueInTable(int[] table , int myValue)
        {
            int[] newTable = new int[table.Length+1];
            for(int i = 0 ; i < table.Length; i++)
                newTable[i] = table[i]; 

            newTable[table.Length] = myValue;

            return newTable;
            
        }
        static int[] InsertValuesInMyTable(int[] table, int[] tableToImplant , int index)
        {
            index++;
            int[] newTable = new int[table.Length+tableToImplant.Length];   
            for(int i = 0 ; i < index ; i++)
                newTable[i] = table[i];

            for(int i = 0 ; i < tableToImplant.Length ; i++)
            {
                newTable[i+index] = tableToImplant[i];
            }
            for(int i = index ; i < table.Length ; i++)
                newTable[i+tableToImplant.Length] = table[i];

            return newTable;

        }
        
    }
}
