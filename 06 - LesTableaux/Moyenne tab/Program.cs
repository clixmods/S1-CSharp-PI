using System;

namespace Moyenne_tab
{
    class Program
    {
        /*
            Exo 2 Bis - Moyenne tab
            Creer une fonction qui retourne la moyenne des valeurs d'un tableau (utiliser la fonction précédente)
        */
        static float[] myTable = {11.5f,20,0,16,15,9,7,9.98f,5.5f};
        static void Main(string[] args)
        {
            float oof = TotalTab(myTable);
            Console.WriteLine(oof);
            float moyenne = MoyenneTab(myTable);
            Console.WriteLine(moyenne);
        }
        static float TotalTab(float[] table)
        {
            float result = 0;
            for(int i = 0; i < table.Length; i++ )
            {
                result += table[i];
            }
            return result;
        }
        static float MoyenneTab(float[] table)
        {
            float result = TotalTab(table);
          
            return result/table.Length;
        }
        
    }
}
