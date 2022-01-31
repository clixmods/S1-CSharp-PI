using System;

namespace DM_LesClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Parking parkingNetto = new Parking(10, 1.5f);
            Clients clientsNetto = new Clients();
            string message = "\nTaper le chiffre correspondant à chaque action pour les effectuer: \n";
            message += "1 - Ajouter une voiture au parking\n";
            message += "2 - Retirer une voiture du parking\n";
            message += "3 - Afficher toutes les places et qui prend chaque place\n";
            message += "4 - Terminer la journée";
            
            int idActionFromUser = 0;
            bool run = true;

            while(run)
            {
                Console.WriteLine(message);
                if(int.TryParse(Console.ReadLine(), out int result))
                {
                    if(result == 0 || result > 4)
                    {
                        Console.WriteLine("Error, veuillez reessayer");
                        result = -1;
                        continue;
                    }
                    else 
                        idActionFromUser = result;

                }
                Console.Clear();
                switch(idActionFromUser)
                {
                    case 1:
                        Console.WriteLine("Taper votre nom d'utilisateur" );
                        string Name = Console.ReadLine();
                        if(!string.IsNullOrEmpty(Name))
                        {
                            Car newCar = new Car(Name);
                            parkingNetto.AddCar(newCar);
                            clientsNetto.AddTicket(newCar);
                        }
                        else
                        {
                            Console.WriteLine("Nom incorrect, retour au menu principal");
                        }
                        
                    break;
                    case 2:
                        Ticket RandomGuy = clientsNetto.GetRandomTicket();
                        if(RandomGuy != null)
                        {
                            parkingNetto.DeleteCar(RandomGuy.Vehicle);
                            Console.WriteLine($"{RandomGuy.Vehicle.Owner} doit payer {parkingNetto.AddMoney(RandomGuy.CreatedDate)} euros");
                            clientsNetto.DeleteTicket(RandomGuy);
                        }
                        else
                        {
                            Console.WriteLine("Impossible de trouver un ticket car aucun ticket n'a été enregistré, retour au menu principal");
                        }
                        
                    break;
                    case 3:
                        Console.WriteLine(parkingNetto);
                    break;
                    case 4:
                        run = false;
                    break;
                    default :
                    
                    break;
                }
                
            }     
            Console.WriteLine($"Le parking a gagné en cette fin de journée {parkingNetto.Gain} euros");

        }
    }
}
