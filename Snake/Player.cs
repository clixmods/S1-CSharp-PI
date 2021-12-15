namespace Snake
{
    public struct Player
    {
        private Point[] positions;

        private char skin;

        // private int[] snakePosition; 

       
        
        public Player(Point position, char skin = 'O')
        {
            positions = new Point[3];
            positions[0] = position;
            positions[1] = new Point(position.x-1, position.y);
            positions[2] = new Point(position.x-2, position.y);

            this.skin = skin; 

        }

        public Player(int x, int y, char skin = 'O')
        {
             positions = new Point[3];
            positions[0] = new Point(x, y);
            positions[1] = new Point(x-1, y);
            positions[2] = new Point(x-2, y);
            // snakePosition = new int[1];     
            // snakePosition[0] = x*y;
            this.skin = skin;
        }
        public void Grown(Point newHead)
        {
            Point[] newPositions = new Point[positions.Length+1];
            for(int i = 0 ; i < positions.Length;i++)
            {
                newPositions[i+1] = positions[i];
            }
            positions = newPositions;
            positions[0] = newHead;
        }
        // public void AddSnakeLenght()
        // {
            
        // }
        // public void UpdateSnakeLenght()
        // {
            
        // }
        public Point GetHeadPosition()
        {
            return positions[0];
        }
        public Point GetLastPosition()
        {
            return positions[positions.Length-1];
        }

        public void Translate(Point positionToAdd)
        {
            // for(int i = 0 ; i < positions.Length-1; i++)
            // //for(int i = positions.Length; i > 0 ; i --)
            // {
            //     positions[i+1].x = positions[i].x; 
            //     positions[i+1].y = positions[i].y;
            // }

             for(int i = positions.Length -2 ; i >= 0 ; i --)
             {
                 positions[i+1] = positions[i]; 
                
             }

            positions[0].x += positionToAdd.x; 
            positions[0].y += positionToAdd.y;
            
            
        }

        public Point[] GetPosition()
        {
            return positions;
        }

        public void SetPosition(Point[] newVector)
        {
            positions = newVector;
        }

        public char GetPlayerSkin()
        {
            return skin;
        }
    }
}