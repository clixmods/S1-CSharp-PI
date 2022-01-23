/*
================== Exo 1 - Char Pointer =====================

1) Creer les variables suivantes :
- un char caractere1 intialisé avec 'O'
- un char caractere2 intialisé avec 'A'
- un pointeur de type char qui reference la variable caractere1
- un pointeur de type char qui reference la variable caractere2

2) Creer une fonction qui prend deux pointeurs de type char en entrée.
La fonction doit copier la valeur de la variable pointée par le premier pointeur dans la variable pointée par le deuxième.

3) Appeler la fonction avec comme paramètres les deux pointeurs déclarés dans 1).

4) Afficher les valeurs de caractere1 et caractere2 via les pointeurs.
Le résultat doit être 'O' et 'O'.
*/

using System;

namespace DM_Les_Pointeurs
{
    unsafe class Exo1
    {
        public static void CharPointeur()
        {
            char caractere1 = 'O';
            char caractere2 = 'A';
            char* pointChar1 = &caractere1;
            char* pointChar2 = &caractere2;

            functionOne(pointChar1, pointChar2);

            Console.WriteLine($" Value of {nameof(pointChar1)} = {*pointChar1}");
            Console.WriteLine($" Value of {nameof(pointChar2)} = {*pointChar2}");
        }
        //La fonction doit copier la valeur de la variable pointée par le premier pointeur dans la variable pointée par le deuxième.
        static void functionOne(char* charRef1, char* charRef2)
        {
            *charRef2 = *charRef1;
        }
        
    }
}
