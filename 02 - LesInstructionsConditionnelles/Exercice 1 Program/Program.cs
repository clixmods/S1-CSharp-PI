using System;

using System.Threading.Tasks;

namespace Exercice_1_Program
{

    /*
    Exo 1
        Ecrivez un programme qui :
        1. déclarer 2 variables a et b, demander à l’utilisateur de saisir les valeurs.
        2. déclarer une variable nbmin également entière.
        3. à l’aide d’un if, fait en sorte que la variable nbmin contienne la valeur minimale de a et b
        4. affiche cette valeur minimale ainsi déterminée.
    */
    class Program
    {   
        static int a; 
        static int b;
        static bool run = true;
        static void Main(string[] args)
        {
              Task WatchToExit= new Task(() =>
              {
                    Console.WriteLine("Tap Echap to exit the program");
                    while(true)
                    {    
                        ConsoleKeyInfo Hello = Console.ReadKey();
                        if((byte)Hello.KeyChar == 27)
                        {
                            Environment.Exit(0);
                            Console.WriteLine("\n Program closed");          
                        }
                    }
              });
            WatchToExit.Start();
            ExecTheExo();
        }

        static void ExecTheExo()
        {
            while(run)
            {
                a = GetUserRequest("A");
                b = GetUserRequest("B");
                if( a < b)
                    Console.WriteLine("A de valeur "+a+" est plus petit que B de valeur "+b);
                else if(a > b)
                    Console.WriteLine("B de valeur "+b+" est plus petit que A de valeur "+a);
                else
                    Console.WriteLine("Soit A et B sont égales, soit une étrange force casse le if");
            }
        
        }
        static int GetUserRequest(string name)
        {
            int result = 0; 
            while(run)
            {
                Console.WriteLine("Tapez la valeur "+name);
                string userProposition = Console.ReadLine();
                if(int.TryParse(userProposition,out int cool))
                {
                    result = int.Parse(userProposition);
                    break;
                }
                else
                {
                    Console.WriteLine("Your value is incorrect, only int number are allowed. Retry please.");
                    continue;
                }
            }
            return result;
        }
        
    }
}
