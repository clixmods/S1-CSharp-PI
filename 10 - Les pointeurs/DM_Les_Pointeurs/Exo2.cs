using System;
namespace DM_Les_Pointeurs
{
    unsafe class Exo2
    {
        public struct Player
        {
            string name; // un nom
            float damage; // un nombre de dégats
            Boss* boss; // - un pointeur de type Boss
            
            //Constructeur qui permet de setter les propriétés.
            public Player(string newName, float newDamage, Boss* bossTarget)
            {
                name = newName;
                damage = newDamage;
                boss = bossTarget;
            }

            /*
            Cette fonction permet d'appliquer des dégats au Boss pointé par la propriété de type pointeur.
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
            int health; //  - une vie sous forme d'entier (si la vie tombe à zero il est mort).
            float multiplier; //- une protection (float) qui sera un multiplicateur des dégats reçus.

            // Constructeur permettant de setter les propriétés.
            public Boss(int newHealth, float newMultiplier)
            {
                health = newHealth;
                multiplier = newMultiplier;
            }
            
            //fonction qui verifie si le boss est mort.
            bool CheckIfDead()
            {
                return health <= 0;
            }
            /*
                Cette fonction permet d'attribuer des dégats au boss.
                Elle applique les degats en fonction de s'il n'est pas mort et de sa protection 
                (on multiplie les degats par la protection).
                Cette fonction retourne le nombre réél de degats appliqués.  
            */
            public float doDamage(float amount)
            {
                if(CheckIfDead())
                    return 0;

                int damage = (int)(amount*multiplier);
                health -= damage;

                return damage;
            }

            //Cette fonction affiche l'état du boss (vie et protection)
            public override string ToString()
            {
                return "Boss health  = "+health+" with a protection multiplier = "+multiplier ;
            }
        }

        public static void Init()
        {
            Boss MyBoss = new Boss(1000, 0.5f); // une variable de type Boss.
            //deux variables de type Player avec des dégats differents, 
            //et qui ont leur propriétés de pointeur Boss pointant la variable Boss créée juste avant.
            Player playerRed = new Player("Clix", 150, &MyBoss);
            Player playerBlue = new Player("Pedro", 100,&MyBoss);

            // Application de degats via les variables de type player.
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
