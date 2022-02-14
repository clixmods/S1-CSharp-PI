public abstract class Vehicule
{
    //Classe de base. Trois attributs, le numéro d'immatriculation du véhicule, la vitesse maximale et le poids à vide.
    string _immatriculation; // Plaque d'immatriculation
    protected float _maxSpeed; // Vitesse maximale
    protected float _weight; // Poids à vide du vehicule ( 1 par tonne)
    
    
    protected float _currentCharge = 0; // Charge actuelle du vehicule
    protected float _maxCharge; // Max charge supporter par le vehicule
    bool _hasHuileEngine; // bool pour indiquer si le vehicule est équipé du moteur


    // Constructeur qui set la plaque dimmatriculation
    public Vehicule(string immatriculation) 
    {
        _immatriculation = immatriculation;
    }
    public float Speed
    {
        get{ return _maxSpeed;}
    }

    // Fonction PoidsTotal qui return le poids totale d'un vehicule, suivant les 
    // caractéristiques des enfants, la fonction peut être différente à chacun d'eux
    public abstract float PoidsTotal();

    /*
    Override de la function ToString qui permet d'afficher les élements de base d'un véhicule
    */
    public override string ToString()
    {
        string display = "";
        display += "Immatriculation : "+_immatriculation+"\n";
        display += "Poids à vide : "+_weight+"\n";
        display += "Vitesse maximal : "+_maxSpeed+"\n";
        // Si il y a possibilité d'avoir une charge, on check sur le max est au dessus de 0;
        if(_maxCharge > 0)
            display += "Charge actuelle : "+_currentCharge+" / "+_maxCharge+"\n";
            
        return display;
    }
    
}