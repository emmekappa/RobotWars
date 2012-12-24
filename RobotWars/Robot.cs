namespace RobotWars
{
    public class Robot
    {
        private Coordinate coordinate;
        private IDirection direction;
        
        public Robot(Coordinate coordinate, IDirection direction)
        {
            this.coordinate = coordinate;
            this.direction = direction;
        }

        public Coordinate Coordinate
        {
            get { return coordinate.Clone(); }            
        }

        public IDirection Direction
        {
            get { return direction; }
        }

        public void RotateLeft()
        {
            direction = direction.RotateLeft();
        }

        public void RotateRight()
        {
            direction = direction.RotateRight();
        }

        public void MoveForward()
        {
            coordinate = direction.MoveForward(coordinate);
        }

    }    
}