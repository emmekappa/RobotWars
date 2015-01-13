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

        protected bool Equals(Coordinate other)
        {
            return x == other.x && y == other.y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Coordinate) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (x*397) ^ y;
            }
        }
    }
}