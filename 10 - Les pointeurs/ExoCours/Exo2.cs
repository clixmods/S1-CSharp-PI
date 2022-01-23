using System;
/*
1) Creer une structure FamilyAccount.
Ajouter à la structure une propriété public amount de type float

2) Creer une structure MemberFamily.
Ajouter à la structure une propriété :
- private account,
- un pointeur de type FamilyAccount

3) Creer le constructeur de la structure MemberFamily

4) Ajouter une fonction à la structure MemberFamily 'UpdateAccount'.
La fonction prend en entrée un montant et l'ajoute au compte (via le pointeur)

5) Dans Main, creer :
- une variable de type FamilyAccount.
- deux variables de type MemberFamily (Dad et Mum)
- appeler la fonction UpdateAccount avec chacune des deux variables et avec un montant different.
- afficher le montant contenu dans la variable de type FamilyAccount.
*/
namespace ExoCours
{

        public struct FamilyAccount{
            public float amount;
            public FamilyAccount(float basea){
                amount = basea;
            }
        }
        unsafe public struct MemberFamily{
            private FamilyAccount* account;

            public MemberFamily(FamilyAccount* AnewAccount)
            {
                account = AnewAccount;
            }
            public void UpdateAccount(float amounta)
            {
                account->amount += amounta;
            }
        }

}