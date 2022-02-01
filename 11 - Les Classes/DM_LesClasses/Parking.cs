using System;

namespace DM_LesClasses
{
    public class Parking
    {
        Car[] vehicles; // Vehicule stationner
        float _pricePerHour; // prix d'une heure.
        float _gain; //  argent gagné dans la journée.
        /*
        Constructeur permettant d'initialiser les propriétés.
        */
        public Parking(int parkingSize, float pricePerHour)
        {
            vehicles = new Car[parkingSize];
            _pricePerHour = pricePerHour;
            Gain = 0;
        }

        public float Gain
        {
            private set{ _gain = value;}
            get{ return _gain;}
        }
        /*
        Ajoute une Car dans le parking .
        La fonction verifie qu'il y a bien de la place disponible.
        */
        public void AddCar(Car carToAdd)
        {
            for(int i = 0; i < vehicles.Length; i++) 
            {
                if(vehicles[i] == null)
                {
                    vehicles[i] = carToAdd;
                    return; // On return car on a pu mettre un vehicule
                }   
            }
            Console.WriteLine("Plus de place dans le parking");
        }
        /*
            Cette fonction supprime une voiture du parking 
        */
        public void DeleteCar(Car carToDelete)
        {
            for(int i = 0; i < vehicles.Length; i++) 
            {
                if(vehicles[i] == carToDelete)
                {
                    vehicles[i] = null;
                    return; // On return car on a pu retiré un vehicule
                }   
            }
            Console.WriteLine("Vehicule non trouvée");
        }
        /*
        Fonction qui retourne le nombre de places disponibles.
        */
        public int NumberAvailablePlace()
        {
            int availablePlace = 0; // Compteur que j'incrementerai si une place contient null vehicule
            for(int i = 0 ; i < vehicles.Length; i++)
            {
                if(vehicles[i] == null)
                    availablePlace++;
            }
            return availablePlace;
        }
        /*
            Cette fonction permet d'ajouter de l'argent dans la variable de l'argent gagné. 
            La fonction prend en paramètre une variable de type DateTime.
            Calcul le temps passé depuis ce paramètre et maintenant.
            Et calcul l'argent gagné en fonction du prix de l'heure.
            Ajoute ensuite l'argent gagné.
        */
        public float AddMoney(DateTime date)
        {
            int hoursPassed = (int)DateTime.Now.Subtract(date).TotalHours; // Calcule le temps passé, il doit surement exister une meilleur méthode, mais bon
            Gain += _pricePerHour * hoursPassed;
            return _pricePerHour * hoursPassed; // Je retourne les gains au cas ou j'en ai besoin
        }
        /*
        Cette fonction permet d'afficher l'état du parking.
        Affiche toutes les places de parking avec leur numéro 
        et le nom de la personne à cette place.
        */
        public override string ToString()
        {
            string message = "";
            for(int i = 0; i < vehicles.Length;i++)
            {
                if(vehicles[i] == null) // si null, ca veut qu'aucun véhicule n'est enregistré
                {
                    message += $"La place de parking numéro {i} est libre \n";
                }
                else
                {
                    message += $"La place de parking numéro {i} est occupé par {vehicles[i].Owner} \n";
                }
               
            }
            return message;
        }

        
    }
}