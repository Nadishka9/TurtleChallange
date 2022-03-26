namespace TurtleChallange
{
    public class Turtle 
    {
        public int x = 0;
        public int y = 0;
        public string direction;

        public Turtle()
        {

        }

        public void Move()
        {
            switch (direction)
            {
                case "east":
                    x += 1;
                    break;
                case "west":
                    x -= 1;
                    break;
                case "north":
                    y += 1;
                    break;
                case "south":
                    y -= 1;
                    break;
            }
        }

        public void TurnLeft()
        {
            switch (direction)
            {
                case "east":
                    direction = "north";
                    break;
                case "west":
                    direction = "south";
                    break;
                case "north":
                    direction = "west";
                    break;
                case "south":
                    direction = "east";
                    break;
            }
        }

        public void TurnRight()
        {
            switch (direction)
            {
                case "east":
                    direction = "south";
                    break;
                case "west":
                    direction = "north";
                    break;
                case "north":
                    direction = "east";
                    break;
                case "south":
                    direction = "west";
                    break;
            }
        }

        public string Report()
        {
            return x + "," + y + "," + direction.ToUpper();
        }
    }
}