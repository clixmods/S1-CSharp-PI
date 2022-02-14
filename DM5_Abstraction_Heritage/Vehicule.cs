public abstract class Vehicule
{
    //Classe de base. Trois attributs, le numéro d'immatriculation du véhicule, la vitesse maximale et le poids à vide.
    string _immatriculation; // Plaque d'immatriculation
    float _maxSpeed; // Vitesse maximale
    float _weight; // Poids à vide du vehicule ( 1 par tonne)
    
    
    float _currentCharge = 0; // Charge actuelle du vehicule
    float _maxCharge; // Max charge supporter par le vehicule
    bool _hasHuileEngine; // bool pour indiquer si le vehicule est équipé du moteur


    // Constructeur qui set la plaque dimmatriculation
    public Vehicule(string immatriculation) 
    {
        _immatriculation = immatriculation;
    }
    public float Speed
    {
        protected set{ if(value > 0)
                            _maxSpeed = value;
                        else
                            _maxSpeed = 1;
                         }
        get{ return _maxSpeed;}
    }
    public float CurrentCharge
    {
        protected set{ if(value > 0 && value <= _maxCharge)
                            _currentCharge = value;
                        else
                            _currentCharge = 1;
                         }
        get{ return _currentCharge;}
    }

    public float MaxCharge
    {
        protected set{ if(value > 0 )
                            _maxCharge = value;
                        else
                            _maxCharge = 1;
                         }
        get{ return _maxCharge;}
    }

    public float Weight 
    {
        protected set{  if(value > 0)
                            _weight = value;
                        else
                            _weight = 1;
                        }
        get{ return _weight;}
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
        display += "Poids à vide (sans charges etc) : "+_weight+"\n";
        display += "Poids Total : "+PoidsTotal()+" \n";
        display += "Vitesse maximal : "+_maxSpeed+"\n";
        // Si il y a possibilité d'avoir une charge, on check sur le max est au dessus de 0;
        if(_maxCharge > 0)
            display += "Charge actuelle : "+_currentCharge+" / "+_maxCharge+"\n";
            
        return display;
    }
    
}