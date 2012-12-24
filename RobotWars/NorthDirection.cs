namespace RobotWars
{
    public class NorthDirection : IDirection
    {        
        public Coordinate MoveForward(Coordinate coordinate)
        {
            return new Coordinate(coordinate.X, coordinate.Y+1);
        }

        public IDirection RotateRight()
        {
            return new EastDirection();
        }

        public IDirection RotateLeft()
        {
            return new WestDirection();
        }

        public override string ToString()
        {
            return "N";
        }

    }
}