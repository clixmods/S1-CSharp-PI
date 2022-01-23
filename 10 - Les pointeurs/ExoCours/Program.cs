using System;

namespace ExoCours
{
    /*
    Exo 1

1) Declarer :
- une variable "myValue" de type int avec une valeur.
- un pointeur "myValuePointer" qui pointe sur cette variable.
- un tableau "myTabValues" de 3 int avec des valeurs differentes assignées à chaque index.
- un pointeur "myTabValuePointer" qui pointe sur le deuxième élément du tableau.

2) Afficher les valeurs des variables via les pointeurs



4) Modifier les variables via les pointeurs et afficher les nouvelles valeurs

5) Ecrire une fonction qui prend en paramètre deux pointeurs de type int.
La fonction doit assigner la valeur de la variable pointé par le premier pointeur
à la seconde variable pointé par le second pointeur.

Appeler la fonction avec le pointeur sur myValue, et un pointeur sur le premier élément du tableau.

exo 2:
5) Dans Main, creer :
- une variable de type FamilyAccount.
- deux variables de type MemberFamily (Dad et Mum)
- appeler la fonction UpdateAccount avec chacune des deux variables et avec un montant different.
- afficher le montant contenu dans la variable de type FamilyAccount.
    */
    class Program
    {
        unsafe static void Exo1()
        {
            int myValue = 5;
            int* myValuePointer = &myValue;
            int[] myTabValues = {1,2,3};
            fixed (int* myTabValuePointer = &myTabValues[1]){
                void ShowValue(int*[] alist, string[] nameOfvar)
                {
                    for(int i = 0 ; i < alist.Length; i++)
                    {
                        Console.WriteLine($"Value of {nameOfvar[i]} {*alist[i]}" );
                        Console.WriteLine($"Adress of {nameOfvar[i]} {(long)alist[i]} \n" );
                    }  
                }           
                ShowValue(new int*[] {myTabValuePointer,myValuePointer}, new string[] {nameof(myTabValuePointer),nameof(myValuePointer)}  );
                Console.WriteLine("Changement value depuis les pointeurs ");   
                *myTabValuePointer +=1 ;
                *myValuePointer += 2; 
                ShowValue(new int*[] {myTabValuePointer,myValuePointer}, new string[] {nameof(myTabValuePointer),nameof(myValuePointer)}  );
                Console.WriteLine("Change Pointeur Value with function");
                ChangeValue(myValuePointer, myTabValuePointer);
                ShowValue(new int*[] {myTabValuePointer,myValuePointer}, new string[] {nameof(myTabValuePointer),nameof(myValuePointer)}  );
            }      
        }
        unsafe static void ChangeValue(int* firstPointeur, int* secondPointeur)
        {
            *secondPointeur = *firstPointeur; 
        }
       

        unsafe static void Main(string[] args)
        {
            Exo1();

            // Console.WriteLine("Exo2");

            // FamilyAccount family = new FamilyAccount(2);
            // MemberFamily Dad = new MemberFamily(&family);
            // MemberFamily Mum = new MemberFamily(&family);
            // Dad.UpdateAccount(5);
            // Mum.UpdateAccount(10);
            // Console.WriteLine(family.amount);

            //  Console.WriteLine($"Value of {nameof(family.amount)} {family.amount}" );
            
        }
    }
}
