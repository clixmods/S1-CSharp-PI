using System;

namespace Total_tab
{
    /*
        Exo 2 - Total tab
        Creer une fonction qui retourne le total des valeurs d'un tableau (int et float)
    */
    class Program
    {
        static float[] myTable = {1,5,68,4.4545465f,651,6.69f,4,9.5f,13,16,16.5f};
        static void Main(string[] args)
        {
            float oof = TotalTabGeneric(myTable);
        }
        static dynamic TotalTabGeneric<T>(T[] table)
        {
            if(typeof(T) != typeof(int) || typeof(T) != typeof(float))
                return 0;

            T result; 

            for(int i = 0; i < table.Length; i++ )
            {
                if(typeof(T) == typeof(int) || typeof(T) == typeof(float))
                    result += table[i];
            }
            return result;
        }
    }
}
