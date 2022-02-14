public class PetitBus : Vehicule
{
    //    public Vehicule(float maxSpeed, float weight)

    public PetitBus(string immatriculation ) : base(immatriculation)
    {
        Weight = 4;
        Speed = 150;
    }

    public override float PoidsTotal()
    {
        return CurrentCharge + Weight;
        
        throw new System.NotImplementedException();
    }

    public override string ToString()
    {
        string display = "Type de véhicule : Petit bus\n";
        display += base.ToString();
        return display;
    }
}