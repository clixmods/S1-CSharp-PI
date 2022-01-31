// Exo 1 - Gestion de stock

// Soit à développer une application pour la gestion de stock. 
// Un article est caractérisé par son numéro de référence, son nom, son prix d’achat et son prix de vente.

// 1) Créer la classe Article.
// 2) Ajouter un constructeur à la classe Article.
// 3) Définir une méthode qui retourne une chaine de caractères représentant les différents attributs de l’objet Article. 
// Pour gérer le stock du magasin, ce dernier se caractérise par son stock d’articles. 
// Le stock est représenté par une collection d’objets Article.
// 4) Ecrire la classe Stock qui permet de réaliser les fonctionnalités suivantes :
//     a. Ajouter un nouvel Article.
//     b. Afficher tous les Articles du magasin.
//     c. Rechercher un Article.
//     d. Afficher les Articles dont les prix d’achat est supérieur à une valeur saisie.
//     e. Supprimer un Article.
//     f. Modifier un Article.
// 5) Utiliser les deux classes dans main pour en faire un exemple de programme de stockage
using System;
using System.Collections.Generic; 
namespace ExoCours
{
    class Exo1
    {
        public static void Init(){
            Article chips = new Article(10, "Chips", 0.5f, 2.65f);
            Console.WriteLine(chips);
            Stock Netto = new Stock();
            Article doritos = new Article(1, "doritos", 0.75f, 3.65f);
            Netto.ShowAllArticle();
            Netto.AddArticle(doritos);
            //Netto.AddArticle(chips);
            //Netto.AddArticle(chips);
            //Netto.AddArticle(chips);

            Netto.ShowAllArticle();
            Console.WriteLine("\n------------------------------------------------------------\n");
            Netto.DeleteArticle(chips);
            Netto.ShowAllArticle();


            // 
    

           
            // Netto.AddArticle(new Article(0, "Coffee", 0.5f, 0.65f));
            // Netto.AddArticle(new Article(0, "Monster", 0.2f, 0.35f));
            // Netto.AddArticle(chips);
            // Netto.AddArticle(doritos);
            // // Netto.ShowAllArticle();
            // Netto.ShowArticleSuperiorTo(0.7f);
        }

        class Article // Créer la classe Article.
        {
            private int _refNumber; // son numéro de référence
            private string _name; // son nom
            private float _priceBuy; //son prix d’achat 
            private float _priceSell; // son prix de vente.

             //  Ajouter un constructeur à la classe Article.
            public Article(int refNumber, string name,  float priceBuy, float priceSell )
            {
                RefNumber = refNumber;
                Name = name;
                PriceBuy = priceBuy;
                PriceSell = priceSell;


            }

            public int RefNumber
            {
                get{return _refNumber;}
                private set{
                    if( value > 0 )
                        _refNumber = value;
                    else
                    {
                        _refNumber = 1;
                    }       
                }
            }
            public float PriceBuy
            {
                get{return _priceBuy;}
                set{
                    if( value > 0 )
                        _priceBuy = value;
                    else
                    {
                        _priceBuy = 0.01f;
                    }       
                }
            }
             public float PriceSell
            {
                get{return _priceSell;}
                set{
                    if( value > _priceBuy )
                        _priceSell = value;
                    else
                    {
                        _priceSell = _priceBuy*1.1f;
                    }       
                }
            }
            public string Name
            {
                get{return _name;}
                set{
                    if(string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("Attention le nom est incorrect");
                        _name = "Incorrect Name";
                    }
                    else
                        _name = value;
                }
                    
               
            }

            /*
            Définir une méthode qui retourne une chaine de caractères représentant les différents attributs de l’objet Article. 
            Pour gérer le stock du magasin, ce dernier se caractérise par son stock d’articles. 
            */
            public override string ToString()
            {
                string str = $" Référence : {_refNumber}";
                str += $"\n Nom de l'article  : {_name}";
                str += $"\n Prix d'achat : {_priceBuy}";
                str += $"\n Prix de vente : {_priceSell}";
                return str;
            }   
        }

        class Stock
        {
            Article[] _stock = new Article[0];

            public void AddArticle(Article articleToAdd){ //  Ajouter un nouvel Article.
                Article[] newStock = new Article[_stock.Length+1];

                for(int i = 0; i < _stock.Length ; i++)
                {
                    newStock[i] = _stock[i];
                }
                newStock[_stock.Length] = articleToAdd;
                _stock = newStock;
            }
            public void ShowAllArticle(){ //Afficher tous les Articles du magasin.
                if(_stock.Length == 0)
                { 
                    Console.WriteLine("Le stock est vide !");
                    return;
                }
                Console.WriteLine("Le stock contient "+_stock.Length+" articles \nListe des articles :");
                foreach(Article art in _stock)
                {
                    Console.WriteLine(art); 
                }

            } 

            public Article SearchArticle(Article articleToSearch){ // Rechercher un Article.
                foreach(Article art in _stock)
                {
                    if(articleToSearch.RefNumber == art.RefNumber )
                    {
                        Console.WriteLine(articleToSearch.Name+" is available");
                        return art;                    
                    }
                }
                Console.WriteLine("Article not found");
                return null;
            }
            public Article SearchArticle(int _ref ){ // Rechercher un Article.
                foreach(Article art in _stock)
                {
                    if( _ref == art.RefNumber )
                    {
                            Console.WriteLine(art.Name+" is available");
                           return art;                    
                    }
                }
                Console.WriteLine("Article not found");
                return null;
            }
            public Article SearchArticle(String _name ){ // Rechercher un Article.
                foreach(Article art in _stock)
                {
                    if( _name == art.Name )
                    {
                        Console.WriteLine(art.Name+" is available");
                        return art;                    
                    }
                }
                Console.WriteLine("Article not found");
                return null;
            }

            // Afficher les Articles dont les prix d’achat est supérieur à une valeur saisie.
            public void ShowArticleSuperiorTo(float minPrice){ 
                foreach(Article art in _stock)
                {
                    if(art.PriceSell > minPrice)
                    {
                        Console.WriteLine(art);
                    }
                }
            }
            //Supprimer un Article.
            public void DeleteArticle(Article articleToRemove){
                
                if(_stock.Length == 0)
                {
                    Console.WriteLine("Le stock est vide");
                    return;
                } 

                Article[] newStock = new Article[_stock.Length-1];
                bool isDeleted = false;
                
                for(int i = 0 ; i < _stock.Length ; i++)
                {
                    if(isDeleted)
                    {

                        newStock[i-1] = _stock[i];
                        continue;
                    }
                    if(_stock[i].RefNumber != articleToRemove.RefNumber)
                    {
                        newStock[i] = _stock[i];
                    }
                    else
                    {
                        Console.WriteLine("Article "+articleToRemove.Name+ " is removed");
                        isDeleted = true;
                    }
                        
                }
                if(isDeleted)
                    _stock = newStock;


            }
            //Modifier un Article.
            public void EditArticle(Article articleToEdit){
                
            }
        }
    }
}