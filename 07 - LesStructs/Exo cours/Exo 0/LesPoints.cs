namespace Exo_0
{
    public struct Point
    {
        public int x;
        public int y;
        public string name;

        public Point(int OOf)
        {
            x = 0;
            y = 0; 
            name = "Default Name";
        }
        public override string ToString() // utilise pour les print et debug log
        {
            return "{ x = "+ x +" \n y = "+ y + " \n name = "+name;
        }
    }
}