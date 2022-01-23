/*

===================== Exo 2 - Boss And Player =====================

1) Creer une structure Boss ayant les propriétés suivantes :
- une vie sous forme d'entier (si la vie tombe à zero il est mort).
- une protection (float) qui sera un multiplicateur des dégats reçus.

2) La structure doit avoir un constructeur permettant de setter ces propriétés.

3) Dans la structure Boss, creer une fonction qui verifie si le boss est mort.

4) Dans la structure Boss, creer une fonction qui permet d'attribuer des dégats au boss.
Appliquer les degats en fonction de s'il n'est pas mort et de sa protection (on multiplie les degats par la protection).
Cette fonction doit être public.
Cette fonction retourne le nombre réél de degats appliqués.

5) Dans la structure Boss, créer une fonction qui affiche l'état du boss (vie et protection)

6) Creer une structure Player ayant les propriétés suivantes :
- un nom
- un nombre de dégats
- un pointeur de type Boss

7) Dans la structure Player, creer une constructeur qui permet de setter ces propriétés.

8) Dans la structure Player, creer une fonction 'Attack' qui permet d'appliquer des dégats au Boss pointé par la propriété de type pointeur.
La fonction utilise les dégats de la propriété de la structure.
La fonction affiche à chaque attaque : "Le Player {NomPlayer} a blessé le Boss de {dégats}".

9) Utiliser ces deux structures pour faire un programme qui :
- Creer une variable de type Boss.
- Creer deux variables de type Player avec des dégats differents, et qui ont leur propriétés de pointeur Boss pointant la variable Boss créée juste avant.
- Appliquer plusieurs fois les degats via les variables de type player.
- Terminer le programme en affichant l'état du Boss après l'application des attaques.


*/
using System;
namespace DM_Les_Pointeurs
{
    unsafe class Exo2
    {
        /*
        6) Creer une structure Player ayant les propriétés suivantes :
            - un nom
            - un nombre de dégats
            - un pointeur de type Boss
        */
        public struct Player
        {
            string name;
            float damage;
            Boss* boss;
            /*
            7) Dans la structure Player, creer une constructeur qui permet de setter ces propriétés.*/
            public Player(string newName, float newDamage, Boss* bossTarget)
            {
                name = newName;
                damage = newDamage;
                boss = bossTarget;
            }

            /*
            8) Dans la structure Player, creer une fonction 'Attack' qui permet d'appliquer des dégats au Boss pointé par la propriété de type pointeur.
            La fonction utilise les dégats de la propriété de la structure.
            La fonction affiche à chaque attaque : "Le Player {NomPlayer} a blessé le Boss de {dégats}".
            */
            public string Attack()
            {
                return $"Le Player {name} a blessé le Boss de {boss->doDamage(damage)}";
            }
        }

        public struct Boss
        {
            /*
            - une vie sous forme d'entier (si la vie tombe à zero il est mort).
            - une protection (float) qui sera un multiplicateur des dégats reçus.
            */
            int health;
            float multiplier;

            //2) La structure doit avoir un constructeur permettant de setter ces propriétés.

            public Boss(int newHealth, float newMultiplier)
            {
                health = newHealth;
                multiplier = newMultiplier;
            }
            /*
                3) Dans la structure Boss, creer une fonction qui verifie si le boss est mort.

                4) Dans la structure Boss, creer une fonction qui permet d'attribuer des dégats au boss.
                Appliquer les degats en fonction de s'il n'est pas mort et de sa protection (on multiplie les degats par la protection).
                Cette fonction doit être public.
                Cette fonction retourne le nombre réél de degats appliqués.           
            */
            public bool CheckIfDead()
            {
                return health <= 0;
            }
            public float doDamage(float amount)
            {
                if(CheckIfDead())
                    return 0;

                health -= (int)(amount*multiplier);

                return amount*multiplier;
            }

            //5) Dans la structure Boss, créer une fonction qui affiche l'état du boss (vie et protection)
            public override string ToString()
            {
                return "Boss health  = "+health+" with a protection multiplier = "+multiplier ;
            }
        }

        public static void Init()
        {
            /*
            9) Utiliser ces deux structures pour faire un programme qui :
            - Creer une variable de type Boss.
            - Creer deux variables de type Player avec des dégats differents, et qui ont leur propriétés de pointeur Boss pointant la variable Boss créée juste avant.
            - Appliquer plusieurs fois les degats via les variables de type player.
            - Terminer le programme en affichant l'état du Boss après l'application des attaques.*/
            Boss MyBoss = new Boss(1000, 0.5f);
            Player playerRed = new Player("Clix", 150, &MyBoss);
            Player playerBlue = new Player("Pedro", 100,&MyBoss);

            playerRed.Attack();
            playerBlue.Attack();


            Console.WriteLine(MyBoss);
            playerRed.Attack();
            playerBlue.Attack();
            playerRed.Attack();
            playerBlue.Attack();
            playerRed.Attack();
            playerBlue.Attack();
            playerRed.Attack();
            playerBlue.Attack();
             Console.WriteLine(MyBoss);
        }
    
      
        
    }
}
