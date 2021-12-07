using System;

namespace MyFirstStruct
{

    


    class Program
    {
        
        static void Main(string[] args)
        {
            MyFirstStructure HellomyStruct = new MyFirstStructure(5);
            HellomyStruct.prop1 = 50;

            Console.WriteLine(HellomyStruct);
            //HellomyStruct.
            Console.WriteLine(MyFirstStructure.GetGlobalValue());
            MyFirstStructure.SetGlobalValue(10);
           // MyFirstStructure.;
            Console.WriteLine(MyFirstStructure.GetGlobalValue());
        }
        struct MyFirstStructure
        {
            // Déf des property
            // Accessible depuis la variable
            public int prop1;

            // Accessible depuis le nom de la struct (grace au static)
            public static int StaticProp = 5;
            private static int myPropStatic = 1;


            // Accessible depuis la variable
            public MyFirstStructure(int prop11)
            {
                prop1 = prop11;
            }
            public int GetPublicValue()
            {
                return myPropStatic;
            }
            private int GetValue()
            {
                return prop1;
            }
            public override string ToString() // utilise pour les print et debug log
            {
                return "prop1 "+ prop1 +" is stringered";
            }
            
            // Accessible depuis le nom de la struct (grace au static)

            public static int GetPublicValues(MyFirstStructure one , MyFirstStructure two) // A partir des variables on peut acceder au function no static
            {
                return one.GetValue()+two.GetValue(); // La function est private mais vue que nous sommes dans la struct et beh on peut y acceder 
            }
            public static int GetGlobalValue()
            {
                
                return myPropStatic;
            }
            public static void SetGlobalValue(int value)
            {
                myPropStatic = value;
            }
        }
    }
}
