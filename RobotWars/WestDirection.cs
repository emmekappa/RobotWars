namespace RobotWars
{
    internal class WestDirection : IDirection
    {        
        public Coordinate MoveForward(Coordinate coordinate)
        {
            return new Coordinate(coordinate.X-1, coordinate.Y);
        }

        public IDirection RotateRight()
        {
            return new NorthDirection();            
        }

        public IDirection RotateLeft()
        {
            return new SouthDirection();            
        }
        public override string ToString()
        {
            return "W";
        }

    }
}