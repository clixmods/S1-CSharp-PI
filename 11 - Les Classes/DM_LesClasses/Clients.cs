using System;

namespace DM_LesClasses
{
    public class Clients
    {
        Ticket[] tickets = new Ticket[0]; //Taille 0 pour avoir au moins une initialisation
        /*
            Cette fonction permet de retourner un ticket aléatoire de la collection.
        */
        public Ticket GetRandomTicket()
        {
            if(tickets.Length == 0) // on return null car il a pas de ticket
            {
                return null;
            }
            // On presume que le tableau a du contenu
            Random rand = new Random();
            return tickets[rand.Next(0, tickets.Length)];
        }
        /*
            Prend en entrée un Car, et qui ajoute un nouveau Ticket dans la collection.
        */
        public void AddTicket(Car newCar)
        {
            Ticket[] temp = new Ticket[tickets.Length+1]; // Tableau temporaire qu'on assignera à la fin à l'original avec une taille +1 car on va ajouter 
            if(tickets.Length == 0) // Taille du tableau original à zero du coup pas besoin de copié les élements
            {
                temp[0] = new Ticket(newCar);
                tickets = temp;
                return; 
            }
            // si tableau plus grand que 0, on va donc devoir copié tout dans le tableau temp
            for(int i = 0 ; i < tickets.Length;i++)
            {
                temp[i] = tickets[i];
            }
            // nouveau ticket a add
            temp[temp.Length-1] = new Ticket(newCar);
            tickets = temp; // on assigne temp au tableau original
        }
        /*
        d) Cette fonction prend en entrée un Ticket,et le supprime de la collection.
        */
        public void DeleteTicket(Ticket ticketToDelete)
        {
            Ticket[] temp = new Ticket[tickets.Length-1]; // on crée un tableau temp de -1 en taille
            bool isDeleted = false;
            for(int i = 0 ; i < tickets.Length; i++)
            {
                if(tickets[i] == ticketToDelete)
                {
                    isDeleted = true; // on l'a delete, du coup, on pourra réassigner correctement le tableau temp à l'original
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