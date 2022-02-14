public class CamionBache : Camion
{
    
    public CamionBache(string immatriculation) : base(immatriculation)
    {
        _weight = 4;
        _maxCharge = 20;
        
    }



           /*
        - un camion baché a un poids à vide de 4 tonnes et une charge maximum de 20 tonnes. Sa vitesse maximale dépend également de sa charge
(mais à charge égale, un camion citerne a une vitesse maximale plus faible, car le liquide qu'il transporte est plus instable qu'un chargement soldie) :
130 km/h si le poids total est de 4 tonnes.
110 km/h si le poids total est superieur à 4 tonnes et inferieur ou égal à 7 tonnes.
90 km/h si le poids total est superieur à 7 tonnes et inferieur ou égal à 11 tonnes.
80 km/h si le poids total est supérieur à 11 tonnes et inferieur ou égal à 14 tonnes.
70 km/h si le poids total est supérieur à 14 tonnes.

    */

    public override float CalculeVitesseMax()
    {
        float totalWeight = PoidsTotal();
        if(totalWeight <= 4)
        {
            return 130;
        }
        else if( totalWeight > 4 && totalWeight <= 7)
        {
            return 110;
        }
        else if( totalWeight > 7 && totalWeight <= 11)
        {
            return 90;
        }
        else if( totalWeight > 11 && totalWeight <= 14)
        {
            return 80;
        }
        else 
        {
            return 70;
        }
        throw new System.NotImplementedException();
    }

    public override string ToString()
    {
        string display = "Type de véhicule : Camion Bache\n";
        display += base.ToString();
        return display;
    }

}