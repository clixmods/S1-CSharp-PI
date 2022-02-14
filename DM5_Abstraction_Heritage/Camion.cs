using System;

public abstract class Camion : Vehicule
{
    // float _currentCharge; // Charge actuelle du vehicule
    // float _maxCharge; // Max charge supporter par le vehicule
    
    public Camion(string immatriculation) : base(immatriculation)
    {
        Speed = CalculeVitesseMax();
    }

 
    public abstract float CalculeVitesseMax();

    // une méthode SetCharge(int charge) pour les camions permettant de modifier le  poids du chargement.
    public bool SetCharge(float charge)
    {
        if(charge <= MaxCharge && charge >= 0)
        {
            CurrentCharge = charge;
            Speed = CalculeVitesseMax();
            return true;
        }    
        else
        {
            Console.WriteLine("Impossible d'attribuer cette charge car limite dépassé ou charge négatif");
            return false;
        }

        
    }

    public override float PoidsTotal()
    {
        return CurrentCharge + Weight;

        throw new System.NotImplementedException();
    }


}