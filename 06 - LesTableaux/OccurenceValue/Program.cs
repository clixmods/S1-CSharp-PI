using System;

namespace OccurenceValue
{
    class Program
    {
        static int[] myTable = {2,5,2,2,5,2,2,5,5,5,5,5,2};
        static void Main(string[] args)
        {
            OccurenceMyValue(myTable,2);
            OccurenceMyValue(myTable,5);
        }
        static void OccurenceMyValue(int[] table, int value)
        {
            int counter = 0;
            for(int i = 0 ; i< table.Length;i++)
            {
                if(table[i] == value)
                    counter++;
                
            }
            Console.WriteLine("Le nombre d'occurence pour "+ value + " est égale à "+ counter);
        }
    }
}
