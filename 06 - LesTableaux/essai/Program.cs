using System;

namespace essai
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oof = new int[]{1,1,6,5,55,59,56,1,3};

            TriBulle(oof);
            for(int i = 0 ; i < oof.Length ;i++)
                Console.Write( oof[i]);
        }

        static void TriBulle(int[] table)
        {
            for(int i =0; i < table.Length; i++)
            {
                for(int j = 0 ; j < table.Length -1 ; j++) 
                {
                    if( table[j] > table[j+1] )
                    {
                        int temp = table[j+1];
                        table[j+1] = table[j];
                        table[j] = temp; 
                    }
                }
            }

        }
    }
}
