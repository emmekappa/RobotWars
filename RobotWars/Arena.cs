namespace RobotWars
{
    /// <summary>
    ///     The Arena.
    /// </summary>
    public class Arena
    {
        private readonly int height;
        private readonly int width;

        public Arena(int width, int height)
        {
            if (width <= 0 || height <= 0)
                throw new InvalidArenaSizeException();
            this.width = width;
            this.height = height;
        }

        public int Width
        {
            get { return width; }
        }

        public int Height
        {
            get { return height; }
        }

        /// <summary>
        ///     Checks if a coordinate is inside the Arena or not.
        /// </summary>
        /// <param name="coordinate">The coordinate to check.</param>
        /// <returns>true when the coordinate is inside the arena.</returns>
        public virtual bool IsInside(Coordinate coordinate)
        {
            if (coordinate.X < 0 || coordinate.Y < 0)
                return false;

            return coordinate.X <= width && coordinate.Y <= height;
        }
    }
}