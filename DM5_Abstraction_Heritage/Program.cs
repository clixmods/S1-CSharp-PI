using System;

namespace DM5_Abstraction_Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programme de simulation d'un convoi
            // Message du menu principal
            string message = "\nProgramme de simulation d'un convoi \n";
            message += "Taper le chiffre correspondant à chaque action pour les effectuer: \n";
            message += "1 - Ajouter un vehicule au convoi\n";
            message += "2 - Afficher tous les vehicules du convoi \n";
            message += "3 - Afficher la vitesse max du convoi\n";
            message += "4 - Terminer le programme";
            
            int idActionFromUser = 0; 
            bool run = true; // Bool qui fait run la boucle 

            Convoi convoiUser = new Convoi();

            while(run)
            {
                idActionFromUser = 0;
                Console.WriteLine(message);
                if(int.TryParse(Console.ReadLine(), out int result))
                {
                    if(result == 0 || result > 4) // verifie si c'est bien correct
                    {
                        Console.WriteLine("Error, veuillez reessayer");
                        result = -1;
                        continue;
                    }
                    else 
                        idActionFromUser = result;

                }
                Console.Clear(); // je clear pour qu'on puisse se focus correctement sur l'action donnée

                switch(idActionFromUser)
                {
                    case 1: // Ajouter un vehicule au convoi
                        AskToCreateVehicule();
                    break;
                    case 2: // Afficher tous les vehicules du convoi
                        Console.WriteLine(convoiUser);
                    break;
                    case 3: // Afficher la vitesse max du convoi
                        Console.WriteLine("La vitesse max : "+convoiUser.MaximalSpeed());
                    break;
                    case 4: // Terminer le programme
                        run = false;
                    break;
                    default :

                    break;
                }
                
            }     
            void AskToCreateVehicule()
            { 
                    /*
                    Demande un choix entre les 3 types de Vehicules Petit Bus, Camion Citerne, Camion Baché.
                    Ensuite le programme demande d'entrer l'immatriculation du vehicule.
                    Si l'utilisateur a choisi un camion, le programme demandera la charge du camion 
                    et verifie si la proposition ne dépasse pas la charge max.
                    Ensuite le programme ajoute le vehicule au convoi.
                    */
                    string message = "\nTaper le chiffre correspondant à chaque vehicule pour les crées:\n";
                    message += "1 - Petit Bus \n";
                    message += "2 - Camion Citerne \n";
                    message += "3 - Camion Baché \n";
                    int idActionFromUser = 0; 
                    bool run = true; // Bool qui fait run la boucle 
                    while(run)
                    {
                        idActionFromUser = 0;
                        Console.WriteLine(message);
                        if(int.TryParse(Console.ReadLine(), out int result))
                        {
                            if(result == 0 || result > 3) // verifie si c'est bien correct
                            {
                                Console.WriteLine("Error, veuillez reessayer");
                                result = -1;
                                continue;
                            }
                            else 
                                idActionFromUser = result;

                        }
                        else
                        {
                            Console.WriteLine("Error, veuillez reessayer");
                            result = -1;
                            continue;
                        }
                        // On déclare le vehicule, il sera ensuite attribué suivant le choix de l'utilisateur
                        Vehicule askedVeh;
                        Console.Clear(); // je clear pour qu'on puisse se focus correctement sur l'action donnée
                        switch(idActionFromUser)
                        {
                            case 1: // Petit Bus
                                Console.WriteLine("PetitBus sélectionner");
                                askedVeh = new PetitBus(EnterImmatriculation());
                            break;
                            case 2: // Camion Citerne
                                Console.WriteLine("Camion Citerne sélectionner");
                                askedVeh = new CamionCiterne(EnterImmatriculation());
                            break;
                            case 3: // Camion Baché
                                Console.WriteLine("CamionBache sélectionner");
                                askedVeh = new CamionBache(EnterImmatriculation());
                            break;
                            default :
                            continue;
                            
                        }
                        // On demande la charge du camion si le Vehicule est de la class Camion
                        if(askedVeh is Camion vehCamion)
                            AskChargeCamion(vehCamion);

                        // Ajoute le vehicule au convoi.
                        convoiUser.AjouterVehicule(askedVeh);
                        run = false;
                        
                    } 
                    
            }
            string EnterImmatriculation()
            {
                while(true)
                {
                    Console.WriteLine("Veuillez entrer le plaque d'immatriculation ");
                    string plaque = Console.ReadLine();
                    if(!string.IsNullOrEmpty(plaque))
                    {
                        return plaque;
                    }
                    else
                    {
                        Console.Clear(); // je clear pour qu'on puisse se focus correctement sur l'action donnée    
                        Console.WriteLine("Plaque saisi invalide.");
                    }
                        
                } 
            }
            void AskChargeCamion(Camion VehCamion)
            {
                while(true)
                {
                    Console.WriteLine("Veuillez entrer la charge (en tonne par unité) du camion, poids maximal autorisé "+VehCamion.MaxCharge+ "Tonnes");
                    string plaque = Console.ReadLine();
                    if(float.TryParse(plaque, out float chargeToPut))
                    {
                        if(VehCamion.SetCharge( chargeToPut ))
                        {
                            break;
                        }
                        else
                        {                        
                            Console.Clear(); // je clear pour qu'on puisse se focus correctement sur l'action donnée    
                            Console.WriteLine("Charge n'a pas été attribué");
                            continue;
                        }
                        
                    }
                    else
                    {
                        Console.Clear(); // je clear pour qu'on puisse se focus correctement sur l'action donnée    
                        Console.WriteLine("Plaque saisi invalide.");
                    }
                        
                } 
            }

        }
    }
}
