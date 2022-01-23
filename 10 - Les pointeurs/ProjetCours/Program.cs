using System;

namespace ProjetCours
{
    enum MyEnum
    {
        MaValeur1,
        MaValeur2,
        MaValeur3,     


    }

    public struct taMere
    {
        public int x;
        public int y;

        public override string ToString()
        {
            return x+" "+y ;
        }
    }

    class Program
    {
   
        static void Main(string[] args)
        {
            int maVarEntiere = 4;
            int maVarEntiere2 = maVarEntiere;

            maVarEntiere++;

            Console.WriteLine($"{nameof(maVarEntiere)} {maVarEntiere}");
            MyFunctionInt(maVarEntiere);
            Console.WriteLine($"{nameof(maVarEntiere)} {maVarEntiere}");
            Console.WriteLine($"{nameof(maVarEntiere2)} {maVarEntiere2}");

            MyEnum maVarEnum;
            maVarEnum = MyEnum.MaValeur1;
            
            MyEnum maVarEnum2 = maVarEnum;
            //maVarEnum2 += 2;
            maVarEnum = MyEnum.MaValeur3;

            Console.WriteLine($"{nameof(maVarEnum)} {maVarEnum}");
            MyFunctionEnum(maVarEnum);

            Console.WriteLine($"{nameof(maVarEnum)} {maVarEnum}");
            Console.WriteLine($"{nameof(maVarEnum2)} {maVarEnum2}");

            ConsoleKey KeyOne = ConsoleKey.Backspace;
            ConsoleKey KeyDeux = KeyOne;
            KeyOne++;

            Console.WriteLine($"{nameof(KeyOne)} {KeyOne}");
            Console.WriteLine($"{nameof(KeyDeux)} {KeyDeux}");

            taMere m = new taMere();
            m.x = 69;
            taMere n = m;
            n.y = 96;

            Console.WriteLine($"{nameof(m)} {m}");
            MyFunctionStruct(m);
            Console.WriteLine($"{nameof(m)} {m}");
            Console.WriteLine($"{nameof(n)} {n}");
        }

        private static void MyFunctionInt(int val) 
        {
            val++;
        }
        private static void MyFunctionEnum(MyEnum val) 
        {
            val++;
        }
        private static void MyFunctionStruct(taMere mere) 
        {
            mere.x++;
            mere.y++;
        }
        
    }
}
