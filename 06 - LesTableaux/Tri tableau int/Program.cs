using System;

namespace Tri_tableau_int
{
    class Program
    {
        /* 
            Exo 7 - Tri tableau int
            - Creer une fonction qui crée un tableau random de int
            - Creer une fonction qui tri un tableau de int.
            => algo en place (pas de création de tableau)
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] myTable = CreateRandomTable(5);
            // for (int i = 0; i < myTable.Length; i++)
            //     Console.WriteLine(myTable[i]);


            int[] myTableSorted = triBulles(myTable);
            for (int i = 0; i < myTableSorted.Length; i++)
                Console.WriteLine(myTableSorted[i]);
        }

        static int[] CreateRandomTable(int tableLenght)
        {
            tableLenght--;
            int[] newTable = new int[tableLenght];
            for (int i = 0; i < tableLenght; i++)
            {
                Random randm = new Random();
                newTable[i] = randm.Next(0, 9);

            }
            return newTable;
        }

        static int[] SortTable(int[] tableToSort)
        {
            for (int i = 0; i < tableToSort.Length; i++)
            {
                if(i+1 < tableToSort.Length)
                {
                    if(tableToSort[i] > tableToSort[i+1])
                    {
                        int oups = tableToSort[i];
                        tableToSort[i] = tableToSort[i+1];
                        tableToSort[i+1] = oups;
                    }
                    else
                    {

                    }
                }    
            }

            return tableToSort;
        }
        

        static int[] triBulles(int[] tableToSort)
        {
            int N = tableToSort.Length;
            for(int i =0; i< N -1 ; i++)
            {
                for(int j = 0 ; j < i -1 ; j++)
                {
                    if(tableToSort[j] > tableToSort[j+1])
                    {
                         int oups = tableToSort[j];
                        tableToSort[j] = tableToSort[j+1];
                        tableToSort[j+1] = oups;
                    }                
                }    
            }
            return tableToSort;
        }
    }
}
