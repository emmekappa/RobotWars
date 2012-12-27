namespace RobotWars
{
    /// <summary>
    /// A Strategy rappresenting the Robot direction and his responses to the behaviors (moving and rotating)
    /// </summary>
    public interface IDirection
    {
        Coordinate MoveForward(Coordinate coordinate);
        IDirection  RotateRight();
        IDirection RotateLeft();
    }
}