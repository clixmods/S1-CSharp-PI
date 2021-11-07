class CompatibilityUtility
{
    public static string CalculTVA(string name, string aprice, string acount, string atva)
    {   
        if(float.TryParse(aprice,out float price) 
        && float.TryParse(atva,out float tva)  
        && int.TryParse(acount,out int count)  )
        {
            float tvafloat = ((float)tva/100)+1;
            float productPriceTTdC = price * tvafloat;
            return count+" quantity of "+name+" cost "+price*count+" in total \n "+count+" quantity of "+name+" cost together "+productPriceTTdC*count+" with for each a TVA  = "+tva+"% \n La taxe ajoute au total "+(productPriceTTdC-price)*count;  
        }
        else
        {
            return "Error dans les données envoyés par l'utilisateur, réessayer";
        }     
                    
    }
}