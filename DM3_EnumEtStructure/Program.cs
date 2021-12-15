using System;
/*
================== Règles =====================
A Rendre dans un dossier DM3_EnumEtStructure.
Doit être sur vos GitHub avant 10h Mercredi 15.
-0.2 points à chaque erreur de nomenclature.
0 sur l'exo si le programme ne compile pas.
https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/inside-a-program/coding-conventions


*/
namespace DM3_EnumEtStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Exo1.MonthToColor();

            // On utilise un do while pour lancer linstruction au moins au fois
             do{
                 Console.WriteLine("Rentre une touche parmi : ArrowLeft, ArrowRight, ArrowUp, ArrowDown");
             }while(!Exo2.ValidInput(Console.ReadKey().Key));
             // Une fois le do while fini, cela veut dire que l'user a bien entrer lune des touches demandés
            Console.WriteLine("Bravo vous savez appuyer sur les touches autorisées :)!");


            // Vector3 Hi = new Vector3(4,5,6);
            // Vector3 HiYO = new Vector3(2,5,6);
            // Console.WriteLine(Hi);
            // Console.WriteLine(HiYO);

            // Hi.Translate(3,1,1);
            // HiYO.Translate(new Vector3(10,10,10));
          
            // Console.WriteLine(Hi);
            // Console.WriteLine(HiYO);

            // Console.WriteLine(Hi.Longueur());
            // Console.WriteLine(HiYO.Longueur());

            // Console.WriteLine(Vector3.Distance(Hi,HiYO));
            // Console.WriteLine(Vector3.Distance(HiYO,Hi));
            
            Forme myForm = new Forme(TypeForme.DiamondSquare, 7);
            Console.WriteLine(myForm);

        }
    }
}
