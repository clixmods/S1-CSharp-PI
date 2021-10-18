using System;

namespace Exercice_5_Program
{
    /*
    Exo 5 : Saison
    Ecrire un programme qui test une variable string contenant un mois, et qui affiche la saison correspondante.

    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ECRIT UN MOIS EN ANGLAIS OU FRANCAIS ET LA SAISON SERA DONNNEEEERRR ( pas daccent svp ) ");
            // Fr ou anglais, normalement c'est langlais qui est privilégié mais du coup j'ai mi les deux.
            string aMonth = Console.ReadLine().ToUpper(); // Comme ca on évite de faire trop de case inutile

            switch(aMonth)
            {
                case "DECEMBRE":
                case "JANVIER":
                case "FEVRIER":
                case "DECEMBER":
                case "JANUARY":
                case "FEBRUARY":
                Console.WriteLine("On est au mois "+aMonth+" à la saison d'hiver ");
                break;
                case "MARS":
                case "AVRIL":
                case "MAI":
                case "MARCH":
                case "APRIL":
                case "MAY":
                Console.WriteLine("On est au mois "+aMonth+" à la saison du printemps");
                break;
                case "JUIN":
                case "JUILLET":
                case "AOUT":
                case "JUNE":
                case "JULY":
                case "AUGUST":
                Console.WriteLine("On est au mois "+aMonth+" à la saison d'été");
                break;
                case "SEPTEMBRE":
                case "OCTOBRE":
                case "NOVEMBRE":
                case "SEPTEMBER":
                case "OCTOBER":
                case "NOVEMBER":
                Console.WriteLine("On est au mois "+aMonth+" à la saison d'automne ");
                break;
                default:
                    Console.WriteLine("Le mois saisi est incorrect, attention il doit être inscrit sans accent");
                break;

            }
        }
    }
}
