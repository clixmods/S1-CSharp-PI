using System;
class DetermineKeyChar
{
       public static string Exec()
        {
            while(true)
            {
                Console.WriteLine("Appuyer sur une ECHAP pour quitter \nAppuyer sur une touche :");
                ConsoleKeyInfo Hello = Console.ReadKey(true);
                if((byte)Hello.KeyChar == 27)
              //     break;

                return "\nVous avez appuyé sur la touche "+Hello.Key+" sa valeur numérique est de "+((byte)Hello.Key)+".";
            }
            
        }
}