namespace RobotWars.Tests.Parser
{
    public class RightMovement : IMovement
    {
        public void ExecuteOn(Robot robot)
        {
            robot.RotateRight();
        }
    }
}