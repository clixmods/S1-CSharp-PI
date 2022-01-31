using System;

namespace DM_LesClasses
{
    public class Car
    {
        string _ownerName; // Nom propriétaire

        public Car(string ownerName)
        {
            _ownerName = ownerName;
        }
        public string Owner
        {
            get{return _ownerName;}
        }
    }
}