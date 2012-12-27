namespace RobotWars
{
    /// <summary>
    ///     The Robot entity.
    /// </summary>
    public class Robot
    {
        private readonly Arena arena;
        private DirectionBase direction;
        private Coordinate position;

        public Robot(Coordinate position, DirectionBase direction, Arena arena)
        {
            this.position = position;
            this.direction = direction;
            this.arena = arena;
        }

        public Coordinate Coordinate
        {
            get { return position.Clone(); }
        }

        /// <summary>
        ///     A string rappresenting the Robot direction
        /// </summary>
        public DirectionBase Direction
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
            Coordinate newRobotPosition = direction.MoveForward(position);
            if (!arena.IsInside(newRobotPosition))
                throw new OutOfArenaException();
            position = newRobotPosition;
        }
    }
}