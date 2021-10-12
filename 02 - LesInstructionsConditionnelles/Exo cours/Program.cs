using System;

namespace Exo_cours
{
    /*
        Exo cours
    Ecrivez un programme qui affiche le signe du produit de a et b sans faire la multiplication. Pour cela, vous testerez
    uniquement si le résultat est inférieur à 0.
    */
    class Program
    {
        static void Main(string[] args)
        {
      
            int valueA = GetValue();
            int valueB = GetValue();
            string signeProduit;
            if((valueA < 0 && valueB > 0) || (valueA > 0 && valueB < 0))
                signeProduit = "negatif";
            else
                signeProduit = "positif";


            Console.WriteLine(signeProduit);

        }
        static int GetValue()
        {
            int result;
            while(true)
            {
                Console.WriteLine("Tapez une valeur ");
                string userProposition = Console.ReadLine();
                if(int.TryParse(userProposition,out int cool))
                {
                    result = int.Parse(userProposition);
                    break;
                }
                else
                {
                    Console.WriteLine("Your value is incorrect, only int number are allowed. Retry please.");
                    continue;
                }
            } 
            return result;
        }
    }
}
