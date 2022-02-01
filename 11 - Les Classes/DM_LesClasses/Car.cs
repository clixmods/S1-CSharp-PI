using System;

namespace DM_LesClasses
{
    public class Car
    {
        string _ownerName; // Nom propriétaire

        public Car(string ownerName)
        {
            Owner = ownerName;
        }
        public string Owner
        {
            get{return _ownerName;}
            set{    if( !string.IsNullOrEmpty(value) ) // je verifie quand meme si c'est bien un nom, sinon anonyme
                    {
                        _ownerName = value;
                    }
                    else
                    {
                        _ownerName = "anonyme";
                    }
            }
        }
    }
}