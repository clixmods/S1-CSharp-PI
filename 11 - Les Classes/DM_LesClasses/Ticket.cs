using System;

namespace DM_LesClasses
{
    public class Ticket
    {
        Car vehicle; // Vehicule stocker
        DateTime createdDate; // Date creation ticket
        public Ticket(Car vehicle)
        {
            this.vehicle = vehicle;
            createdDate = DateTime.Now;
        }
    }
}