namespace RobotWars
{
    public class EastDirection : IDirection
    {        
        public Coordinate MoveForward(Coordinate coordinate)
        {
            return new Coordinate(coordinate.X+1, coordinate.Y);
        }

        public IDirection RotateRight()
        {
            return new SouthDirection();
        }

        public IDirection RotateLeft()
        {
            return new NorthDirection();            
        }

        public override string ToString()
        {
            return "E";
        }
    }
}