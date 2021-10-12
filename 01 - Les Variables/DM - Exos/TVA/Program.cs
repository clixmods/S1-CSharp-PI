using System;

namespace CalculeTVA
{
    /*
       // - Declarer une variable reprensentant la TVA.
       // - Affecter à cette variable la valeur 20.0 
       // - Declarer une variable reprensentant la TVA de premiere necessité.
       // - Affecter à cette variable la valeur 5.0

       // - Declarer une variable representant le prix d'un produit 1 Hors Taxe (HT), affecter lui un prix de 19.64.
        //- Declarer une variable representant la quantité du produit 1 et affecter lui une valeur.
        //- Declarer une variable representant le prix d'un produit 2 Hors Taxe, affecter lui un prix de 254.50.
        //- Declarer une variable representant la quantité du produit 2 et affecter lui une valeur.

        //- Calculer et affecter à une variable pour chaque produit le prix Toutes Taxes Comprises (TTC) avec la variable TVA à 20%.
        -// Calculer et affecter à une variale le prix pour chaque produit en fonction de la quantité.
        //- Même chose pour la TVA à 5%.
        //- Affiicher le résultat.

        -// Calculer et affecter à une variable le total HT de tous les produits en fonction de leur quantité, puis le total TTC. 
        //- Afficher le résultat.
        //- Calculer et affecter à une variable le total des TVAs.
        //- Affiicher le résultat.    
    */
    class Product
    {
        public string Name;
        public float Price;
        public int Count;
    }
    class Program
    {
         static int tva = 20;
         static int tvaPrimary = 5;
        
        static void Main(string[] args)
        {
            Product a = new Product(); a.Name = "Chips"; a.Price = 19.64f; a.Count = 5; 
            Product b = new Product(); b.Name = "Television"; b.Price = 254.50f; b.Count = 5000;  
            Pogger( a);
            Pogger( b);
        }
        static void Pogger(Product product)
        {
            Console.WriteLine("-----------------------------");
            Program.TVAPrice(tva,product); Program.TVAPrice(tva,product,true);
            Console.WriteLine("-----------------------------");
            Program.TVAPrice(tvaPrimary,product); Program.TVAPrice(tvaPrimary,product,true);
            Console.WriteLine("-----------------------------");
        }
        static void TVAPrice(int tva, Product product, bool WithQuantity = false)
        {   
                float tvafloat = ((float)tva/100)+1;
                     

                    float productPriceTTdC = product.Price * tvafloat;
                    if(WithQuantity)
                    {
                        Console.WriteLine(product.Count+" "+product.Name+" coute "+product.Price*product.Count+" au total");  
                        Console.WriteLine(product.Count+" "+product.Name+" coute "+productPriceTTdC*product.Count+" avec pour chaque une TVA de "+tva+"%"  ); 
                        Console.WriteLine("La taxe ajoute au total "+(productPriceTTdC-product.Price)*product.Count);
                    }    
                    else
                    {
                        Console.WriteLine(product.Name+" coute "+product.Price);  
                        Console.WriteLine(product.Name+" coute "+productPriceTTdC+" avec une TVA de "+tva+"%");   
                        Console.WriteLine("La taxe ajoute "+(productPriceTTdC-product.Price));

                    }
                        
        }
    }    
     
        
    
}
