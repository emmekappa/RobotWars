namespace RobotWars
{
    public interface IDirection
    {
        Coordinate MoveForward(Coordinate coordinate);
        IDirection  RotateRight();
        IDirection RotateLeft();
    }
}