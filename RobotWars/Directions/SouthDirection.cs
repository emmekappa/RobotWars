namespace RobotWars
{
    public class SouthDirection : DirectionBase
    {
        protected internal override Coordinate MoveForward(Coordinate coordinate)
        {
            return new Coordinate(coordinate.X, coordinate.Y - 1);
        }

        protected internal override DirectionBase RotateRight()
        {
            return new WestDirection();
        }

        protected internal override DirectionBase RotateLeft()
        {
            return new EastDirection();
        }

        public override string ToString()
        {
            return "S";
        }
    }
}