using System;

namespace Exercice_3_Program
{

    /*
        
        Exo 3 :
        - Declarer une variable qui represente la vie et l'initialiser à 100 de valeur.
        - Declarer une variable qui represente l'état invincible/non invincible et l'initialiser à non invincible.
        - Declarer une variable dommage et demander à l’utilisateur de saisir la valeur.

        - Appliquer les degats en testant si la vie est tjrs superieur à zero ET si l'etat n'est pas invincible
        - Afficher la valeur de la vie

        - Mettre la variable invincible dans l'état invincible.
        - Appliquer les degats en faisant les mêmes tests précédents
        - Afficher la valeur de la vie
    */
    class Program
    {
        static int health = 100; 
        static bool isInvincible = false;
        static int damageAmount;
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Attaquez votre adversaire qui a "+health+" de vie, en indiquant le nombre de dégats ");
                DoDamage();
                if(health <= 0)
                    break;
        
                
               // Random r = new Random();
                int randomGod = new Random().Next(1,100);
                if(randomGod > 50)
                    isInvincible = true;
                else
                    isInvincible = false;

            }
           Console.WriteLine("Vous avez battu votre adversaire.");
        
        }
        static void DoDamage()
        {
            string userProposition = Console.ReadLine();
            if(int.TryParse(userProposition,out damageAmount))
            {
                if(health > 0 && !isInvincible)
                {
                    health -= damageAmount;
                    Console.WriteLine("Vous avez infligé "+damageAmount+" de dégats à votre adversaire, sa vie est à "+health);
                }
                else
                {
                    Console.WriteLine("L'ennemi est invincible ! Essaye de retaper dessus");
                }
            }
            else 
            {
                Console.WriteLine("La valeur donnée est non valide, réessayer SVP.");
            }
        }
    }
}
