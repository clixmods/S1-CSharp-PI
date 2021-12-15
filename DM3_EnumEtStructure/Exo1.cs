
using System;
/*

================== Exo 1 ===================== Creer un projet 'MonthToColor' 

0 - Declarer les trois enums Mois, Saison, Couleur et définir leurs valeurs. 
Pour l'enumeration Couleur => Blanc, Vert, Jaune, Rouge

Implementer un programme :
1 - Qui demande d'entrer dans la console un mois ecrit (ou un int).
2 - Puis qui donne cette entrée à une fonction qui retourne le mois sous forme d'enum de type Mois. (Il faut implementer cette fonction)
3 - Puis qui donne cette enum Mois à une fonction qui retourne à quelle saison appartient ce mois sous forme d'enum de type Saison. (Il faut aussi implementer cette fonction)
4 - Puis qui donne cette enum Saison à une fonction qui retourne une couleur en fonction de la saison sous forme d'enum de type Couleur. (Il faut aussi aussi implementer cette fonction)
5 - Et qui se termine en affichant (avec les valeurs récupérées) : Le mois de '' appartient à la saison '' et sa couleur est le ''.

*/

namespace DM3_EnumEtStructure
{
    public enum Mois
    {
        Janvier,
        Fevrier,
        Mars,
        Avril,
        Mai,
        Juin,
        Juillet,
        Aout,
        Septembre,
        Octobre,
        Novembre,
        Decembre
    }
    public enum Saison
    {
        Automne,
        Hiver,
        Printemps,
        Ete
    }
    public enum Couleur
    {
        Blanc,
        Vert,
        Jaune,
        Rouge
    }
    public class Exo1
    {
        public static void MonthToColor()
        {
            Console.WriteLine("Veuillez entrer un mois");
            string userValue = Console.ReadLine();
            userValue = new string(Helper.CharTableRemoveAccents( userValue.ToCharArray() )); // On remove les accent pour simplifier le texte
            userValue = userValue.ToLower();
            Mois month = EnumMois(userValue);
            Saison season = EnumSaison(month);
            Couleur couleur = EnumCouleur(season);
            Console.WriteLine("Le mois de '"+month+"' appartient à la saison "+season+" et sa couleur est le "+couleur);

        }
        public static Couleur EnumCouleur(Saison season)
        {
            switch(season)
            {
                case Saison.Hiver:
                return Couleur.Blanc;
                case Saison.Automne:
                return Couleur.Jaune;
                case Saison.Printemps:
                return Couleur.Vert;
                case Saison.Ete:
                return Couleur.Rouge;
                default : 
                return Couleur.Blanc;
            }
        }

        public static Saison EnumSaison(Mois month)
        {
            switch(month)
            {
                case Mois.Janvier : 
                case Mois.Fevrier : 
                case Mois.Mars : 
                    return Saison.Hiver;
                case Mois.Avril : 
                case Mois.Mai : 
                case Mois.Juin : 
                    return Saison.Printemps;
                case Mois.Juillet : 
                case Mois.Aout : 
                case Mois.Septembre : 
                    return Saison.Ete;
                case Mois.Octobre : 
                case Mois.Novembre : 
                case Mois.Decembre : 
                    return Saison.Automne;
                default : 
                    return Saison.Hiver;
            }
        }

        public static Mois EnumMois(string month)
        {
            switch (month)
            {   
                case "january" :
                case "janvier" :
                case "1" :
                   return Mois.Janvier;

                case "fevrier" :
                case "february" :
                case "2" :
                return Mois.Fevrier;

                case "mars" :
                case "march" :
                case "3" :
                return Mois.Mars;

                case "avril" :
                case "april" :
                case "4" :
                return Mois.Avril;

                case "may" :
                case "mai" :
                case "5" :
                return Mois.Mai;

                case "juin" :
                case "june" :
                case "6" :
                return Mois.Juin;

                case "july" :
                case "juillet" :
                case "7" :
                return Mois.Juillet;

                case "august" :
                case "aout" :
                case "8" :
                return Mois.Aout;

                case "septembre" :
                case "september" :
                case "9" :
                return Mois.Septembre;

                case "octobre" :
                case "october" :
                case "10" :
                return Mois.Octobre;

                case "novembre" :
                case "november" :
                case "11" :
                return Mois.Novembre;

                case "decembre" :
                case "december" :
                case "12" :
                return Mois.Decembre;
                // Par defaut si il y a une erreur sur ce qu'a taper le user, je mets janvier
                default:
                    return Mois.Janvier;
            }
        }
    }
}