using System;

namespace DM_LesClasses
{
    public class Parking
    {
        Car[] vehicles; // Vehicule stationner
        float _pricePerHour; // prix d'une heure.
        float gain; //  argent gagné dans la journée.
        /*
            b) constructeur permettant d'initialiser les propriétés.
        */
        public Parking(int parkingSize, float pricePerHour)
        {
            vehicles = new Car[parkingSize];
            _pricePerHour = pricePerHour;
            gain = 0;
        }
        /*
        c) Ajouter une fonction qui permet d'ajouter une Car 
        dans le parking (ajout ds collection).
        La fonction doit verifier qu'il y a bien 
        de la place disponible.
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
            d) Ajouter une fonction qui supprime une voiture du parking 
            (suppression de la collection).
        */
        public void DeleteCar(Car carToDelete)
        {
            for(int i = 0; i < vehicles.Length; i++) 
            {
                if(vehicles[i] == carToDelete)
                {
                    vehicles[i] = null;
                    return; // On return car on a pu mettre un vehicule
                }   
            }
            Console.WriteLine("Vehicule non trouvée");
        }
        /*
        f) Ajouter une fonction qui retourne le nombre de places disponibles.
        */
        public int NumberAvailablePlace()
        {
            int availablePlace = 0;
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
        public void AddMoney(DateTime date)
        {
            int hoursPassed = (int)DateTime.Now.Subtract(date).TotalHours;
            gain += _pricePerHour * hoursPassed;
        }
        /*
        h) Ajouter une fonction qui permet d'afficher l'état du parking.
        Affiche toutes les places de parking avec leur numéro 
        et le nom de la personne à cette place.
        */
        public override string ToString()
        {
            string message = "";
            for(int i = 0; i < vehicles.Length;i++)
            {
                if(vehicles[i] == null)
                {
                    message += $"La place de parking numéro{i} est libre";
                }
                else
                {
                    message += $"La place de parking numéro{i} est occupé par {vehicles[i].Owner}";
                }
               
            }
            return base.ToString();
        }
    }
}