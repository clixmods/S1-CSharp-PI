using System;

namespace DM_LesClasses
{
    public class Ticket
    {
        Car _vehicle; // Vehicule stocker
        DateTime _createdDate; // Date creation ticket
        public Ticket(Car vehicle)
        {
            Random rand = new Random();
            _vehicle = vehicle;
            _createdDate = DateTime.Now.AddHours(rand.Next(-23,0)); // J'ai mis un random pour que le program puisse marcher vue qu'on check les heures passé
            Console.WriteLine($"Ticket crée pour {vehicle.Owner} le {_createdDate}"); // Pour avoir un retour 
            // je vais pas attendre des vrais heures pour voir si ca marche ? si ? ;C
        }
        public Car Vehicle // Getteur et setteur pour garder les propriétés en private 
        {
            get{return _vehicle;}
            set{ _vehicle = value;}
        }
        public DateTime CreatedDate
        {
            get{return _createdDate;}
        }

    }
}