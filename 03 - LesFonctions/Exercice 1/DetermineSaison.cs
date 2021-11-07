using System;
class DetermineSaison
{
     public static string Exec()
        {
            Console.WriteLine("ECRIT UN MOIS EN ANGLAIS OU FRANCAIS ET LA SAISON SERA DONNNEEEERRR pas daccent svp");
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
                return "On est au mois "+aMonth+" à la saison d'hiver ";
                
                case "MARS":
                case "AVRIL":
                case "MAI":
                case "MARCH":
                case "APRIL":
                case "MAY":
                return "On est au mois "+aMonth+" à la saison du printemps";
                
                case "JUIN":
                case "JUILLET":
                case "AOUT":
                case "JUNE":
                case "JULY":
                case "AUGUST":
               return "On est au mois "+aMonth+" à la saison d'été";
                
                case "SEPTEMBRE":
                case "OCTOBRE":
                case "NOVEMBRE":
                case "SEPTEMBER":
                case "OCTOBER":
                case "NOVEMBER":
                return "On est au mois "+aMonth+" à la saison d'automne ";
                
                default:
                return "Le mois "+aMonth+" saisi est incorrect, attention il doit être inscrit sans accent";
                

            }
        }
}