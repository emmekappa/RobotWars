namespace RobotWars
{
    public class ForwardMovement : IMovement
    {
        public void ExecuteOn(Robot robot)
        {
            robot.MoveForward();
        }
    }
}