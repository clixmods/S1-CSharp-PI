using System;

namespace ProjetPointer
{
    class Program
    { 
       
            static void cool()
            {
                Console.WriteLine("ntm");
            }

        public struct Point
        {
            public float x;
            public float y;
            public Point(float x, float y)
            {
                this.x = x;
                this.y = y;
            }
            public override string ToString()
            {
                return "("+x+", "+y+" )";
            }
            
        }
        unsafe static void Main(string[] args)
        {
            int a = 1;
            int* p1;
            p1 = &a;
            delegate*<void> pog = &cool;

            p1++;
            Console.WriteLine(a);
            Console.WriteLine((long)p1);
            Console.WriteLine("Hello World!");

            Point myPoint = new Point(50,150);
            Point* Bite = &myPoint;

            Bite->x += 10;
            Bite->y -= 100;

            Console.WriteLine(*Bite);
            ModifyPoint(Bite, 10,10 , pog);
            Console.WriteLine(*Bite);
        }
        private unsafe static void ModifyPoint(Point* pointeur, float newX, float newY, delegate*<void> Off)
        {
            pointeur -> x = newX;
            pointeur -> y = newY;
            Off();
        }
    }
}
