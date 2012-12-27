namespace RobotWars
{
    public class SouthDirection : DirectionBase
    {
        internal override Coordinate MoveForward(Coordinate coordinate)
        {
            return new Coordinate(coordinate.X, coordinate.Y - 1);
        }

        internal override DirectionBase RotateRight()
        {
            return new WestDirection();
        }

        internal override DirectionBase RotateLeft()
        {
            return new EastDirection();
        }

        public override string ToString()
        {
            return "S";
        }
    }
}