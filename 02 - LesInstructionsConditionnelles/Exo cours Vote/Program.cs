using System;

namespace Exo_cours_Vote
{
    /*
    Exo cours
    Intitialiser une variable entière qui correspondera à l’ˆage d’une personne, si la personne a au moins 18 ans, alors on affiche
    ”peut voter”, sinon, on affiche ”ne peut pas voter”. Refaire la mˆeme chose en le formulant négativement : si la personne
    n’a pas 18 ans, elle ne peut pas voter, sinon elle peut.
    */
    class Program
    {
        static void Main(string[] args)
        {   
            



            while(true)
            {
                Console.WriteLine("Entrez un age quelconque svp, EN INT MERCI");
                string age = Console.ReadLine();
                int result;
                if(int.TryParse(age, out result))
                {
                    CheckAgePourVoter(result);
                    CheckAgePourVoterNegativement(result);
                    break;
                }
                else
                {
                    Console.WriteLine("JAI DIS INT PAS AUTRE CHOSE AHH ON RECOMMENCE");
                    continue;
                }
                    
            }
            
        }
        static void CheckAgePourVoter(int age)
        {
            if(age >= 18)
            {
                Console.WriteLine("peut voter");
            }
            else
            {
                Console.WriteLine("ne peut pas voter");
            }
            
        }
        static void CheckAgePourVoterNegativement(int age)
        {
            if(age < 18)
            {
                Console.WriteLine("ne peut pas voter (de maniere negative)");
            }
            else
            {
                Console.WriteLine("peut voter (de maniere negative)");
            }
            
        }
    }
}
