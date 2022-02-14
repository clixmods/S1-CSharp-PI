using System;

public abstract class Camion : Vehicule
{
    // float _currentCharge; // Charge actuelle du vehicule
    // float _maxCharge; // Max charge supporter par le vehicule
    
    public Camion(string immatriculation) : base(immatriculation)
    {
        _maxSpeed = CalculeVitesseMax();
    }

 
    public abstract float CalculeVitesseMax();

    public float MaxCharge
    {
        get{ return _maxCharge;}
    }
    // une méthode SetCharge(int charge) pour les camions permettant de modifier le  poids du chargement.
    public bool SetCharge(float charge)
    {
        if(charge <= _maxCharge && charge >= 0)
        {
            _currentCharge = charge;
            _maxSpeed = CalculeVitesseMax();
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
        return _currentCharge + _weight;

        throw new System.NotImplementedException();
    }


}