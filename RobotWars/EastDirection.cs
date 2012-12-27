namespace RobotWars
{
    public class EastDirection : DirectionBase
    {
        internal override Coordinate MoveForward(Coordinate coordinate)
        {
            return new Coordinate(coordinate.X + 1, coordinate.Y);
        }

        internal override DirectionBase RotateRight()
        {
            return new SouthDirection();
        }

        internal override DirectionBase RotateLeft()
        {
            return new NorthDirection();
        }

        public override string ToString()
        {
            return "E";
        }
    }
}