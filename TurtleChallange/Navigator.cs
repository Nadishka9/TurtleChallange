using System.Text.RegularExpressions;
namespace TurtleChallange
{
    public class Navigator
    {
        public Turtle Turtle;
        public Table Table;

        public Navigator(Table table)
        {
            Table = table;
        }

        public void Place(int east, int north, string direction)
        {
            if (Table.IsValidLocation(east, north))
            {
                Turtle = new Turtle
                {
                    direction = direction.ToLower(),
                    x = east,
                    y = north
                };
            }
        }

        public void TurtleMoves(string movement)
        {
            switch (movement)
            {
                case "move":
                    if (Regex.IsMatch(Turtle.direction, "^north") && Table.IsValidLocation(Turtle.x, Turtle.y + 1))
                    {
                        Turtle.Move();
                    }
                    else if (Regex.IsMatch(Turtle.direction, "^east") && Table.IsValidLocation(Turtle.x + 1, Turtle.y))
                    {
                        Turtle.Move();
                    }
                    else if (Regex.IsMatch(Turtle.direction, "^south") && Table.IsValidLocation(Turtle.x, Turtle.y - 1))
                    {
                        Turtle.Move();
                    }
                    else if (Regex.IsMatch(Turtle.direction, "^west") && Table.IsValidLocation(Turtle.x - 1, Turtle.y))
                    {
                        Turtle.Move();
                    }
                    break;
                case "right":
                    Turtle.TurnRight();
                    break;
                case "left":
                    Turtle.TurnLeft();
                    break;
            }
        }

        public string Report()
        {
            return Turtle.Report();
        }
    }
}
