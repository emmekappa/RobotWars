namespace RobotWars
{
    public class EastDirection : DirectionBase
    {
        protected internal override Coordinate MoveForward(Coordinate coordinate)
        {
            return new Coordinate(coordinate.X + 1, coordinate.Y);
        }

        protected internal override DirectionBase RotateRight()
        {
            return new SouthDirection();
        }

        protected internal override DirectionBase RotateLeft()
        {
            return new NorthDirection();
        }

        public override string ToString()
        {
            return "E";
        }
    }
}