using System;
using PersonNameSpace;
namespace ExoEntrainement
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = -312; 
            person.Name = "BITE";
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Name);
            Console.WriteLine("Hello World!");
        }
    }
}
