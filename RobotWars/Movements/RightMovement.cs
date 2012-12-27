namespace RobotWars
{
    public class RightMovement : IMovement
    {
        public void ExecuteOn(Robot robot)
        {
            robot.RotateRight();
        }
    }
}