public class CamionCiterne : Camion
{
    
    public CamionCiterne(string immatriculation) : base(immatriculation)
    {
        _weight = 3;
        _maxCharge = 10;
    }

    /*
        - un camion citerne a un poids à vide de 3 tonnes et une charge maximale de 10 tonnes. 
        Sa vitesse maximale dépend de son poids total :
        130 km/h si le poids total est de 3 tonnes.
        110 km/h si le poids total est superieur à 3 tonnes et inferieur ou égal à 4 tonnes.
        90 km/h si le poids total est superieur à 4 tonnes et inferieur ou égal à 7 tonnes.
        80 km/h si le poids total est supérieur à 7 tonnes.
    */

    public override float CalculeVitesseMax()
    {
        float totalWeight = PoidsTotal();
        if(totalWeight <= 3)
        {
            return 130;
        }
        else if( totalWeight > 3 && totalWeight <= 4)
        {
            return 110;
        }
        else if( totalWeight > 4 && totalWeight <= 7)
        {
            return 90;
        }
        else
        {
            return 80;
        }
        throw new System.NotImplementedException();
    }

    public override string ToString()
    {
        string display = "Type de véhicule : Camion Citerne\n";
        display += base.ToString();
        return display;
    }
}