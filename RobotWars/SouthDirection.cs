namespace RobotWars
{
    class SouthDirection : IDirection
    {        
        public Coordinate MoveForward(Coordinate coordinate)
        {
            return new Coordinate(coordinate.X, coordinate.Y-1);
        }

        public IDirection RotateRight()
        {
            return new WestDirection();
        }

        public IDirection RotateLeft()
        {
            return new EastDirection();
        }
        public override string ToString()
        {
            return "S";
        }

    }
}