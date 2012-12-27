namespace RobotWars
{
    public class WestDirection : DirectionBase
    {
        internal override Coordinate MoveForward(Coordinate coordinate)
        {
            return new Coordinate(coordinate.X - 1, coordinate.Y);
        }

        internal override DirectionBase RotateRight()
        {
            return new NorthDirection();
        }

        internal override DirectionBase RotateLeft()
        {
            return new SouthDirection();
        }

        public override string ToString()
        {
            return "W";
        }
    }
}