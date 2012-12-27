namespace RobotWars
{
    /// <summary>
    ///     The Value Object rappresenting a cartesian coordinate.
    ///     It pretends to be immutable.
    /// </summary>
    public class Coordinate
    {
        private readonly int x;
        private readonly int y;

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public Coordinate Clone()
        {
            return new Coordinate(x, y);
        }
    }
}