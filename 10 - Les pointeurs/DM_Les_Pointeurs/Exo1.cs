
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

            CopyPaste(pointChar1, pointChar2);
             //Le résultat doit être 'O' et 'O'.
            Console.WriteLine($" Value of {nameof(pointChar1)} = {*pointChar1}");
            Console.WriteLine($" Value of {nameof(pointChar2)} = {*pointChar2}");
        }
        //La fonction copie la valeur de la variable pointée par le premier pointeur dans la variable pointée par le deuxième.
        static void CopyPaste(char* charRef1, char* charRef2)
        {
            *charRef2 = *charRef1;
        }
        
    }
}
