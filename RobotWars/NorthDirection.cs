namespace RobotWars
{
    public class NorthDirection : DirectionBase
    {
        internal override Coordinate MoveForward(Coordinate coordinate)
        {            
            return new Coordinate(coordinate.X, coordinate.Y + 1);
        }

        internal override DirectionBase RotateRight()
        {
            return new EastDirection();
        }

        internal override DirectionBase RotateLeft()
        {
            return new WestDirection();
        }

        public override string ToString()
        {
            return "N";
        }
    }
}