using System;

namespace DM_LesClasses
{
    public class Clients
    {
        Ticket[] tickets = new Ticket[0];
        /*
            b) Ajouter une fonction qui permets de retourner de 
            manière aléatoire un ticket de la collection.
        */
        public Ticket GetRandomTicket()
        {
            Random rand = new Random();
            return tickets[rand.Next(0, tickets.Length)];
        }
        /*
            c) Ajouter une fonction qui prend en entrée un Car, 
            et qui ajoute un nouveau Ticket dans la collection.
        */
        public void AddTicket(Car newCar)
        {
            Ticket[] temp = new Ticket[tickets.Length+1];
            for(int i = 0 ; i < tickets.Length;i++)
            {
                temp[i] = tickets[i];
            }
            temp[temp.Length-1] = new Ticket(newCar);
        }
        /*
        d) Ajouter une fonction qui prend en entrée un Ticket, 
        et qui le supprime de la collection.
        */
        public void DeleteTicket(Ticket ticketToDelete)
        {
            Ticket[] temp = new Ticket[tickets.Length-1];
            bool isDeleted = false;
            for(int i = 0 ; i < tickets.Length; i++)
            {
                if(tickets[i] == ticketToDelete)
                {
                    isDeleted = true;
                    tickets[i] = null;
                    continue;
                }
                if(isDeleted)
                    temp[i-1] = tickets[i];
                else
                    temp[i] = tickets[i];

            }
            
            
            if(isDeleted)
                tickets = temp;
        }
    }
}