namespace RobotWars.Tests.Parser
{
    public class LeftMovement : IMovement
    {
        public void ExecuteOn(Robot robot)
        {
            robot.RotateLeft();
        }
    }
}