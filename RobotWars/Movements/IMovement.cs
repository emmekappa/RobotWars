namespace RobotWars
{
    /// <summary>
    ///     A Command rappresenting a Robot movement.
    /// </summary>
    public interface IMovement
    {
        void ExecuteOn(Robot robot);
    }
}