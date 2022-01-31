using System;

namespace DM_LesClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( DateTime.Now.AddHours(48).Subtract(DateTime.Now).TotalHours);
            Parking parkingNetto = new Parking(20, 1.5f);
            Clients clientsNetto = new Clients();
            string message = "Taper le chiffre correspondant à chaque action pour les effectuer: \n";
            message += "1 - Ajouter une voiture au parking\n";
            message += "2 - Retirer une voiture du parking\n";
            message += "3 - Afficher toutes les places et qui prend chaque place\n";
            message += "4 - Terminer la journée";
            int idActionFromUser;
            do
            {

            }while(!int.TryParse(Console.ReadLine(), out int result));
            switch(idActionFromUser)
            {
                
            }


            Console.WriteLine()
        
        }
    }
}
