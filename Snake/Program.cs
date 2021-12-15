using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Grid newGrid = new Grid(10,10);
            Player player = new Player(newGrid.GetCenter());
            newGrid.SetCharInGrid(player.GetPosition(),player.GetPlayerSkin());


            // newGrid.SetCharInGrid(0,0,'A');
            // newGrid.SetCharInGrid(0,10,'B');
            // newGrid.SetCharInGrid(10,0,'C');
            // newGrid.SetCharInGrid(10,10,'D');
            // newGrid.SetCharInGrid(11,11,'D');
            Console.WriteLine(newGrid);
            
            while(true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if(keyInfo.Key == ConsoleKey.R)
                {
                    newGrid = new Grid(10,10);
                    player = new Player(newGrid.GetCenter());
                    continue;
                }
                Console.Clear();
                Point position = new Point(0,0);
                switch(keyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        position.x += 1;
                        break;
                    case ConsoleKey.LeftArrow:
                        position.x -= 1;
                        break;
                    case ConsoleKey.DownArrow:
                        position.y += 1;
                        break;
                    case ConsoleKey.UpArrow:
                        position.y -= 1;
                        break;
                    
                }
                Random rand = new Random();
                int lootChance = rand.Next(0, 100);
                if(lootChance > 50)
                    newGrid.CreateLoot();

                Point positionPlayer = player.GetHeadPosition();
                Point newPosition = new Point(position.x + positionPlayer.x, position.y + positionPlayer.y);
                if(newGrid.IsInGrid(newPosition))
                {    
                    if(newGrid.IsSelf(newPosition.x,newPosition.y,player.GetPlayerSkin()))
                    {
                        newGrid = new Grid(10,10);
                        player = new Player(newGrid.GetCenter());
                   
                        continue;
                    }

                    if(newGrid.IsLoot(newPosition.x,newPosition.y) )
                    {
                        player.Grown(newPosition);
                        
                    }
                    else
                    {
                        newGrid.CleanCharInGrid(player.GetLastPosition());
                        player.Translate(position);
                    }
                    newGrid.SetCharInGrid(player.GetPosition(), player.GetPlayerSkin());
                    Console.WriteLine(newGrid);
                    
                    //lastPositionPlayer = player.GetPosition()[player.GetPosition().Length-1];
                    
                }
            }

            
        }
    }
}
