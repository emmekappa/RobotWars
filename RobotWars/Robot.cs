namespace RobotWars
{
    /// <summary>
    /// The Robot entity.    
    /// </summary>
    public class Robot
    {
        private Coordinate coordinate;
        private IDirection direction;
        private readonly Arena arena;

        public Robot(Coordinate coordinate, IDirection direction, Arena arena)
        {
            this.coordinate = coordinate;
            this.direction = direction;
            this.arena = arena;
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