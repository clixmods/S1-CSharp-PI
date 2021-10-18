using System;

namespace Exercice_6_Program
{

    /*
        Exo 6 :
        Si l’année A n’est pas divisible par 4, alors elle n’est pas bissextile Si A est divisible par 4, l’année est bissextile sauf si
        A est divisible par 100 et pas par 400.
        Exemples :
        – 1901 n’est pas bissextile car non divisible par 4
        – 2004 est bissextile car divisible par 4 et pas par 100
        – 2100 n’est pas bissextile car divisible par 4, divisible par 100 mais pas par 400
        – 2000 est bissextile car divisible par 4, par 100 et par 400
        Ecrire un programme qui détermine si une année est bissextile ou non.

    */
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                     Console.WriteLine("Saisi une année stp, je vais te dire des choses dessus, tape Quit pour quitter le programme");
                     string strYear = Console.ReadLine();
                     if(strYear == "Quit")
                        break;

                     int intYear;
                     if(int.TryParse(strYear,out intYear))
                     {
                         if(intYear % 4 == 0 && intYear % 100 != 0 && intYear % 400 == 0 ) // est divisible par 4 
                         {
                             Console.WriteLine( strYear+" est bissextile");
                         }
                         else if(intYear % 4 == 0 && intYear % 100 != 0)
                         {
                             Console.WriteLine( strYear+" est bissextile");
                         }
                         else if(intYear % 4 == 0 && intYear % 100 == 0  && intYear % 400 != 0  )
                         {
                             Console.WriteLine( strYear+" n’est pas bissextile");
                         }
                         else if(intYear % 4 == 0 && intYear % 100 == 0  && intYear % 400 == 0  )
                         {
                             Console.WriteLine( strYear+" bissextile");
                         }
                         else
                         {
                             Console.WriteLine( strYear+" n’est pas bissextile");
                         }
                     }
                     else
                     {
                         Console.WriteLine("Error");

                     }
            }
        }
    }
}
