using System;


namespace Snake
{
    

    public struct Grid
    {
        private char[] grid;
        private int width, height;

        private static char empty = ' ';
        private static char limitSideBorder = '|';
        private static char limitTopBottomBorder = '-';

        public Grid(int width, int height)
        {
            this.width = width+1;
            this.height = height+1;
            grid = new char[this.width*this.height];
            for(int i = 0; i < grid.Length; i++)
            {
                grid[i] = empty;
            }
        }

        public void CreateLoot()
        {
            while(true)
            {
                Random rand = new Random();
                int x = rand.Next(0, width);
                int y = rand.Next(0, height);
                if(IsInGrid(x , y) && grid[x*y] == empty)
                {
                    SetCharInGrid(x, y, 'L');    
                    break;
                }
               
            }
        }
        public bool IsSelf(int x, int y , char playerSkin)
        {
            return grid[GetIndexCoordonate(x, y)] == playerSkin;
        }

        public bool IsLoot(int x, int y)
        {
            return grid[GetIndexCoordonate(x, y)] == 'L';
        }
        public bool IsInGrid(Point position)
        {
            return GetIndexCoordonate(position.x, position.y) != -1;
        }

        public bool IsInGrid(int x, int y)
        {
            return IsInGrid(new Point(x,y));
        }

        public void CleanCharInGrid(Point position)
        {
            SetCharInGrid(position, empty);
        }
        public Point GetCenter()
        {
            return new Point(width / 2,height /2);
        }

        public static void ChangeSkin(char newLimitSideBorder)
        {
            limitSideBorder = newLimitSideBorder;
        }
        private int GetIndexCoordonate(int x, int y)
        {
            if(x >= 0 && x < width && y >= 0 && y < height)
                return y * width + x;

            return -1;
        }

        public void SetCharInGrid(Point[] positions, char newChar)
        {
            for(int i = 0; i < positions.Length; i ++)
            {
                SetCharInGrid(positions[i], newChar);
            }
            
        }
        

        public void SetCharInGrid(int x, int y, char newChar)
        {
            int index = GetIndexCoordonate(x,y);
            if(index != -1 ) 
                grid[index] = newChar;
        }

        public void SetCharInGrid(Point position, char newChar)
        {
            SetCharInGrid(position.x, position.y, newChar);
        }
        
        #region DISPLAY GRID
        public override string ToString()
        {
            string toDisplay = DisplayTopBottomLine();
            toDisplay += DisplayCenterLines();
            toDisplay += DisplayTopBottomLine();
            return toDisplay;
        }

        private string DisplayCenterLines()
        {
            string toDisplay = "";
            for(int j = 0; j < height; j++)
            {
                toDisplay += limitSideBorder;
                int preCalcul = j * width;
                for(int i = 0; i < width; i++)
                {
                    toDisplay += empty.ToString() + grid[preCalcul + i] + empty;
                }
                toDisplay += limitSideBorder + "\n";
            }
            return toDisplay;
        }

        private string DisplayTopBottomLine()
        {
            string toDisplay = " ";
            for(int i = 0; i < width; i++)
            {
                toDisplay += limitTopBottomBorder.ToString() + limitTopBottomBorder + limitTopBottomBorder;
            }
            toDisplay += " \n";
            return toDisplay;
        }
        #endregion DISPLAY GRID
        
    }
}