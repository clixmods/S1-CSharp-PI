using System;
class DetermineCouleur
{
    public static string Exec()
        {
            int life;
            while(true)
            {
                Console.WriteLine("Indiquez la vie que vous souhaitez, tapez autre chose qu'un nombre pour éteindre le programme");
                string userLife = Console.ReadLine();
                if(int.TryParse(userLife, out life))
                {
                    if(life <= 0) return"NOIR";
                    else if(life >= 1 && life <= 20 ) return"ROUGE";
                    else if(life >= 21 && life <= 40 ) return"ORANGE";
                    else if(life >= 41 && life <= 60 ) return"JAUNE";
                    else if(life >= 61 ) return "VERT";
                }
                else 
                {
                    return "Good bye world!";
                }
            } 
        }
}