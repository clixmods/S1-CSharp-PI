using System;
using System.Collections.Generic;

public class Convoi
{
    /*
    La classe Convoi permet de gérer un convoi de véhicules, et elle y comporte un attribut de type List 
    qui contiendra tous les vehicules du convoi.

    Ecrire les méthodes suivantes : 
    - un constructeur qui initialise la liste de vehicules.
    - une fonction ToString permettant d'afficher tous les véhicules du convoi avec leurs propriétés.
    - une fonction AjouterVehicule qui ajoute un vehicule au convoi.
    - une fonction AjouterConvoi qui ajoute les vehicule d'un autre convoi au convoi.
    - un fonction qui retourne la vitesse maximum du convoi.
    */
    List<Vehicule> convoi = new List<Vehicule>();

    public Convoi()
    {
        convoi = new List<Vehicule>();
    }

    // Permet de get la list de vehicule
    public List<Vehicule> Vehicules
    {
        get{return convoi;}
    }

    // Cette fonction permet d'ajouter un vehicule, grace aux List (comme indiquer dans la consigne), il suffit juste de faire Add
    public void AjouterVehicule(Vehicule vehToAdd)
    {
        convoi.Add(vehToAdd);
        // On affiche les informations du vehicule
        Console.WriteLine("Nouveau ajout de vehicule dans le convoi \nInfo du véhicule :\n"+vehToAdd );
    }
    
    // On ajoute chaque vehicule d'un convoi donner, vers le convoi actuelle
    public void AjouterConvoi(Convoi convoiToAdd)
    {
        // grace au getteur de la list, on fait un foreach pour chaque vehicule afin de les ajouter
        foreach(Vehicule veh in convoiToAdd.Vehicules)
        {
            AjouterVehicule(veh);
        }
    }
    public override string ToString()
    {
        string display = "Liste de véhicule dans le convoi \n";
        // Si le convoi est vide; on l'indique
        if(convoi.Count == 0)
        {
            display += "Aucun vehicule trouvée";
        }
        else // sinon on affiche les vehicules avec leur index, afin de bien les distinguer
        {
            for(int i = 0 ; i < convoi.Count; i++ )
            {
                display += "\nVehicule n°"+(i+1)+"\n";
                display += convoi[i].ToString();
            }
        }
        return display;
       
    }

    /*
    Cette fonction calcule la vitesse maximale d'un convoi, 
    sachant que cette vitesse correspond à la plus petite des vitesses maximales des véhicules du convoi.
    */
    public float MaximalSpeed()
    {
        if(convoi.Count == 0)
        {    
            Console.WriteLine("Le convoi est vide, impossible de récupérer la valeur");
            return -1;
        }
        // On prend la vitesse du premier vehicule (maximalSpeed), que l'on va comparer à tout les autres, et si
        // la nouvelle valeur est plus petit que maximalSpeed, on remplace maximalSpeed par la nouvelle valeur
        float maximalSpeed = convoi[0].Speed;
        foreach(Vehicule veh in convoi)
        {
            if(veh.Speed < maximalSpeed)
                maximalSpeed = veh.Speed;
        }
        return maximalSpeed;

    }

}