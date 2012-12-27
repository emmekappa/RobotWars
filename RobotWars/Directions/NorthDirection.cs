namespace RobotWars
{
    public class NorthDirection : DirectionBase
    {
        protected internal override Coordinate MoveForward(Coordinate coordinate)
        {
            return new Coordinate(coordinate.X, coordinate.Y + 1);
        }

        protected internal override DirectionBase RotateRight()
        {
            return new EastDirection();
        }

        protected internal override DirectionBase RotateLeft()
        {
            return new WestDirection();
        }

        public override string ToString()
        {
            return "N";
        }
    }
}