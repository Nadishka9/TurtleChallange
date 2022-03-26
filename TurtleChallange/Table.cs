namespace TurtleChallange
{
    public class Table
    {
        public int width;
        public int length;
        public bool IsValidLocation(int x, int y)
        {
            return x >= 0 && x < width && y >= 0 && y < length;
        }
        public Table(int width, int length)
        {
            this.width = width;
            this.length = length;
        }
    }
}
