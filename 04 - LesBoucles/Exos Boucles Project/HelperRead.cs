using System;

class HelperRead
{
    
    public static int ReadInt(string message = "Veuillez taper un int svp")
    {
        Console.WriteLine(message);
        string number = Console.ReadLine();
        int result;
        while(true)
        {
            if(int.TryParse(number,out result))
            {
                Console.WriteLine("Valeur valide, c'est cool");
                return result;
            }
            else
            {
                Console.WriteLine("Attention la valeur donnée "+number+" n'est pas valide en tant que INT, veuillez réessayer");
                number = Console.ReadLine();
            }
        }
    }
   
    public static float ReadFloat(string message = "Veuillez taper un float svp")
    {
        Console.WriteLine(message);
        string number = Console.ReadLine();
        float result;
        while(true)
        {
            if(float.TryParse(number,out result))
            {
                Console.WriteLine("Valeur valide, c'est cool");
                return result;
            }
            else
            {
                Console.WriteLine("Attention la valeur donnée "+number+" n'est pas valide en tant que INT, veuillez réessayer");
                number = Console.ReadLine();
            }
        }
    }
    public static float ReadFloatBetween(float minValue,float maxValue,string message = "Veuillez taper un float entre ")
    {
        message += minValue+" et "+maxValue;
        Console.WriteLine(message);
        string number = Console.ReadLine();
        float result;
        while(true)
        {
            if(float.TryParse(number,out result) && result <= maxValue && result >= minValue )
            {
                Console.WriteLine("Valeur valide, c'est cool");
                return result;
            }
            else
            {
                Console.WriteLine("Attention la valeur donnée "+number+" n'est pas valide en tant que Float, veuillez réessayer");
                number = Console.ReadLine();
            }
        }
    } 
    public static int ReadIntBetween(int minValue,int maxValue,string message = "Veuillez taper un int entre ")
    {
        message += minValue+" et "+maxValue;
        Console.WriteLine(message);
        string number = Console.ReadLine();
        int result;
        while(true)
        {
            if(int.TryParse(number,out result) && result <= maxValue && result >= minValue )
            {
                Console.WriteLine("Valeur valide, c'est cool");
                return result;
            }
            else
            {
                Console.WriteLine("Attention la valeur donnée "+number+" n'est pas valide en tant que INT, veuillez réessayer");
                number = Console.ReadLine();
            }
        }
    }
}