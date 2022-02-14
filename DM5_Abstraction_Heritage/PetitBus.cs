public class PetitBus : Vehicule
{
    //    public Vehicule(float maxSpeed, float weight)

    public PetitBus(string immatriculation ) : base(immatriculation)
    {
        _weight = 4;
        _maxSpeed = 150;
    }

    public override float PoidsTotal()
    {
        return _currentCharge + _weight;
        
        throw new System.NotImplementedException();
    }

    public override string ToString()
    {
        string display = "Type de véhicule : Petit bus\n";
        display += base.ToString();
        return display;
    }
}